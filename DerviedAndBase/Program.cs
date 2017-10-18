using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace ConsoleApplication2
{
    class clsBase
    {
        public clsBase()
        {
            Console.WriteLine("Base\n");
        }
    }

    class clsDerived : clsBase
    {
        public clsDerived()
        {
            Console.WriteLine("Derived\n");
        }
    }

    public class Program
    {
        public static void Main(String[] arg)
        {
            clsDerived d;
            clsBase b;

            //To run Comment the Below line
            d = new clsBase();

            b = new clsDerived();
            Console.Read();
        }
    }
}
