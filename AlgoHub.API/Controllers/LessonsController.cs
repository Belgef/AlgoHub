using AlgoHub.BLL.DTOs;
using AlgoHub.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AlgoHub.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LessonsController : ControllerBase
    {

        private readonly ILessonService _lessonService;

        public LessonsController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet]
        public IEnumerable<LessonBriefDto> GetTopPopularLessons()
        {
            return _lessonService.GetTopPopularLessons(2);
        }
    }
}