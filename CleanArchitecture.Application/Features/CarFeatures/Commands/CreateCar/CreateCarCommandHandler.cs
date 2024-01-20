using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;

public sealed class CreateCarCommandHandler : IRequestHandler<CreateCarCommand
    , MessageResponse>
{

    //bu method aldigimiz deyerler ile beraber bize responsu geri dondure bilir!
    public async Task<MessageResponse> Handle(CreateCarCommand request,
        CancellationToken cancellationToken)
    {
        return new("Car is created");
    }




}
