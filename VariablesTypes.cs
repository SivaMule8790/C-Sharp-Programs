using System;
class VariablesTypes{
	int x=23, y=45; //Instance
	static int p=33, q=33; //static
	const int b=7; //constant
	readonly int c=6; // Readonly
	void local(){  // Local
		int d=356;
		Console.WriteLine(d);
	}
	
	
	static void Main(string[] args){
		VariablesTypes v1=new VariablesTypes();
		Console.WriteLine(v1.y);
		Console.WriteLine(v1.x);
		Console.WriteLine(p-q);
		Console.WriteLine(v1.c);
		v1.local();
		
	}
}
		