<<<<<<< HEAD
--视图
--数据库字段，敏感
--难受（无文档,第二程序和数据库结构很乱）
--视图有点
--1、隐藏字段，隐藏敏感信息
--2、简化查询

--简化查询，创建视图，视图相当于一个虚拟表
--create database 创建表数据库
--create  table 创建表
--将视图当作一张表使用，当我们生成视图表之后
--可以将生成视图的代码删除，之后直接调用视图名
--就可以查询到视图
--alter修改表，update，修改数据
alter view view_Getstudents 
as
select *from students
inner join classinfos
on  students.classshcoolid=classinfos.jgwshcoolid
--对视图，进行增删改只要成功，是会影响原来的物理表的
--如果是单表，是可以操作的，当是多表组成的视图是操作会报错

--可以把视图也当作一张表，当需要查询的信息，已经成为了一张视图，我们可以直接用视图来操作
select  *from view_Getstudents as a
inner join  shcoolinfos as b
on (a.JGWshcoolID=b.ClassID)
--视图可以嵌套视图，视图不可以排序order by，创建视图的时候，不能使用order by
--into克隆表结构，变量也不能使用

--跨库查询(数据库名) ..表名
select *from cwdb..cwinfos
=======
--视图
--数据库字段，敏感
--难受（无文档,第二程序和数据库结构很乱）
--视图有点
--1、隐藏字段，隐藏敏感信息
--2、简化查询

--简化查询，创建视图，视图相当于一个虚拟表
--create database 创建表数据库
--create  table 创建表
--将视图当作一张表使用，当我们生成视图表之后
--可以将生成视图的代码删除，之后直接调用视图名
--就可以查询到视图
--alter修改表，update，修改数据
alter view view_Getstudents 
as
select *from students
inner join classinfos
on  students.classshcoolid=classinfos.jgwshcoolid
--对视图，进行增删改只要成功，是会影响原来的物理表的
--如果是单表，是可以操作的，当是多表组成的视图是操作会报错

--可以把视图也当作一张表，当需要查询的信息，已经成为了一张视图，我们可以直接用视图来操作
select  *from view_Getstudents as a
inner join  shcoolinfos as b
on (a.JGWshcoolID=b.ClassID)
--视图可以嵌套视图，视图不可以排序order by，创建视图的时候，不能使用order by
--into克隆表结构，变量也不能使用

--跨库查询(数据库名) ..表名
select *from cwdb..cwinfos

create view view_Getstudents 
as
select *from students
inner join classinfos
on  students.classshcoolid=classinfos.jgwshcoolid
>>>>>>> 45f0c71 (new)
