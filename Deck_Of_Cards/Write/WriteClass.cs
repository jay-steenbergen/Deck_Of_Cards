using System;
using System.Collections.Generic;
using System.Text;

namespace Deck_Of_Cards
{
    public class WriteClass 
    {
		public enum Colors
		{
			None,
			Red,
			Blue,
			Yellow,
			Cyan,
			Magenta
		}
		public void Deceminter()
		{
			WriteLine(Colors.None, "============================================================= ");
		}
		public void Write(Colors color,  string body )
		{
			Console.ResetColor();
			this.ApplyColor(color);
			Console.Write(body);
			Console.ResetColor();

		}
		public void WriteLine(Colors color, string body)
		{
			Console.ResetColor();
			this.ApplyColor(color);
			Console.WriteLine(body);
		}
		public void WriteList(Colors color, List<string> list)
		{
			Console.ResetColor();
			this.ApplyColor(color);
			foreach (var item in list)
			{
				Console.Write(item + " ");
			}
			Console.ResetColor();
		}
		private void ApplyColor(Colors color)
		{
			switch(color)
			{
				case Colors.Blue:
					{
						Console.ForegroundColor = ConsoleColor.Blue;
						break;
					}
				case Colors.Red:
					{
						Console.ForegroundColor = ConsoleColor.Red;
						break;
					}
				case Colors.Yellow:
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						break;
					}
				case Colors.Cyan:
					{
						Console.ForegroundColor = ConsoleColor.Cyan;
						break;
					}
				case Colors.Magenta:
					{
						Console.ForegroundColor = ConsoleColor.Magenta;
						break;
					}
				default:
					{
						Console.ForegroundColor = ConsoleColor.White;
						break;
					}

			}
		}
	}
}
