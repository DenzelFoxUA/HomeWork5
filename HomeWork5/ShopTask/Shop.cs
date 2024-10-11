using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{

    public enum ShopTypes
    {
        Default = 0,
        Grocery = 1,
        Drugstore,
        Clothing,
        Electronics,
        Sport,
        Touristic,
        MegaMart,
        ShoppingMall

    }

    public class Shop : IDisposable
    {
        private bool _disposed = false;

        public string Name { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public ShopTypes ShopType { get; set; }

        public Shop()
        {
            Name = string.Empty;
            Description = string.Empty;
            Address = string.Empty;
            ShopType = ShopTypes.Default;
        }

        public Shop(string name, string description, string address, ShopTypes type)
        {
            Name = name;
            Description = description;
            Address = address;
            ShopType = type;
        }

        public override string ToString()
        {
            return $"{ShopType}: {Name}\n" +
                $"{Description}\n" +
                $"Address: {Address}\n";
        }

        public virtual void Dispose(bool isDisposed)
        {
            if (_disposed) return;
            if (isDisposed)
            {
                Console.WriteLine($"Dispose() method of a Shop class called by object {Name}");
                ClearData();
            }
            else
            {
                Console.WriteLine($"~Destructor of a Shop class called by object {Name}");
                ClearData();
            }
            _disposed = true;
        }

        protected virtual void ClearData()
        {
            Name = string.Empty;
            Description = string.Empty;
            Address = string.Empty;
            ShopType = ShopTypes.Default;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Shop()
        {
            Dispose(false);
        }
    }
}
