﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Deck_Of_Cards
{
    public class WriteClass : IWriteClass
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
		public void Clear()
		{
			Console.Clear();
		}
		public void ReadLine()
		{
			Console.ReadLine();
		}
		public string Input()
		{
			return Console.ReadLine();
		}
		public void BlankLine()
		{
			Console.WriteLine();
		}
		public void Deliminter()
		{
			WriteLine(Colors.None, "============================================================= ");
		}
		public void Write(Colors color,  string body )
		{
			Console.ResetColor();
			this.ApplyColor(color);
			Console.Write(body);

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
