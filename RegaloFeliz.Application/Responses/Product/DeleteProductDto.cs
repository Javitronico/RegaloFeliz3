﻿namespace RegaloFeliz.Domain.DTOs.Responses.Product
{
    public class DeleteProductDto
    {
        public DeleteProductDto(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
    }
}