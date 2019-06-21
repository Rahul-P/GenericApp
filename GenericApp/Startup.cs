using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

//dotnet ef migrations add 3March18_1_FirstEver
//dotnet ef database update
//dotnet ef migrations remove

//Main command : dotnet ef --startup-project "..\GenericApp" database update
//from- 
//PS C:\ShiTiLikes\GenericApp\GenericApp.Data> dotnet ef --startup-project "..\GenericApp" database update

namespace GenericApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GenericAppContext>
                (options =>
                {
                    options.UseSqlServer
                    ("Server = DESKTOP-8E34R4N\\SQLEXPRESS; Database = GenericDB; Trusted_Connection = True;");

                });       

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();
        }
    }
}


using GrantEd.DomainModel.UserMgmt;
using Microsoft.IdentityModel.Tokens;
using PerfGuard.Constants;
using PerfGuard.Core;
using PerfGuard.Cryptography;
using PerfGuard.Statics;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GrantEd.ProcessServices.UserMgmt
{
    public class CryptoHelper : IDisposable
    {
        #region Decrypt AuthAPI

        public Result<AuthHubApi> Decrypt_AuthHubApi(AuthHubApi _api)
        {
            if (_api != null)
            {
                new AES()
                    .Use((aes) =>
                    {
                        int keyEnd = _api.PathArt.IndexOf(Messages.KEY_MASK_Base64, Misc.DIGIT_ZERO);
                        var _key = _api.PathArt.Substring(0, keyEnd);

                        int _addMe = Messages.KEY_MASK_Base64.Length;

                        int ivEnd = _api.PathArt.IndexOf(Messages.KEY_MASK_Base64, keyEnd + _addMe);
                        var _iv = _api.PathArt.Substring(ivEnd + _addMe);

                        byte[] _aesKey = Convert.FromBase64String(_key);
                        byte[] _aesIv = Convert.FromBase64String(_iv);

                        _api.GOneFive = Convert.ToBase64String(aes.Decrypt(Convert.FromBase64String(_api.GOneFive), _aesKey, _aesIv));
                        _api.ROne = Encoding.UTF8.GetString(aes.Decrypt(Convert.FromBase64String(_api.ROne), _aesKey, _aesIv));
                        _api.RTwo = Encoding.UTF8.GetString(aes.Decrypt(Convert.FromBase64String(_api.RTwo), _aesKey, _aesIv));
                        _api.HGold = Convert.ToBase64String(aes.Decrypt(Convert.FromBase64String(_api.HGold), _aesKey, _aesIv));
                        _api.SGold = Convert.ToBase64String(aes.Decrypt(Convert.FromBase64String(_api.SGold), _aesKey, _aesIv));
                    });
                return PerfGuard.Core.Result.Ok(_api);
            }
            return PerfGuard.Core.Result.Fail<AuthHubApi>(Messages.AUTHENTICATION_FAILED);
        }

        #endregion

        #region Set Claims

        public ClaimsPrincipal Set_Claims(AuthHubApi _api)
        {
            return TryCatch.Process<ClaimsPrincipal>
                (() =>
                {
                    var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Convert.FromBase64String(_api.GOneFive));

                    JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                    TokenValidationParameters validationParameters = new TokenValidationParameters()
                    {
                        ValidAudience = System.Configuration.ConfigurationManager.AppSettings[Messages.SchoolHubApi_Jwt_Audience_AppKey],
                        ValidIssuer = System.Configuration.ConfigurationManager.AppSettings[Messages.SchoolHubApi_Jwt_Issuer_AppKey],
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        LifetimeValidator = this.LifetimeValidator,
                        IssuerSigningKey = securityKey
                    };

                    SecurityToken securityToken = null;
                    return handler.ValidateToken(_api.GenerationOne, validationParameters, out securityToken);
                },
                (exceptionObj) =>
                {
                    return null;
                });           
        }

        #endregion

        #region LifetimeValidator

        private bool LifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken securityToken, TokenValidationParameters validationParameters)
        {
            if (expires != null)
            {
                if (DateTime.UtcNow < expires) return true;
            }
            return false;
        }

        #endregion

        #region IDisposable Support

        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}


