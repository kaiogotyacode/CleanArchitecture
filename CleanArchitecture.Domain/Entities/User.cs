namespace CleanArchitecture.Domain.Entities
{
    public sealed class User : BaseEntity
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
    }
}
