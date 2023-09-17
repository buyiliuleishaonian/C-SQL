use 学生管理系统
insert into classinfos(ClassId,ClassName) values(1,'软件1班')
insert into StudentClass(ClassId,ClassName) values(2,'软件2班')
insert into StudentClass(ClassId,ClassName) values(3,'计算机1班')
insert into StudentClass(ClassId,ClassName) values(4,'计算机2班')
insert into StudentClass(ClassId,ClassName) values(5,'网络1班')
insert into StudentClass(ClassId,ClassName) values(6,'网络2班')


insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('王小虎','男','1989-08-07',22,120223198908071111,'0004018766','022-22222222','天津市南开区红磡公寓5-5-102',1)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('贺小张','女','1989-05-06',22,120223198905062426,'0006394426','022-33333333','天津市河北区王串场58号',2)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('马小李','男','1990-02-07',21,120223199002078915,'0006073516','022-44444444','天津市红桥区丁字沽曙光路79号',4)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('冯小强','女','1987-05-12',24,130223198705125167,'0006254540','022-55555555',default,2)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('杜小丽','女','1986-05-08',25,130223198605081528,'0006403803','022-66666666','河北衡水路北道69号',1)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('王俊桥','男','1987-07-18',24,130223198707182235,'0006404372','022-77777777',default,1)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('张永利','男','1988-09-28',24,130223198909282235,'0006092947','022-88888888','河北保定市风华道12号',3)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('李铭','男','1987-01-18',24,130223198701182257,'0006294564','022-99999999','河北邢台市幸福路5号',1)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('宁俊燕','女','1987-06-15',24,130223198706152211,'0006092450','022-11111111',default,3)
insert into studentsinfos (StudentName,Gender,Birthday,Age,studentidno,CardNo,PhoneNumber,StudentAddress,ClassId)
         values('刘玲玲','女','1989-08-19',24,130223198908192235,'0006069457','022-11111222',default,4)

insert into scorelistinfos (id,CSharp,SQLserver成绩)values(100000,60,78)
insert into scorelistinfos (id,CSharp,sqlserver成绩)values(100001,55,88)
insert into scorelistinfos (id,CSharp,sqlserver成绩)values(100002,90,58)
insert into scorelistinfos (id,CSharp,sqlserver成绩)values(100003,88,75)

insert into scorelistinfos (id,CSharp,sqlserver成绩)values(100004,62,88)
insert into scorelistinfos (id,CSharp,sqlserver成绩)values(100006,52,80)
insert into scorelistinfos (id,CSharp,sqlserver成绩)values(100007,91,66)
insert into scorelistinfos (id,CSharp,sqlserver成绩)values(100009,78,35)

insert into Admins (password,AdminName) values(123456,'王晓军')
insert into Admins (password,AdminName) values(123456,'张明丽')


select *from StudentsInfos
select*from ScoreListInfos
select*from ClassInfos
select*from AttendanceInfos
select*from admins