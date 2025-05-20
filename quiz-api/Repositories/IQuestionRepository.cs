using quiz_api.Entities;

namespace quiz_api.Repositories
{
    public interface IQuestionRepository
    {
        Task<IEnumerable<Question>> GetQuestionsAsync();
    }
}
