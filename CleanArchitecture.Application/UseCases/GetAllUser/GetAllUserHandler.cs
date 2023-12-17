using AutoMapper;
using CleanArchitecture.Domain.Interfaces;
using MediatR;

namespace CleanArchitecture.Application.UseCases.GetAllUser;

public sealed class GetAllUserHandler : IRequestHandler<GetAllUserRequest, IEnumerable<GetAllUserResponse>> {

    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetAllUserHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetAllUserResponse>> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
    {
       var response = await _userRepository.GetAll(cancellationToken);

        return _mapper.Map<List<GetAllUserResponse>>(response);   
    }
}
