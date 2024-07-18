using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Wrappers;

namespace StudentManagementSystem.Application.Helpers
{
    public class PaginationHelper
    {
        public static PagedResponse<List<T>> CreatePageResponse<T>(List<T> pagedData, PaginationFilter filter, int totalRecords)
        {
            var response = new PagedResponse<List<T>>(pagedData, filter.PageIndex, filter.PageSize);
            var totalPages = ((double)totalRecords / (double)filter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
            response.TotalPages = roundedTotalPages;
            response.TotalRecords = totalRecords;
            return response;
        }
    }
}