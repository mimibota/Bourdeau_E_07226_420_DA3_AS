namespace Bourdeau_E_07226_420_DA3_AS.Models
{
    public interface IModels<TModel> where TModel:IModels<TModel>
    {

        TModel GetById();
        TModel Insert();
        TModel Update();
        void Delete();
    }
}