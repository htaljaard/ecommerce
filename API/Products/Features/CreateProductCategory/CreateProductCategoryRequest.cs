using MediatR;
using SharedKernel.Entities;

namespace Products.Features.CreateProductCategory;

public record CreateProductCategoryRequest(string Name, string? Description) : IRequest<Result<CreateProductCategoryResponse>>;