using GrantEd.Communications.Interfaces;
using PerfGuard.Core;
using PerfGuard.Statics;
using System.Linq;

namespace GrantEd.ProcessServices.UserMgmt
{
    internal class GetAuthHubApiByParam :
        GetAuthHubApiByParamService, IGrantEdService
    {
        public void ExecuteService()
        {
            this.ParametersOUT = new Result();

            // Call Get Domain Service  
            DomainServices.UserMgmt.GetAuthHubApiByParamService _domainSvc = 
                new DomainServices.UserMgmt.GetAuthHubApiByParamService();

            _domainSvc.Session = Session;

            _domainSvc.ParametersIN.HGold = this.ParametersIN.HGold;
            _domainSvc.ParametersIN.SGold = this.ParametersIN.SGold;

            _domainSvc.Execute();

            this.ParametersOUT.AuthHubApis = _domainSvc.ParametersOUT.AuthHubApis;

            new CryptoHelper().Use(_helper =>
            {
                _helper.Decrypt_AuthHubApi(_domainSvc.ParametersOUT.AuthHubApis.ToList().FirstOrDefault())
                .OnSuccess((r) =>
                {
                    this.ParametersOUT.Claims = _helper.Set_Claims(r.Value);
                    return PerfGuard.Core.Result.Ok();
                })
                .OnFaliure(() =>
                {
                    this.ParametersOUT.Claims = null;
                });
            });

            // Mark it as handled
            return;
        }

        //#region Private Method(s).

        //#region Set Claims

        //private ClaimsPrincipal Set_Claims(AuthHubApi _api)
        //{            
        //    var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Convert.FromBase64String(_api.GOneFive));
          
        //    JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
        //    TokenValidationParameters validationParameters = new TokenValidationParameters()
        //    {
        //        ValidAudience = System.Configuration.ConfigurationManager.AppSettings[Messages.SchoolHubApi_Jwt_Audience_AppKey],
        //        ValidIssuer = System.Configuration.ConfigurationManager.AppSettings[Messages.SchoolHubApi_Jwt_Issuer_AppKey],
        //        ValidateLifetime = true,
        //        ValidateIssuerSigningKey = true,
        //        LifetimeValidator = this.LifetimeValidator,
        //        IssuerSigningKey = securityKey
        //    };

        //    SecurityToken securityToken = null;
        //    return handler.ValidateToken(_api.GenerationOne, validationParameters, out securityToken);          
        //}

        //#endregion

        //#region Decrypt AuthAPI

        //private Result<AuthHubApi> Decrypt_AuthHubApi(AuthHubApi _api)
        //{            
        //    if (_api != null)
        //    {
        //        new AES()
        //            .Use((aes) =>
        //            {                        
        //                int keyEnd = _api.PathArt.IndexOf(Messages.KEY_MASK_Base64, Misc.DIGIT_ZERO);
        //                var _key = _api.PathArt.Substring(0, keyEnd);

        //                int _addMe = Messages.KEY_MASK_Base64.Length;

        //                int ivEnd = _api.PathArt.IndexOf(Messages.KEY_MASK_Base64, keyEnd + _addMe);
        //                var _iv = _api.PathArt.Substring(ivEnd + _addMe);

        //                byte[] _aesKey = Convert.FromBase64String(_key);
        //                byte[] _aesIv = Convert.FromBase64String(_iv);

        //                _api.GOneFive = Convert.ToBase64String(aes.Decrypt(Convert.FromBase64String(_api.GOneFive), _aesKey, _aesIv));
        //                _api.ROne = Encoding.UTF8.GetString(aes.Decrypt(Convert.FromBase64String(_api.ROne), _aesKey, _aesIv));
        //                _api.RTwo = Encoding.UTF8.GetString(aes.Decrypt(Convert.FromBase64String(_api.RTwo), _aesKey, _aesIv));
        //                _api.HGold = Convert.ToBase64String(aes.Decrypt(Convert.FromBase64String(_api.HGold), _aesKey, _aesIv));
        //                _api.SGold = Convert.ToBase64String(aes.Decrypt(Convert.FromBase64String(_api.SGold), _aesKey, _aesIv));                                               
        //            });
        //        return PerfGuard.Core.Result.Ok(_api);
        //    }
        //    return PerfGuard.Core.Result.Fail<AuthHubApi>(Messages.AUTHENTICATION_FAILED);
        //}

        //#endregion

        //#region LifetimeValidator

        //private bool LifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken securityToken, TokenValidationParameters validationParameters)
        //{
        //    if (expires != null)
        //    {
        //        if (DateTime.UtcNow < expires) return true;
        //    }
        //    return false;
        //}

        //#endregion

        //#endregion

    }
}


