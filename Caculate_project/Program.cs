using System;

namespace Caculate_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //입력 : _______ 
            Console.WriteLine("메뉴를 선택하시오.");
            Console.WriteLine("1.double,2.float,3.long,4.int,5.char,6.종료");

            /* 입력 1~5 넘어감, 6 return,  나머지 while문으로 1~6이 될때까지 반복
               여기서 함수 1개 만들기*/
            string data_type = " ";
            for (; ; )
            {
                Console.Write("입력: ");
                String num = Console.ReadLine();
                if (num == "1")
                {
                    data_type = "double";
                    break;
                }
                else if (num == "2")
                {
                    data_type = "float";
                    break;
                }
                else if (num == "3")
                {
                    data_type = "long";
                    break;
                }
                else if (num == "4")
                {
                    data_type = "int";
                    break;
                }
                else if (num == "5")
                {
                    data_type = "char";
                    break;
                }
                else if (num == "6") Environment.Exit(0);
                else
                {
                    Console.WriteLine("잘못된 메뉴 번호입니다");
                    continue;
                }
            }

            // _____값을 2개를 입력하시오.
            Console.WriteLine(data_type + "값 2개를 입력하시오.");


            //입력 1:________ 
            Console.Write("입력 1:");
            string inputone = Console.ReadLine();

            //입력 2:________
            Console.Write("입력 2:");
            string inputtwo = Console.ReadLine();

            //연산 종류를 입력하시오.
            string cal = " ";
            for (; ; )
            {
                Console.Write("연산 종류를 입력하시오(+,-,*,/,%):");
                string mathtype = Console.ReadLine();
                if (mathtype == "+")
                {
                    cal = "+";
                    break;
                }
                else if (mathtype == "-")
                {
                    cal = "-";
                    break;
                }
                else if (mathtype == "*")
                {
                    cal = "*";
                    break;
                }
                else if (mathtype == "/")
                {
                    cal = "/";
                    break;
                }
                else if (mathtype == "%")
                {
                    cal = "%";
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 연산 기호입니다");
                    continue;
                }
            }

            //결과의 type을 선택하시오.
            String changetype = " ";
            for (; ; )
            {
                Console.Write("결과의 타입을 선택하시오.");
                string result_type = Console.ReadLine();
                if (result_type == "1")
                {
                    changetype = "double";
                    break;
                }
                else if (result_type == "2")
                {
                    changetype = "float";
                    break;
                }
                else if (result_type == "3")
                {
                    changetype = "long";
                    break;
                }
                else if (result_type == "4")
                {
                    changetype = "int";
                    break;
                }
                else if (result_type == "5")
                {
                    changetype = "char";
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 연산 타입 입니다");
                    continue;
                }
            }

            //data_type , cal , changetype에서 함수 만들기

            //원래 결과: ____:________________
            Console.Write("원 결과: ");
            Console.WriteLine(Best.Cal(Test.Dat(data_type,inputone), Test.Dat(data_type, inputtwo)));
            
            //형 변환 결과 ____:_______________
            //Console.Write("형 변환 결과: ");

        }
        class Test
        {   
            public static double Dat(string a, string b)
            {
                if (a == "double") return double.Parse(b);
            }
            public static float Dat(string a, string b)
            {
                if (a == "float") return float.Parse(b);
            }
            public static long Dat(string a, string b)
            {
                if (a == "long") return long.Parse(b);
            }
            public static int Dat(string a, string b)
            {
                if (a == "int") return int.Parse(b);
            }
            public static char Dat(string a, string b)
            {
                if (a == "char") return char.Parse(b);
            }
        }

        class Best
        {
            public static double Cal(String cal, double x, double y)
            {
                if (cal == "+") return x + y;
                else if (cal == "-") return x - y;
                else if (cal == "*") return x * y;
                else if (cal == "/") return x / y;
                else if (cal == "%") return x % y;
            }
            public static float Cal(String cal, float x, float y)
            {
                if (cal == "+") return x + y;
                else if (cal == "-") return x - y;
                else if (cal == "*") return x * y;
                else if (cal == "/") return x / y;
                else if (cal == "%") return x % y;
            }
            public static long Cal(String cal, long x, long y)
            {
                if (cal == "+") return x + y;
                else if (cal == "-") return x - y;
                else if (cal == "*") return x * y;
                else if (cal == "/") return x / y;
                else if (cal == "%") return x % y;
            }
            public static int Cal(String cal, int x, int y)
            {
                if (cal == "+") return x + y;
                else if (cal == "-") return x - y;
                else if (cal == "*") return x * y;
                else if (cal == "/") return x / y;
                else if (cal == "%") return x % y;
            }
            public static char Cal(String cal, char x, char y)
            {
                if (cal == "+") return (char)((char)x + (char)y);
                else if (cal == "-") return (char)((char)x - (char)y);
                else if (cal == "*") return (char)((char)x * (char)y);
                else if (cal == "/") return (char)((char)x / (char)y);
                else if (cal == "%") return (char)((char)x % (char)y);
            }


        }

    }
}
