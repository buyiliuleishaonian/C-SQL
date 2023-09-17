<<<<<<< HEAD
--学习T-SQL的增删改查,在数据库里面，都用''，单引号，假如非数字类型，必须加单引号，如果是数字类型，可以或不加单引号
use JGWnameDB--表示调用那个数据库
--增，当我们有设置为标识的列，不能显示手动插入
--程序里面将值插到数据库里面来，sqlparameter
--单行增加，当列可以为null时，插入可以不插入值，default缺省值
insert into ClassInfos(JGWshcoolID,className1)
values(3,'java班')
--当ID列为标识列时，不需要手动插入
insert into ClassInfos(className1)
values('算法班')
--多行增加：insert select 
insert into ClassInfos(JGWshcoolID,className1)
select 4,'前端班'  union
select 5,'算法班' 
--多行增加，insert select 将现有的表中的数据转到另一个表中去
insert into Test(id,[name])
select JGWshcoolID,className1
from  ClassInfos

--删（几种删除）
--delete    --drop结构删除：删除表
--drop table 表名
--delete
delete from ClassInfos --delete使用几乎不能不带条件，除非删除所有
where JGWshcoolID=5 --几乎都是删除主键（唯一键）

--truncate table  将表恢复到初始大小，将标识列恢复，不带条件
truncate table Classinfos

--改 update
update Students --update后面接表名
set   stuName='张三',ClassShcoolID=2  --set后面跟需要修改的信息
where   stuNo=1001 --一般删除和修改，都需要满足哪些条件的，可以多条件and，or


--查*后面表示全部
select * from ClassInfos
select *from Test

--*这里可以自定义，
--查询时，凡是列表N条信息，都是某个表部分信息
--电脑的内存有限text
select  '张三',ClassShcoolID,sex from Students  where sex='男' 

-- union, union all
--合并多张表，联合查询，连表查询，要求表之间有相互关系
select  JGWshcoolID,className1  from  ClassInfos
union --合并多张表，并且排序，去除重复，效率没有ouion all高
select id,name  from Test

--合并多张表，单纯的将表排序在一起
select JGWshcoolID ,className1 from ClassInfos
union all 
select id,name from Test



--普通的insert delete update理论上可以恢复
--带table 是及时性的，不可以恢复
=======
--学习T-SQL的增删改查,在数据库里面，都用''，单引号，假如非数字类型，必须加单引号，如果是数字类型，可以或不加单引号
use JGWnameDB--表示调用那个数据库
--增，当我们有设置为标识的列，不能显示手动插入
--程序里面将值插到数据库里面来，sqlparameter
--单行增加，当列可以为null时，插入可以不插入值，default缺省值
insert into ClassInfos(JGWshcoolID,className1)
values(3,'java班')
--当ID列为标识列时，不需要手动插入
insert into ClassInfos(className1)
values('算法班')
--多行增加：insert select 
insert into ClassInfos(JGWshcoolID,className1)
select 4,'前端班'  union
select 5,'算法班' 
--多行增加，insert select 将现有的表中的数据转到另一个表中去
insert into Test(id,[name])
select JGWshcoolID,className1
from  ClassInfos

--删（几种删除）
--delete    --drop结构删除：删除表
--drop table 表名
--delete
delete from ClassInfos --delete使用几乎不能不带条件，除非删除所有
where JGWshcoolID=5 --几乎都是删除主键（唯一键）

--truncate table  将表恢复到初始大小，将标识列恢复，不带条件
truncate table Classinfos

--改 update
update Students --update后面接表名
set   stuName='张三',ClassShcoolID=2  --set后面跟需要修改的信息
where   stuNo=1001 --一般删除和修改，都需要满足哪些条件的，可以多条件and，or


--查*后面表示全部
select * from ClassInfos
select *from Test

--*这里可以自定义，
--查询时，凡是列表N条信息，都是某个表部分信息
--电脑的内存有限text
select  '张三',ClassShcoolID,sex from Students  where sex='男' 

-- union, union all
--合并多张表，联合查询，连表查询，要求表之间有相互关系
select  JGWshcoolID,className1  from  ClassInfos
union --合并多张表，并且排序，去除重复，效率没有ouion all高
select id,name  from Test

--合并多张表，单纯的将表排序在一起
select JGWshcoolID ,className1 from ClassInfos
union all 
select id,name from Test



--普通的insert delete update理论上可以恢复
--带table 是及时性的，不可以恢复
>>>>>>> 45f0c71 (new)
