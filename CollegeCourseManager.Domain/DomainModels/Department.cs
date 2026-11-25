using CollegeCourseManager.Domain.Dtos;

namespace CollegeCourseManager.Domain.DomainModels;
public sealed class Department
{
    private readonly List<Course> _courses = [];

    private readonly List<Lecturer> _lecturers = [];

    public IReadOnlyList<Course> DepartmentCourses { get; private init; }

    public IReadOnlyList<Lecturer> Lecturers { get; private init; }

    public required Lecturer HeadOfDepartment { get; init; }

    public void AdoptCourse(CourseAddingDto courseDto)
    {
        var result = _courses.Find(c => c.CourseCode.Equals(courseDto.CourseCode));
        if(result is not null)
            throw new ArgumentException("To replace an existing course, please deleting the already existing course.The course currently being adopted has already been adopted and so the current adoption will be aborted!");
        _courses.Add(Course.Create(courseDto.CourseName, courseDto.CourseCode, courseDto.CreditLoad));
    }

    public void AssignLecturerToCourse(LecturerCourseAssignmentDto dto)
    {
        var course = _courses.SingleOrDefault(x => x.CourseCode == dto.CourseCode);
        var findLecturer = course?.Lecturers.SingleOrDefault(x => x.ID == dto.LecturerId);
        if(findLecturer is not null)
            throw new ArgumentException($"The lecturer has already been assigned to this course.");
        
        var lecturer = _lecturers.SingleOrDefault(x => x.ID.Equals(dto.LecturerId));
        if(lecturer is not null)
            course?.AddLecturerToLectureCourse(lecturer);
        throw new InvalidOperationException("It seems there is no lecturer with this ID");
    }

    public void RegisterStudentForCourse()
    {
        
    }

    public Department()
    {
        DepartmentCourses = _courses.AsReadOnly();
        Lecturers = _lecturers.AsReadOnly();
    }
    public static Department Create(Lecturer hod)
    {
        var department = new Department()
        {
            HeadOfDepartment = hod
        };

        return department;
    }
}
