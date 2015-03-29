using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st2
{
    class Goods
    {
        public Goods()
        {
            price = 0;
            name = "unspecified";
            goodsGroup = new GoodsGroup();
        }
        public Goods(double price, string name, GoodsGroup group)
        {
            this.name = name;
            this.price = price;
            this.goodsGroup = group;
        }

        public Goods(string name) : this()
        {
            this.name = name;
        }
        public Goods(double price) : this()
        {
            this.price = price;
        }
        
        public void Print()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Price: {0}", price);
            goodsGroup.Print();
        }
        public double Price { get { return price; } set { price = value > 0 ? value : 0; } }
        public string Name { get { return name; } }

        protected double price;
        protected string name;
        protected GoodsGroup goodsGroup;
        
        public string ToString()
        {
            return "name: " + name + ", price:" + price + "goodsGroup:" + ((goodsGroup != null) ? goodsGroup.Name : "пустая");  

        }
    
    }
   

    class GoodsGroup
    {
        private string name;
        private double minPrice;
        public string Name { get { return name; } }
        public double MinPrice { get { return minPrice; } set { minPrice = value > 0 ? value : 0; } }


        public GoodsGroup()
        {
            name = "Unnamed group";
            minPrice = 0;
        }
        public GoodsGroup(string name, double minPrice)
        {
            this.name = name;
            this.minPrice = minPrice;
        }
        public GoodsGroup(string name) : this()
        {
            this.name = name;
        }
        public GoodsGroup(double minPrice) : this()
        {
            this.minPrice = minPrice;
        }
        public void Print()
        {
            Console.WriteLine("Group Name: {0}", name);
            Console.WriteLine("Group MinPrice: {0}", minPrice);
        }
    }
    class BadGoods : Goods
    {
        
        string reason;
        double newPrice;

        public string Reason { get { return reason; } set { reason = "null"; } }
        public double NewPrice { get { return newPrice;  } set {newPrice = value > 0 ? value:0;}} 

        public BadGoods(double price, string name, GoodsGroup group, string reason, double newPrice) :
            base (price, name, group)
        {
            Reason = reason;
            NewPrice = newPrice;

        }
        public BadGoods(double price, string name) : this(price, "null", null, "no reason", 0)
        {

        }
           
    }
    class Program
    {
        static void Main(string[] args)
        {
            GoodsGroup group = new GoodsGroup("group1", 100);
            Goods goodie = new Goods(372.50, "goodie", group);
            BadGoods anothergoodie = new BadGoods(350, "badgoodie",group, "broken", 200); 
            goodie.Print();

            Console.WriteLine("Price of our goodie: {0}", goodie.Price);
            Console.WriteLine(goodie.ToString());
            Console.ReadLine();

        }
    }
}

/******************\
|     __    __     |
|    /_*\  /_*\    |
|                  |
|        ''        |
|      ______      |
|      \||||/      |
|                  |
|******************/