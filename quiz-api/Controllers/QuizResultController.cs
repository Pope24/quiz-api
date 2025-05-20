using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using quiz_api.Entities;
using quiz_api.Services;

namespace quiz_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizResultController : ControllerBase
    {
        private readonly IQuizResultService quizResultService;

        public QuizResultController(IQuizResultService quizResultService)
        {
            this.quizResultService = quizResultService;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuizResultsAsync()
        {
            var res = await quizResultService.GetQuizResultsAsync();
            return res.Count() == 0 ? NoContent() : Ok(res);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuizResultByIdAsync(int id)
        {
            var res = await quizResultService.GetQuizResultByIdAsync(id);
            return res == null ? NotFound() : Ok(res);
        }
        [HttpPost("/add")]
        public async Task<IActionResult> AddQuizResultAsync([FromBody] QuizResult quizResult)
        {
            var res = await quizResultService.AddQuizResultAsync(quizResult);
            return res ? Ok() : BadRequest();
        }
    }
}
