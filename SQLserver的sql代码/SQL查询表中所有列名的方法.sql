--
SELECT table_name = t.name
FROM sys.tables t
INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
ORDER BY t.name;


SELECT name
FROM sysobjects
WHERE xtype = 'U'
ORDER BY name;


