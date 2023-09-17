use JGWnameDB
select * from testinfos
--execute
exec pro_GetProduct

---什么叫预编译
--特点:预编译，批处理
--优点:提高查询效率
--优点:存储过程（T-SQL）只能通过参数化方式调用，安全性更高
--优点:模块化编程（功能，存储过程也可以调用存储过程）
--缺点：写起来复杂


--访问修饰符，返回值，方法名（形参）

--创建一个存储过程，存储过程可以构建试图，但是试图不可以调用存储过程
--语法规范PROC_
--三种参数，输出参数，输入参数，返回值
use jgwnamedb
create proc PROC_GetProduct(
	--输入参数
	@studentname  varchar(50),
	@studenthome  varchar(50),
	@studentnianji  int output
	--输出参数，可以定义多个
--一般输入参数在前，输出参数在后
)--形参
as
begin
	insert into shcoolinfos(studentsname,studentshome,StudentsNianji)
	values(@studentname,@studenthome)
	select  @qq=@@identity--返回值  ---获取当前最近插入的自增id
	--return  @@indentity
end

--存储过程，修改
alter  proc   PROC_GetProduct(
	--输入参数
	@studentname  varchar(50),
	@studenthome  varchar(50),
	@studentnianji  int  output--输出参数，可以定义多个
--一般输入参数在前，输出参数在后
)--形参
as
begin
	insert into shcoolinfos(studentsname,studentshome)
	values(@studentname,@studenthome)
	select  @studentnianji=@@identity--返回值  ---获取当前最近插入的自增id，局部变量，通过select赋值，多个值时，给定查询的最后一个值
	--return  @@indentity
end


--调用存储过程
--execute
--如果存储过程中，有输出参数
--需要定义一个参数接受
declare @qq1  int
execute PROC_GetProduct '孙总','湖北黄冈',@qq1 output
select @qq1

--写一个返回值的存储过程
create proc PROC_GetShcoolinfos
(
	@studentname varchar(50),
	@studenthome varchar(50)--输入参数
)
as
begin
  insert into ShcoolInfos(StudentsName,Studentshome)
  values(@studentname,@studenthome)
  return  @@identity
end



--返回值
declare  @id1  varchar(50)
  exec  @id1=PROC_GetShcoolinfos '彭总','湖北随州'--放回值

