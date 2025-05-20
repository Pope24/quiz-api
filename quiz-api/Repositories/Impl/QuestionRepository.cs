using Microsoft.EntityFrameworkCore;
using quiz_api.Entities;

namespace quiz_api.Repositories.Impl
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly QuizDbContext _dbContext;

        public QuestionRepository(QuizDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Question>> GetQuestionsAsync()
        {
            return await _dbContext.Questions.Include(q => q.Answers).ToListAsync();
        }
    }
}
