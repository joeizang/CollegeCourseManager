using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeCourseManager.Domain.DomainModels;
public sealed class Faculty
{
    private readonly List<Department> _departments = [];
    public required string FacultyName { get; init; }

    public required Lecturer FacultyDean { get; init; }

    public IReadOnlyList<Department> FacultyDepartments { get; private init; }

    public Faculty()
    {
        FacultyDepartments = _departments.AsReadOnly();
    }

    public static Faculty Create(Lecturer dean)
    {
        var faculty = new Faculty()
        {
            FacultyName = string.Empty,
            FacultyDean = dean,
        };

        return faculty;
    }
}
