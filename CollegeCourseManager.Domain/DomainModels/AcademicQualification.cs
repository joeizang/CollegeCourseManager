using CollegeCourseManager.Domain.Dtos;
using CollegeCourseManager.Domain.ResultTypes;
using CollegeCourseManager.Domain.ValueObjects;

namespace CollegeCourseManager.Domain.DomainModels;
public sealed class AcademicQualification
{
    public required string Name { get; init; }

    public required GraduateType GraduateType { get; init; }

    public required string TitleOnConclusion { get; init; }

    public static Result<AcademicQualification, DomainError> Create(AcademicQualificationDto dto)
    {
        var acad = new AcademicQualification
        {
            Name = dto.Name,
            GraduateType = dto.GradType,
            TitleOnConclusion = dto.TitleOnConclusion
        };
        return acad;
    }
}