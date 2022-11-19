using Domain.Common;

namespace Domain.Entities
{
    public class Book : BaseEntity
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public int AuthorId { get; set; }
        public Author? Author { get; set; }

    }
}
