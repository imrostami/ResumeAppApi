namespace ResumeAppApi.Domain.Entities.PortfolioAgg
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; } = default!;
        public int Value { get; set; } = default!;
    }
}
