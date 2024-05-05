using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        class Utils
        {
            public void Print(string message)
            {
                Console.WriteLine(message);
            }

            public void Pause(int milliseconds)
            {
                Thread.Sleep(milliseconds);
            }
        }
        static void Main(string[] args)
        {
            Utils utils = new Utils();

            utils.Print("Пример использования методов Print и Pause:");
            utils.Pause(2000); 
            utils.Print("Приостановка завершена.");
            
            string Name ="Иван";
            string surname="Новитов";
            int age= 34;
            int height =180;
            int weight =80;

            
Client cli=new Client();
            cli.Name=Name;
            cli.surname=surname;
            cli.age =age;
            cli.height=height;
            cli.ToString();
            IMT y = new IMT();
            y.H = 200;
            y.M = 80;
            y.iny();
 SUM1 s = new SUM1();
            s.X1 = 1;
            s.X2 = 5;
            s.Y1 = 8;
            s.Y2 = 10;
            s.SUM();
            exchange1 e = new exchange1();
            e.x1 = 20;
            e.x2 = 36;
            e.exchange2();

            Client3 c3 =new Client3();
            c3.name = "iva";
            c3.lastName = "hovan";
            c3.city = "kazan";
            c3.PrintCentered();
        }
    }


    /// 1

    public class Client
        {
            public string Name { get; set; }
            public string surname { get; set; }
            public  int age { get; set; }
            public int height { get; set; }
            public int weight { get; set; }

            public  void ToString()
            {
            // склеивание
                Console.WriteLine(Name + "" + surname + "" + age + "" + height + "" + weight);
                //форматированный 
                Console.WriteLine("{ 1} { 2} { 3} { 4} { 5}", Name , surname , age , height , weight);
                //вывод со знаком $
                Console.WriteLine($"{Name} {surname} {age} {height} {weight}");

            }
               
        }
        //2
        public class IMT{
            public int H{ get; set; }
            public int M{ get; set; }
            public void iny()
            {
                int I = M / (H * H);
                Console.WriteLine("I=m/(h*h)=",I);
              

            }
        }
        //3
        public class SUM1
        {
            public int  X1{ get; set; }
            public int X2 { get; set; }
            public int Y1 { get; set; }
            public int Y2 { get; set; }
            public void SUM()
            {
                double R = Math.Sqrt(Math.Pow(X2 - X1,2) + Math.Pow(Y2 - Y1,2));
                Console.WriteLine("R = Math.Sqrt(Math.Pow(X2 - X1,2) + Math.Pow(Y2 - Y1,2))=", R);


            }
        }
        //4
        public class exchange1
        {
            public int x1 { get; set; }
            public int x2 { get; set; }
            
            public void exchange2()
            {
                //a
                int x3;
               x3 =x1;
                x1 = x2;
                x2 = x3;
                Console.WriteLine("x1:{0},x2:{1}",x1,x2);
                //b
                x1 = x2 ;
                x2 = x1;
                Console.WriteLine("x1:{0},x2:{1}", x1, x2);

            }
        }
        //5
       
    public class Client3
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }

        
    
    public void PrintCentered()
    {
        string message ="{name} {lastName}  {city}";
        int screenWidth = Console.WindowWidth;
        int messageWidth = message.Length;

        int leftIndent = (screenWidth - messageWidth) / 2;
        Console.SetCursorPosition(leftIndent, Console.CursorTop);
        Console.WriteLine(message);
    }
    }
    }
