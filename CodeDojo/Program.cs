/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 19/02/2015
 * Time: 13:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace CodeDojo
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			IList results = Anagram.Anagram.Process("string");
			int i = 1;
			foreach(string result in results)
			{
				Console.WriteLine((i++).ToString() + " = " + result);
			}
						
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}