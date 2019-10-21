using EShop.Enums;
using EShop.Products.Phones.Colors;
using EShop.Products.Phones.InternalMemory;
using EShop.Products.Phones.SimSlots;

namespace EShop.Products.Phones
{
    public interface IPhone: IProduct
    {
        EColor Color { get; set; }
        EInternalMemory InternalMemory { get; set; }
        ESimSlots SimSlots { get; set; }
    }
}