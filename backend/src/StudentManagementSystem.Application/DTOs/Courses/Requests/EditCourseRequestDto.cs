using StudentManagementSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Application.DTOs.Courses.Requests
{
    public class EditCourseRequestDto
    {
        public string CourseCode { get; set; }
        public string Title { get; set; }

        public int Credits { get; set; }

        public CourseLevelType Level { get; set; }
        public int MaxStudent { get; set; }

        public CourseStateType CourseState { get; set; }

        public string? ImageUrl { get; set; }
    }
}