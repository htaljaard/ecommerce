using System;
using MediatR;
using Microsoft.Extensions.Logging;
using Products.Entities;
using Products.Errors;
using SharedKernel.Entities;
using SharedKernel.Repositories;

namespace Products.Features.CreateProductCategory;

internal class CreateProductCategoryHandler : IRequestHandler<CreateProductCategoryRequest, Result<CreateProductCategoryResponse>>
{
    private readonly IGenericRepository<ProductCategory> _repository;
    private readonly ILogger<CreateProductCategoryHandler> _logger;

    public CreateProductCategoryHandler(IGenericRepository<ProductCategory> repository, ILogger<CreateProductCategoryHandler> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<Result<CreateProductCategoryResponse>> Handle(CreateProductCategoryRequest request, CancellationToken cancellationToken)
    {
        var productCategory = new ProductCategory(request.Name, request.Description ?? string.Empty);

        _logger.LogInformation("Creating product category {productCategory}", productCategory);
        _logger.LogInformation("Checking if product category is unique {productCategory}", productCategory);
        if (!productCategory.IsUnique(_repository))
        {
            _logger.LogError("Product category {productCategory} already exists", productCategory);
            return Result<CreateProductCategoryResponse>.Failure(ProductCategoryErrors.ProductCategoryAlreadyExists(request.Name));
        }

        _logger.LogInformation("Adding product category {productCategory}", productCategory);
        var result = await _repository.AddAsync(productCategory);

        if (!result.IsSuccess)
        {
            _logger.LogError("Error adding product category {productCategory}: {message}", productCategory, result.Error!.Message);
            return Result<CreateProductCategoryResponse>.Failure(result.Error!);
        }

        _logger.LogInformation("Product category {productCategory} created", productCategory);
        return Result<CreateProductCategoryResponse>.Success(new CreateProductCategoryResponse(result.Value!.Id.Value));



    }
}