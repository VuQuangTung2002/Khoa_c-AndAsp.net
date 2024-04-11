class Hello
{
    //hàm tạo có tham số truyền vào. Tên hàm tạo trùng với tên class
    public Hello(string str)
    {
        Console.WriteLine(str);
    }
}
class Program
{
    static void Main()
    {
        Hello h = new Hello("Hello every body");
    }
}