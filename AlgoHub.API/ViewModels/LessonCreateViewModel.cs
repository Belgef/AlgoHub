using AlgoHub.DAL.Entities;

namespace AlgoHub.API.ViewModels
{
    public class LessonCreateViewModel
    {
        public string Title { get; set; } = null!;

        public string? Content { get; set; }

        public int? AuthorId { get; set; }

        public IFormFile? FrontImage { get; set; }

        public IEnumerable<IFormFile> Images { get; set; } = null!;

        public IEnumerable<int>? TagIds { get; set; }
    }
}
