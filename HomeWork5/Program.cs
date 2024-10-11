
namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayTask.Run();
            ShopTask.Run();

            //якщо методи Dispose() закоментовані в методі Run(), спрацює ~деструктор
            GC.Collect();
            Console.ReadLine();
        }
    }
}
