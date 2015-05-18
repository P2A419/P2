using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.Wizard
{
    class Wizard
    {
        public static void wizard()
        {
            wizard_start();
            List<TestData> listdata = DataSelection.readfromfile(DataSelection.data_location(DataSelection.file_name()));
            //DataSelection.print_list(listdata);
            Algorithm.Algorithm.algorithm_selection(listdata);
        }
        public static void wizard_start()
        {
            Console.WriteLine("Velkommen til vored wizard\r\n" +
                  "Her kan du definere diverse data til algoritmen\r\n" +
                  "Her skal du blandt andet også vise hvor dine test data er\r\n" +
                  "Tryk på en vilkårlig knap for at forsætte");
            Console.ReadKey();
        }
    }
}
