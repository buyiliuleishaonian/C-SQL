<<<<<<< HEAD
--临时表，临时和内存有关 c#中datatable临时表，程序结束的时候，临时表结束
--视图：虚拟表，他的记录可以存在

--数据库临时表：全局临时表##，普通临时表#
--特殊符号标记临时表#


create table test2
(id  int identity(1,1),
name varchar(10)  not null
)
insert into  test2 (name)
values('张三')


--第一种自定义一个临时表，只能在汇话窗体执行，存在于内存中
--第一种drop table #test2，第二种就是关闭会话窗体
--临时表只存在当前会话窗体
create table #test2--只存在于内存
(id  int identity(1,1),
name varchar(10)  not null
)
insert into #test2
values('王五')
select *from #test2

--第二种克隆创建临时表，真实表
select [stuNo], [ClassShcoolID], [stuName], [sex]
 into students2  from Students --真实表

 select [stuNo], [ClassShcoolID], [stuName], [sex]
 into #test3  from Students--临时表

 select * from #test3

=======
--临时表，临时和内存有关 c#中datatable临时表，程序结束的时候，临时表结束
--视图：虚拟表，他的记录可以存在

--数据库临时表：全局临时表##，普通临时表#
--特殊符号标记临时表#


create table test2
(id  int identity(1,1),
name varchar(10)  not null
)
insert into  test2 (name)
values('张三')


--第一种自定义一个临时表，只能在汇话窗体执行，存在于内存中
--第一种drop table #test2，第二种就是关闭会话窗体
--临时表只存在当前会话窗体
create table #test2--只存在于内存
(id  int identity(1,1),
name varchar(10)  not null
)
insert into #test2
values('王五')
select *from #test2

--第二种克隆创建临时表，真实表
select [stuNo], [ClassShcoolID], [stuName], [sex]
 into students2  from Students --真实表

 select [stuNo], [ClassShcoolID], [stuName], [sex]
 into #test3  from Students--临时表

 select * from #test3

>>>>>>> 45f0c71 (new)
 --全局的临时表，还是在内存种，当创建他的窗口关闭时，就消失