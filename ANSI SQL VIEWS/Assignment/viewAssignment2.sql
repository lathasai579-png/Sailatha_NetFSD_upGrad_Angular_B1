create view vw_StudentCourses AS
select 
s.FirstName + ' ' + s.LastName AS StudentName,
c.CourseName,
e.EnrollmentDate,
s.StudentID
from Students s
JOIN Enrollments e ON s.StudentID=e.StudentID
JOIN Courses c ON e.CourseID=c.CourseID
SELECT CourseName
FROM vw_StudentCourses
WHERE StudentID =205
SELECT StudentName, COUNT(CourseName) AS TotalCourses
FROM vw_StudentCourses
GROUP BY StudentName;
SELECT *
FROM vw_StudentCourses
WHERE EnrollmentDate > '2024-12-31'