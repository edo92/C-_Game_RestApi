using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.Api.Entities;

namespace Catalog.Api.Repositories
{
    public interface IItemsRepository
    {
        Task<Item> GetItemsAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreateItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Task DeleteItemAsync(Guid id);
    }
}