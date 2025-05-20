using Microsoft.EntityFrameworkCore;

namespace quiz_api.Entities
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options)
            : base(options) { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<QuizResult> QuizResults { get; set; }
        public DbSet<DetailResult> DetailResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Question)
                .WithMany(q => q.Answers)
                .HasForeignKey(a => a.QuestionId);

            modelBuilder.Entity<DetailResult>()
                .HasOne(qr => qr.QuizResult)
                .WithMany(q => q.DetailResults)
                .HasForeignKey(qr => qr.QuizResultId);
        }
    }
}