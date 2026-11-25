using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeCourseManager.Domain.ValueObjects;

namespace CollegeCourseManager.Domain.Dtos;
public sealed record LecturerCourseAssignmentDto(string CourseCode, string LecturerId);

public sealed record CreateLecturerDto(string StaffID, string Title, StaffName Name);
