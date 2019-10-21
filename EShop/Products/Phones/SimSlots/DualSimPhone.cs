using EShop.Enums;

namespace EShop.Products.Phones.SimSlots
{
    public class DualSimPhone: PhoneDecorator
    {
        public DualSimPhone(IPhone decoratedPhone) : base(decoratedPhone)
        {
            decoratedPhone.SimSlots = ESimSlots.DualSim;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedPhone.Price += 150;
        }
    }
}