using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Domain.Enums;
using StudentManagementSystem.Infrastructure.Common;
using StudentManagementSystem.Infrastructure.DataAccess;
using System.Linq.Expressions;

namespace StudentManagementSystem.Infrastructure.Repositories
{
    public class EnrollmentRepository : GenericRepository<Enrollment>, IEnrollmentRepository
    {
        public EnrollmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> CheckStudentPassCourse(Guid enrollmentId, double grade)
        {
            var enrollment = await _dbContext.Enrollments.FirstOrDefaultAsync(x => x.Id == enrollmentId && !x.IsDeleted);
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

        public async Task<bool> CheckUserExsitingInEnrollment(Guid courseId, Guid studentId)
        {
            var checkUser = await _dbContext.Enrollments.FirstOrDefaultAsync(x => x.CourseId == courseId && x.StudentId == studentId && !x.IsDeleted);
            if (checkUser != null)
            {
                return true;
            }
            return false;
        }

        public async Task<int> CountStudentInCourse(Guid courseId)
        {
            var result = await _dbContext.Enrollments.CountAsync(x => x.CourseId == courseId && !x.IsDeleted);
            result = result + 1;
            return result;
        }

        public async Task<(IEnumerable<Enrollment> Data, int TotalRecords)> GetAllEnrollmentOfStudent(PaginationFilter? pagination, Guid studentId, CourseLevelType? level, EnrolmentStateType? enrolmentStateType, bool? isPassed, string? search, string? orderBy, bool? isDescending)
        {
            var enrollment = _dbContext.Enrollments.Include(x => x.Course).Include(x => x.Student).Include(x => x.Semester);

            var query = enrollment.AsNoTracking().Where(x => x.StudentId == studentId && !x.IsDeleted);

            if (level.HasValue)
            {
                query = query.Where(x => x.Course.Level == level);
            }

            if (enrolmentStateType.HasValue)
            {
                query = query.Where(x => x.State == enrolmentStateType);
            }
            if (isPassed.HasValue)
            {
                query = query.Where(x => x.IsPassed == isPassed);
            }
            var searchPhraseLower = search?.ToLower() ?? string.Empty;

            if (!string.IsNullOrWhiteSpace(searchPhraseLower))
            {
                query = query.Where(x => x.Course.Title.ToLower().Contains(searchPhraseLower)
                               || x.Course.CourseCode.ToLower().Contains(searchPhraseLower)
                               || x.Semester.SemesterCode.ToLower().Contains(searchPhraseLower));
            }

            var totalRecords = await query.CountAsync();

            if (!string.IsNullOrWhiteSpace(orderBy))
            {
                var columnsSelector = new Dictionary<string, Expression<Func<Enrollment, object>>>
                {
                    {"courseCode", x => x.Course.CourseCode },
                    {"courseTitle", x => x.Course.Title },
                    {"semesterCode", x => x.Semester.SemesterCode },
                    {"state", x => x.State },
                    {"isPassed", x => x.IsPassed }
                };
                var selectedColumn = columnsSelector[orderBy];

                query = isDescending.HasValue && isDescending.Value
                    ? query.OrderByDescending(selectedColumn)
                    : query.OrderBy(selectedColumn);
            }
            var enrollments = await query
                .Skip((pagination.PageIndex - 1) * pagination.PageSize)
                .Take(pagination.PageSize)
                .ToListAsync();

            return (Data: enrollments, TotalRecords: totalRecords);
        }

        public async Task<(IEnumerable<Enrollment> Data, int TotalRecords)> GetAllEnrollments(PaginationFilter? pagination, CourseLevelType? level, EnrolmentStateType? enrolmentStateType, bool? isPassed, string? search, string? orderBy, bool? isDescending)
        {
            var enrollment = _dbContext.Enrollments.Include(x => x.Course).Include(x => x.Student).Include(x => x.Semester);

            var query = enrollment.AsNoTracking().Where(x => !x.IsDeleted);

            if (level.HasValue)
            {
                query = query.Where(x => x.Course.Level == level);
            }

            if (enrolmentStateType.HasValue)
            {
                query = query.Where(x => x.State == enrolmentStateType);
            }
            if (isPassed.HasValue)
            {
                query = query.Where(x => x.IsPassed == isPassed);
            }
            var searchPhraseLower = search?.ToLower() ?? string.Empty;

            if (!string.IsNullOrWhiteSpace(searchPhraseLower))
            {
                query = query.Where(x => x.Course.Title.ToLower().Contains(searchPhraseLower)
                               || x.Course.CourseCode.ToLower().Contains(searchPhraseLower)
                               || x.Semester.SemesterCode.ToLower().Contains(searchPhraseLower));
            }

            var totalRecords = await query.CountAsync();

            if (!string.IsNullOrWhiteSpace(orderBy))
            {
                var columnsSelector = new Dictionary<string, Expression<Func<Enrollment, object>>>
                {
                    {"courseCode", x => x.Course.CourseCode },
                    {"courseTitle", x => x.Course.Title },
                    {"semesterCode", x => x.Semester.SemesterCode },
                    {"state", x => x.State },
                    {"isPassed", x => x.IsPassed }
                };
                var selectedColumn = columnsSelector[orderBy];

                query = isDescending.HasValue && isDescending.Value
                    ? query.OrderByDescending(selectedColumn)
                    : query.OrderBy(selectedColumn);
            }
            var enrollments = await query
                .Skip((pagination.PageIndex - 1) * pagination.PageSize)
                .Take(pagination.PageSize)
                .ToListAsync();

            return (Data: enrollments, TotalRecords: totalRecords);
        }

        public async Task<List<Enrollment>> GetCourseById(Guid courseId)
        {
            var enrollment = await _dbContext.Enrollments.Where(x => x.CourseId == courseId && !x.IsDeleted).ToListAsync();
            if (enrollment is null)
            {
                return null;
            }
            return enrollment;
        }

        public async Task<List<Enrollment>> GetReportStudentInEnrollment(Guid studentId)
        {
            return await _dbContext.Enrollments.Include(x => x.Course).Include(x => x.Semester).Include(x => x.Student).Where(x => x.StudentId == studentId && !x.IsDeleted).ToListAsync();
        }

        public async Task<Enrollment> GetStudentInEnrollment(Guid studentId)
        {
            return await _dbContext.Enrollments.Where(x => x.StudentId == studentId && !x.IsDeleted).FirstOrDefaultAsync();
        }
    }
}