using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            long b = 12345678901L;

            Console.WriteLine("{0}", a);
            Console.WriteLine("{0:D4}", a);//D4:자릿수를 의미
            Console.WriteLine("{0}", b);

            //Console.WriteLine("{0}", 1234567 * 1234567); 컨트롤+kc , 컨트롤 ku
            Console.WriteLine("{0}", 1234567L * 1234567);
            Console.WriteLine("--------------------------");

            float c = 1.23456789f;
            double d = 1.234567890123;

            Console.WriteLine("{0}", c);
            Console.WriteLine("{0:F2}", c); //F2:float가 소수점 이하 2자리까지
            Console.WriteLine("{0}", d);
            Console.WriteLine("--------------------------");

            char e = 'a';
            string f = "abcdefghijklmnopqrstuvwxyz";
            String g = "가나다라마바사"; //C#은 유니코드를 지원한다. char 2바이트
            Console.WriteLine("char:{0}", e);
            Console.WriteLine("string:{0}", f);
            Console.WriteLine("String:{0}", g);
            Console.WriteLine("--------------------------");

            string h = "\nUnicode Test\n";
            string i = "\u2605\u2606";

            Console.WriteLine("{0}", h);
            Console.WriteLine("\n code:{0}", i);

            //10+7
            CMyClass.Add(10, 7); //Main이 없는 CMyClass의 Add사용 하기


            //10*7
            CMyClass A = new CMyClass();
            A.Multiply(10, 7); //static이 빠졌으니 객체를 하나 만들어서 접근한다.


            /*TMI 스트링 대소문자 차이점
             String -> 원래는 System.String인데 using system 써줘서 생략 가능한것....
             System.String =string 
             소문자 스트링 쓰면 유징 시스템 안써도 돼 
            */

            int banti = 22338286;
            double banti2 = 2233.8286;

            Console.WriteLine("int ={0:x}", banti);  
            Console.WriteLine("double ={0:f}", banti2);

            int moonbin = 21;
            Console.WriteLine("int ={0:x}", moonbin); //16진수

            int aa = 10;
            int bb = 200;
            Console.WriteLine("{0}{0:D3}{0:D5}", aa, bb);



        }
    }
}
