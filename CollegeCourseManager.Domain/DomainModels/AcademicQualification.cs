using CollegeCourseManager.Domain.ValueObjects;

namespace CollegeCourseManager.Domain.DomainModels
{
    public sealed class AcademicQualification
    {
        public required string Name { get; init; }

        public required GraduateType GraduateType { get; init; }

        public required string TitleOnConclusion { get; init; }
    }
}