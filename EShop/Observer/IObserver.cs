namespace EShop.Observer
{
    public interface IObserver
    {
        void LastEntityInStock();
        void EntityAddedToStock();
        void NewEntityAdded();
    }
}