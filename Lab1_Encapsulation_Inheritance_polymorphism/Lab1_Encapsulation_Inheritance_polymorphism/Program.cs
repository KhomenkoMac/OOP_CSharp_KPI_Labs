using Lab1_Encapsulation_Inheritance_polymorphism.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Lab1_Encapsulation_Inheritance_polymorphism
{
	public class Client
	{
		private Dictionary<string, Polygon> _avaliableFigures = new();

		public void AddAvalableFigure(KeyValuePair<string,Polygon> figure)
		{
			_avaliableFigures.Add(figure.Key, figure.Value);
		}

		public void MoveRectangle(int x, int y)
		{
			_avaliableFigures.GetValueOrDefault(nameof(Rectangle))?.Move(x, y);
		}

		public void PaintRectangle()
		{
			_avaliableFigures.GetValueOrDefault(nameof(Rectangle))?.Paint();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Rectangle r = new(5, 4);
			
			Client c = new();
			
			c.AddAvalableFigure(new KeyValuePair<string, Polygon>(nameof(Rectangle), r));
			
			r.FigureMoved += new Func<Point, Polygon, bool>(OnMoved); // delegate func
			r.FigurePainted += new Action<Polygon>(OnPaintedLog); // delegate action
			r.FigureMoved += delegate (Point location, Polygon sender)  // subscription using anonymus method
			{ 
				return OnMoved(location, sender); 
			};
			r.FigurePainted += (obj) => OnPaintedLog(obj); // subscription using labda-expression

			c.PaintRectangle();
		}

		private static bool OnMoved(Point location, Polygon senderObj) // event handler
		{
			if (!double.IsNaN(location.x) && !double.IsNaN(location.y))
			{
				Console.WriteLine( $"{senderObj.GetType()} has been moved at ({location.x};{location.y})");
				return true;
			}

			return false;
		}

		private static void OnPaintedLog(Polygon senderObj)
		{
			Console.WriteLine($"{senderObj.GetType().Name} has been painted");
		}
	}
}
