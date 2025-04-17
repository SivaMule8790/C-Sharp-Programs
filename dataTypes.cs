using System;
class ps1{
	static void Main(string[] args){
		Console.WriteLine("hh");
		Int32 a=5;
		double b=54;
		char c='s';
		string d="fnfn";
		bool e=true;	
		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.WriteLine(c);
		Console.WriteLine(d);
		Console.WriteLine(e);
		//Conversions
		double db=a; //implict
		Console.WriteLine(db);
		double db1=45.44;
		Int32 a1=(int) db1; //explict
		Console.WriteLine(a1);
		Console.WriteLine(Convert.ToInt32(db)); //explict using method
	}
}

