﻿using MediatR;
using RegaloFeliz.Application.Responses.Product;

namespace RegaloFeliz.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<CreateProductDto>
    {
        public CreateProductCommand(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
