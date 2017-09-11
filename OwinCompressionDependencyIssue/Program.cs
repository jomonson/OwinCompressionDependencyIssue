using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;

namespace OwinCompressionDependencyIssue
{
    class Program
    {
        static void Main(string[] args)
        {
            if (OwinCompression.basePath == "")
            {
                Console.WriteLine("aasc");
            }
        }
    }
}
