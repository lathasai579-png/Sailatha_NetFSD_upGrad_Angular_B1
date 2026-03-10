use Edu
create view vw_StudentDepartment
AS
select 
s.StudentID,
s.FirstName + ' ' +s.LastName AS StudentName,
d.DepartmentName,
s.AdmissionDate
from Students s
join Departments d
ON s.DepartmentID=d.DepartmentID
select * from vw_StudentDepartment
SELECT *
FROM vw_StudentDepartment
WHERE DepartmentName = 'Computer Science'
DROP VIEW vw_StudentDepartment
