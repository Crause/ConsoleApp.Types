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

      double db = 2.6;
      var vdb = 1.82;

      char ch = 'i';

      bool b = true;
      var vb = false;

      string s = "string text";
      var vs = "string text too";

      decimal decim = 0.1M;


      Console.WriteLine("i = "     + Convert.ToString(i));
      Console.WriteLine("vi = "    + Convert.ToString(vi));
      Console.WriteLine("db = "    + Convert.ToString(db));
      Console.WriteLine("vdb = "   + Convert.ToString(vdb));
      Console.WriteLine("ch = "    + Convert.ToString(ch));
      Console.WriteLine("b = "     + Convert.ToString(b));
      Console.WriteLine("vb = "    + Convert.ToString(vb));
      Console.WriteLine("s = "     + Convert.ToString(s));
      Console.WriteLine("vs = "    + Convert.ToString(vs));
      Console.WriteLine("decim = " + Convert.ToString(decim)); 
      Console.ReadKey();
    }
  }
}
