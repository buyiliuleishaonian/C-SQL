use JGWnameDB
--触发器-针对于表添加，删除，修改(触发)
--对于某张表添加动作，触发动作，向另一张表添加一条操作记录

--触发器：约束，不带约束的
--当存在主外键约束的时候，需要删除主表中数据，子表也删除时需要用触发器


--实际上只有两种对数据库有影响，只有添加，删除，修改的本质是先删除，后添加
--临时表，系统临时表  inserted(添加记录)  deleted(删除记录)

--trigger  触发器

--1、创建触发器，创建在某个表中
create trigger tri_Test1  --创建触发器，修改是alter
on test1  --创建的触发器存在于那个表
for  insert,update,delete   ---after/inserted  of(可以删除带约束的表)
as
begin
	--相当于事务
	declare @name  varchar(50)--操作人
	declare @动作  varchar(50)
	declare @sum  int--统计
	if  exists(select top 1 * from deleted)
	begin
	 select @name=name from deleted
	 set	@动作='删除'
	 set  @sum=@sum+1
	end
	if  exists (select top 1 * from inserted)
	begin
	select @name=name from inserted
	 set  @动作='添加'
	 set  @sum=@sum+1
	end
	if  @sum=2
	begin
	select @name=name from deleted
	set  @动作='修改'
	end

	--触发器存在的表，触发之后，于另一张表，实现添加删除修改
	--这是写在记录表里面，如果是要对另一个表的话，就需要建立对应的变量，和实现相对应的
	--添加，删除，修改
	insert  into  test2(name,动作)
	values(@name,@动作)
end