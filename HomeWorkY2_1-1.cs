using System;
using System.Collections.Generic;
namespace HW

{
    class Tshirt
    {
        public string size_1;
        public string color_1;
        public float price_1;
        public string image_1;
        public string size_2;
        public string color_2;
        public float price_2;
        public string image_2;
        public string size_3;
        public string color_3;
        public float price_3;
        public string image_3;


        public Tshirt(string valueSize_1 , string valueColor_1, float valuePrice_1 , string valueImage_1 
                      , string valueSize_2, string valueColor_2 ,float valuePrice_2 , string valueImage_2
                      , string valueSize_3, string valueColor_3, float valuePrice_3, string valueImage_3)
        {
            size_1 = valueSize_1;
            color_1 = valueColor_1;
            price_1 = valuePrice_1;
            image_1 = valueImage_1;

            size_2 = valueSize_2;
            color_2 = valueColor_2;
            price_2 = valuePrice_2;
            image_2 = valueImage_2;

            size_3= valueSize_3;
            color_3 = valueColor_3;
            price_3 = valuePrice_3;
            image_3 = valueImage_3;

        }
    }

    class User
    {
        public string name;
        public string email;
        public string shoppingCart;
        private List<Tshirt> shoppingCarts;

        public User(string valueName, string valueEmail , string valueShoppingCart)
        {
            name = valueName;
            email = valueEmail;
            shoppingCart = valueShoppingCart;
            shoppingCarts = new List<Tshirt>();

        }
    }

    class Address
    {
        public string street;
        public string city;
        public string zipCode;

        public Address(string valueStreet , string valueCity , string valueZipcode)
        {
            street = valueStreet;
            city = valueCity;
            zipCode = valueZipcode;

    }
    }
    
    
    class Program
    {
        
        static void Main(string[] args)
        {
            

            User jame = new User("Jame watson", "jame@gmail.com","");
            Address inforJame = new Address("131/75 phuttamonthon Road", "nakhonPathom", "10180");
            Tshirt inforshirt = new Tshirt("L","Red",500f,"RD","M","Black", 750f ,"BK" ,"S", "Purple", 625 ,"PP");

            Console.WriteLine("Name: {0} Email: {1}", jame.name,jame.email);
            Console.WriteLine("Address: {0} City: {1} ZipCode: {2}",inforJame.street,inforJame.city,inforJame.zipCode);
            Console.WriteLine("ShoppingCart : Size {0} Color {1} Price {2} Baht ", inforshirt.size_1 , inforshirt.color_1, inforshirt.price_1);
            Console.WriteLine("               Size {0} Color {1} Price {2} Baht", inforshirt.size_2, inforshirt.color_2, inforshirt.price_2);
            Console.WriteLine("               Size {0} Color {1} Price {2} Baht", inforshirt.size_3, inforshirt.color_3, inforshirt.price_3);
            float count = 0f;
            count += inforshirt.price_1 + inforshirt.price_2 + inforshirt.price_3;
            Console.WriteLine("Total cost :"+count);
            Console.ReadLine();
        }
    }
}
