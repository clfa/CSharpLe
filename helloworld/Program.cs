using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
namespace HelloWorldAppication
{
    class helloworld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.ReadKey();
        }
    }
}
*/


/*
namespace RectangleApplication
{
    class Rectangle
    {
        private double length;
        private double width;
        public void Acceptdetails()
        {
            Console.WriteLine("Input width: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input length: ");
            length = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("length: {0}", length);
            Console.WriteLine("width:{0}", width);
            Console.WriteLine("area:{0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            
            r.Display();
            Console.ReadLine();
        }
    }
}
*/


/*
namespace DataTypeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of bool: {0}", sizeof(bool));
            Console.WriteLine("Size of byte: {0}", sizeof(byte));
            Console.WriteLine("Size of char: {0}", sizeof(char));
            Console.WriteLine("Size of decimal: {0}", sizeof(decimal));
            Console.WriteLine("Size of double: {0}", sizeof(double));
            Console.WriteLine("Size of float: {0}", sizeof(float));
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.WriteLine("Size of long: {0}", sizeof(long));
            Console.WriteLine("Size of sbyte: {0}", sizeof(sbyte));
            Console.WriteLine("Size of short: {0}", sizeof(short));
            Console.WriteLine("Size of uint: {0}", sizeof(uint));
            Console.WriteLine("Size of ulong: {0}", sizeof(ulong));
            Console.WriteLine("Size of ushort: {0}", sizeof(ushort));

            String str = "w3cschool.cc";
            Console.WriteLine(str);

            str = @"C:\Windows";
            Console.WriteLine(str);

            str = @"<script type=""text/javascript"">
                    <!--
                    -->
                    </script>";
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
*/


/*
namespace TypeConversionApplication
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;
            // double convert to int
            i = (int)d;
            Console.WriteLine(i);

            float f = 53.005f;
            bool b = true;
            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());

            String strDate = "2017-03-03";
            Console.WriteLine(Convert.ToDateTime(strDate));

            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);

            const double pi = 3.1415926;
            Console.WriteLine("Enter Radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Radius: {0}, Area: {1}", r, pi * r * r);

            Console.WriteLine(typeof(ExplicitConversion));
            Console.ReadKey();
        }
    }
}
*/

/*    
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2)
        {
            int nRes = -1;
            if(num1 > num2)
            {
                nRes = num1;
            } else
            {
                nRes = num2;
            }

            return nRes;
        }

        public int Factorial(int nNum)
        {
            int nRet = -1;
            if(1 == nNum) {
                return 1;
            } else
            {
                nRet = Factorial(nNum - 1) * nNum;
                return nRet;
            }
        }

        public void Swap(ref int nX, ref int nY)
        {
            int nTemp = nX;
            nX = nY;
            nY = nTemp;
        }

        public void getValue(out int x)
        {
            int nTemp = 5;
            x = nTemp;
        }
    }

    class Test
    {
        static void Main(String[] args)
        {
            int a = 100;
            int b = 200;
            int nRet = -1;
            NumberManipulator n = new NumberManipulator();

            nRet = n.FindMax(a, b);
            Console.WriteLine("Max 0f {0} and {1} Is {2}.", a, b, nRet);
            Console.WriteLine("6 factorial is {0}.", n.Factorial(6));

            Console.WriteLine("Before swap, a is {0}, b is {1}. ", a, b);
            n.Swap(ref a, ref b);
            Console.WriteLine("After swap, a is {0}, b is {1}.", a, b);

            Console.WriteLine("Before getValue, a is {0}", a);
            n.getValue(out a);
            Console.WriteLine("After getValue, a is {0}", a);

            Console.ReadKey();
        }
    }
}
*/

/*
namespace CalculatorApplication
{
    class NullablesAtShow
    {
        static void Main(String[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.1415926;

            bool? boolval = new bool?();

            Console.WriteLine("显示可空类型的值：{0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("一个可空的布尔值：{0}", boolval);

            double num5 = num1 ?? 5.34;
            Console.WriteLine("num5的值为：{0}", num5);
            num5 = num2 ?? 5.34;
            Console.WriteLine("num5的值为：{0}", num5);

            Console.ReadKey();
        }
    }
}
*/

