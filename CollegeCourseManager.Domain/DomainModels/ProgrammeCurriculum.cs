using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeCourseManager.Domain.ResultTypes;

namespace CollegeCourseManager.Domain.DomainModels
{
    public class ProgrammeCurriculum
    {
        private readonly List<Course> _courses = [];
        
        public IReadOnlyList<Course> Courses { get; private init; }

        public List<string> Prerequisites { get; init; }

        public required Programme StudyProgram { get; init; }

        private ProgrammeCurriculum()
        {
            Courses = _courses.AsReadOnly();
            Prerequisites = [];
        }

        public static Result<ProgrammeCurriculum, DomainError> Create(Programme programme)
        {
            if (programme is null)
                return new DomainError(
                    "To create a valid curriculum, you cannot pass an invalid programme",
                    -1);
            var curriculum = new ProgrammeCurriculum
            {
                StudyProgram = programme
            };

            return curriculum;
        }
    }
}