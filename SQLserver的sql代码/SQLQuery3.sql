--静态游标，有相对定位，绝对定位，可以找到固定的某一行，
--定义静态游标，当定义游标打开之后，得到啦所查询的数据集之后
--在没有关闭之前，不管再在查询的表中增删改任何数据，游标中得到的数据集不会改变
--静态游标也是可以上下读取
declare product_cursor cursor  static
for 
select *from ProductInfos

--打开游标
open product_cursor

--定义对应游标数据里面的变量
declare @cursorvarchar cursor,@产品id int,@产品名  varchar(50),@产品单价 money
set @cursorvarchar=product_cursor
fetch next from  @cursorvarchar into  @产品id,@产品名,@产品单价
print cast(@产品id as varchar(50))+@产品命+cast(@产品单价 as varchar(50))

close @cursorvarchar
deallocate  @cuesorvarchar




--动态游标,保存的是动态的结果集，当查询得数据集，改变之后，相对应的游标也会改变
--动态游标，可以向上读取或者向下读取
declare product_cursor_dynamic cursor  dynamic
for 
select *from ProductInfos

--打开游标
open product_cursor

--定义对应游标数据里面的变量
declare @cursorvarchar1 cursor,@产品id1 int,@产品名1  varchar(50),@产品单价1 money
set @cursorvarchar=product_cursor_dynamic
fetch next from  @cursorvarchar into  @产品id1,@产品名1,@产品单价1
print cast(@产品id1 as varchar(50))+@产品命1+cast(@产品单价1 as varchar(50))

close @cursorvarchar
deallocate  @cuesorvarchar