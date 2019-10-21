using EShop.Enums;
using EShop.Products.Headphones.Colors;
using EShop.Products.Headphones.Connectivity;
using EShop.Products.Headphones.Style;

namespace EShop.Products.Headphones
{
    public abstract class HeadphonesDecorator: IHeadphones
    {
        protected readonly IHeadphones DecoratedHeadphones;

        protected HeadphonesDecorator(IHeadphones decoratedHeadphones)
        {
            DecoratedHeadphones = decoratedHeadphones;
        }

        public int Price { get; set; }
        public string Name { get; set; }
        public EColor Color { get; set; }
        public EConnectivity Connectivity { get; set; }
        public EStyle Style { get; set; }
        public abstract void SetPrice();
    }
}