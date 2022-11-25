using AlgoHub.API.DTOs;
using AlgoHub.API.Helpers;
using AlgoHub.API.Services.Interfaces;
using AlgoHub.API.ViewModels;
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

    private readonly IStorageService _storageService;

    public LessonsController(ILessonService lessonService, IMapper mapper, IStorageService storageService)
    {
        _lessonService = lessonService;
        _mapper = mapper;
        _storageService = storageService;
    }

    [HttpGet]
    public IActionResult GetLessons(int page = 0, int limit = -1)
        => Ok(_lessonService.GetLessons().Select(_mapper.Map<LessonBriefDto>).Paginate(page, limit));

    [HttpGet("Popular")]
    public IActionResult GetPopularLessons()
        => Ok(_lessonService.GetPopularLessons(10).Select(_mapper.Map<LessonBriefDto>));

    [HttpPost]
    public IActionResult AddLesson(LessonCreateViewModel lesson)
    {
        throw new NotImplementedException();
    }
}