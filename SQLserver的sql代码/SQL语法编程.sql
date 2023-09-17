<<<<<<< HEAD
use jgwnamedb

--查询一个学生号
--之后将其临近的也查询出来

declare  @id int=0
select @id=classid  from shcoolinfos
where  studentsname='于证'

select studentsname from  ShcoolInfos
where classid=@id+1  or  classid=@id-1


--输出信心2种
print 'aaa'--显示输出，不能使用或调用，直接输出文本
select 'aaa' --显示输出，可以调用，输出的是表格类型的

--类型转换 cast convert两种方式
declare @str  varchar(10)='★'
select   @str +cast(1 as varchar)

select getdate()
select convert(varchar,getdate(),113)
--convert可以指定转换格式


--判断语句
declare @num int=9
if @num<10
begin
 print '★'
end
else
begin
print '★★'
end


--如果增删改查只有一条，GO没有任何意义
--一般存储过程用go
go--批量处理，执行两种使用


--不要begin end 下面语句只有一条，begin end相当于是一个大括号{}

--case	end
--两种语法:第一种固定值判断
--		  ;表示范围判断和替换
--用于数据类型为bit比如男女，
select (case sex when 1 then '男' else  '女' end ) as sex from students
select sex=case sex when 1 then '男' else '女' end from students

--select 
--列名= case  when 列名 between  100 and 90 then 'A'
			--when 列名  between  89 安定 80 then 'B'
			--when  列名>=70 and 列名<=79 then 'C'
			--end
--from 表名
 --在任何情况下select查询是不会修改结果的

--一般都使用varchar，nvarchar,可伸缩的长度类型一个非uncoding，一个uncoding类型




=======
use jgwnamedb

--查询一个学生号
--之后将其临近的也查询出来

declare  @id int=0
select @id=classid  from shcoolinfos
where  studentsname='于证'

select studentsname from  ShcoolInfos
where classid=@id+1  or  classid=@id-1


--输出信心2种
print 'aaa'--显示输出，不能使用或调用，直接输出文本
select 'aaa' --显示输出，可以调用，输出的是表格类型的

--类型转换 cast convert两种方式
declare @str  varchar(10)='★'
select   @str +cast(1 as varchar)

select getdate()
select convert(varchar,getdate(),113)
--convert可以指定转换格式


--判断语句
declare @num int=9
if @num<10
begin
 print '★'
end
else
begin
print '★★'
end


--如果增删改查只有一条，GO没有任何意义
--一般存储过程用go
go--批量处理，执行两种使用


--不要begin end 下面语句只有一条，begin end相当于是一个大括号{}

--case	end
--两种语法:第一种固定值判断
--		  ;表示范围判断和替换
--用于数据类型为bit比如男女，
select (case sex when 1 then '男' else  '女' end ) as sex from students
select sex=case sex when 1 then '男' else '女' end from students

--select 
--列名= case  when 列名 between  100 and 90 then 'A'
			--when 列名  between  89 安定 80 then 'B'
			--when  列名>=70 and 列名<=79 then 'C'
			--end
--from 表名
 --在任何情况下select查询是不会修改结果的

--一般都使用varchar，nvarchar,可伸缩的长度类型一个非uncoding，一个uncoding类型




>>>>>>> 45f0c71 (new)
