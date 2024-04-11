//trong c# thường sẽ đặt namespace cho các class. Namespace dùng để phân biệt các class khi nó trùng tên nhau. Thường tên namespace sẽ trùng với tên folder project
namespace lab6;
class Hello
{
    public void sayHello1()
    {
        Console.WriteLine("Hello world");
    }
    //tạo hàm có từ khóa static
    public static void sayHello2()
    {
        Console.WriteLine("Hello 2024");
    }
}
class Program
{
    static void Main()
    {
        //để gọi hàm (không có từ khóa static) thì phải tạo đối tượng mới gọi được hàm trong class đó
        var obj1 = new Hello();
        obj1.sayHello1();
        //muốn từ tên class gọi thẳng tên hàm mà không cần khởi tạo đối tượng của class thì sử dụng từ khóa static ở đầu tên hàm
        Hello.sayHello2();
    }
}
