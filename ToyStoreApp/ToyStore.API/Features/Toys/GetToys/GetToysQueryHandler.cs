using MediatR;

namespace ToyStore.API.Features.Toys.GetToys;

public class GetToysQueryHandler : IRequestHandler<GetToysQuery, List<Toy>>
{
    private static readonly List<Toy> _toys = new();

    public async Task<List<Toy>> Handle(GetToysQuery request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(_toys);
    }
}
