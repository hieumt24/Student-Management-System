﻿using StudentManagementSystem.Domain.Common;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.DTOs.Enrollments.Responses
{
    public class EnrollmentDto : BaseEntity
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }

        public Guid SemesterId { get; set; }

        public double? Grade { get; set; }

        public bool? IsPassed { get; set; }

        public EnrolmentStateType State { get; set; }
        public LocationType Location { get; set; }
    }
}