using System;

namespace Goods
{

	class GoodsGroup
	{
		public string groupName;
		public float minPrice;


		public GoodsGroup()
		{
			this.minPrice = 0;
			this.groupName = "group";
		}

		public GoodsGroup(string groupName)
		{
			this.minPrice = 0;
			this.groupName = "group";
		}

		public GoodsGroup(float minPrice)
		{
			this.minPrice = 0;
			this.groupName = "group";
		}
	}

	class Goods:GoodsGroup
	{
		public string goodName;

		public float goodPrice 
		{ 
			get
			{ 
				return goodPrice;
			} 

			set
			{ 
				this.goodPrice = (goodPrice < 0) ? goodPrice : 0;
			}
		}



		public Goods()
		{
			this.goodPrice = 0;

			this.goodName = "good";

		}

		public Goods(float goodPrice)
		{
			this.goodPrice = 0;

			this.goodName = "good";

		}

		public Goods(string goodName)
		{
			this.goodPrice = 0;

			this.goodName = "good";

		}
			
	}



	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			Goods good1 = new Goods();

		//	string NewStr = good1.groupName;

		//	Console.WriteLine (NewStr);

//			Console.WriteLine (""+good1.goodPrice);

		}
	}
}
