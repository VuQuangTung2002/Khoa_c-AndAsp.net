namespace lab7;
//muốn import file Hello.cs trong thư mục MyClass thì sử dụng cú pháp sau:
using lab7.MyClass;//khi đó có thể import được các file trong thư mục MyClass vào đây
class Program
{
    public static void Main()
    {
        Hello.sayHello();
    }
}