using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;

namespace CleanArchitecture.Application.Features.Services;

public interface ICarService
{

    Task CreateAsync(CreateCarCommand request, CancellationToken cancellationToken);


}
