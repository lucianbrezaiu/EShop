using EShop.Enums;

namespace EShop.Products.Phones.Colors
{
    public class WhitePhone : PhoneDecorator
    {
        public sealed override void SetPrice()
        {
            DecoratedPhone.Price += 50;
        }

        public WhitePhone(IPhone decoratedPhone) : base(decoratedPhone)
        {
            DecoratedPhone.Color = EColor.White;
            SetPrice();
        }
    }
}