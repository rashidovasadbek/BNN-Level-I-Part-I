using System;

public class Univercity<TStudent, TId, TGrade> where TStudent : Studet<TId,TGrade>
{
    public List<TStudent> students;
    public List<Course> courses;

    public Univercity()
    {
        students = new List<TStudent>();
        courses = new List<Course>();
    }
    public void EnrollStudent(TStudent student, Course course)
    {
        students.Add(student);
        courses.Add(course);
    }

    public override string ToString()
    {
        return $"Ctudents:{students}\nCourses:{courses}";
    }
}

