using Azure.Core;
using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.Products.Commands.UpdateProduct;

public static class UpdateProductCommandExtension
{
    public static Product UpdateProduct(this UpdateProductCommand command)
    {
        var product = new Product { Id = command.Id, Name = command.Name };

        return product;
    }
}