using GrantEd.Common.Messaging;
using GrantEd.Communications.Interfaces;
using GrantEd.DomainModel.UserMgmt;
using PerfGuard.Constants;
using PerfGuard.Cryptography;
using PerfGuard.Statics;
using System;
using System.Configuration;
using System.Security.Claims;

namespace GrantEd.ProcessServices.UserMgmt
{
    /// <summary>
    /// Make sure the following App Keys Exists in Service Configuration file.
    /// 
    /// <add key = "SchoolHubApi_Jwt_ValidAudience" value = "http://localhost:40044" />
	/// <add key = "SchoolHubApi_Jwt_ValidIssuer" value = "http://localhost:40044" />
    /// <add key = "SchoolHubApi_Jwt_Token_Validation_Limit_In_Minutes" value= "10080" />  <!-- 7 days -->
    /// 
    /// </summary>
    internal class UpdateAuthHubApi : 
        UpdateAuthHubApiService, IGrantEdService
    {
        public void ExecuteService()
        {
            this.ParametersOUT = new Result();
            this.ParametersOUT.Messages = new MessageCollection();                  

            // Call Update Domain Service - RunBusinessRules() will Create Encryption Package etc
            DomainServices.UserMgmt.UpdateAuthHubApiService _domainSvc = 
                new DomainServices.UserMgmt.UpdateAuthHubApiService();

            _domainSvc.Session = Session;

            _domainSvc.ParametersIN.AuthHubApi =
                RunRules(this.ParametersIN.User, this.ParametersIN.ClaimsIdentity);           

            _domainSvc.Execute();

            this.ParametersOUT.AuthHubApi = _domainSvc.ParametersOUT.AuthHubApi;
            this.ParametersOUT.Messages = _domainSvc.ParametersOUT.Messages;

            // Mark it as handled
            return;
        }

        #region Private Method(s).

        private AuthHubApi RunRules(User _user, ClaimsIdentity _claims)
        {
            AuthHubApi _authApi = new AuthHubApi();

            _authApi.User = _user;

            #region Generate Token

            var _jwtSigningKey = RealRandomNumber.GenerateRandomNumber(Misc.KEY_OF_32_BYTES_FOR_AES);

            // Assign the Key used to sign JWT Token.           
            _authApi.GOneSix = Convert.ToBase64String(RealRandomNumber.GenerateRandomNumber(Misc.KEY_OF_32_BYTES_FOR_AES));

            // Assign JWT Token
            _authApi.GenerationOne = GenerateJwtToken(_claims, _jwtSigningKey);

            #endregion

            #region Generate Encryption Package

            byte[] _hmac = null, _signature = null;
            new RSAOrchestrator()
                .Use((_rsaOrc) =>
                {
                    var rsa = _rsaOrc.InitialiseRSA_Generate_Keys();

                    _authApi.ROne = rsa.Fetch_PrivateKeyInXmlString();
                    _authApi.RTwo = rsa.Fetch_PublicKeyInXmlString();

                    // Finalise Package here.
                    new HybridEncryption()
                        .Use((_obj) =>
                        {
                            var _securePacket = _obj.EncryptData(_authApi.GenerationOne, rsa, new DigitalSignature());

                            _authApi.GenerationTwo = Convert.ToBase64String(_securePacket.EncryptedData);
                            _authApi.AThree = Convert.ToBase64String(_securePacket.EncryptedSessionKey);
                            _authApi.AFour = Convert.ToBase64String(_securePacket.InitializationVector_IV);

                            _hmac = _securePacket.Hmac;
                            _signature = _securePacket.Signature;

                            //_authApi.PathArt = PathArt_Scramble;
                            _authApi.StoredDate = DateTime.UtcNow;
                        });                    
                });

            #endregion

            return Encrypt_AuthHubApi(_authApi, _jwtSigningKey, _hmac, _signature);
        }

        #region Call Utility to Create JWT Token

        private string GenerateJwtToken(ClaimsIdentity _claims, byte[] _jwtSigningKey)
        {
            return new PerfGuard.Cryptography.JwtToken()
                .Use(obj =>
                {
                    return obj.Create(_claims, // Claims
                        DateTime.UtcNow.AddMinutes(Convert.ToDouble(ConfigurationManager.AppSettings[Messages.Jwt_Token_Validation_Limit_In_Minutes])), // Expiry
                        _jwtSigningKey, // Signing Key in Bytes
                        ConfigurationManager.AppSettings[Messages.SchoolHubApi_Jwt_Issuer_AppKey], // Issuer
                        ConfigurationManager.AppSettings[Messages.SchoolHubApi_Jwt_Audience_AppKey]); // Audience
                });
        }

        #endregion

        #region Encrypt AuthAPi before saving in DB

        private AuthHubApi Encrypt_AuthHubApi(AuthHubApi _authApi, byte[] _gOneFive, byte[] _hGold, byte[] _sGold)
        {
            new AES()
                .Use((aes) => 
                {
                    byte[] _key = aes.GenerateRandomNumberForKey(Misc.KEY_OF_32_BYTES_FOR_AES);
                    byte[] _iv = aes.GenerateRandomNumberForKey(Misc.INITIALIZATION_VECTOR_16_BYTES_FOR_AES);                    

                    string _key64 = Convert.ToBase64String(_key);
                    string _iv64 = Convert.ToBase64String(_iv);
                    string _scramble = Convert.ToBase64String(aes.GenerateRandomNumberForKey(Misc.KEY_OF_32_BYTES_FOR_AES));

                    _authApi.PathArt = _key64 +
                        Messages.KEY_MASK_Base64 +
                        _scramble +
                        Messages.KEY_MASK_Base64 +
                        _iv64;

                    _authApi.GOneFive = Convert.ToBase64String(aes.Encrypt(_gOneFive, _key, _iv));
                    _authApi.ROne = Convert.ToBase64String(aes.Encrypt(_authApi.ROne, _key, _iv));
                    _authApi.RTwo = Convert.ToBase64String(aes.Encrypt(_authApi.RTwo, _key, _iv));
                    _authApi.HGold = Convert.ToBase64String(aes.Encrypt(_hGold, _key, _iv));
                    _authApi.SGold = Convert.ToBase64String(aes.Encrypt(_sGold, _key, _iv));
                });
            return _authApi;
        }

        #endregion

        #endregion
    }
}



