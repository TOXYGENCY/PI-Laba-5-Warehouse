namespace PI_Laba_5_Warehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World:");
            var a = int.Parse(Console.ReadLine());

            var b = new Warehouse(a);
            Console.WriteLine(b.GoodsAmount);

            var c = int.Parse(Console.ReadLine());
            b.WriteOff(c);
            
        }
    }
}
