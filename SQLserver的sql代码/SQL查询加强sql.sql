<<<<<<< HEAD
use JGWnameDB

--每一次查询，都是产生虚拟表， 
--按着查询的结果来，按着表格模式显示

--c# 对于用户 连表
--从业务层面？
--做网站，做winform，用到下拉框
--列 as 别名
--列 空格  别名
--别名=列

--有序 主键索引默认是排序的
--order by <排序的列名>
select * from Students
where   sex='男'
order by  stuno
--order by  列名，（不论学到分组，过滤筛选，都是在最后）,asc升序，desc降序
--asc 升序从小到打
--desc 降序从大到小
--升序
select  stuno from Students
order by  stuno asc
--降序
select  stuno from Students
order by  stuno desc	

--查询语法
--select  列名
--from  表明
--where 满足条件
--order  by   列名[asc和desc]     
select  ClassShcoolID,stuName
from Students
where  sex='男'
order by   stuNo

--字符串合并列（字段分类型）  字符串+字符串=拼接， 数字+数字=运算
--convert转换，cast： convert(varchar,ClassShcoolID),cast(stuno as varchar) 
select  convert(nvarchar,classshcoolid)+stuName
from Students

--字符串空不是null,什么都没有，对象空=null，对象创建之后没有赋值
--判断数据段空 where  creattime is null


--限制固定行数
--1、限制固定几行，top 1
select top 4 stuNo from Students

--2、按百分比显示几行 top 2 percent
select top 80  percent ClassShcoolID from Students


--字符串常见的几类函数
--charindex（var1，var2，var3）：寻找一个指定字符串在另一个字符串中开始的位置，没有区分大小写
--参数1，查询的参数，参数2，被搜索的字符串，参数3，索引地开始找，数据库里面的字符串索引的长度是从0开始的
select stuname from students where stuno=1004
select CHARINDEX('三','张三丰',1) stuname
from Students

--字符串长度：len（'字符串'）,返回传递给它的字符串长度
select stuname  from Students  where len(stuname)>=3

--upper：将字符串的小写转为大写 upper('字符串')
select upper('wenqiaocui')

--ltrim:清楚左边的空格 ltrim('字符串')
select LTRIM('  文憔悴')

--rtrim：清楚字符串右边的空格  rtrim（'字符串'）

--right:从字符串右边返回指定数目的字符  right（'字符串',1）

--replace：替换一个字符串中的字符 replace('字符串','var1','var2')，var1表示为需要替换的字符，var2表示替换的值
select  replace('布衣流泪少年','布衣流泪','孤高自傲')

--stuff：在一个字符串中，删除指定索引的指定长度，并且插入一个新的字符串，stuff（'字符串1',2（索引）,3（个数）,'字符串2'）
select  stuff('文憔悴',2,1,'最帅')


--日期函数
--getdate：取得当前时间 select getdate（），返回今天日期
select getdate()

--dateadd：将指定数字加到日期的指定部分 select  dateadd(mm,4,'01/01/2009'),返回值5/1/2009

--datediff：两个日期之间的指定日期部分的间隔 select datediff（mm,'01/01/2001','05/01/2001'），返回4

--datename：日期中指定日期部分的字符串形式 select datename（mm,'01/01/2000'） 返回 星期六或者saturday

--datepart：日期中指定日期部分的整数形式 select datepart（day,'01/15/2000'） 返回15

--获得当前日期的各种格式,用convert转换，先转成字符串格式，之后选择那种格式输出，百度selserver的convert转换日期格式
select CONVERT(varchar,GETDATE(),111)

select (DATEADD (day,1,getdate()))
--c# yy年 MM月  dd日  hh小时   mm分  ss秒
--sql  yy年  mm月   dd日  m分   


--数学函数
--rand ：返回从0到1的随机float值， select rand（）

--abs：取数值表达式的绝对值 select abs（数学表达式）

--geiling：取大于或等于指定数值，表达式的最小整数 select  getling（43.5）  返回值44

--floor：取小于或等于指定数值，表达式的最大整数 select floor（43.5） 返回值43

--power：取数值表达式的幂值 select power（5，2） 返回值25  5^2

--rouno:将数值表达式四舍五入为指定精度 select rouno（43.543，1） 反沪指43.5

--sigh: 对于正数返回值+1，对于负数返回值-1，对于0返回0， select sigh（-43） 返回值-44

--sqrt;取浮点表达式的平方根 select sqrt（9） 返回值3