using System;
using System.Text;

namespace PerfGuard.Constants
{
    public static class Messages
    {
        #region Message(s).

        public const string TASK_FAILED_FUNNY =
            "Opps! we dropped the ball. Our army of monkeys is on this, meanwhile can you please try again soon.";

        public const string ERROR_DESCRIPTION_PROPERTIES_SHOULD_BE_NULL = 
            "Error description property(s) should be null.";

        public const string ERROR_DESCRIPTION_PROPERTIES_SHOULD_NOT_BE_NULL =
            "Error description property(s) should not be null.";

        public const string TASK_WAS_CANCELLED = "Task was cancelled.";

        public const char SPACE = ' ';
        public const char PERIOD = '.';
        public const char COMMA = ',';

        public const string UNDER_SCORE = "_";
        public const string FORWARD_SLASH = "/";
        public const string SPACE_IN_STRING = " ";

        public const string ALL_TASKS_FAILED = "All tasks failed.";

        public const string FAILED_TO_INITIALISE_FROM_CONFIGURATION = "Initialising from configuration has failed. Configuration string provided is:";

        public const string CONFIGURATION_KEY_PROVIDED = "Configuration KEY provided:";
        public const string CONFIGURATION_VALUE_IS_NULL_FOR_KEY = "Configuration value is null for KEY:";


