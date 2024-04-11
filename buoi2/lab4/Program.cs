class PhepTinh //đặt tên biến theo quy tắc pascal
{
    public int so1 { get; set; }//đặt tên biến theo quy tắc camel, snake
    public int so2 { get; set; }
    //hàm tạo
    public PhepTinh(int s1, int s2)
    {
        this.so1 = s1;
        this.so2 = s2;
    }
    public void Cong()//đặt tên hàm theo quy tắc pascal
    {
        var ket_qua = so1 + so2;//khi không biết trước kiểu dữ liệu thì sử dụng từ khóa var
        Console.WriteLine($"{this.so1} + {this.so2} = {ket_qua}");
    }
    public void Tru()//đặt tên hàm theo quy tắc pascal
    {
        var ket_qua = so1 - so2;//khi không biết trước kiểu dữ liệu thì sử dụng từ khóa var
        Console.WriteLine($"{this.so1} - {this.so2} = {ket_qua}");
    }
    public void Nhan()//đặt tên hàm theo quy tắc pascal
    {
        var ket_qua = so1 * so2;//khi không biết trước kiểu dữ liệu thì sử dụng từ khóa var
        Console.WriteLine($"{this.so1} * {this.so2} = {ket_qua}");
    }
    public void Chia()//đặt tên hàm theo quy tắc pascal
    {
        var ket_qua = so1 / so2;//khi không biết trước kiểu dữ liệu thì sử dụng từ khóa var
        Console.WriteLine($"{this.so1} / {this.so2} = {ket_qua}");
    }
}
class Program
{
    public static void Main()
    {
        PhepTinh phep_tinh = new PhepTinh(5,3);
        phep_tinh.Cong();
        phep_tinh.Tru();
        phep_tinh.Nhan();
        phep_tinh.Chia();
    }
}