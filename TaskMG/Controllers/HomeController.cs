using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskMG.Data;
using TaskMG.Models;
using TaskMG.Models.DTOs;
using TaskMG.Services;
using TaskMG.Validators;

namespace TaskMG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISentenceService _sentenceService;
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly ProcessTextValidator _processValidator;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db
            , ISentenceService sentenceService, ProcessTextValidator processValidator)
        {
            _sentenceService = sentenceService;
            _logger = logger;
            _db = db;
            _processValidator = processValidator;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ProcessText(SentenceDto sentence)
        {
            var result = new SentenceDto();
            var validationResult = await _processValidator.ValidateAsync(sentence);
            if (validationResult.IsValid)
            {
                result = await _sentenceService.ProcessText(sentence.InputSentence);
            }
            else
            {
                result.ErrorMessage = validationResult.Errors.First().ErrorMessage;
            }
            return View("Index",result); 
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}