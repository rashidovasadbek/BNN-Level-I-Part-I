﻿using problem;
using System;
using System.Runtime.CompilerServices;

List<Student> student = new List<Student>()
{
   new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  BirthDay = new DateTime(2004, 1, 17),  EduType = "Python", Payment = 1600000, PaymentAmount = 500000 },
    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  BirthDay = new DateTime(2003, 12, 12),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 3000000 },
    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  BirthDay = new DateTime(2003, 11, 1),  EduType = "SMM", Payment = 1450000, PaymentAmount = 2500000 },
    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  BirthDay = new DateTime(2006, 7, 18),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 0 },
    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "SMM", Payment = 1450000, PaymentAmount = 900000 },
    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  BirthDay = new DateTime(2007, 4, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  BirthDay = new DateTime(2005, 8, 1),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2500000 },
    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  BirthDay = new DateTime(2002, 1, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1500000 },
    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  BirthDay = new DateTime(2001, 3, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 1900000 },
    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  BirthDay = new DateTime(2003, 5, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1700000 },
    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  BirthDay = new DateTime(2006, 2, 7),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  BirthDay = new DateTime(2003, 5, 6),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2700000 },
    new Student(){ Id = 15, FullName = "To'rayev Dinur Alisher O'g'li",  BirthDay = new DateTime(2002, 8, 22),  EduType = "Python", Payment = 1600000, PaymentAmount = 2000000 },
    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  BirthDay = new DateTime(2000, 11, 20),  EduType = "SMM", Payment = 1450000, PaymentAmount = 1400000 },
    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  BirthDay = new DateTime(2005, 2, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  BirthDay = new DateTime(2006, 5, 9),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2400000 },
};
int[,] balls = new int[,]
{
    { 90, 100, 75, 60 },
    { 100, 100, 70, 1},
    { 90, 50, 60, 100 },
    { 60, 50, 100, 90 },
    { 100, 10, 75, 45 },
    { 55, 85, 70, 60 },
    { 95, 90, 40, 100 },
    { 80, 100, 100, 40 },
    { 65, 80, 100, 50 },
    { 80, 90, 100, 60 },
    { 90, 85, 65, 55 },
    { 100, 55, 90, 100 },
    { 80, 75, 90, 60 },
    { 90, 90, 100, 55 },
    { 100, 60, 90, 75 },
    { 90, 80, 50, 100 },
    { 100, 100, 60, 60 },
    { 90, 50, 80, 90 },
};

aaa:
Console.WriteLine("1.Talabalar ro'yhati:");
Console.WriteLine("2.To'lovlar");
Console.WriteLine("3.Talabalar baxosi");

Console.WriteLine("0.<-orqaga");

var choose = Console.ReadKey().KeyChar;
Console.WriteLine("");

switch (choose)
{
    case '1':
        Console.Clear();
        zzz:
        Console.WriteLine("1 - dotnet");
        Console.WriteLine("2 - Dizayn");
        Console.WriteLine("3 - SMM");
        Console.WriteLine("4 - Python");
        Console.WriteLine("5.Talaba qo'shish ");
        Console.WriteLine("6.Talaba o'chirish");
        Console.WriteLine("0 <-orqaga");
        
        var choosefakulty  = Console.ReadKey().KeyChar;
        switch (choosefakulty)
        {
            
            case '1':
                Console.Clear();
                foreach (var item in student)
                {
                    if (item.EduType.Equals("DotNET"))
                    {
                        Console.WriteLine($"{item.Id} - {item.FullName}-{item.GetAge()} yosh");
                    }
                }
          
                Console.WriteLine("0 <-orqaga");      
                goto zzz;
                
            case '2':
                Console.Clear();
                foreach (var item in student)
                {
                    if (item.EduType.Equals("Dizayn"))
                    {
                        Console.WriteLine($"{item.Id} - {item.FullName}-{item.GetAge()} yosh");
                    }
                }
                Console.WriteLine("0 <-orqaga");
                goto zzz;
                 
            case '3':
                Console.Clear();
                foreach (var item in student)
                {
                    if (item.EduType.Equals("SMM"))
                    {
                        Console.WriteLine($"{item.Id} - {item.FullName}-{item.GetAge()} yosh");
                    }
                }
                Console.WriteLine("0 <-orqaga");
                goto zzz;
            
            case '4':
                Console.Clear();
                foreach (var item in student)
                {
                    if (item.EduType.Equals("Python"))
                    {
                        Console.WriteLine($"{item.Id} - {item.FullName}-{item.GetAge()} yosh");
                    }
                }
                Console.WriteLine("0 <-orqaga");
                goto zzz;
               
            case '5':
                Console.Clear();
                
                Console.WriteLine();
                Console.WriteLine("FIO: ");
                string FIO = Console.ReadLine();
                Console.WriteLine("Yo'nalish: ");
                string eduType = Console.ReadLine();
                Console.WriteLine("Birthday: ");
               
                var yil = int.Parse(Console.ReadLine());
                var oy = int.Parse(Console.ReadLine());
                var kun = int.Parse(Console.ReadLine());
                var birthDay = new DateTime(yil,oy,kun);
            
                student.Add(new Student
                {
                    Id = student.Last().Id + 1,
                    FullName = FIO,
                    BirthDay = birthDay,
                    EduType = eduType
                }) ;
                Console.WriteLine("0<-orqaga");
                char chooseA = Console.ReadKey().KeyChar; 
                if(chooseA == '0')
                    goto zzz;
                break;

            case '6':
                Console.WriteLine("O'chiriladigan talabani id kiriting:");
                var id = int.Parse(Console.ReadLine());
                student.RemoveAt(id);
                Console.WriteLine($"{id} dagi talaba o'chirildi");
                Console.WriteLine("0 <-orqaga");
                goto zzz;
                break;
            
            case '0':
                Console.Clear();
                goto aaa;
            
            default:
                Console.Clear ();
                Console.WriteLine("invalid choose!");
                break;
        }
        break;
    
    case '2':
        Console.WriteLine("1.DotNet");
        Console.WriteLine("2.SMM");
        Console.WriteLine("3.Dizayn");
        Console.WriteLine("4.Python");

        var chooseC = Console.ReadKey().KeyChar;
        switch (chooseC)
        {
            case '1':
                foreach (var item in student)
                {
                    item.GetTableAmount(item, item.EduType);
                }
              break;
            case '2':
                foreach (var item in student)
                {
                    item.GetTableAmount(item, item.EduType);
                }
                break;
            case '3':
                foreach (var item in student)
                {
                    item.GetTableAmount(item, item.EduType);
                }
                break;
            case '4':
                foreach (var item in student)
                {
                    item.GetTableAmount(item, item.EduType);
                }
                break;

        }
        break;
    
    case '3':
        Console.Clear();

        Console.Write("".PadLeft(48));
        for (int i= 1; i < 5; i++)
        {   
            Console.ForegroundColor = ConsoleColor.Green;
            string sana = $"{i}/07";
            Console.Write($"{sana}\t\t");
            
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 0; i < 17; i++)
        {
            Console.Write($"{student[i].GetShotName()}");
            for (int j = 0; j < 4; j++)
                Console.Write($"\t{balls[i, j]}\t");

            Console.WriteLine("\n");
        }
        break;
    
    case '4':

        
   
        break;
}



