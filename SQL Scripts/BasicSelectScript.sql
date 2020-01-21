SELECT students.name, students.lastname, students.email, courses.name, studentcourses.date_enrolled
FROM
	students INNER JOIN studentcourses ON students.id = studentcourses.student_id
    INNER JOIN courses ON studentcourses.course_id = courses.id
ORDER BY studentcourses.date_enrolled DESC;