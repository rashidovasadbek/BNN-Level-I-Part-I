Course course = new Course();
course.CourseId = 1;
course.Title = "dot net";
Studet<int, string> studet = new Studet<int, string>(1, "Asadbek", "Komputer inginering");
Univercity<Studet<int, string>, int, string> univercity = new
    Univercity<Studet<int, string>, int, string>();
univercity.EnrollStudent(studet, course);


univercity.students.ForEach(student => Console.WriteLine($"{student.Id}\n{student.Grade}\n{student.Name}\n"));
univercity.courses.ForEach(course => Console.WriteLine($"{course.CourseId}\n{course.Title}"));
/*foreach (var item in univercity.students)
{
    Console.WriteLine(item.Grade);
    Console.WriteLine(item.Name);
}
foreach (var item in univercity.courses)
{
    Console.WriteLine(item.Title);
}*/