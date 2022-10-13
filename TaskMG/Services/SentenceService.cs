using AutoMapper;
using TaskMG.Models.DTOs;
using TaskMG.Repositories;

namespace TaskMG.Services
{
	public class SentenceService : ISentenceService
	{
		private readonly IRepository _repository; 
            
		public SentenceService(IRepository repository)
		{
			_repository = repository;
        }
        public async Task<SentenceDto> ProcessText(string firstSentence)
        {
            SentenceDto sentenceDto = new SentenceDto();
            sentenceDto.InputSentence = firstSentence;
            sentenceDto.OutputSentence = StringReverse(firstSentence);

            var result = await _repository.AddSentence(sentenceDto);
            if (result)
                sentenceDto.IsSaved = true;
            else 
                sentenceDto.IsSaved = false;

            return sentenceDto;
        }
        public string StringReverse(string str)
        {
            if (str.Length > 0)
                return str[str.Length - 1] + StringReverse(str.Substring(0, str.Length - 1));
            else
                return str;
        }

        public IEnumerable<SentenceDto> GetAllSentences()
        {
            return _repository.GetAllSentences();
        }
    }
}
