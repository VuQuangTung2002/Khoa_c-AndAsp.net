using System.Drawing;
// See https://aka.ms/new-console-template for more information
class Car{
    // dinh nghia cac bien thuoc class (cac thuoc tinh thuoc class)
    public string color;
    public string brand;
    public void setinfo(string c, string b){
        this.brand = b;
        this.brand =c;
    }
    public void display(){
        Console.WriteLine($"Brand : {this.brand}- color : {this.color}");
    }
    // ham tao khong tham so
    // ham tao co tham so
    public Car(){
    }
}
class Program{
    static void Main(){
    Console.WriteLine("Hello, World!");
    Car car1 = new Car();
    car1.setinfo("green","BMW");
    car1.display();
}
}
