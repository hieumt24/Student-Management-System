using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Application.DTOs.Images;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Application.Models;

namespace StudentManagementSystem.WebApi.Controllers
{
    [Route("api/v1/images")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class ImagesController : ControllerBase
    {
        private readonly ILocalImageRepository _localImageRepository;

        public ImagesController(ILocalImageRepository localImageRepository)
        {
            _localImageRepository = localImageRepository;
        }

        [HttpPost]
        [Route("upload")]
        public async Task<IActionResult> UploadImageAsync([FromForm] ImageUploadRequestDto request)
        {
            ValidateFileUpload(request);

            if (ModelState.IsValid)
            {
                //Covert DTO to Domain Model

                var imageDomainModel = new Image
                {
                    File = request.File,
                    FileExtension = Path.GetExtension(request.File.FileName),
                    FileSizeInBytes = request.File.Length,
                    FileName = request.FileName,
                    FileDescription = request.FileDescription
                };

                //User repository to upload image
                await _localImageRepository.Upload(imageDomainModel);

                return Ok(imageDomainModel);
            }
            return BadRequest(ModelState);
        }

        private void ValidateFileUpload(ImageUploadRequestDto request)
        {
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };
            if (!allowedExtensions.Contains(Path.GetExtension(request.File.FileName)))
            {
                ModelState.AddModelError("file", "Unsupported file extension");
            }

            if (request.File.Length > 10485760)
            {
                ModelState.AddModelError("file", "File size more than 10MB, please upload a smaller size file.");
            }
        }
    }
}