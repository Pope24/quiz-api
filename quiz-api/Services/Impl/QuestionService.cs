using quiz_api.Entities;

namespace quiz_api.Services.Impl
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionService questionService;

        public QuestionService(IQuestionService questionService)
        {
            this.questionService = questionService;
        }

        public async Task<IEnumerable<Question>> GetQuestionsAsync()
        {
            return await questionService.GetQuestionsAsync();
        }
    }
}
