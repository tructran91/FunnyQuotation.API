namespace FunnyQuotation.Domain.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public bool IsFavorite { get; set; }

        //public IList<Favorite> Favorites { get; set; } = new List<Favorite>();
    }
}
