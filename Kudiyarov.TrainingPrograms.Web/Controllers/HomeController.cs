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

    public IActionResult Session(ApiSessionRequest apiRequest, double snatch = 82.5)
    {
        var request = new SessionRequest
        {
            ProgramType = apiRequest.ProgramType,
            Day = apiRequest.Day,
            Stats = new Stats(snatch)
        };

        var session = _logic.Get(request);
        var program = _logic.Get(request.ProgramType);

        var viewModel = new SessionViewModel
        {
            Session = session,
            ProgramName = program.Name,
            ProgramType = apiRequest.ProgramType,
            PaginationInfo = new PaginationInfo
            {
                CurrentPage = session.Day,
                TotalPages = program.Days
            },
            RouteFactory = day => apiRequest with { Day = day }
        };

        return View(viewModel);
    }
}