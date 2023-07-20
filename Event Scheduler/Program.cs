
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var eventtime = new TimeOnly[10];
        eventtime[0] = new TimeOnly(7, 0);
        eventtime[1] = new TimeOnly(16, 0);
        eventtime[2] = new TimeOnly(12, 0);
        eventtime[3] = new TimeOnly(17, 0);
        eventtime[4] = new TimeOnly(10, 30);
        eventtime[5] = new TimeOnly(14, 0);
        eventtime[6] = new TimeOnly(9, 30);
        eventtime[7] = new TimeOnly(20, 45);
        eventtime[8] = new TimeOnly(11, 50);
        eventtime[9] = new TimeOnly(15, 0);

        var eventname = new string[10];
        eventname[0] = "meetingBing";
        eventname[1] = "meetingGoogle";
        eventname[2] = "meetingFacebook";
        eventname[3] = "meetingMicrosoft";
        eventname[4] = "meetingOracl";
        eventname[5] = "meetingAmazon";
        eventname[6] = "meetingApple";
        eventname[7] = "meetingSamsung";
        eventname[8] = "meetingTesla";
        eventname[9] = "meetingNasa";


        Console.WriteLine();
    ccc:
        Console.Clear();
        Console.WriteLine("1.Eventlarni saralash");
        Console.WriteLine("2.Eventni nomi bo'yicha topish");
        Console.WriteLine("3.Eventni vaqti bo'yicha topish ");
        Console.WriteLine("4.Kelayotgan eventlarni ko'rsatish");
        Console.WriteLine("5.O'tib ketgan eventlarni ko'rsatish");
        Console.WriteLine("6.Kelayotgan eventlarni ko'rsatish(yaqinligi bo'yicha)");
        Console.WriteLine("7.O'tib ketgan eventlarni ko'rsatish(yaqinligi bo'yicha)");
        Console.WriteLine("8.dasturni yopish");
        char choose = Console.ReadKey().KeyChar;
        switch (choose)
        {
            case '1':
            zzz:
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("1.Eventlarni nomi bo'yicha saralash");
                Console.WriteLine("2.Eventlarni vaqti bo'yicha saralash");
                Console.WriteLine("0<-ortga");
                char chooseA = Console.ReadKey().KeyChar;
                switch (chooseA)
                {
                    case '1':
                        Console.WriteLine();
                    eee:
                        Console.Clear();
                        Console.WriteLine("1.O'sish");
                        Console.WriteLine("2.kamayish");
                        Console.WriteLine("0.<-ortga");
                        char chooseB = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        switch (chooseB)
                        {

                            case '1':
                                Console.Clear();
                                var temp = "";
                                for (var i = 0; i < eventname.Length - 1; i++)
                                {
                                    for (var j = i + 1; j < eventname.Length; j++)
                                    {
                                        int camValueA = eventname[i].CompareTo(eventname[j]);
                                        if (camValueA < 0)
                                        {
                                            temp = eventname[i];
                                            eventname[i] = eventname[j];
                                            eventname[j] = temp;
                                        }
                                    }
                                }
                                foreach (var item in eventname)
                                    Console.WriteLine(item);
                                Console.WriteLine("0<-ortga");
                                char a = Console.ReadKey().KeyChar;
                                goto eee;

                            case '2':
                                Console.Clear();
                                var tempB = "";
                                for (var i = 0; i < eventname.Length - 1; i++)
                                {
                                    for (var j = i + 1; j < eventname.Length; j++)
                                    {
                                        int camValueB = eventname[i].CompareTo(eventname[j]);
                                        if (camValueB > 0)
                                        {
                                            tempB = eventname[i];
                                            eventname[i] = eventname[j];
                                            eventname[j] = tempB;
                                        }
                                    }
                                }
                                foreach (var item in eventname)
                                    Console.WriteLine(item);
                                Console.WriteLine("0<-ortga");
                                char b = Console.ReadKey().KeyChar;
                                goto eee;

                            case '0':
                                goto zzz;

                            default: Console.WriteLine("bunday tallov mavjud emas"); break;
                        }
                        Console.WriteLine();
                        break;
                    case '2':
                        Console.WriteLine();
                    fff:
                        Console.Clear();
                        Console.WriteLine("1.O'sish");
                        Console.WriteLine("2.kamayish");
                        Console.WriteLine("0.<-ortga");
                        char chooseC = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        switch (chooseC)
                        {

                            case '1':
                                Console.Clear();
                                var tempC = new TimeOnly();
                                for (var i = 0; i < eventtime.Length - 1; i++)
                                {
                                    for (var j = i + 1; j < eventtime.Length; j++)
                                    {

                                        if (eventtime[i] > eventtime[j])
                                        {
                                            tempC = eventtime[i];
                                            eventtime[i] = eventtime[j];
                                            eventtime[j] = tempC;
                                        }
                                    }
                                }
                                foreach (var item in eventtime)
                                    Console.WriteLine(item);
                                Console.WriteLine("0<-ortga");
                                char a = Console.ReadKey().KeyChar;
                                goto fff;

                            case '2':
                                Console.Clear();

                                var tempB = new TimeOnly();
                                for (var i = 0; i < eventtime.Length - 1; i++)
                                {
                                    for (var j = i + 1; j < eventtime.Length; j++)
                                    {

                                        if (eventtime[i] < eventtime[j])
                                        {
                                            tempB = eventtime[i];
                                            eventtime[i] = eventtime[j];
                                            eventtime[j] = tempB;
                                        }
                                    }
                                }
                                foreach (var item in eventtime)
                                    Console.WriteLine(item);
                                Console.WriteLine("0<-ortga");
                                char b = Console.ReadKey().KeyChar;
                                goto fff;

                            case '0':
                                goto zzz;

                            default: Console.WriteLine("bunday tallov mavjud emas"); break;
                        }
                        Console.WriteLine();
                        break;
                    case '0':
                        goto ccc;
                    default: Console.WriteLine("bunday tallov mavjud emas"); break;
                }
                break;

            case '2':
                Console.WriteLine();
            ggg:
                Console.Clear();
                Console.Write("search: ");
                var eventvalue = Console.ReadLine();
                bool chackA = eventname.Contains(eventvalue);

                if (chackA)
                    Console.WriteLine(eventvalue + "find");
                else
                    Console.WriteLine("not found");

                Console.WriteLine("n<-ortga");
                Console.WriteLine("y-yana qidirish");

                char nullchooseA = Console.ReadKey().KeyChar;
                if (nullchooseA == 'y')
                    goto ggg;
                if (nullchooseA == 'n')
                    goto ccc;
                break;

            case '3':
                Console.WriteLine();
            ttt:
                Console.Clear();
                Console.WriteLine("search: ");

                var eventvalueA = new TimeOnly[10];
                int hour = int.Parse(Console.ReadLine());
                int minut = int.Parse(Console.ReadLine());
                for (int i = 0; i < eventvalueA.Length; i++)
                {
                    eventvalueA[i] = new TimeOnly(hour, minut);
                }

                for (int i = 0; i < eventtime.Length - 1; i++)
                {
                    for (int j = i + 1; j < eventtime.Length; j++)
                    {
                        if (eventtime[i] == eventvalueA[j])
                        {
                            Console.WriteLine(eventtime[i] + " found"); break;
                        }
                        else if (eventtime[i] != eventvalueA[j])
                        {
                            continue;
                            
                        }
                        Console.WriteLine("not found"); break;

                    }
                }

                Console.WriteLine("n<-ortga");
                Console.WriteLine("y-yana qidirish");

                char nullchoose = Console.ReadKey().KeyChar;
                if (nullchoose == 'y')
                    goto ttt;
                if (nullchoose == 'n')
                    goto ccc;
                break;

            case '4':
                Console.Clear();
                Console.WriteLine();

                DateTime dateTime = DateTime.Now;
                for(int i = 0;i < eventtime.Length; i++)
                {
                    
                    if (eventtime[i].Hour < dateTime.Hour)
                    {
                        Console.WriteLine(eventtime[i]);
                    }
                }
                Console.WriteLine("0<-ortga");

                char nullchooseC = Console.ReadKey().KeyChar;
                if (nullchooseC == '0')
                    goto ccc;
                break;
            
            case '5':
                Console.Clear();
                Console.WriteLine();

                DateTime dateTimeA = DateTime.Now;
                for (int i = 0; i < eventtime.Length; i++)
                {

                    if (eventtime[i].Hour > dateTimeA.Hour)
                    {
                        Console.WriteLine(eventtime[i]);
                    }
                }
                Console.WriteLine("0<-ortga");

                char nullchooseX = Console.ReadKey().KeyChar;
                if (nullchooseX == '0')
                    goto ccc;
                break;

            case '6':
                Console.Clear();
                Console.WriteLine();

                var tempE = new TimeOnly();
                for (var i = 0; i < eventname.Length - 1; i++)
                {
                    for (var j = i + 1; j < eventname.Length; j++)
                    {

                        if (eventtime[i] > eventtime[j])
                        {
                            tempE = eventtime[i];
                            eventtime[i] = eventtime[j];
                            eventtime[j] = tempE;
                        }
                    }
                }
                DateTime dateTime1 = DateTime.Now;

                for (int i = 0;i < eventtime.Length; i++)
                {
                    if(dateTime1.Hour > eventtime[i].Hour)
                        Console.WriteLine(eventtime[i]);
                }

                Console.WriteLine("0<-ortga");

                char nullchooseN = Console.ReadKey().KeyChar;
                if (nullchooseN == '0')
                    goto ccc;
                break;
            
            case '7':
                Console.Clear();
                Console.WriteLine();

                var tempH = new TimeOnly();
                for (var i = 0; i < eventname.Length - 1; i++)
                {
                    for (var j = i + 1; j < eventname.Length; j++)
                    {

                        if (eventtime[i] < eventtime[j])
                        {
                            tempE = eventtime[i];
                            eventtime[i] = eventtime[j];
                            eventtime[j] = tempE;
                        }
                    }
                }
                DateTime dateTime2 = DateTime.Now;

                for (int i = 0; i < eventtime.Length; i++)
                {
                    if (dateTime2.Hour < eventtime[i].Hour)
                        Console.WriteLine(eventtime[i]);
                }

                Console.WriteLine("0<-ortga");

                char nullchooseK = Console.ReadKey().KeyChar;
                if (nullchooseK == '0')
                    goto ccc;
                break;
            
            case '8':
                return;
            
            default:
                Console.WriteLine("bunday tallov mavjud emas");
                break;
        }
    }
}