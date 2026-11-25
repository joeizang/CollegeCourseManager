using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeCourseManager.Domain.Dtos;
using CollegeCourseManager.Domain.ValueObjects;

namespace CollegeCourseManager.Domain.DomainModels
{
    public sealed class Lecturer
    {
        private readonly List<Course> _courses = [];
        public required string Title { get; init; }

        public required string ID { get; init; }

        public required StaffName Name { get; init; }

        public IReadOnlyList<Course> CoursesTaught { get; private init; }

        public Lecturer()
        {
            CoursesTaught = _courses.AsReadOnly();
        }

        public static Lecturer Create(CreateLecturerDto dto)
        {
            Lecturer lecturer = new()
            {
                Title = dto.Title,
                Name = dto.Name,
                ID = dto.StaffID
            };

            return lecturer;
        }
        
    }
}