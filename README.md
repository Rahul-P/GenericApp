# GenericApp
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
