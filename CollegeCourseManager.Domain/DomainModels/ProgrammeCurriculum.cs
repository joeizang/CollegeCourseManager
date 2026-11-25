using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public static ProgrammeCurriculum Create(Programme programme)
        {
            var curriculum = new ProgrammeCurriculum
            {
                StudyProgram = programme
            };

            return curriculum;
        }
    }
}