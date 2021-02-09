using System;

namespace ConsoleApp.Types
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 1;
      i = 2;

      var vi = 3;
      vi = -5;

      double dbl = 2.6;
      var vdbl = 1.82;

      char ch = 'i';

      bool b = true;
      var vb = false;

      string s = "string text";
      var vs = "string text too";

      decimal decim = 0.1M;

      //Console.WriteLine("i = "     + Convert.ToString(i));
      //Console.WriteLine("vi = "    + Convert.ToString(vi));
      //Console.WriteLine("dbl = "   + Convert.ToString(dbl));
      //Console.WriteLine("vdbl = "  + Convert.ToString(vdbl));
      //Console.WriteLine("ch = "    + Convert.ToString(ch));
      //Console.WriteLine("b = "     + Convert.ToString(b));
      //Console.WriteLine("vb = "    + Convert.ToString(vb));
      //Console.WriteLine("s = "     + Convert.ToString(s));
      //Console.WriteLine("vs = "    + Convert.ToString(vs));
      //Console.WriteLine("decim = " + Convert.ToString(decim)); 
      //Console.ReadKey();

      string UpperCamelCase;
      string lowerCamelCase;

      string snake_case;
      string FAT_SNAKE_CASE;

      //string kebab-case;
      //string sHungarianCase;

      //implicit casting(неявное приведение)
      byte bb = 5;
      int a = bb;

      //explicit casting(явное приведение)
      int ii = 5;
      int j = 2047;
      byte qii = (byte)ii;
      byte qj = (byte)j;

      string ss = "1234";
      //int jo = int(ss);

      //explicit conversion(явное преобразование)
      int ji = Convert.ToInt32(ss);
      int ij = int.Parse("44");

      //implicit conversion(неявное преобразование)
      int k = 1;
      string str = "str " + k;

      //Console.WriteLine(str);
      //Console.ReadKey();

      //============================

      bool bl = true;
      string sl = bl.ToString();
      //Console.WriteLine(sl);

      string sbl = "false";
      bl = Convert.ToBoolean(sbl);
      //Console.WriteLine(bl);

      //Console.ReadKey();

      //============================

      if(int.TryParse(Console.ReadLine(), out int result))
      {
        Console.WriteLine(result);
        Console.ReadKey();
      }
    }
  }
}
