using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public static class ShopTask
    {
        public static void Run()
        {
            var mall = new Shop("Daffi", "Shopping center", "someaddress", ShopTypes.ShoppingMall);
            var grocery = new Shop("Goods and Food", "Grocery store of your town", "someaddress", ShopTypes.Grocery);
            var drugstore = new Shop("FirstAid", "Pills and Drugs", "someaddress", ShopTypes.Drugstore);

            Console.WriteLine(mall);
            Console.WriteLine(grocery);
            Console.WriteLine(drugstore);
            Console.ReadLine();

            //розкоментувати для використання методу Dispose()
            //mall.Dispose();
            //grocery.Dispose();
            //drugstore.Dispose();

        }
    }
}