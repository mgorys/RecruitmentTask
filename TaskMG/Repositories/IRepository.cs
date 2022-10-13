using TaskMG.Models.DTOs;

namespace TaskMG.Repositories
{
	public interface IRepository
	{
        Task<bool> AddSentence(SentenceDto dto);
        IEnumerable<SentenceDto> GetAllSentences();

    }
}
