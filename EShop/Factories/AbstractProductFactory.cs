namespace EShop.Factories
{
    public abstract class AbstractProductFactory
    {
        public static int LastId { get; set; }
        public abstract Product GetAppliance(int Price, string Name);
        public abstract Product GetLaptop(int Price, string Name);
        public abstract Product GetTV(int Price, string Name);
        public abstract Product GetPhone(int Price, string Name);
        public abstract Product GetHeadphones(int Price, string Name);
    }
}
