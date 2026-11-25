using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeCourseManager.Domain.ValueObjects;
public record struct MatriculationNumber([Required]string AplhaNumeric);
