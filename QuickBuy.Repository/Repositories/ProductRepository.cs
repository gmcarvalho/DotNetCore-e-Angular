using QuickBuy.Domain.Contract;
using QuickBuy.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
    }
}