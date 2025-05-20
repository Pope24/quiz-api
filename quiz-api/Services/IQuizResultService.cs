using quiz_api.Entities;

namespace quiz_api.Services
{
    public interface IQuizResultService
    {
        Task<IEnumerable<QuizResult>> GetQuizResultsAsync();
        Task<QuizResult?> GetQuizResultByIdAsync(int id);
        Task<bool> AddQuizResultAsync(QuizResult quizResult);
    }
}