/*
namespace ArrayAplication
{
    class MyArray
    {
        public void OneDimensionsArray()
        {
            int[] n = new int[10];

            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }

            Console.ReadKey();
            Console.WriteLine();
        }

        public void TwoDimensionsArray()
        {
            int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            for(int  i = 0; i< 5; i++)
            {
                for(int j = 0; j< 2; j++)
                {
                    Console.WriteLine("a[{0}, {1}] = {2}", i, j, a[i, j]);
                }
            }

            Console.ReadKey();
            Console.WriteLine();
        }

        public void JaggedArray()
        {
            int[][] a = new int[][] { new int[] { 0, 0 }, new int[] { 1, 2 }, new int[] { 2, 4 }, new int[] { 3, 6 }, new int[] { 4, 8 } };
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }

            Console.ReadKey();
            Console.WriteLine();
        }

        double getAverage(int[] arr, int nSize)
        {
            double dAvg = 0.0;
            int nSum = 0;
            for(int i=0; i<nSize; ++i)
            {
                nSum += arr[i];
            }

            dAvg = (double)nSum / nSize;

            return dAvg;
        }

        public int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }

            return sum;
        }

        public void ArrayMethods()
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;
            Console.Write("原始数组：");
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Reverse(temp);
            Console.Write("逆转数组：");
            foreach(int i in temp) {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Sort(list);
            Console.Write("排序数组：");
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        static void Main(String[] args)
        {
            MyArray p = new MyArray();
            p.OneDimensionsArray();

            p.TwoDimensionsArray();

            p.JaggedArray();

            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double dAvg = p.getAverage(balance, balance.Length);
            Console.WriteLine("balance average value is {0}", dAvg);

            int sum = p.AddElements(512, 38, 27, 5, -6, -1, 23);
            Console.WriteLine("总和是： {0}", sum);
            Console.ReadKey();
            Console.WriteLine();

            p.ArrayMethods();

            Console.ReadKey();
        }
    }
}
*/

/*
namespace StringApplication
{
    class Program
    {
        static void Main(String[] args)
        {
            String fName, lName;
            fName = "hello, ";
            lName = "world.";

            String fFullName = fName + lName;
            Console.WriteLine("Full Name: {0}", fFullName);

            char[] cLetters = { 'H', 'e', 'l', 'l', 'o' };
            String greetings = new String(cLetters);
            Console.WriteLine("Message: {0}", greetings);

            String[] strAry = { "Hello", "From", "Tutorials", "Point" };
            String strMsg = String.Join(" ", strAry);
            Console.WriteLine("Message: {0}", strMsg);

            DateTime waiting = new DateTime(2017, 03, 14, 21, 15, 20);
            String strChat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", strChat);

            string strA = "This is test";
            string strB = "This is text";
            if (0 == string.Compare(strA, strB)) {
                Console.WriteLine("\"" + strA + "\" and \"" + strB + "\" are equal.");
            } else
            {
                Console.WriteLine("\"" + strA + "\" and \"" + strB + "\" are not equal.");
            }
            
            Console.ReadKey();
        }
    }
}
*/

/*
namespace StructApplication
{
    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;
        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }

        public void display()
        {
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Author: {0}", author);
            Console.WriteLine("Subject: {0}", subject);
            Console.WriteLine("Book_id: {0}", book_id);
        }
    }

    public class TestStruct
    {
        public static void Main(string[] args)
        {
            Books book1 = new Books();
            Books book2 = new Books();

            book1.getValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);
            book2.getValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", 6495700);

            book1.display();
            book2.display();

            Console.ReadKey();
        }
    }
}
*/

/*
namespace EnumApplication
{
    class EnumProgram
    {
        enum Days { Sun, Mon, Tues, Wed, Fri, Sat};

        static void Main(string[] args)
        {
            int wekdayStart = (int)Days.Mon;
            int wekdayEnd = (int)Days.Sat;
            Console.WriteLine("Monday: {0}", wekdayStart);
            Console.WriteLine("Saturday: {0}", wekdayEnd);

            Console.ReadKey();
        }
    }
}
*/

