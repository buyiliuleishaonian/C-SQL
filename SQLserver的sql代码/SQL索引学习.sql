select * from Testinfos
with(index=pk_testinfos)

--非聚集索引nonclustered
--唯一：可选unique
--创建唯一的非聚集索引
create unique nonclustered
index testinfos_name  --索引的名称，确保唯一，有意义
on testinfos(name)
with fillfactor=60 --填充因子百分比0-100之间


select * from sysindexes  --系统的索引表
where name='testinfos_name'


--使用索引查询
select * from testinfos
with (index=testinfos_name)--使用索引查询，从什么索引去查
where name='iphone手机'



--57个同学
--假如表明57个人
--填充因子为0时，数据中间没有空间
--所以在构建索引时，一般会设定其填充因子的百分比
--如果在中间插入一条数据的时候，所有数据都要更改

--视图：简化查询的方式