using System.Threading;
using System.Diagnostics;
using System;
using System.Runtime.CompilerServices;
using System.Globalization;
// See https://aka.ms/new-console-template for more information

public class A{
    public string varible = "bien cua class a";
    public void Function(){
        Console.WriteLine("Ham A1 cua class A");
    }
}
public class B:A{
    public B(){
        Console.WriteLine(this.varible);
        this.Function();
    }
}
class Program
{
    public static void Main(){
        B obj = new B();
    }
}