using System;
class CopiedConstuctor{
    private string name;
    private int marks;
    CopiedConstuctor(string name, int marks){
        this.name=name;
        this.marks=marks;
    }
    public string display{
        get{
            return "name is "+name+" marks is "+marks.ToString();
        }
    }
    CopiedConstuctor(CopiedConstuctor c){
        name=c.name;
        marks=c.marks;
    }
    static void Main(){
        CopiedConstuctor c1=new CopiedConstuctor("siva",78);
        CopiedConstuctor c2=new CopiedConstuctor(c1);
        Console.WriteLine(c2.display);
    }
}