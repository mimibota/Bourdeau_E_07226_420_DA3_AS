namespace Bourdeau_E_07226_420_DA3_AS.Models
{
    internal class Product:IModels<Product>
    {
        //properties
        private int Id;
        private int GtinCode;
        private int QtyInStock;
        private string Name;
        private string Description;
        
        
        //constructors

        public Product(int id, int gtincode, int qty, string name, string desc)
        {
            Id = id;
            GtinCode = gtincode;
            QtyInStock = qty;
            Name = name;
            Description = desc;
        }
        
        
        private IModels<Product> _modelsImplementation;
        public Product GetById()
        {
            return _modelsImplementation.GetById();
        }

        public Product Insert()
        {
            return _modelsImplementation.Insert();
        }

        public Product Update()
        {
            return _modelsImplementation.Update();
        }

        public void Delete()
        {
            _modelsImplementation.Delete();
        }
    }
}