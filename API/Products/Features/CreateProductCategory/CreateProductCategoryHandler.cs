using System;
using MediatR;

namespace Products.Features.CreateProductCategory;

internal class CreateProductCategoryHandler : IRequestHandler<CreateProductCategoryRequest, CreateProductCategoryResponse>
{
    public Task<CreateProductCategoryResponse> Handle(CreateProductCategoryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
