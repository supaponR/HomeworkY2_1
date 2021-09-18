using System;
using System.Collections.Generic;
namespace Quiz
{
    class Rose
    { //สร้างinstanceของโรส
        public int ID;
        public string NamePlant;
        public string DescriptionPlant;
        public int Amount;
        public string Height;
        public string Circumference;

        public Rose(int id , string namePlant,string desdriptionPlant, int amount , string height , string circumference)
        {
            this.ID = id;
            this.NamePlant = namePlant;
            this.DescriptionPlant = desdriptionPlant;
            this.Amount = amount;
            this.Height = height;
            this.Circumference = circumference;
        }
    }
    class SunFolwer:Rose
    {   //ทำการเชื่อมโยงclassของโรสกับทานตะวัน                                                    
        public SunFolwer(int id, string namePlant, string desdriptionPlant, int amount, string height, string circumference): base(id ,namePlant, desdriptionPlant, amount, height, circumference) {}
    } 
    class Program
    {
        static void Main(string[] args)
        {
            int totalRose, totalSunflower;
            Console.Write("Input Total Rose:");
            totalRose = int.Parse(Console.ReadLine());
            Console.Write("Input Total Sun Flower:");
            totalSunflower = int.Parse(Console.ReadLine());

            //ใส่ค่าให้กับinstanceของโรสและทานตะวัน
            Rose rose = new Rose(totalRose, "ดอกกุหลาบสีขาว", "สวยงามมาก", 2, "10.5", "6");
            Sunflower: Rose sunflower = new Rose(totalSunflower, "ดอกทายตะวันเล็ก", "สวยงาม", 1, "2.0", "2.0");
            Console.WriteLine();

            //แสดงค่าของข้อมูลต้นไม้ น้องสับสนการสร้างlist น้องเลยComsolrwirteยาวพี่คงกำหมัดอยู่น้องSorryyy55555
            Console.WriteLine("Input Rose");
            Console.WriteLine("----------------");
            Console.WriteLine();
            Console.WriteLine("ID: {0}", rose.ID);
            Console.WriteLine("Plant name:{0}", rose.NamePlant);
            Console.WriteLine("Plant description: {0}", rose.DescriptionPlant);
            Console.WriteLine("Amount:{0}", rose.Amount);
            Console.WriteLine("Height:{0}", rose.Height);
            Console.WriteLine("Circumference:{0}", rose.Circumference);
            Console.WriteLine();

            Console.WriteLine("Input Sun Flower");
            Console.WriteLine("----------------");
            Console.WriteLine();
            Console.WriteLine("ID: {0}", sunflower.ID);
            Console.WriteLine("Plant name:{0}", sunflower.NamePlant);
            Console.WriteLine("Plant description: {0}", sunflower.DescriptionPlant);
            Console.WriteLine("Amount:{0}", sunflower.Amount);
            Console.WriteLine("Height:{0}", sunflower.Height);
            Console.WriteLine("Circumference:{0}", sunflower.Circumference);

            
        }


      
    }
}
