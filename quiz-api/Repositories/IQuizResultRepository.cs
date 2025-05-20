using quiz_api.Entities;

namespace quiz_api.Repositories
{
    public interface IQuizResultRepository
    {
        Task<IEnumerable<QuizResult>> GetQuizResultsAsync();
        Task<QuizResult?> GetQuizResultByIdAsync(int id);
        Task<bool> AddQuizResultAsync(QuizResult quizResult);
    }
}
