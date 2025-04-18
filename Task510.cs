using System;
public abstract class Book{
    private string title;
    public string ti{
        get{return title;}
        set{ title=value;}
    }
    public abstract string set(string Title);
}
class c1:Book{
    public override string set(string Title){
        ti=Title;
        return ti;
    }
    static void Main(){
        c1 obj=new c1();
        obj.ti="A tale of two cities";
        Console.WriteLine("The title is: "+obj.set(obj.ti));
    }
}
/*
A Java abstract class is a class that can't be instantiated. That means you cannot create new instances of an abstract class. 
It works as a base for subclasses. You should learn about Java Inheritance before attempting this challenge.
Following is an example of an abstract class:
abstract class Book{
String title;
abstract void setTitle(String s);
String getTitle(){
return title;
}
}
If you try to create an instance of this class like the following line you will get an error:
Book new_novel=new Book();
You have to create another class that extends the abstract class. Then you can create an instance of the new class. 
Notice that the setTitle method is abstract too and has no body. 
That means you must implement the body of that method in the child class.
In the editor, we have provided the abstract Book class and a Main class. In the Main class, 
we created an instance of a class called MyBook. Your task is to write just the MyBook class.
Your class mustn't be public.
Sample Input
A tale of two cities
Sample Output
The title is: A tale of two cities
*/