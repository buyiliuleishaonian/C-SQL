<<<<<<< HEAD
use JGWnameDB
--子查询语句
--查询内嵌套查询
--嵌套查询的优先级，先进行子查询
--子查询，将查询的结果作为条件
--子查询里面也可以实现表连接
select *from  Students
where qian>(select qian from students where qian=100)


--表连接，也是可以用子查询代替的

--表连接，三张表关联匹配
--表连接需要两张表有相关联的列
--假设显示结果来源于多张表，不适合子查询
--表连接更适合查看多表的数据

--where 可以写子查询
--在select 后面也是可以写子查询
--在from 后面也是可以写子查询的
=======
use JGWnameDB
--子查询语句
--查询内嵌套查询
--嵌套查询的优先级，先进行子查询
--子查询，将查询的结果作为条件
--子查询里面也可以实现表连接
select *from  Students
where qian>(select qian from students where qian=100)


--表连接，也是可以用子查询代替的

--表连接，三张表关联匹配
--表连接需要两张表有相关联的列
--假设显示结果来源于多张表，不适合子查询
--表连接更适合查看多表的数据

--where 可以写子查询
--在select 后面也是可以写子查询
--在from 后面也是可以写子查询的
>>>>>>> 45f0c71 (new)
--在group by也可以子查询