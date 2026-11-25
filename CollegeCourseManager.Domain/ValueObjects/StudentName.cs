using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeCourseManager.Domain.ValueObjects;
public sealed record StudentName
{
    public required string FirstName { get; init; }

    public required string LastName { get; init; }

    public string MiddleName { get; init; }

    public StudentName(string fName, string lName, string mName)
    {
        FirstName = fName;
        LastName = lName;
        MiddleName = mName;
    }

    public StudentName(){}

    private void ValidateStudentName(string fName, string lName, string mName)
    {
        
    }
}

public sealed record StaffName(string FirstName, string MiddleName, string LastName);