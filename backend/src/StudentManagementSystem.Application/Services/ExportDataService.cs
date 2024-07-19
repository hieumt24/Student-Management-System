using ClosedXML.Excel;
using StudentManagementSystem.Application.Interface.Services;

namespace StudentManagementSystem.Application.Services
{
    public class ExportDataService : IEportDataService
    {
        private readonly IEnrollmentService _enrollmentService;

        public ExportDataService(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        public async Task<byte[]> ExportGradeStudentToExcelAsync(Guid studentId)
        {
            var dataResponse = await _enrollmentService.GetReportGradeOfStudent(studentId);
            var data = dataResponse.Data;
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Report Grade Of Student");

                //add hearders
                var headers = new[] { "Student Name", "Student Code ", "Course Code", "Semester Code", "Grade", "Is Passed" };
                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet.Cell(1, i + 1).Value = headers[i];
                    worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                    worksheet.Cell(1, i + 1).Style.Font.FontColor = XLColor.White;
                    worksheet.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.RoyalBlue;
                    worksheet.Cell(1, i + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    worksheet.Cell(1, i + 1).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                }
                //add Data
                int row = 2;
                foreach (var item in data)
                {
                    worksheet.Cell(row, 1).Value = item.StudentName;
                    worksheet.Cell(row, 2).Value = item.StudentCode;
                    worksheet.Cell(row, 3).Value = item.CourseCode;
                    worksheet.Cell(row, 4).Value = item.SemesterCode;
                    worksheet.Cell(row, 5).Value = item.Grade;
                    worksheet.Cell(row, 6).Value = (XLCellValue)item.IsPassed;

                    for (int col = 1; col <= 6; col++)
                    {
                        worksheet.Cell(row, col).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet.Cell(row, col).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        worksheet.Cell(row, col).Style.Fill.BackgroundColor = (row % 2 == 0) ? XLColor.LightGray : XLColor.White;
                    }
                    row++;
                }

                worksheet.Columns().AdjustToContents();

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
        }
    }
}