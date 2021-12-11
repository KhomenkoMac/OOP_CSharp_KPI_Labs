using Lab4_Part2.models;
using System;

namespace Lab4_Part2
{
    class Program
    {
        private static void ShowAccessories()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{(int)Accessory.Muzzle} - {Accessory.Muzzle}");
            Console.WriteLine($"{(int)Accessory.Colar} - {Accessory.Colar}");
            Console.WriteLine($"{(int)Accessory.Leash} - {Accessory.Leash}");
            Console.WriteLine("----------------------------");
        }

        private static void ShowSizes()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{(int)Size.M} - {Size.M}");
            Console.WriteLine($"{(int)Size.L} - {Size.L}");
            Console.WriteLine($"{(int)Size.S} - {Size.S}");
            Console.WriteLine("----------------------------");
        }

        private static Size GetSize()
        {
            Console.Write("\n Your choice>");
            return (Size)int.Parse(Console.ReadLine());
        }

        private static Accessory GetAccessory()
        {
            Console.Write("\n Your choice>");
            return (Accessory)int.Parse(Console.ReadLine());
        }

        public enum Size
        {
            M = 1, L, S
        }

        public enum Accessory
        {
            Muzzle = 1, Colar, Leash
        }

        class Client
        {
            public void Produce(IDogAccessoriesFactory f)
            {
                ShowAccessories();
                var toProduce = GetAccessory();
                string produced = null;
                switch (toProduce)
                {
                    case Accessory.Muzzle:
                        produced = f.CreateMuzzle().ToString();
                        break;
                    case Accessory.Colar:
                        produced = f.CreateColar().ToString();
                        break;
                    case Accessory.Leash:
                        produced = f.CreateLeash().ToString();
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"Produced: {produced}");
            }
        }

        static void Main(string[] args)
        {
            Client c = new();
            IDogAccessoriesFactory idaf = null;
            do
            {
                try
                {

                    ShowSizes();
                    Size size = GetSize();
                    switch (size)
                    {
                        case Size.M:
                            idaf = new MFactory();
                            break;
                        case Size.L:
                            idaf = new LFactory();
                            break;
                        case Size.S:
                            idaf = new SFactory();
                            break;
                        default:
                            Console.WriteLine("Invalid size variant!");
                            break;
                    }
                    c.Produce(idaf);

                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            } while (true);
        }
    }
}
