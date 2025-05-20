using Microsoft.EntityFrameworkCore;
using quiz_api.Entities;

namespace quiz_api.Repositories.Impl
{
    public class QuizResultRepository : IQuizResultRepository
    {
        private readonly QuizDbContext _dbContext;

        public QuizResultRepository(QuizDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddQuizResultAsync(QuizResult quizResult)
        {
            await _dbContext.QuizResults.AddAsync(quizResult);
            var isAdded = await _dbContext.SaveChangesAsync();
            return isAdded == 1;
        }

        public async Task<QuizResult?> GetQuizResultByIdAsync(int id)
        {
            return await _dbContext.QuizResults
                .Where(qr => qr.Id == id)
                .Include(qr => qr.DetailResults)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<QuizResult>> GetQuizResultsAsync()
        {
            return await _dbContext.QuizResults.ToListAsync();
        }
    }
}
