namespace Bourdeau_E_07226_420_DA3_AS.Models
{
    internal class Product : IModels<Product>
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

        //getters and setters
        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public int getGtintCode()
        {
            return GtinCode;
        }

        public void setGtinCode(int gtincode)
        {
            GtinCode = gtincode;
        }


        public int getQtyInStock()
        {
            return QtyInStock;
        }

        public void setQtyInStock(int qty)
        {
            QtyInStock = qty;
        }

        public string getName()
        {
            return Name;
        }

        public void setName(string name)
        {
            Name = name;
        }

        public string getDescription()
        {
            return Description;
        }

        public void setDescription(string desc)
        {
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