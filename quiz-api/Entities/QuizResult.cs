namespace quiz_api.Entities
{
    public class QuizResult
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CorrectCount { get; set; }
        public bool IsPassed { get; set; }
        public ICollection<DetailResult> DetailResults { get; set; }
    }
}
