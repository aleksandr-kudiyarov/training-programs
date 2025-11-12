using Kudiyarov.TrainingPrograms.Bll.Interfaces;
using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Requests;
using Kudiyarov.TrainingPrograms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kudiyarov.TrainingPrograms.Web.Controllers;

public class HomeController : Controller
{
    private readonly ITrainingProgramLogic _logic;

    public HomeController(ITrainingProgramLogic logic)
    {
        _logic = logic;
    }

    public IActionResult Index()
    {
        var result = _logic.Get();
        return View(result);
    }

    public IActionResult Program(ProgramType type)
    {
        var result = _logic.Get(type);
        return View(result);
    }

    public IActionResult Session(ApiSessionRequest apiRequest)
    {
        var request = new SessionRequest
        {
            ProgramType = apiRequest.ProgramType,
            Day = apiRequest.Day,
            Stats = new Stats()
        };
        
        var result = _logic.Get(request);
        return View(result);
    }
}