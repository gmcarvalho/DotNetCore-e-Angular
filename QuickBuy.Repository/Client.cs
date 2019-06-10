using QuickBuy.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class Client
    {
        public Client() {
            var userRepository = new UserRepository();
            userRepository.Adicionar(new User());
        }
    }
}
