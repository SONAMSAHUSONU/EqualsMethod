/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsMethod
{
    class Program
    {
        //(==)doubleequals meunt for address compairesion of object,if object has refrence type.
        //(==)it is also compaire the value type, if it is value type then it will compaire of containt. 
        //containt means (character is Same Bhopal, bhopal  it is compaire the character)
        static void Main(string[] args)
        {
            Program p1 = new Program();// object is alocated 8 bit of memories location 
            Program p2 = new Program();
            Program p3 = p2;
            Console.WriteLine(p1==p2);// (==)double equals for address compairesion for mint 
            Console.WriteLine(p1==p3);//it is pointing same object addres
            Console.WriteLine(p3==p2);
            Console.WriteLine("==============================");
            string City = "Bhopal";
            string state = "bhopal";
            string temp = state;

            Console.WriteLine(City.Equals(state));
            Console.WriteLine(City==state);
            Console.WriteLine(temp==state);
            Console.WriteLine(temp.Equals(state)); //dot equals compair the containt it is not compait address of object
            Console.ReadLine();  
        }
    }  
}*/
//what is diffrence blw double equals and dot equals oprator?IMP
//when ever program will execute it will run in Ram and ram is bolatiyiled(Randum Access Memory) bolatiyed means when system have power it will run otherwise it is gone.
//new key when clrl when he she new keyword it will run 
//what valuetype and refrence type
//===============================================================================
//Memory location:-  we have only rame the program is run insied the ram, we have two think static or non static 
//memories-1.stack:-when we have static  variable then it is store the stack static variable is store in stack and initilized in stack.
//2.Heap:- when we have non-static variable it is create the object, and this object linke insied the heap, 
//it will store the value insied the heap and object variable inside stack also.
//by default distractor insied the heap. 
//insied the object class one more methode is thier it is called the finallized method 
//insied the memories if all opration done the clr is call by Garbage collectore and GC to notified the Distractore and Distractore call by Finallized method after callling the finilized methode memorie is clean.

/*using System;
public class Program
{
    public static int i = 20;
    public static int j = 30;
    public int k = 40;
    public int l = 50;

    public static void Main()
    {
        Program p1 = new Program();
        Program p2 = new Program();
        Program p3 = new Program();

        Console.WriteLine(i);
        Console.WriteLine(j);// static variable.
        Console.WriteLine("=============");
        Console.WriteLine(p1.k);//it is non static it will create multiple copay 
        Console.WriteLine(p1.l);//why we are using the onject here p1.l because object value store the heap and object variavle store inside the stack.
        Console.WriteLine(p2.k);
        Console.WriteLine(p2.l);
        Console.WriteLine(p3.k);
        Console.WriteLine(p3.k);
        // what is static keyword and non-static keyword?
        // static keyword is fast blc we can access the directly blc non need to create the object and non-static keyword is slow blc there we have to create the object when we create the multiple object then application performance is slow 
        // static keyword is only one-copy created insied the memory.
        //what is meaning of one copy?
        Console.ReadLine();
    }
}*/
//========================================================================================
//Is and as when is used?
//when we have to check the object is that class object then we have to create the Is and As
//Is:-In C# language, we use the "is" operator to check the object type. If two objects are of the same type, it returns true, else it returns false.

//AS:-The "as" operator behaves in a similar way as the "is" operator. The only difference is it returns the object if both are compatible with that type. Else it returns a null.

/*using System;
public class Employe
{
    public static void Main()
    {
        object obj = "lara";// it is object and it will assiend the string that is why it is string 
        if (obj is int)
        {
            Console.WriteLine("not a correct type");
        }
        else if (obj is string)
        {
            Console.WriteLine("not a string type");

        }
        else if (obj is object )
        {
            Console.WriteLine("is the object");
        }
        Console.WriteLine("is the string");//true
        Console.WriteLine("is the object");//true

        Console.ReadLine();
    }
}*/
using System;
public class Employe
{
}
public class Program
{
    public static void Main()
    {
        Employe e = new Employe();
        Program p = new Program();
        string name = "Kavi";
        int age = 30;
        Console.WriteLine(p is Employe);//False
        Console.WriteLine(e is Program);//False
        Console.WriteLine(p is Program);//True
        Console.WriteLine(name is string);//True
        Console.WriteLine(age);
        Console.ReadLine();


    }
}
