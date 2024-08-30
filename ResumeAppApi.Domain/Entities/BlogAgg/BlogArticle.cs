namespace ResumeAppApi.Domain.Entities.BlogAgg
{
    public class BlogArticle
    {
        public int ArticleId { get; set; }
        public string Title { get; set; } = default!;
        public string Body { get; set; } = default!;
		public int CategoryId { get; set; }
        public BlogArticleCategory BlogArticleCategory { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public DateTime LastUpdateTime { get; set; } = DateTime.Now;
        public string Picture { get; set; }
        public string PircutrAlt { get; set; }


    }
}
