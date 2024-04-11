namespace lab9;
class Students
{
    public string name { get; set; }
    public string email { get; set; }
}
class Program
{
    public static void Main()
    {
        //tạo biến kiểu List
        List<Students> list_students = new List<Students>();
        bool flag = true;
        do
        {
            Console.WriteLine("-----");
            Console.WriteLine("1. Exit");
            Console.WriteLine("2. Create");
            Console.WriteLine("3. Read");
            Console.WriteLine("4. Delete");
            Console.WriteLine("-----");
            try
            {
                Console.Write("Ban chon chuc nang: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice){
                    case 1: flag = false; break;
                    case 2: Create(list_students); break;
                    case 3: Read(list_students); break;
                    case 4: Delete(list_students); break;
                }
            }catch{ Console.WriteLine("De nhi nhap dung thong tin"); }
        }while(flag == true);
    }
    //Create
    public static void Create(List<Students> list_students)
    {
        Console.Write("Nhap ten sinh vien: ");
        string str_name = Console.ReadLine();
        Console.Write("Nhap email: ");
        string str_email = Console.ReadLine();
        //tạo một đối tượng sinh viên
        Students obj = new Students(){name = str_name, email = str_email};
        //thêm vào thành một phần tử của biến list_students
        list_students.Add(obj);
    }
    public static void Read(List<Students> list_students)
    {
        Console.WriteLine("Ho ten \t\t\t Email");
        foreach(var item in list_students)
        {
            Console.WriteLine($"{item.name} \t\t {item.email}");
        }
    }
    public static void Delete(List<Students> list_students)
    {
        Console.Write("Nhap email cua sinh vien can xoa: ");
        string str_email = Console.ReadLine();
        foreach(var item in list_students)
        {
            if(item.email == str_email)
            {
                //xóa phần tử tương ứng với email
                list_students.Remove(item);
            }
        }
    }
}