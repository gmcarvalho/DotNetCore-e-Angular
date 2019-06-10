using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entity
{
    public class Order : Entity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DateDeliveryForecast { get; set; }
        public string Cep { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Logradouro { get; set; }
        public string Number { get; set; }
        public int PaymentFormId { get; set; }
        public PaymentForm PaymentForm { get; set; }
        public ICollection<OrderItem> ItemsOrder { get; set; }

        public override void Validate()
        {
            ClearMessageValidation();

            if (!ItemsOrder.Any()) 
                AddMessage("Item de pedido não pode estar vazio.");
            if(string.IsNullOrEmpty(Cep))
                AddMessage("Cep deve estar preenchido.");
        }
    }
}
