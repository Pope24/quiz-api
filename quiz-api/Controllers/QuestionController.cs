using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using quiz_api.Services;

namespace quiz_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private IQuestionService questionService;

        public QuestionController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }
        [HttpGet]
        public async Task<IActionResult> GetQuestionsAsync()
        {
            var res = await questionService.GetQuestionsAsync();
            return res.Count() == 0 ? NoContent() : Ok(res);
        }
    }
}
