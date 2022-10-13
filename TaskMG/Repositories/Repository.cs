using AutoMapper;
using TaskMG.Data;
using TaskMG.Models;
using TaskMG.Models.DTOs;

namespace TaskMG.Repositories
{
	public class Repository : IRepository
	{
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;


        public Repository(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
		}
        public async Task<bool> AddSentence(SentenceDto dto)
        {
            try
            {
                var sentences = _mapper.Map<Sentence>(dto);
                await _dbContext.Sentences.AddAsync(sentences);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<SentenceDto> GetAllSentences()
        {
            try
            {
                var sentences = _dbContext.Sentences;
                var mappedSentences = _mapper.Map<IEnumerable<SentenceDto>>(sentences);
                return mappedSentences;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        //public async Task<SentenceDto>AddSentences(string firstSentence, string secondSentence)
        //{
        //    _db.Sentences.Add(obj);
        //    _db.SaveChanges();

        //}

    }
}
