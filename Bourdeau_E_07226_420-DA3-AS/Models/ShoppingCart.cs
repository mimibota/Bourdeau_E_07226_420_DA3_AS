namespace Bourdeau_E_07226_420_DA3_AS.Models
{
    internal class ShoppingCart:IModels<ShoppingCart>
    {
        //properties
        private int Id;
        private int CustomerId;
        private string BillingAddress;
        private string ShippingAddress;
        private string DateCreated;
        private string DateUpdated;
        private string DateDeleted;
        private string DateOrdered;
        private string DateShipped;

        
        //constructors

        public ShoppingCart(int id, int customerId, string billAddress, string shipAddress, string created,
            string updated,
            string deleted, string ordered, string shipped)
        {
            Id = id;
            BillingAddress = billAddress;
            ShippingAddress = shipAddress;
            DateCreated = created;
            DateUpdated = updated;
            DateDeleted = deleted;
            DateOrdered = ordered;
            DateShipped = shipped;

        }

        private IModels<ShoppingCart> _modelsImplementation;

        public ShoppingCart GetById()
        {
            return _modelsImplementation.GetById();
        }

        public ShoppingCart Insert()
        {
            return _modelsImplementation.Insert();
            
        }

        public ShoppingCart Update()
        {
            return _modelsImplementation.Update();
            
        }

        public void Delete()
        {
            _modelsImplementation.Delete();
        }

    }
}