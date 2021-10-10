using Lab1_Encapsulation_Inheritance_polymorphism.ExceptionHierarchy;
using Lab1_Encapsulation_Inheritance_polymorphism.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Lab1_Encapsulation_Inheritance_polymorphism
{
	public static class Extensions //
	{
		public static void AddAvaliableFigure(this Dictionary<string,Polygon> dictionary, KeyValuePair<string, Polygon> figureForDict)
		{
			dictionary.Add(figureForDict.Key, figureForDict.Value);
		}
	}


	public class Client
	{
		private Dictionary<string, Polygon> _avaliableFigures = new();

		public void AddAvalableFigure(KeyValuePair<string,Polygon> figure)
		{
			_avaliableFigures.AddAvaliableFigure(figure); // extension in use
		}

		public void MoveRectangle(double x, double y)
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
			
			//r.FigureMoved += new Func<Point, Polygon, bool>(OnMoved); // delegate func
			//r.FigurePainted += new Action<Polygon>(OnPaintedLog); // delegate action
			r.FigureMoved += delegate (Point location, Polygon sender)  // subscription using anonymus method
			{ 
				return OnMoved(location, sender); 
			};
			r.FigurePainted += (obj) => OnPaintedLog(obj); // subscription using labda-expression

			c.PaintRectangle();
			c.MoveRectangle(double.NaN, double.PositiveInfinity); // initiation of exception
		}

		private static bool OnMoved(Point location, Polygon senderObj) // event handler
		{
			//if (!double.IsNaN(location.x) && !double.IsNaN(location.y))
			//{
			//	Console.WriteLine( $"{senderObj.GetType()} has been moved at ({location.x};{location.y})");
			//	return true;
			//}

			// code using app exception

			try
			{
				if (double.IsNaN(location.x) || double.IsNaN(location.y))
				{
					throw new FigureNotMovedException(
						new FigureNotMovedExceptionArgs($"Figure is not moved due to invalid args!", null));
				}

				Console.WriteLine($"{senderObj.GetType()} has been moved at ({location.x};{location.y})");
			}
			catch (FigureNotMovedException e)
			{
				string output = $"{nameof(FigureNotMovedException)}:";

				if (e.Source != null)
				{
					output += $" Source: {e.Source};";
				}

				if (e.Message != null)
				{
					output += $" Message: {e.Message};";
				}
				
				if (e.InnerException != null)
				{
					output += $"Inner: {e.InnerException.Message};";
				}


				return false;
			}
			
			return true;
		}

		private static void OnPaintedLog(Polygon senderObj)
		{
			Console.WriteLine($"{senderObj.GetType().Name} has been painted");
		}
	}
}
