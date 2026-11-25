using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeCourseManager.Domain.ResultTypes;

namespace CollegeCourseManager.Domain.DomainModels;
public sealed class Course
{
    private readonly List<Student> _students = [];

    private readonly List<Lecturer> _courseLecturers = [];

    public required string CourseName { get; init; }

    public required string CourseCode { get; init; }

    public required int CreditLoad { get; init; }

    public IReadOnlyList<Lecturer> Lecturers { get; private init; } //=> _courseLecturers.AsReadOnly();

    public IReadOnlyList<Student> Students { get; private init; } //=> _students.AsReadOnly();

    public void AddLecturerToLectureCourse(Lecturer lecturer)
    {
        _courseLecturers.Add(lecturer);
    }

    public void EnrollStudentForCourse(Student student)
    {
        if (student is not null)
        {
            _students.Add(student);
        }
    }

    public Course()
    {
        Lecturers = _courseLecturers.AsReadOnly();
        Students = _students.AsReadOnly();
    }
    
    public static Course Create(string courseName, string courseCode, int creditLoad)
    {
        var course = new Course()
        {
            CourseName = courseName,
            CourseCode = courseCode,
            CreditLoad = creditLoad
        };

        return course;
    }

    private void ValidateInvariants(string courseName)
    {
        if(string.IsNullOrEmpty(courseName))
            new Result<Error>(new ArgumentError("Course name cannot be empty!"));
    }
}