--系统函数
--convert：用来转化数据类型convert （varchar,12334）

--current_use: 返回当前用户名：select current_use

--datalength：返回用于指定表达式的字节数，select datalength

--host_name:返回当前计算机所登入的计算机名字，select host_name()

--system_user:返回当前所登入的用户名称，select system_user

--user_name: 从给定的用户id返回用户名，select user_name(1)： 返回值从任意数据库中返回'db0'



--查询常用函数
--LIKE,BETWEEN,IN进行模糊查询
--使用聚合函数统计和汇总函数

--模糊查询,不知道具体的信息，只知道一部分
--模糊查询like,任意匹配多次将包含查询的信息的数据选择筛选出来，不知道具体的信息，只知道一部分
--like
--通配符1、_：表示一个字符，A LIKE '张_'  表示 张cs，张三  这些满足
--通配符2、%：表示任意长度，B LIKE	'张_',表示只要含有张的数据都提取出来
--通配符3、[]:表示规定的长度范围，C LIKE '张[1-2]',表示张的后面跟有2至3个字符的数据全部提取出阿里
--通配符4、[^]：不在括号范围类的数据提取出来 ，D LIKE '张[^1-2]' ,
select *from  Students
where stuName like '张%'  

--in 包含/not in 不包含
select*from Students 
where stuNo in (1001,1002,1003)
--truncate table students恢复表到达初始
truncate table students
--分页
select top 3* from  Students
where stuNo in (1,2,3)

select top 3*from Students
where stuno in(4,5,6)

select  top 3*from Students 
where stuNo in(7,8,9)

--前三行，为一页
select top 3 * from Students

--各三行为一页
select top 3* from Students
where  stuNo not in (select top 3 *from Students)


--between 推荐使用
--数字和日期的筛选
--根据索引从小到大的查找，效率最高bettwwn 从小到大查找
select * from Students
where stuno between 1 and 3



--聚合函数五种 最大值max 最小值 min 总和 sum, 平均avg 只能用作数字 统计记录count，可以统计字符串和日期，null不参与统计，一般用主键统计
select  max(qian) as zuidazhi from Students
select min(qian) from Students
select  avg(qian) from Students
select sum(qian)  from Students
select  count(stuName) from Students
=======
use JGWnameDB

--每一次查询，都是产生虚拟表， 
--按着查询的结果来，按着表格模式显示

--c# 对于用户 连表
--从业务层面？
--做网站，做winform，用到下拉框
--列 as 别名
--列 空格  别名
--别名=列

--有序 主键索引默认是排序的
--order by <排序的列名>
select * from Students
where   sex='男'
order by  stuno
--order by  列名，（不论学到分组，过滤筛选，都是在最后）,asc升序，desc降序
--asc 升序从小到打
--desc 降序从大到小
--升序
select  stuno from Students
order by  stuno asc
--降序
select  stuno from Students
order by  stuno desc	

--查询语法
--select  列名
--from  表明
--where 满足条件
--order  by   列名[asc和desc]     
select  ClassShcoolID,stuName
from Students
where  sex='男'
order by   stuNo

--字符串合并列（字段分类型）  字符串+字符串=拼接， 数字+数字=运算
--convert转换，cast： convert(varchar,ClassShcoolID),cast(stuno as varchar) 
select  convert(nvarchar,classshcoolid)+stuName
from Students

--字符串空不是null,什么都没有，对象空=null，对象创建之后没有赋值
--判断数据段空 where  creattime is null


--限制固定行数
--1、限制固定几行，top 1
select top 4 stuNo from Students

--2、按百分比显示几行 top 2 percent
select top 80  percent ClassShcoolID from Students


--字符串常见的几类函数
--charindex（var1，var2，var3）：寻找一个指定字符串在另一个字符串中开始的位置，没有区分大小写
--参数1，查询的参数，参数2，被搜索的字符串，参数3，索引地开始找，数据库里面的字符串索引的长度是从0开始的
select stuname from students where stuno=1004
select CHARINDEX('三','张三丰',1) stuname
from Students

--字符串长度：len（'字符串'）,返回传递给它的字符串长度
select stuname  from Students  where len(stuname)>=3

--upper：将字符串的小写转为大写 upper('字符串')
select upper('wenqiaocui')

--ltrim:清楚左边的空格 ltrim('字符串')
select LTRIM('  文憔悴')

--rtrim：清楚字符串右边的空格  rtrim（'字符串'）

