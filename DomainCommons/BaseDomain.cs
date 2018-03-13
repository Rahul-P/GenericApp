
namespace DomainCommons
{
    using System;

    public class BaseDomain
    {
        
            public int Id { get; set; }

            public DateTime LastModifiedOn { get; set; }
            public string LastModifiedBy { get; set; }

            public DateTime CreatedOn { get; set; }
            public string CreatedBy { get; set; }

            public byte[] Rowversion { get; set; }

            public bool IsDirty { get; set; }
        
    }
}
