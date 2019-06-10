using QuickBuy.Domain.Enumarator;

namespace QuickBuy.Domain.ValueObject
{
    public class PaymentForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsTicket {
            get {
                return Id == (int) TypePaymentFormEnum.Ticket;
            }
        }

        public bool IsCreditCard
        {
            get
            {
                return Id == (int)TypePaymentFormEnum.CreditCard;
            }
        }

        public bool IsDeposit
        {
            get
            {
                return Id == (int)TypePaymentFormEnum.Deposit;
            }
        }

        public bool IsNotDefined
        {
            get
            {
                return Id == (int)TypePaymentFormEnum.NotDefined;
            }
        }
    }
}
