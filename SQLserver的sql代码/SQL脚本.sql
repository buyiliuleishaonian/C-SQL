<<<<<<< HEAD
--sqlserver文件后缀.mdf主要文件,log日志文件,ndf次要文件

--使用那个数据库
use  JGWnameDB

--增
insert into  Students(stuName)
values('嘿嘿')
--多行增
insert into Students(stuName)
select ('小小') union
select('灰太狼')
--将一个表中的竖插入到另一个表
insert into  Students(stuName,ClassShcoolID)
select [name],id
from Test

--删
delete  from  Students
where  stuname=('小小') or stuName=('嘿嘿') or stuName=('灰太狼')
--恢复整张表
truncate  table  classinfos

--改
update  Students
set  stuName='张三四'
where stuName='张三'

select @@VERSION--查看sqlserver的版本


--group by分组查询
--多表联接查询

--count(1),表示伪劣,因为聚合函数不查询null，所以采用伪劣来查询每一行

--凡是出现在查询select关键词之后的列， 如果不是聚合函数，
--那么一定要添加到group by
--按年级分出来，确定每个年级的人数
select studentsnianji,count(1) as '年级人数' from  ShcoolInfos
group by studentsnianji
having count(1)>1  --表示为筛选出来的人数大于1

--where 数据集中筛选，在group by前使用，分组在后面
--having 分组后筛选的关键词
--order by  必须在所有语句后面

--得到每个年级分组的最大编号
select studentsnianji,max(classid) as '编号' from ShcoolInfos
group by  StudentsNianji


--表连接
--内连接(inner join)，外连接:左外连接(left join)，右外连接(right join)
select stuno,classshcoolid,stuname,classname1 from Students as a  --需要将被连接表中需要显示的列，select选择上
inner join  ClassInfos as b
on (a.ClassShcoolID=b.JGWshcoolID)
--内连接，根据主外键匹配，匹配的到就显示出来，匹配不到不显示
---三种连接方式
select top 4 stuno,classshcoolid,stuname from Students as a
inner join  ClassInfos as b
on a.ClassShcoolID=b.JGWshcoolID

select  top 4   a.stuno ,a.stuName,a.ClassShcoolID,b.className1
from  Students  as a ,ClassInfos as b
where a.ClassShcoolID=b.JGWshcoolID



--如果两张表连接，没有区别，多张表时采用inner join关键字联表查询

--外连接
--左连接，以左边的表为基准去匹配右边的表，如果匹配不到数据，右边为null
select  jgwshcoolid,classname1 from ClassInfos as a
left join  Students as b
on  a.JGWshcoolID=b.ClassShcoolID

--右连接
select stuno,stuName,ClassShcoolID,b.classname1 from  Students as a
right join  ClassInfos as b
on a.ClassShcoolID=b.JGWshcoolID
--通常两张表相同的列名，select a.* b.列名   a.表示所有列
--将主表全部输出，副表输出除相同列名以外的所有列

--去重复，distinct，两行的所有列一样

=======
--sqlserver文件后缀.mdf主要文件,log日志文件,ndf次要文件

--使用那个数据库
use  JGWnameDB

--增
insert into  Students(stuName)
values('嘿嘿')
--多行增
insert into Students(stuName)
select ('小小') union
select('灰太狼')
--将一个表中的竖插入到另一个表
insert into  Students(stuName,ClassShcoolID)
select [name],id
from Test

--删
delete  from  Students
where  stuname=('小小') or stuName=('嘿嘿') or stuName=('灰太狼')
--恢复整张表
truncate  table  classinfos

--改
update  Students
set  stuName='张三四'
where stuName='张三'

select @@VERSION--查看sqlserver的版本


--group by分组查询
--多表联接查询

--count(1),表示伪劣,因为聚合函数不查询null，所以采用伪劣来查询每一行

--凡是出现在查询select关键词之后的列， 如果不是聚合函数，
--那么一定要添加到group by
--按年级分出来，确定每个年级的人数
select studentsnianji,count(1) as '年级人数' from  ShcoolInfos
group by studentsnianji
having count(1)>1  --表示为筛选出来的人数大于1

--where 数据集中筛选，在group by前使用，分组在后面
--having 分组后筛选的关键词
--order by  必须在所有语句后面

--得到每个年级分组的最大编号
select studentsnianji,max(classid) as '编号' from ShcoolInfos
group by  StudentsNianji


--表连接
--内连接(inner join)，外连接:左外连接(left join)，右外连接(right join)
select stuno,classshcoolid,stuname,classname1 from Students as a  --需要将被连接表中需要显示的列，select选择上
inner join  ClassInfos as b
on (a.ClassShcoolID=b.JGWshcoolID)
--内连接，根据主外键匹配，匹配的到就显示出来，匹配不到不显示
---三种连接方式
select top 4 stuno,classshcoolid,stuname from Students as a
inner join  ClassInfos as b
on a.ClassShcoolID=b.JGWshcoolID

select  top 4   a.stuno ,a.stuName,a.ClassShcoolID,b.className1
from  Students  as a ,ClassInfos as b
where a.ClassShcoolID=b.JGWshcoolID



--如果两张表连接，没有区别，多张表时采用inner join关键字联表查询

--外连接
--左连接，以左边的表为基准去匹配右边的表，如果匹配不到数据，右边为null
select  jgwshcoolid,classname1 from ClassInfos as a
left join  Students as b
on  a.JGWshcoolID=b.ClassShcoolID

--右连接
select stuno,stuName,ClassShcoolID,b.classname1 from  Students as a
right join  ClassInfos as b
on a.ClassShcoolID=b.JGWshcoolID
--通常两张表相同的列名，select a.* b.列名   a.表示所有列
--将主表全部输出，副表输出除相同列名以外的所有列

--去重复，distinct，两行的所有列一样

>>>>>>> 45f0c71 (new)
--