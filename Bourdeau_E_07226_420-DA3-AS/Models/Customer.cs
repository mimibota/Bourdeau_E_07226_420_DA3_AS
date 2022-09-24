namespace Bourdeau_E_07226_420_DA3_AS.Models
{
    public class Customer:IModels<Customer>
    {
        
        //properties
        private int Id;
        private string FirstName;
        private string LastName;
        private string Email;
        private string CreatedAt;
        private string DeletedAt;
        
        
        //constructors
        public Customer(int id, string fname, string lname, string email, string createAt, string deletedAt)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
            Email = email;
            CreatedAt = createAt;
            DeletedAt = deletedAt;

        }
        
        
        private static IModels<Customer> _modelsImplementation;

        public Customer GetById()
        {
            return _modelsImplementation.GetById();
        }
        
        public class TModel
        {
        }


        public Customer Insert()
        {

            return _modelsImplementation.Insert();
        }

        public Customer Update()
        {
            return _modelsImplementation.Update();
        }

        public void Delete()
        {
            _modelsImplementation.Delete();
        }

    }
}