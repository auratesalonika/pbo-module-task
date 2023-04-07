using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using file;

namespace file
{
    //superclass laptop
    class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dinyalakan");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dimatikan");
        }
    }
    // ASUS sebagai anak dari class Laptop
    class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }
    //2 anakan dari class ASUS
    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }

    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    // ACER sebagai anak dari class Laptop
    class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }

    // 2 anakan dari class ACER
    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }

    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }

    //Lenovo sebagai anakan dari class Laptop
    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }
    //2 class anakan dari class Lenovo
    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }

    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }

    //superclass VGA
    class Vga
    {
        public string merk;
    }

    //2 class anakan dari class Vga
    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }

    class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }


    //superclass processor
    class Processor
    {
        public string merk, tipe;
    }

    //class intel sebagai childclass dari processor
    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    //3 anakan dari class intel

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }

    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }

    //class amd sebagai anakan dari class processor 
    class amd : Processor
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }

    // 2 anakan dari class amd
    class Ryzen : amd
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }

    class Athlon : amd
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new CoreI5();
            Console.WriteLine($"---------- Laptop1 ----------");
            Console.WriteLine($"Merk VGA : {laptop1.vga.merk}");
            Console.WriteLine($"Merk Processor : {laptop1.processor.merk}");
            Console.WriteLine($"Tipe Processor : {laptop1.processor.tipe}");
            Console.WriteLine($"-----------------------------\n\n");

            //Laptop1.Ngoding(); (ini akan error ketika dijalankan)
            
            
            Laptop laptop2 = new IdeaPad();
            laptop2.vga = new AMD();
            laptop2.processor = new Ryzen();
            Console.WriteLine($"---------- Laptop2 ----------");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            Console.WriteLine($"------------------------------\n\n");

            Predator predator = new Predator();
            predator.vga = new AMD();
            predator.processor = new CoreI7();
            Console.WriteLine($"---------- predator ----------");
            predator.BermainGame();
            Console.WriteLine($"------------------------------\n\n");

            /*  ACER acer = new Predator();  
                acer.BermainGame(); */  // akan error jika dijalankan
            
        }
    }
}