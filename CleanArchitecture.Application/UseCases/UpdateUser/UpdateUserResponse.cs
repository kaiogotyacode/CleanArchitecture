namespace CleanArchitecture.Application.UseCases.UpdateUser;

public sealed class UpdateUserResponse
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
}
