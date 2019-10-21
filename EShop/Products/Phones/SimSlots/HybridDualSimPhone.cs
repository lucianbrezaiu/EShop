using EShop.Enums;

namespace EShop.Products.Phones.SimSlots
{
    public class HybridDualSimPhone: PhoneDecorator
    {
        public HybridDualSimPhone(IPhone decoratedPhone) : base(decoratedPhone)
        {
            decoratedPhone.SimSlots = ESimSlots.HybridDualSim;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedPhone.Price += 250;
        }
    }
}