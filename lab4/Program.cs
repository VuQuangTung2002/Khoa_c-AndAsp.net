// See https://aka.ms/new-console-template for more information
// tinh tong 2 so
class PhepTinh{
    public int so1 { get; set; }
    // dat ten bien tho quy tawc camel , snake
    public int so2 { get; set; }
    public PhepTinh(int s1,int s2){
        this.so1 = s1;
        this.so2 = s2;
    }
    public void tong(){
        var ket_qua = so1 + so2;
        Console.WriteLine($"{this.so1} + {this.so2} = {ket_qua}");
    }
    public void cong(){
        int tong = so1 + so2;
     Console.WriteLine($"{this.so1} + {this.so2} = {tong}");
    }
    public void tru(){
       
        var ket_qua = so1 - so2;
        
        Console.WriteLine($"{this.so1} - {this.so2} = {ket_qua} ");
    }
    // dat ten ham the
    
    
    
}
class Program{
    static void Main(){
        PhepTinh pt = new PhepTinh(5,3);
        pt.cong();
        pt.tru();
    }
}