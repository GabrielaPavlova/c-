using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_new
{
    class Program
    {
        static void Main(string[] args)
        {

            // Има три начина за изписване и показване на символите в С#

            string file = " C: \\ Windows\\ win.ini"; // pokazwa i dvete nakloneni cherti

            string file1 = @" C:\Windows\abc\dot.net\"; // pokazva vsichki simwoli izpolzwani vytre w kavichkite

            string firstName = "Gabriela";
            string lastName = "Pavlova"; // naj novata funkciq v C# tyrsi i otpechatva direktno stringa w kawichkite !!!!!! NOVA FUNKCIQ !!!!
            string fullName = $"{firstName} {lastName}";

            Console.WriteLine(file);
            Console.WriteLine(file1);
            Console.WriteLine(fullName);

            int age = 34;
            Console.WriteLine("Helo i am " + age +" years old"); // Sybirane na stringove 


        }
    }
}
