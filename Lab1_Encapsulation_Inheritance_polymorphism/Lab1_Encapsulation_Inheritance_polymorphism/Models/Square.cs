using System;

namespace Lab1_Encapsulation_Inheritance_polymorphism.Models
{
	public class Square : Rectangle
	{
		public Square(double side) : base(side, side) 
		{
			Console.WriteLine($"{nameof(Square)} -> derived ctor executed");
		}
	}
}
