using EShop.Enums;
using EShop.Products.Phones.Colors;
using EShop.Products.Phones.InternalMemory;
using EShop.Products.Phones.SimSlots;

namespace EShop.Products.Phones
{
    public abstract class PhoneDecorator: IPhone
    {
        protected readonly IPhone DecoratedPhone;

        protected PhoneDecorator(IPhone decoratedPhone)
        {
            DecoratedPhone = decoratedPhone;
        }

        public EColor Color { get; set; }
        public EInternalMemory InternalMemory { get; set; }
        public ESimSlots SimSlots { get; set; }
        public abstract void SetPrice();
        public int Price { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return DecoratedPhone.ToString();
        }
    }
}