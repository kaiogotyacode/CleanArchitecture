using MediatR;

namespace CleanArchitecture.Application.UseCases.GetAllUser;

public sealed record GetAllUserRequest : IRequest<IEnumerable<GetAllUserResponse>>   
{
    // no request
}
