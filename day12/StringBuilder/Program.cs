
using System;
using System.Text;

class Program {
	static void Main() {
		
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < 100000000; i++) {
			sb.Append("a");
			sb.Append("b");
			sb.Replace('a', 'c');
		}
	}
}
