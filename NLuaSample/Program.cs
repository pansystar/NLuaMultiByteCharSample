using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLuaSample
{
	class Program
	{
		public static void Main(string[] args)
		{
			NLua.Lua lua = new NLua.Lua();

			// エンコードを指定すると, マルチバイト文字でも
			// 返り値が正常な文字列になる
			lua.State.Encoding = Encoding.UTF8;

			var resultDoString = lua.DoString("return 'あいうえお', 'かきくけこ'");

			var resultDoFile = lua.DoFile("Sample.lua");

			Console.WriteLine($"# DoString結果");
			foreach (var item in resultDoString)
			{
				Console.WriteLine($"- {item}");
			}
			Console.WriteLine();
			Console.WriteLine($"# DoFile結果");
			foreach (var item in resultDoFile)
			{
				Console.WriteLine($"- {item}");
			}
		}
	}
}
