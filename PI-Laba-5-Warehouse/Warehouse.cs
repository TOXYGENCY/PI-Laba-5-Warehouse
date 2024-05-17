using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Laba_5_Warehouse
{
    public class Warehouse
    {
        public int GoodsAmount { get; protected set; }

        public Warehouse(int amount) 
        {
            if (amount < 0) throw new NegativeGoodsException();
            GoodsAmount = amount;
        }

        public void WriteOff(int amount)
        {
            try
            {
                GoodsAmount -= amount;
                if (GoodsAmount < 0) throw new NegativeGoodsException();
            }
            catch (NegativeGoodsException e) 
            {
                GoodsAmount = 0;
                throw e; // по заданию надо кидать ошибку обратно
            }
            finally
            {
                Console.WriteLine($"Осталось товара на складе: {GoodsAmount}");
            }

        }
    }
}
