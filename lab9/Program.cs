using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Net.Http.Headers;
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
using System;
using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information

namespace lab9;
class Student{
    public string name{get;set;}
    public string email{get;set;}

    
}
class Program{
    // tao bien kieu list

    
    public static void Main(){
    List<Student> list_student = new List<Student>();    
    bool flag = true;
    do{
        Console.WriteLine("-------");
        Console.WriteLine("1. exit");
        Console.WriteLine("2. create");
        Console.WriteLine("3. read");
        Console.WriteLine("-------");
        try{
            Console.WriteLine("ban chon chuc nang ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                flag = false;
                break;
                case 2:
                Create(list_student);
                break;
                case 3:
                Read(list_student);
                break;
                case 4:
                Delete(list_student);
                break;
            }
        }
        catch{
        Console.WriteLine("de nhap dung thong tin");
        }
        
        }
        while(flag == true);
    }
    public static void Create(List<Student> list_student){
        Console.WriteLine("nhap ten sinh vien :");
        string str_name = Console.ReadLine();
         Console.WriteLine("nhap email :");
        string str_email = Console.ReadLine();
        Student obj = new Student(){
            name = str_name, email = str_email
        };
        list_student.Add(obj);
    }
    public static void Read(List<Student> list_student){
        Console.WriteLine("ho ten \t \t email :");
        foreach(var x in list_student){
            Console.WriteLine($"{x.name} \t \t {x.email}");
        }
    }
    public static void Delete(List<Student> list_student){
        Console.WriteLine("xoa nhan vien");
        string str_email = Console.ReadLine();
        foreach(var x in list_student){
            if( x.name == str_email){
            list_student.Remove(x);
            }
        }
    }
}