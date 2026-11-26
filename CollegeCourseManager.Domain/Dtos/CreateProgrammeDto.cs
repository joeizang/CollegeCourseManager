using System.Reflection;
using CollegeCourseManager.Domain.DomainModels;
using CollegeCourseManager.Domain.ValueObjects;

namespace CollegeCourseManager.Domain.Dtos;

public sealed record CreateProgrammeDto(string Title, StudyMode StudyMode, 
    ProgrammeTenure tenure, AcademicQualificationDto QualificationDto);



public static class CreateProgrammeDtoExtensions
{
    extension(CreateProgrammeDto source)
    {
        public AcademicQualification MapPropertyToQualification(
            AcademicQualificationDto property
            )
        {
            return AcademicQualification.Create();
        }
    }
}