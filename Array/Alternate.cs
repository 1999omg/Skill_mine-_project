using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Array
{
    class Alternate
    {
        public void printalter (string[]sr)
        {
            for (int i = 0; i < sr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(sr[i]);
                }
                {

                }
            }
        }
        static void Main (string []args)
        {
            string[] sr = { "my name is om sanjay gawade" };
            Alternate obj = new Alternate();
            obj.printalter(sr);
        }
    }
}
