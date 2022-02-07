using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Laptops> laptops = new List<Laptops>()
            {
                new Laptops(){Code=1, Name="MSI", Proccessor="AMD Ryzen 9", CPU="3.3 ГГц", RAM=32, HDD="1 ТБ", MemorySize="10 ГБ", Price=2700, Quantity=1},
                new Laptops(){Code=2, Name="HP", Proccessor="AMD Ryzen 7", CPU="3.2 ГГц", RAM=32, HDD="1 ТБ", MemorySize="6 ГБ", Price=1850, Quantity=1},
                new Laptops(){Code=3, Name="Lenovo", Proccessor="AMD Ryzen 7", CPU="3.2 ГГц", RAM=16, HDD="512 ГБ", MemorySize="4 ГБ", Price=1315, Quantity=1},
                new Laptops(){Code=4, Name="Asus", Proccessor="AMD Ryzen 5", CPU="2.9 ГГц", RAM=16, HDD="512 ГБ", MemorySize="4 ГБ", Price=1645, Quantity=2},
                new Laptops(){Code=5, Name="Acer", Proccessor="Core i7", CPU="2.3 ГГц", RAM=16, HDD="512 ГБ", MemorySize="4 ГБ", Price=1300, Quantity=2},
                new Laptops(){Code=6, Name="Dell", Proccessor="Core i7", CPU="3.2 ГГц", RAM=16, HDD="1 ТБ", MemorySize="4 ГБ", Price=1710, Quantity=2},
                new Laptops(){Code=7, Name="Xiaomi", Proccessor="Core i5", CPU="2.3 ГГц", RAM=8, HDD="1 ТБ", MemorySize="2 ГБ", Price=1000, Quantity=2},

            };

            Console.WriteLine("Выберите производитея");
            string name = Console.ReadLine();
            List<Laptops> laptopss1 = laptops.Where(x => x.Name == name).ToList();
            Print(laptopss1);

            Console.WriteLine("Выберите объём оперативной памяти в ГБ:");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Laptops> laptopss2 = laptops.Where(x => x.RAM == ram).ToList();
            Print(laptopss2);

            List<Laptops> laptopss3 = laptops.OrderBy(x => x.Name).ToList();
            Print(laptopss3);

            IEnumerable<IGrouping<string, Laptops>> laptopss4 = laptops.GroupBy(x => x.CPU);
            foreach (IGrouping<string, Laptops> gr in laptopss4)
            {
                Console.WriteLine(gr.Key);
                foreach (Laptops e in gr)
                {
                    Console.WriteLine($"{e.Name} {e.Proccessor} {e.CPU} {e.RAM} {e.HDD} {e.Price}");
                }
            }

            Laptops laptops5 = laptops.OrderByDescending(x => x.Proccessor).FirstOrDefault();
            Console.WriteLine($"{laptops5.Code} {laptops5.Name} {laptops5.Proccessor}  {laptops5.CPU} {laptops5.RAM} {laptops5.HDD} {laptops5.MemorySize} {laptops5.Price} {laptops5.Quantity}");
            Console.WriteLine(laptops.Any(x => x.Price > 1000));

            Console.ReadKey();

        }

        static void Print(List<Laptops> laptops)
        {
            foreach (Laptops e in laptops)
            {
                Console.WriteLine($"{e.Code} {e.Name} {e.Proccessor} {e.CPU} {e.RAM} {e.HDD} {e.MemorySize} {e.Price}");
            }
            Console.WriteLine();
        }
    }
}