using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeCourseManager.Domain.ValueObjects;
//Postgraduate Degrees, Bachelor's Degrees, Diploma/Certificate, Doctorate
public sealed record GraduateType(
    [Required(ErrorMessage = "Name cannot be blank")]
    string Name,
    [Required]
    [MinLength(3, ErrorMessage = "The length of the abbreviation given is too short!")]
    string Abbreviation);