using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HEllo");
            Console.WriteLine("Standard Numeric Format Specifiers");
Console.WriteLine("(C) Currency: . . . . . . . . {0:C}\n" +
"(D) Decimal:. . . . . . . . . {0:D}\n" +
"(E) Scientific: . . . . . . . {1:E}\n" +
"(F) Fixed point:. . . . . . . {1:F}\n" +
"(G) General:. . . . . . . . . {0:G}\n" +
" (default):. . . . . . . . {0} (default = 'G')\n" +
"(N) Number: . . . . . . . . . {0:N}\n" +
"(P) Percent:. . . . . . . . . {1:P}\n" +
"(R) Round-trip: . . . . . . . {1:R}\n" +
"(X) Hexadecimal:. . . . . . . {0:X}\n",
-123, -123.45f);
            Console.ReadLine();
        }
    }
}
