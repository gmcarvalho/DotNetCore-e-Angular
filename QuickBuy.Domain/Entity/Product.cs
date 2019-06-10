namespace QuickBuy.Domain.Entity
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
        public int Price { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
