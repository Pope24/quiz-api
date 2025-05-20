namespace quiz_api.Entities
{
    public class DetailResult
    {
        public int Id { get; set; }
        public int QuizResultId { get; set; }
        public int QuestionId { get; set; }
        public int SelectedAnswerId { get; set; }
        public bool IsCorrect { get; set; }

        public QuizResult QuizResult { get; set; }
        public Question Question { get; set; }
        public Answer Answer { get; set; }
    }
}
