/*
    - Tính kế thừa
        - class B kế thừa class A có nghĩa là class B có thể sử dụng được các hàm, biến của class A (tùy thuộc tầm vực của biến)
    - Tầm vực của biến
        - public
            - từ ngoài class tác động được vào hàm, biến bên trong hàm đó
            - từ class kế thừa có thể tác động được vào hàm, biến của class được kế thừa
            - tác động được ở trong chính class đó
        - protected
            - từ ngoài class không tác động được vào hàm, biến bên trong hàm đó
            - từ class kế thừa có thể tác động được vào hàm, biến của class được kế thừa
            - tác động được ở trong chính class đó
        - private
            - từ ngoài class không tác động được vào hàm, biến bên trong hàm đó
            - từ class kế thừa không thể tác động được vào hàm, biến của class được kế thừa
            - tác động được ở trong chính class đó
*/
public class A
{
    public string varible_a1 = "Bien cua class A";
    public void Function_A1()
    {
        Console.WriteLine("Ham A1 cua class A");
    }
    public void Hello()
    {
        Console.WriteLine("Class A: Hello world");
    }
}
//class B kế thừa class A theo cú pháp: class B : A{}
public class B : A{
    //hàm tạo
    public string varible_a1 = "Bien cua class B";
    public B()
    {
        //do class B kế thừa class A nên từ class B có thể gọi các hàm, biến của class A (tùy thuộc tầm vực của biến)
        //gọi đến hàm, biến của class A
        Console.WriteLine(base.varible_a1);
        Console.WriteLine(this.varible_a1);
        base.Function_A1();
        //gọi hàm Hello thì sẽ ưu tiên gọi hàm Hello của class B (vì khởi tạo object của class B nên nó sẽ ưu tiên hàm trong class khởi tạo object)
        this.Hello();
        //để gọi lên hàm Hello của class A thì dùng từ khóa base
        base.Hello();
    }
    public void Hello()
    {
        Console.WriteLine("Class B: Hello world");
    }
}
class Program
{
    public static void Main()
    {
        B obj = new B();
        //obj.Function_A1();
    }
}