using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
     class Inventory
    {
        private List<Product.Fruits> listFruits;
        private List<Product.Vegetables> listVegetable;
        public Inventory()
        {
            listFruits = new List<Product.Fruits>();
            listVegetable = new List<Product.Vegetables>();
        }
        public void Add(Product.Fruits obj)
        {
            listFruits.Add(obj);
        }
        public void Add(Product.Vegetables obj)
        {
            listVegetable.Add(obj);
        }
        public void SumFruits()
        {
            int sumPrice = listFruits.Sum(p => p.price * p.count);
            Console.WriteLine($"Стоимость всех фруктов: {sumPrice} р. \n");
        }
        public void SumVegetable()
        {
            int sumPrice = listVegetable.Sum(p => p.price * p.count);
            Console.WriteLine($"Стоимость всех овощей: {sumPrice} р.\n");
        }
        public void SumALL()
        {
            int sumPrice = listFruits.Sum(p => p.price * p.count) + listVegetable.Sum(p => p.price * p.count);
            Console.WriteLine($"Стоимость всего инвентаря: {sumPrice} р.\n");
        }
        public void PrintFruits()
        {
            Console.WriteLine("Список инвентаря Фрукты:\n");
            listFruits.ForEach(x => Console.WriteLine($"{x.id} - {x.name}, кол-во: {x.count}, цена за 1: {x.price} р."));
        }
        public void PrintVegetable()
        {
            Console.WriteLine("\nСписок инвентаря Овощи:\n");
            listVegetable.ForEach(x => Console.WriteLine($"{x.id} - {x.name}, кол-во: {x.count}, цена за 1: {x.price} р."));
        }
        public void AddProduct()
        {
          int type;
            while (true)
            {
                Console.WriteLine("Выберите тип продукта: 1 - фрукты, 2 - овощи");
                if (int.TryParse(Console.ReadLine(), out type))
                {
                    if (type != 1 & type != 2)
                    {
                        Console.WriteLine("Выберите тип продукта!");
                        continue;
                    }
                    break;
                }
                continue;
            }
         
            if (type == 1)
            {
                Console.WriteLine("Введите id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите название:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите количество:");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите стоимость:");
                int price = int.Parse(Console.ReadLine());
                listFruits.Add(new Product.Fruits(id, count, price, name));
            }
            if (type == 2)
            {
                Console.WriteLine("Введите id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите название:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите количество:");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите стоимость:");
                int price = int.Parse(Console.ReadLine());
                listVegetable.Add(new Product.Vegetables(id, count, price, name));
            }
        }
        
        public void RemoveProduct() 
        {
            Console.WriteLine("Введите id продукта:");
            int id = int.Parse(Console.ReadLine());
            if ((listFruits.RemoveAll(p => p.id == id) > 0) & (listVegetable.RemoveAll(p => p.id == id) > 0))
                Console.WriteLine("Указанный продукт удален");
            else
                Console.WriteLine("Продукта с таким кодом не существует");
        }
    }
}