        public const string NotNullStringProperty_Is_NULL = "NotNullStringProperty should not be null/empty.";
        public const string NotNullStringProperty_No_Details_Provided = "No details have been provided as to why the property is null. The location where its set etc. Nothing is provided.";
        
        public const string EMAIL_IS_NULL = "Email should not be null/empty.";
        public const string EMAIL_IS_TOO_LONG = "Email is too long";
        public const string EMAIL_INVALID = "Email is invalid";

        public const string KEY_MASK = "--::--";
        public readonly static string KEY_MASK_Base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(KEY_MASK));

        public const string AUTHENTICATION_FAILED = "Authentication failed.";

        public const string SchoolHubApi_Jwt_Audience_AppKey = "SchoolHubApi_Jwt_ValidAudience";
        public const string SchoolHubApi_Jwt_Issuer_AppKey = "SchoolHubApi_Jwt_ValidIssuer";
        public const string Jwt_Token_Validation_Limit_In_Minutes = "SchoolHubApi_Jwt_Token_Validation_Limit_In_Minutes";

        public const string CalledFromMethod = "Called from method: ";
        public const string FilePathOfCalledCode = "File path: ";
        public const string LineNumberOfCalledCode = "Called from line number: ";

        #endregion


        #region Exception related message(s).

        public const string INNER_EXCEPTION_IS_NULL = "Inner Exception is null.";
        public const string NO_EXCEPTIONS_FOUND = "No exception message found/set.";

        public const string DETAILED_MESSAGE_RETURNED_BY_SEMIS_SERVICE = 
            "Exception message(s) returned by SEMIS service:";

        public const string NO_MESSAGES_FOUND = "No message(s) found/set.";

        public const string INTERNAL_SERVER_ERROR = "Internal server error. Please try again later.";

        public const string APPEND_PLEASE_TRY_AGAIN = ". Please try again.";

        public const string FAILED_TO_MARSHAL_PTR_TO_STRING = "Failed to marshal supplied string, system exception.";
        public const string FAILED_TO_MARSHAL_PTR_TO_STRING_USER_DISPLAY_MESSAGE = "We have encountered something special, we are looking into the issue occurred. Please, try again in a while.";
        public const string FAILED_TO_MARSHAL_SECURESTRING_TO_CHAR_ARRAY = "Failed to marshal supplied secure string, system exception.";

        public const string EXCEPTION_ALREADY_RECORDED = "Exception has been or should be recorded in valid place by now. Moving on.";

        #endregion

        #region Maybe Type 

        public const string NO_VALUE = "No Value";

        public const string EXPECTED_REFERENCE_IS_NULL = 
            "Expected reference type is null.";

        public const string IS_NULL = "is Null.";

        #endregion


    }
}


