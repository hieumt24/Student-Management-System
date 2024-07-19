using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Infrastructure.Common;
using StudentManagementSystem.Infrastructure.DataAccess;

namespace StudentManagementSystem.Infrastructure.Repositories
{
    public class EnrollmentRepository : GenericRepository<Enrollment>, IEnrollmentRepository
    {
        public EnrollmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> CheckStudentPassCourse(Guid enrollmentId, double grade)
        {
            var enrollment = await _dbContext.Enrollments.FirstOrDefaultAsync(x => x.Id == enrollmentId);
            if (grade < 5)
            {
                enrollment.IsPassed = false;
                enrollment.State = Domain.Enums.EnrolmentStateType.Failed;
                _dbContext.Enrollments.Update(enrollment);
                await _dbContext.SaveChangesAsync();
                return false;
            }
            enrollment.IsPassed = true;
            enrollment.State = Domain.Enums.EnrolmentStateType.Passed;
            _dbContext.Enrollments.Update(enrollment);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Enrollment>> GetCourseById(Guid courseId)
        {
            var enrollment = await _dbContext.Enrollments.Where(x => x.CourseId == courseId).ToListAsync();
            if (enrollment is null)
            {
                return null;
            }
            return enrollment;
        }
    }
}