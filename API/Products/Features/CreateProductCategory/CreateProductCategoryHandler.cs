using System;
using MediatR;

namespace Products.Features.CreateProductCategory;

public record CreateProductCategoryRequest(string Name) : IRequest<CreateProductCategoryResponse>;

public record CreateProductCategoryResponse(Guid Id);

internal class CreateProductCategoryHandler : IRequestHandler<CreateProductCategoryRequest, CreateProductCategoryResponse>
{
    public Task<CreateProductCategoryResponse> Handle(CreateProductCategoryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
