using MediatR;

namespace CleanArchitecture.Application.UseCases.UpdateUser
{
    public sealed record UpdateUserRequest(Guid Id, string Nome, string Email) : IRequest<UpdateUserResponse>;
}
