using EShop.Enums;

namespace EShop.Products.Phones.Colors
{
    public class GoldPhone: PhoneDecorator
    {
        public GoldPhone(IPhone decoratedPhone) : base(decoratedPhone)
        {
            decoratedPhone.Color = EColor.Gold;
            SetPrice();
        }

        public sealed override void SetPrice()
        {
            DecoratedPhone.Price += 100;
        }
    }
}