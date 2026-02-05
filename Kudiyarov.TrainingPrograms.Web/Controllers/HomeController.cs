using Kudiyarov.TrainingPrograms.Bll.Interfaces;
using Kudiyarov.TrainingPrograms.Entities;
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

    public IActionResult Program(ProgramRequest request)
    {
        var result = _logic.GetProgram(request);
        return View(result);
    }

    public IActionResult Session(ApiSessionRequest apiRequest)
    {
        var request = new SessionRequest
        {
            ProgramName = apiRequest.ProgramName,
            Day = apiRequest.Day,
            Stats = new Stats(apiRequest.Snatch)
        };

        var session = _logic.GetSession(request);
        var program = _logic.GetProgram(request);

        var viewModel = new SessionViewModel
        {
            Session = session,
            Program = program,
            PaginationInfo = new PaginationInfo
            {
                CurrentPage = session.Day,
                TotalPages = program.Days
            },
            PaginationRoute = new PaginationRoute
            {
                Action = "Session",
                Controller = "Home",
                ValuesFactory = day => apiRequest with { Day = day }
            }
        };

        return View(viewModel);
    }
}