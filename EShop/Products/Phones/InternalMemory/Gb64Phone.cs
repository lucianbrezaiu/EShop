using EShop.Enums;

namespace EShop.Products.Phones.InternalMemory
{
    public class Gb64Phone: PhoneDecorator
    {
        public Gb64Phone(IPhone decoratedPhone) : base(decoratedPhone)
        {
            decoratedPhone.InternalMemory = EInternalMemory.Gb64;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedPhone.Price += 250;
        }
    }
}