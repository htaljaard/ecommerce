using MediatR;

namespace Products.Features.CreateProductCategory;

public record CreateProductCategoryRequest(string Name) : IRequest<CreateProductCategoryResponse>;
