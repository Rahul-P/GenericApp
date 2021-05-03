

public static Set_Control_Values(_formGroupToSetValuesFor: FormGroup, _keyValueList: { _key: string, _value: any }[]) {
        if (StaticFunctions.ValueIsDefinedAndNotNull(_formGroupToSetValuesFor) && StaticFunctions.Check_Array_Length(_keyValueList)) {
            _keyValueList.forEach(_keyValue => {
                _formGroupToSetValuesFor.get(_keyValue._key).setValue(_keyValue._value);
            });
        }
    }
    
    Statics.Set_Control_Values(this.updateSomeForm,
      [
          { _key: "name", _value: this._dataService.currentSomeToEdit.name },
          { _key: "description", _value: this._dataService.currentSomeToEdit.description },
          { _key: "preferredMethod", _value: this._dataService.currentSomeToEdit.preferredMethod },
          { _key: "contactName", _value: this._dataService.currentSomeToEdit.contactName},
          { _key: "contactEmail", _value: this._dataService.currentSomeToEdit.contactEmail },
          { _key: "contactPhone", _value: this._dataService.currentSomeToEdit.contactPhone },
          { _key: "SomeClass", _value: this._dataService.currentSomeToEdit.airlineClass }
      ]);
  }

# GenericApp

public static T[] DropNulls<T>(this T[] _array) =>
            _array.Where(_a => _a != null).ToArray();
   
The App - aka - "the generic app".   We are not here to take part, we are here to Take Over.


SELECT QUOTENAME(SCHEMA_NAME(tb.[schema_id])) AS 'Schema'
   ,QUOTENAME(OBJECT_NAME(tb.[OBJECT_ID])) AS 'Table'
   ,C.NAME as 'Column'
   ,T.name AS 'Type'
   ,C.max_length
   ,C.is_nullable
FROM SYS.COLUMNS C INNER JOIN SYS.TABLES tb ON tb.[object_id] = C.[object_id]
   INNER JOIN SYS.TYPES T ON C.system_type_id = T.user_type_id
WHERE tb.[is_ms_shipped] = 0
ORDER BY tb.[Name]


SELECT table_schema, table_name, column_name, data_type, character_maximum_length,
    is_nullable, column_default, numeric_precision, numeric_scale
  FROM information_schema.columns
  ORDER BY table_schema, table_name, ordinal_position
  
  
  
https://stackoverflow.com/questions/18901720/get-column-datatype-from-entity-framework-entity

https://github.com/aspnet/EntityFrameworkCore/issues/7717


https://github.com/aspnet/EntityFrameworkCore/blob/master/src/EFCore.Relational/Scaffolding/Metadata/DatabaseTable.cs
https://github.com/aspnet/EntityFrameworkCore/blob/master/src/EFCore.SqlServer/Scaffolding/Internal/SqlDataReaderExtension.cs
https://github.com/aspnet/EntityFrameworkCore/blob/master/src/EFCore.SqlServer/Scaffolding/Internal/SqlServerCodeGenerator.cs
https://github.com/aspnet/EntityFrameworkCore/blob/master/src/EFCore.SqlServer/Scaffolding/Internal/SqlServerDatabaseModelFactory.cs

select * FROM information_schema.columns
order by TABLE_SCHEMA asc


https://stackoverflow.com/questions/434864/how-to-check-if-connection-string-is-valid  -- check DB is Valid connection.
https://social.msdn.microsoft.com/Forums/vstudio/en-US/3af721df-03ce-4c25-9084-24970b1d3278/checking-if-a-connection-is-valid?forum=csharpgeneral -- check DB is Valid connection.
