using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/*
參考資料:
http://www.daimacuowu.com/q/c6ab8f28628486b1
https://msdn.microsoft.com/zh-tw/library/01escwtf(v=vs.110).aspx
*/
namespace Console_CS_IsDomainString
{
    class Program
    {
        static bool isDomainString(String Data)
        {
            Match match = Regex.Match(Data, @"^(([\w][\w\-\.]*)\.)?([\w][\w\-]+)(\.([\w][\w\.]*))?$");
            String domain = match.Groups[1].Value;
            if (domain != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void pause()
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            String data="http://www.yahoo.com";
            Console.WriteLine("{0}={1}", data, isDomainString(data));
            data = "www.yahoo.com";
            Console.WriteLine("{0}={1}", data, isDomainString(data));
            data = "www.yahoo";
            Console.WriteLine("{0}={1}", data, isDomainString(data));
            data = "www";
            Console.WriteLine("{0}={1}", data, isDomainString(data));
            pause();
        }
    }
}
