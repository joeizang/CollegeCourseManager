using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeCourseManager.Domain.Dtos;
public sealed record CourseAddingDto(Guid Id, string CourseName, string CourseCode, int CreditLoad);