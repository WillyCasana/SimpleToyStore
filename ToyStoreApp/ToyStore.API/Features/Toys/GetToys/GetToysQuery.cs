using MediatR;

namespace ToyStore.API.Features.Toys.GetToys;

public class GetToysQuery : IRequest<List<Toy>>
{

}
