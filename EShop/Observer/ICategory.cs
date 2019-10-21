using EShop.Composite;
using EShop.Enums;

namespace EShop.Observer
{
    public interface ICategory
    {
        void Subscribe(Entity entity, int quantity);
        bool Unsubscribe(Entity entity, int quantity);
        void Notify(Entity entity, EAction action);
    }
}