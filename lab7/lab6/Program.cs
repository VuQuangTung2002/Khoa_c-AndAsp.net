// See https://aka.ms/new-console-template for more information
namespace  lab6;
class Hello{
    public void sayHello1(){
        Console.WriteLine("hello world");
    }
    // tao ham co tu khoa la static 
    public static void sayhello2(){
        Console.WriteLine("hello 2");
    }
}
class Program{
    public static void Main()
    {
        // de goi ham ko co
        Hello ob1 = new Hello();
        ob1.sayHello1();
        Hello.sayhello2();
         
    }
}