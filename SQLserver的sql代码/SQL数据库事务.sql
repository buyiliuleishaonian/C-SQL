
--不合理 两条语句不是一个整体
--数据库三种事务
--对事物操作只有增删改，查询不会改变数据
--insert  delete  update  select(不影响数据)
--数据库第一种，显示事务 begin transaction
--系统函数，捕获T-SQL语句执行错误编号@@error
use jgwnamedb
begin transaction--开始事务
declare @num int=0
update students
set stuname='张老六'
where stuname='张三'
set @num=@num+@@error--出现错误报为1
update students
set stuName='李老五'
where stuname='李四'
set @num=@num+@@error
if @num=0
begin
print '转帐成功'
commit transaction--提交业务
end
else --如果报错
begin
print '转帐失败'+cast(@num as varchar)
rollback transaction--就回滚信息
end


--数据库第二种，自动事务commit transaction：SQL server的默认模式
--每条单独T-SQL语句视为一个事务

--数据库第三种，隐式事务：通过设置set implicit_transactions on语句
--将其隐式事务模式设置为打开，其后的T-SQL语句自动启动一个新事务
--提交或回滚一个事务后，下一个T-SQL语句又将启动一个新事务，保证事务的隔离性


set implicit_transactions on--打开隐式事务，如果打开隐式事务，使用添加删除修改，事务锁表，看不到表中信息，但是表已经执行操作
--正在等待下一步指令，等待提交或者取消  rollback：取消  commit提交
commit
rollback
--oracle，默认隐式事务开启，sqlserver默认隐式事务关闭
=======
--不合理 两条语句不是一个整体
--数据库三种事务
--对事物操作只有增删改，查询不会改变数据
--insert  delete  update  select(不影响数据)
--数据库第一种，显示事务 begin transaction
--系统函数，捕获T-SQL语句执行错误编号@@error
use jgwnamedb
begin transaction--开始事务
declare @num int=0
update students
set stuname='张老六'
where stuname='张三'
set @num=@num+@@error--出现错误报为1
update students
set stuName='李老五'
where stuname='李四'
set @num=@num+@@error
if @num=0
begin
print '转帐成功'
commit transaction--提交业务
end
else --如果报错
begin
print '转帐失败'+cast(@num as varchar)
rollback transaction--就回滚信息
end


--数据库第二种，自动事务commit transaction：SQL server的默认模式
--每条单独T-SQL语句视为一个事务

--数据库第三种，隐式事务：通过设置set implicit_transactions on语句
--将其隐式事务模式设置为打开，其后的T-SQL语句自动启动一个新事务
--提交或回滚一个事务后，下一个T-SQL语句又将启动一个新事务，保证事务的隔离性


set implicit_transactions on--打开隐式事务，如果打开隐式事务，使用添加删除修改，事务锁表，看不到表中信息，但是表已经执行操作
--正在等待下一步指令，等待提交或者取消  rollback：取消  commit提交
commit
rollback
--oracle，默认隐式事务开启，sqlserver默认隐式事务关闭
--sqlconnection 连接对象 conn.close() 关闭汇话窗口