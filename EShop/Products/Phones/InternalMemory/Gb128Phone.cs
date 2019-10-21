using EShop.Enums;

namespace EShop.Products.Phones.InternalMemory
{
    public class Gb128Phone : PhoneDecorator
    {
        public sealed override void SetPrice()
        {
            DecoratedPhone.Price += 400;
        }

        public Gb128Phone(IPhone decoratedPhone) : base(decoratedPhone)
        {
            decoratedPhone.InternalMemory = EInternalMemory.Gb128;
            SetPrice();
        }
    }
}