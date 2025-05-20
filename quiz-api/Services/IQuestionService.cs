using quiz_api.Entities;

namespace quiz_api.Services
{
    public interface IQuestionService
    {
        Task<IEnumerable<Question>> GetQuestionsAsync();
    }
}
