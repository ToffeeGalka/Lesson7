namespace Lesson7
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.Add(new Product.Fruits(1, 2, 500, "яблоко"));
            inventory.Add(new Product.Fruits(2, 4, 750, "груша"));
            inventory.Add(new Product.Fruits(3, 10, 220, "киви"));
            inventory.Add(new Product.Vegetables(1, 10, 100, "лук"));
            inventory.Add(new Product.Vegetables(4, 12, 150, "морковь"));
            inventory.Add(new Product.Vegetables(5, 8, 400, "томат"));
            while (true)
            {
                int menu;
                while (true)
                {
                    Console.WriteLine("Выберите пункт меню, нажав соответствующую цифру от 1 до 4: \n" + "1 - Вывести список всего инвентаря \n" +
                        "2 - Вывести стоимость всего инвентаря \n" +
                        "3 - Добавить инвентарь \n" +
                        "4 - Удалить инвентарь \n");
                    if (int.TryParse(Console.ReadLine(), out menu))
                    {
                        if (menu != 1 & menu != 2 & menu != 3 & menu != 4)
                        {
                            Console.WriteLine("Выберите предложенный пункт меню от 1 до 3!");
                            continue;
                        }
                        break;
                    }
                    continue;
                }
                if (menu == 1)
                {
                    inventory.PrintFruits();
                    inventory.PrintVegetable();
                }
                if (menu == 2)
                {
                    inventory.SumFruits();
                    inventory.SumVegetable();
                    inventory.SumALL();
                }
                if (menu == 3)
                {
                    inventory.AddProduct();
                }
                if (menu == 4)
                {
                    inventory.RemoveProduct();
                }
                Console.WriteLine("\n ПРОДОЛЖИМ? Y:");
                if (char.TryParse(Console.ReadLine(), out char cancel))
                {
                    if (cancel != 'Y')
                    {
                        break;
                    }
                    continue;
                }
            }

        }
    }
}
