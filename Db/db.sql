create database College
go

create table student
(
	student_id int primary key,
	[name] varchar(128),
	teacher_id int
)
go

create table course
(
	course_id int primary key,
	[name] varchar(128),
	[status] bit default 1
)
go

create table enrollment(
	student_id int,
	course_id int,
)
go


alter table dbo.enrollment
add constraint fk_enrollment_stu
foreign key (student_id) references student(student_id)
go

alter table dbo.enrollment
add constraint fk_enrollment_course
foreign key (course_id) references course(course_id)
go

INSERT INTO student (student_id, [name], teacher_id)
VALUES 
    (1, 'John Doe',2),
    (2, 'Jane Smith',2),
    (3, 'Michael Johnson',1),
    (4, 'Sarah Williams',1),
    (5, 'David Brown',2),
    (6, 'Jennifer Lee',2),
    (7, 'Christopher Davis',1),
    (8, 'Emily Taylor',1),
    (9, 'Matthew Jackson',1),
    (10, 'Amanda Lee',1);
go

delete from student;

INSERT INTO course (course_id, [name], [status])
VALUES 
    (1, 'Introduction to Programming', 1),
    (2, 'Database Design and Management', 1),
    (3, 'Web Development with ASP.NET', 0),
    (4, 'Software Engineering', 1),
    (5, 'Data Analytics and Visualization', 1),
    (6, 'Artificial Intelligence', 0),
    (7, 'Computer Networks and Security', 1),
    (8, 'Mobile App Development', 0),
    (9, 'Operating Systems', 1),
    (10, 'Human-Computer Interaction', 1);
go



INSERT INTO enrollment (student_id, course_id)
VALUES 
    (1, 2),
    (1, 4),
    (1, 5),
    (2, 1),
    (2, 3),
    (2, 7),
    (3, 2),
    (3, 6),
    (4, 3),
    (5, 2);
go


alter proc spCountCourses
as
begin
	select count(course_id) 'count_c' from course
end
go

exec spCountCourses
go

CREATE PROCEDURE spGetEnrollments
AS
BEGIN
    SELECT s.student_id, s.name, c.course_id, c.name AS course_name
    FROM student s
    JOIN enrollment e ON s.student_id = e.student_id
    JOIN course c ON e.course_id = c.course_id
END


CREATE PROC spGetAllActiveCourses
as
begin
	select * from course
	where [status] = 1
end
go

create table teacher
(
	teacher_id int primary key,
	[name] varchar(128)
);
go

alter table student
add teacher_id int

insert into teacher (teacher_id,[name])
values (1, 'Abc'), (2,'Def')

create proc
