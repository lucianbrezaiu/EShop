using EShop.Enums;

namespace EShop.Products.Phones.InternalMemory
{
    public class Gb256Phone: PhoneDecorator
    {
        public Gb256Phone(IPhone decoratedPhone) : base(decoratedPhone)
        {
            decoratedPhone.InternalMemory = EInternalMemory.Gb256;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedPhone.Price += 750;
        }
    }
}