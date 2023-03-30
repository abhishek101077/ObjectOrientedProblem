namespace InventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string path = "C:\\Users\\Arindam shukla\\source\\repos\\InventoryManagement\\InventoryManagement";
            ReadInventory obj = new ReadInventory();  
            InventoryDetails data = obj.Read(path);

            Console.WriteLine(data.typeOfRice.name);
            Console.WriteLine(data.typeOfRice.weight);
            Console.WriteLine(data.typeOfRice.price);

        }
    }
}