--right:从字符串右边返回指定数目的字符  right（'字符串',1）

--replace：替换一个字符串中的字符 replace('字符串','var1','var2')，var1表示为需要替换的字符，var2表示替换的值
select  replace('布衣流泪少年','布衣流泪','孤高自傲')

--stuff：在一个字符串中，删除指定索引的指定长度，并且插入一个新的字符串，stuff（'字符串1',2（索引）,3（个数）,'字符串2'）
select  stuff('文憔悴',2,1,'最帅')


--日期函数
--getdate：取得当前时间 select getdate（），返回今天日期
select getdate()

--dateadd：将指定数字加到日期的指定部分 select  dateadd(mm,4,'01/01/2009'),返回值5/1/2009

--datediff：两个日期之间的指定日期部分的间隔 select datediff（mm,'01/01/2001','05/01/2001'），返回4

--datename：日期中指定日期部分的字符串形式 select datename（mm,'01/01/2000'） 返回 星期六或者saturday

--datepart：日期中指定日期部分的整数形式 select datepart（day,'01/15/2000'） 返回15

--获得当前日期的各种格式,用convert转换，先转成字符串格式，之后选择那种格式输出，百度selserver的convert转换日期格式
select CONVERT(varchar,GETDATE(),111)

select (DATEADD (day,1,getdate()))
--c# yy年 MM月  dd日  hh小时   mm分  ss秒
--sql  yy年  mm月   dd日  m分   


--数学函数
--rand ：返回从0到1的随机float值， select rand（）

--abs：取数值表达式的绝对值 select abs（数学表达式）

--geiling：取大于或等于指定数值，表达式的最小整数 select  getling（43.5）  返回值44

--floor：取小于或等于指定数值，表达式的最大整数 select floor（43.5） 返回值43

--power：取数值表达式的幂值 select power（5，2） 返回值25  5^2

--rouno:将数值表达式四舍五入为指定精度 select rouno（43.543，1） 反沪指43.5

--sigh: 对于正数返回值+1，对于负数返回值-1，对于0返回0， select sigh（-43） 返回值-44

--sqrt;取浮点表达式的平方根 select sqrt（9） 返回值3



--系统函数
--convert：用来转化数据类型convert （varchar,12334）

--current_use: 返回当前用户名：select current_use

--datalength：返回用于指定表达式的字节数，select datalength

--host_name:返回当前计算机所登入的计算机名字，select host_name()

--system_user:返回当前所登入的用户名称，select system_user

--user_name: 从给定的用户id返回用户名，select user_name(1)： 返回值从任意数据库中返回'db0'



--查询常用函数
--LIKE,BETWEEN,IN进行模糊查询
--使用聚合函数统计和汇总函数

--模糊查询,不知道具体的信息，只知道一部分
--模糊查询like,任意匹配多次将包含查询的信息的数据选择筛选出来，不知道具体的信息，只知道一部分
--like
--通配符1、_：表示一个字符，A LIKE '张_'  表示 张cs，张三  这些满足
--通配符2、%：表示任意长度，B LIKE	'张_',表示只要含有张的数据都提取出来
--通配符3、[]:表示规定的长度范围，C LIKE '张[1-2]',表示张的后面跟有2至3个字符的数据全部提取出阿里
--通配符4、[^]：不在括号范围类的数据提取出来 ，D LIKE '张[^1-2]' ,
select *from  Students
where stuName like '张%'  

--in 包含/not in 不包含
select*from Students 
where stuNo in (1001,1002,1003)
--truncate table students恢复表到达初始
truncate table students
--分页
select top 3* from  Students
where stuNo in (1,2,3)

select top 3*from Students
where stuno in(4,5,6)

select  top 3*from Students 
where stuNo in(7,8,9)

--前三行，为一页
select top 3 * from Students

--各三行为一页
select top 3* from Students
where  stuNo not in (select top 3 *from Students)


--between 推荐使用
--数字和日期的筛选
--根据索引从小到大的查找，效率最高bettwwn 从小到大查找
select * from Students
where stuno between 1 and 3



--聚合函数五种 最大值max 最小值 min 总和 sum, 平均avg 只能用作数字 统计记录count，可以统计字符串和日期，null不参与统计，一般用主键统计
select  max(qian) as zuidazhi from Students
select min(qian) from Students
select  avg(qian) from Students
select sum(qian)  from Students
select  count(stuName) from Students
>>>>>>> 45f0c71 (new)
