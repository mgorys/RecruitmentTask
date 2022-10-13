using Microsoft.AspNetCore.Mvc;
using TaskMG.Data;
using TaskMG.Models;
using TaskMG.Models.DTOs;
using TaskMG.Services;

namespace TaskMG.Controllers
{
    public class SentenceController : Controller
    {
        private readonly ISentenceService _sentenceService; 
        public SentenceController(ISentenceService sentenceService)
        {
            _sentenceService = sentenceService;
        }
        public IActionResult Index()
        {
            IEnumerable<SentenceDto> objSentenceList = _sentenceService.GetAllSentences();
            return View(objSentenceList);
        }
       
        
    }
}
