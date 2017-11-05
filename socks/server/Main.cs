using System;


public class _Main{
	public static void Main(string[] args){
		Console.Write(":)\n");
		Clients c = new Clients();
		int i = 0;
		while(i<10){
			Console.Write("Added {0}{1}", c.add(),"\n");

			i++;
		}
		//c.add();

	}
}

