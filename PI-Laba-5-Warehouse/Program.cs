namespace PI_Laba_5_Warehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wo = 10;
            var w1 = new Warehouse(234);
            var w2 = new Warehouse(10);
            var w3 = new Warehouse(0);

            w1.WriteOff(wo);
            w2.WriteOff(wo);
            w3.WriteOff(wo);
        }
    }
}
