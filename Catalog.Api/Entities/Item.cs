using System;

namespace Catalog.Api.Entities
{
    public record Item
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}