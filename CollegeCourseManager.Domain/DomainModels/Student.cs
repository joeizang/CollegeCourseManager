using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeCourseManager.Domain.ValueObjects;

namespace CollegeCourseManager.Domain.DomainModels;
public sealed class Student
{
    private readonly List<Course> _studentCourses = [];
    public MatriculationNumber MatricNumber { get; init; }

    public required StudentName StudentName { get; init; }

    public IReadOnlyList<Course> StudentsCourses => _studentCourses.AsReadOnly();

    private Student()
    {
    }

    public void EnrollStudentForCourse(Course studentCourse)
    {
        _studentCourses.Add(studentCourse);
    }

    public static Student Create(string firstName, string lastName, string middleName, string matricNum)
    {
        var student = new Student
        {
            MatricNumber = new MatriculationNumber(matricNum),
            StudentName = new StudentName {
                FirstName = firstName,
                LastName = lastName,
                MiddleName = middleName
            },
        };

        return student;
    }
}