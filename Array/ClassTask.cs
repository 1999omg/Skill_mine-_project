using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Array
{
    class ClassTask
    {
        // write code for Accept starting number ‘fromNum’ and end number 

        public void filterString (string s, char[] ch)
        {
            int num;
            for (int i =0;i< ch.Length; i++)
            {
                if (ch[i] < '9' && ch[i] > '0')
                {
                   // num = (int)ch[i];

                    // num = Convert.toInt32(ch[i]);
                    // num = ch[i].GetNumericValue();
                    // num = (int)Int32.Parse(ch[i]);

                    num = ch[i] - '0';
                    Console.WriteLine(num);

                }
            }
        }
        static void mmMain(string []args)
        {
            Console.WriteLine(" enter string ");
            string sr = Console.ReadLine();
            char[] ch = sr.ToArray();
            ClassTask obj = new ClassTask();
            obj.filterString(sr, ch);
        }
    }
}