using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace PerfGuard.Cryptography
{
    public class JwtToken : IDisposable
    {
        /// <summary>
        /// New JWT Token is created and returned as  a string.         
        /// Pass in claims you want in token.
        /// 
        /// A Symmetric Key is used to Encrypt the Token.
        /// </summary>
        /// <param name="_claimsIdentity">Claims Required in Token.</param>
        /// <param name="_expires">Token Expiry Time.</param>
        /// <param name="_securityKey">The Security Key to be used for Digitally Signing this Joy of JWT.</param>
        /// <param name="_issuer">The Issuer.</param>
        /// <param name="_audience">The audience(s).</param>
        /// <returns>The Jwt Token as a String.</returns>
        public string Create(ClaimsIdentity _claimsIdentity, DateTime _expires, 
            byte[] _securityKey, string _issuer, string _audience)
        {
            //Set issued at date
            DateTime issuedAt = DateTime.UtcNow;

            //set the time when it expires
            DateTime expires = _expires; // DateTime.UtcNow.AddDays(7);

            // http://stackoverflow.com/questions/18223868/how-to-encrypt-jwt-security-token
            var tokenHandler = new JwtSecurityTokenHandler();             

            var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(_securityKey);

            var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256Signature);

            //create the jwt -- http://localhost:50191
            var token = (JwtSecurityToken)
                    tokenHandler.CreateJwtSecurityToken(issuer: _issuer, 
                        audience: _audience, 
                        subject: _claimsIdentity,
                        notBefore: issuedAt,
                        expires: expires,
                        signingCredentials: signingCredentials);

            var tokenString = tokenHandler.WriteToken(token);         

            return tokenString;
        }

        #region IDisposable Support

        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}


using GrantEd.Communications.Interfaces;
using Microsoft.IdentityModel.Tokens;
using PerfGuard.Constants;
using PerfGuard.Core;
using PerfGuard.Statics;
using Semis.Services.GetServices;
using Semis.Services.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace SchoolAuthHub.Middleware
{
    public class TokenPipelineHandler : DelegatingHandler
    {
        #region Private Members

        private readonly AppSession _session;

        #endregion

        #region Constructor

        public TokenPipelineHandler()
        {
            _session = new Session().Use(obj => obj.GetAppSession());
        }

        #endregion

        #region Protected Method(s).

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {            
            string token;

            // Determine whether a jwt exists or not!
            if (!TryRetrieveToken(request, out token))
            {                
                // Allow requests with no token - whether a action method needs an authentication can be set with the claimsauthorization attribute
                return base.SendAsync(request, cancellationToken);
            }

            return TryCatch.ProcessAsync<HttpResponseMessage>(
                () =>
                {
                    return new GetAuthHubLogin().Use((obj) =>
                        {
                            return obj.RetrieveRequiredDetails(token, _session);
                        })
                        .ConcludeResult<ClaimsPrincipal, Task<HttpResponseMessage>>(
                        (resultSuccess) => 
                            {
                                // extract and assign the user of the jwt
                                Thread.CurrentPrincipal = resultSuccess.Value;  
                                HttpContext.Current.User = resultSuccess.Value;

                                return base.SendAsync(request, cancellationToken);
                            },
                        (resultFaliure) => 
                            {
                                return Task.FromResult(
                                    new HttpResponseMessage(HttpStatusCode.Unauthorized)
                                    {
                                        Content = new StringContent(SchoolAuthHubConstants.AccessDenied, System.Text.Encoding.UTF8, SchoolAuthHubConstants.TextHtml_MediaType)
                                    });
                            });                    
                },
                (exceptionObj) =>
                {
                    HttpStatusCode statusCode = ((exceptionObj is SecurityTokenValidationException) 
                        ? HttpStatusCode.InternalServerError : HttpStatusCode.Unauthorized);
                    
                    return Task.FromResult(
                        new HttpResponseMessage(statusCode)
                        {
                            Content = new StringContent(SchoolAuthHubConstants.AccessDenied, System.Text.Encoding.UTF8, SchoolAuthHubConstants.TextHtml_MediaType)
                        });
                });           
        }

        #endregion

        #region Private Method(s).

        private static bool TryRetrieveToken(HttpRequestMessage request, out string token)
        {
            token = null;
            IEnumerable<string> authzHeaders;
            if (!request.Headers.TryGetValues(SchoolAuthHubConstants.AuthorizationString, out authzHeaders) || authzHeaders.Count() > Misc.DIGIT_ONE)
            {
                return false;
            }
            var bearerToken = authzHeaders.ElementAt(Misc.DIGIT_ZERO);
            token = bearerToken.StartsWith(SchoolAuthHubConstants.BearerPlusSpaceString) ? bearerToken.Substring(Misc.BEARER_PLUS_SPACE_LENGTH) : bearerToken;
            return true;
        }

        #endregion
    }
}
