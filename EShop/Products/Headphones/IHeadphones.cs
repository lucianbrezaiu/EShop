using EShop.Enums;
using EShop.Products.Headphones.Colors;
using EShop.Products.Headphones.Connectivity;
using EShop.Products.Headphones.Style;

namespace EShop.Products.Headphones
{
    public interface IHeadphones: IProduct
    {
        EColor Color { get; set; }
        EConnectivity Connectivity { get; set; }
        EStyle Style { get; set; }
    }
}