using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeCourseManager.Domain.ResultTypes;
using CollegeCourseManager.Domain.ValueObjects;

namespace CollegeCourseManager.Domain.DomainModels
{
    public class Programme
    {
        private readonly List<Student> _students = [];

        public required string ProgrammeTitle { get; init; }

        public required AcademicQualification AwardingQualification { get; init; }

        public required StudyMode ProgrammeStudyMode { get; init; }

        public required ProgrammeTenure ProgrammeTenure { get; init; }

        public IReadOnlyList<Student> Students { get; private init; }

        public ProgrammeCurriculum Curriculum { get; init; }

        private Programme()
        {
            Students = _students.AsReadOnly();
        }

        public static Result<Programme, DomainError> Create(CreateProgrammeDto dto)
        {
            if (dto is null)
                return new DomainError("Programme cannot be created with null",
                    -1);
            if (dto.Qualification is null || dto.Tenure is null || string.IsNullOrEmpty(dto.Title))
                return new DomainError("One or more values are invalid!");
            var prog = new Programme()
            {
                ProgrammeTitle = dto.Title,
                ProgrammeStudyMode = dto.StudyMode,
                ProgrammeTenure = dto.Tenure,
                AwardingQualification = dto.QualificationDto
            };
        }
    }
}