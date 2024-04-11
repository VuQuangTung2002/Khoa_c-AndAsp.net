//định nghĩa class Car
class Car
{
    //định nghĩa các biến thuộc class (các thuộc tính trong class)
    public string color;
    public string brand;
    /*
        - Đặt tên biến theo cách khác:
        public string color{get;set;}
    */
    // khi các biến có cùng kiểu dữ liệu thì có thể định nghĩa như sau: public string color, brand;
    //hàm trong class (gọi là phương thức) về bản chất giống một hàm trong c#
    public void setInfo(string c, string b)
    {
        //để tác động vào biến trong class, sử dụng cú pháp: this.tenbien
        this.brand = b;
        this.color = c;
    }
    public void displayInfo()
    {
        Console.WriteLine($"Brand: {this.brand} - Color: {this.color}");
    }
    //hàm tạo là hàm mặc định được triệu gọi khi khởi tạo đối tượng
    public Car()
    {
        Console.WriteLine("Ham tao duoc tu dong trieu goi dau tien");
    }
}
class Program
{
    static void Main()
    {
        //tạo đối tượng cụ thể của class -> gọi là object. Cú pháp: TenClass doituong = new TenClass();
        Car car1 = new Car();
        //gọi hàm setInfo và truyền các giá trị vào hàm
        car1.setInfo("Green","BMW");
        car1.displayInfo();
        //---
        Car car2 = new Car();
        car2.setInfo("Yellow","Toyota");
        car2.displayInfo();
    }
}