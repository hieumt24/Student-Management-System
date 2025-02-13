﻿using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.DTOs.Courses.Responses
{
    public class CourseDto
    {
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public int Level { get; set; }
        public int Credits { get; set; }
        public CourseStateType CourseState { get; set; }
        public int? StudentInCourse { get; set; }
        public int MaxStudent { get; set; }

        public string? ImageUrl { get; set; }
    }
}