/*
namespace TestClassApplication
{
    class Line
    {
        private double dLength; // line length
        private static int nFontSize;

        public Line()
        {
            Console.WriteLine("Object has been created.");
        }

        ~Line()
        {
            Console.WriteLine("Object will be deleted.");
        }

        public void setLength(double dLen)
        {
            dLength = dLen;
        }

        public double getLength()
        {
            return dLength;
        }

        public void IncFontSize()
        {
            ++nFontSize;
        }

        public static int getFontSize()
        {
            return nFontSize;
        }        
    }

    class Test
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            line.setLength(6.0);
            Console.WriteLine("Line length is {0}.", line.getLength());

            line.IncFontSize();
            line.IncFontSize();
            Console.WriteLine("Line fontsize is {0}.", Line.getFontSize());

            Console.ReadKey();
            Console.WriteLine("ooooo");
            Console.ReadLine();
        }
    }
}
*/

/*
using SomeNameSpace;
using SomeNameSpace.Nested;

namespace SomeNameSpace
{
    public class MyClass
    {
        static void Main()
        {
            Console.WriteLine("In SomeNameSpace");
            Nested.NestedNameSpaceClass.SayHello();
            Console.ReadKey();
        }
    }

    namespace Nested
    {
        public class NestedNameSpaceClass
        {
            public static void SayHello()
            {
                Console.WriteLine("In Nested");
            }
        }
    }
}
*/

/*
namespace FileIOApplication
{
    class FileOptProgram
    {
        void ReadWrtByteFile()
        {
            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();

            Console.ReadKey();
        }

        void ReadWrtBinaryFile()
        {
            BinaryWriter bw;
            BinaryReader br;
            int i = 25;
            double d = 3.1415926;
            bool b = true;
            string s = "I am happy. From HC. 2017-03-16中国";
            // 创建文件
            try
            {
                bw = new BinaryWriter(new FileStream("mydata", FileMode.Create));
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }
            // 写入文件
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
            bw.Close();

            try
            {
                br = new BinaryReader(new FileStream("mydata", FileMode.Open));
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer data: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                s = br.ReadString();
                Console.WriteLine("String data: {0}", s);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read file.");
                return;
            }
            br.Close();

            Console.ReadKey();
        }

        string FileSize(long nVar)
        {
            string strRet = @"0KB";
            string[] sDW = { "B", "KB", "MB", "GB"};
            long nTemp = nVar;
            int nStep = (nVar > 0) ? 1 : 0;
            while(nTemp > 1024)
            {
                ++nStep;
                nTemp /= 1024;
            }
            if(nVar > 0)
            {
                double dTemp = (double)nVar;
                strRet = String.Format(" {0,-5:F} {1}", dTemp / (double)(System.Math.Pow( 1024, nStep-1)), sDW[nStep-1]);
            }

            return strRet;
        }

        private int nTotalFilesCountNum;
        void FileOpt(DirectoryInfo di)
        {
            DirectoryInfo[] diSubDir = di.GetDirectories();
            if (diSubDir.Length > 0)
            {
                foreach(DirectoryInfo i in diSubDir)
                {
                    FileOpt(i);
                }
            }

            FileInfo[] fileList = di.GetFiles();
            foreach (FileInfo f in fileList)
            {
                Console.WriteLine("{0,-160}: {1}", f.FullName, FileSize(f.Length));
                ++nTotalFilesCountNum;
            }
        }

        void DirectoryOpt()
        {
            //Console.WriteLine("{0}", FileSize(10245));
            DirectoryInfo diFolder = new DirectoryInfo(@"F:\Backup");
            Console.WriteLine("\n\n开始统计目录\"{0}\"下的所有文件...\n==============================================", diFolder.FullName);
            FileOpt(diFolder);

            Console.WriteLine("\n==============================================\n共计{0}个文件.", nTotalFilesCountNum);

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            FileOptProgram f = new FileOptProgram();
            f.ReadWrtByteFile();
            
            f.ReadWrtBinaryFile();

            f.DirectoryOpt();

        }
    }
}
*/ 


class LINQQueryExpressions
{
    static void Main()
    {
        int[] scores = new int[] { 89, 64, 94, 88 };
        IEnumerable<int> scoreQuery = from score in scores
                                      where score > 80
                                      select score;

        foreach(int i in scoreQuery)
        {
            Console.WriteLine(i);
        }

        IEnumerable<string> highScoresQuery = from score in scores
                                              where score > 80
                                              orderby score descending
                                              select String.Format("The score is {0}", score);
        foreach (string i in highScoresQuery)
        {
            Console.WriteLine(i);
        }

        Console.ReadKey();
    }
}