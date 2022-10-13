using TaskMG.Models.DTOs;

namespace TaskMG.Services
{
	public interface ISentenceService
	{
        Task<SentenceDto> ProcessText(string firstSentence);
        string StringReverse(string str);
        IEnumerable<SentenceDto> GetAllSentences();

    }
}