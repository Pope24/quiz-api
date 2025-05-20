using quiz_api.Entities;
using quiz_api.Repositories;

namespace quiz_api.Services.Impl
{
    public class QuizResultService : IQuizResultService
    {
        private IQuizResultRepository quizResultRepository;

        public QuizResultService(IQuizResultRepository quizResultRepository)
        {
            this.quizResultRepository = quizResultRepository;
        }

        public Task<bool> AddQuizResultAsync(QuizResult quizResult)
        {
            throw new NotImplementedException();
        }

        public async Task<QuizResult?> GetQuizResultByIdAsync(int id)
        {
            return await quizResultRepository.GetQuizResultByIdAsync(id);
        }

        public async Task<IEnumerable<QuizResult>> GetQuizResultsAsync()
        {
            return await quizResultRepository.GetQuizResultsAsync();
        }
    }
}
