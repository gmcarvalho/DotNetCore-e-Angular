using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Contract
{
    public interface IBaseRepository<TEnytity> : IDisposable where TEnytity : class
    {
        void Adicionar(TEnytity entity);
        void GetById(int id);
        IEnumerable<TEnytity> GetAll();
        void Update(TEnytity enytity);
        void Delete(TEnytity enytity);
    }
}
