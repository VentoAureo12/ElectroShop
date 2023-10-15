using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Basket
    {
        private static List<int> _basket = new List<int>();

        public static List<int> getBasket()
        {
            return _basket;
        }

        public static void addProduct(int value)
        {
            _basket.Add(value);
        }

        public static void ClearBasket()
        {
            _basket = new List<int>();

        }

        public static void Delete(int id)
        {
            _basket.Remove(id);
        }
    }
}
