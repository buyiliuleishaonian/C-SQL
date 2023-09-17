use [学习游标和触发器DB]
truncate table  productinfos
--游标
--SQLserver对数据访问的一种机制，它允许用户对数据结果进行逐条的访问
--访问都是单条语句，避免缩表
--数据结果集，游标
--三种游标
--只进游标
--静态游标static
--动态游标dynamic

--游标语法;1、定义游标  2、打开查询的结果集 3、使用  4、关闭 5、释放，也只存在定义游标的会话，会话结束游标也就结束
--只进游标，只能往下走（向下，中途无法改变），走到头，当数据改变之后，也会改变
--定义游标（一般写在存储过程中），定义其需要查询的结果集
declare product_cursor cursor for
select *from ProductInfos
--打开游标，全局global，多个存储过程，触发器使用和本地  local：本地，只能在本地批处理使用
open product_cursor 
--使用游标
--1、定义其他用于存放信息的变量，定义游标来存放查询结果集的游标，定义结果集中存在的列的数据类型的变量，
--@varCousor  cursor 用于存放单行数据
--2、将游标的值赋值给定义的cousor的变量
--fetch next from  cursor变量  into	 定义的变量（对应结果集中列的数据类型）	游标前进，相当于在C#中sqldatareader类中的方法reader
--next 向下，prior 向上
declare @cursorvarchar cursor,@产品id int,@产品名  varchar(50),@产品单价 money
set @cursorvarchar=product_cursor
fetch next from  @cursorvarchar into  @产品id,@产品名,@产品单价
--将读取出来的数据集，一一读取出来
while @@FETCH_STATUS=0  --专门用于在游标中，判断是否将游标中的数据全部读取出来啦，
begin
  --print  @cursorvarchar
  print cast(@产品id as varchar(50))+@产品名+cast(@产品单价 as varchar(50))
  fetch next from  @cursorvarchar into @产品id,@产品名,@产品单价
end

--关闭游标，close关闭
close @cursorvarchar--因为已经将游标赋值给游标变量，所以需要关闭游标变量
--释放资源，deallocate释放
deallocate @cursorvarchar





--触发器
--预编译的语法结构
