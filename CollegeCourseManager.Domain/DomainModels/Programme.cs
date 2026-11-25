using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public Programme()
        {
            Students = _students.AsReadOnly();
        }
    }
}