namespace FunnyQuotation.Domain.Entities
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }
    }
}
