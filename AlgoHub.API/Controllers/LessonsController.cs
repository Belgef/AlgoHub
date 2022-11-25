using AlgoHub.API.DTOs;
using AlgoHub.API.Helpers;
using AlgoHub.BLL.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AlgoHub.API.Controllers;

[ApiController]
[Route("[controller]")]
public class LessonsController : ControllerBase
{
    private readonly ILessonService _lessonService;

    private readonly IMapper _mapper;

    public LessonsController(ILessonService lessonService, IMapper mapper)
    {
        _lessonService = lessonService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetLessons(int page = 0, int limit = -1)
        => Ok(_lessonService.GetLessons().Select(_mapper.Map<LessonBriefDto>).Paginate(page, limit));

    [HttpGet("Popular")]
    public IActionResult GetPopularLessons()
        => Ok(_lessonService.GetPopularLessons(10).Select(_mapper.Map<LessonBriefDto>));
}