/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     2023/6/2 15:55:48                            */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AttendanceInfos') and o.name = 'FK_ATTENDAN_REFERENCE_STUDENTS')
alter table AttendanceInfos
   drop constraint FK_ATTENDAN_REFERENCE_STUDENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ClassInfos') and o.name = 'FK_CLASSINF_REFERENCE_STUDENTS')
alter table ClassInfos
   drop constraint FK_CLASSINF_REFERENCE_STUDENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ScoreListInfos') and o.name = 'FK_SCORELIS_REFERENCE_STUDENTS')
alter table ScoreListInfos
   drop constraint FK_SCORELIS_REFERENCE_STUDENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StudentsInfos') and o.name = 'FK_STUDENTS_REFERENCE_CLASSINF')
alter table StudentsInfos
   drop constraint FK_STUDENTS_REFERENCE_CLASSINF
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Admins')
            and   type = 'U')
   drop table Admins
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AttendanceInfos')
            and   type = 'U')
   drop table AttendanceInfos
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ClassInfos')
            and   type = 'U')
   drop table ClassInfos
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ScoreListInfos')
            and   type = 'U')
   drop table ScoreListInfos
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StudentsInfos')
            and   type = 'U')
   drop table StudentsInfos
go

/*==============================================================*/
/* Table: Admins                                                */
/*==============================================================*/
create table Admins (
   Username             int                  not null,
   Password             varchar(20)          null,
   AdminName            Varchar(20)          null,
   constraint PK_ADMINS primary key (Username)
)
go

/*==============================================================*/
/* Table: AttendanceInfos                                       */
/*==============================================================*/
create table AttendanceInfos (
   id                   int                  not null,
   CardNo               varchar(20)          null,
   DTtime               samalldatetime       null,
   constraint PK_ATTENDANCEINFOS primary key (id)
)
go

/*==============================================================*/
/* Table: ClassInfos                                            */
/*==============================================================*/
create table ClassInfos (
   Classid              int                  not null,
   ClassName            varchar(50)          null,
   constraint PK_CLASSINFOS primary key (Classid)
)
go

/*==============================================================*/
/* Table: ScoreListInfos                                        */
/*==============================================================*/
create table ScoreListInfos (
   id                   int                  not null,
   StudentId            int                  null,
   Csharp               int                  null,
   SQLserver³É¼¨          int                  null,
   Updatetime           smalldatetime        null,
   constraint PK_SCORELISTINFOS primary key (id)
)
go

/*==============================================================*/
/* Table: StudentsInfos                                         */
/*==============================================================*/
create table StudentsInfos (
   StudentID            int                  not null,
   StudentName          varchar(10)          null,
   Gender               char                 null,
   Birthday             smalldatetime        null,
   StudentIdNo          vchar(18)            null,
   CardNo               varchar(20)          null,
   StuImage             image                null,
   Age                  int                  null,
   PhoneNumber          varchar(50)          null,
   StudentAddress       varchar(50)          null,
   Classid              int                  null,
   constraint PK_STUDENTSINFOS primary key (StudentID)
)
go

alter table AttendanceInfos
   add constraint FK_ATTENDAN_REFERENCE_STUDENTS foreign key (CardNo)
      references StudentsInfos (CardNo)
go

alter table ClassInfos
   add constraint FK_CLASSINF_REFERENCE_STUDENTS foreign key (Classid)
      references StudentsInfos (Classid)
go

alter table ScoreListInfos
   add constraint FK_SCORELIS_REFERENCE_STUDENTS foreign key (StudentId)
      references StudentsInfos (StudentID)
go

alter table StudentsInfos
   add constraint FK_STUDENTS_REFERENCE_CLASSINF foreign key (Classid)
      references ClassInfos (Classid)
go

