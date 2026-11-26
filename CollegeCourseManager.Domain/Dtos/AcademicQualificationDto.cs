using System.ComponentModel.DataAnnotations;
using CollegeCourseManager.Domain.ValueObjects;

namespace CollegeCourseManager.Domain.Dtos;

public sealed record AcademicQualificationDto(
    [Required(ErrorMessage = "A Qualification's name cannot be an emtpy string!")]
    [MaxLength(100, ErrorMessage ="A Qualification's Name length is invalid!")]
    [MinLength(2, ErrorMessage = "This Qualification's name is too short!")]
    [RegularExpression(@"\A[A-Z]\.[A-Z][a-z]?\.\z")]
    string TitleOnConclusion,
    [Required(ErrorMessage = "Every qualification must have a name!")]
    [MaxLength(100)]
    string Name,
    [Required]
    GraduateType GradType);
