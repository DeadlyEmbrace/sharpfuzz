using System.IO;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharpFuzz;

namespace Microsoft.CodeAnalysis.CSharp.Fuzz
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Fuzzer.Run(() =>
			{
				var text = File.ReadAllText(args[0]);
				var tree = CSharpSyntaxTree.ParseText(text);
				var root = (CompilationUnitSyntax)tree.GetRoot();
			});
		}
	}
}
