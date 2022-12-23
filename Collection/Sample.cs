using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Skill_mine__project.Collection
{
    class Sample
    {
        static void MMain(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("hello");
            al.Add(12.022);
            al.Add( 'c');
            al.Add(true);

            foreach(var i in al)
            {
                Console.WriteLine(i);

            }

            Stack stack = new Stack();  // first in last out

            stack.Push(120);
            stack.Push(12000);
            stack.Push(40);
            stack.Push(500);
            stack.Pop();
            foreach(var item in stack)
            {
                Console.WriteLine( item);
            }

            Queue queue = new Queue();// fist in first out
            queue.Enqueue(10);
            queue.Enqueue(1400);
            queue.Enqueue(" hello");

            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            Hashtable hashtable = new Hashtable();//  store deta in order of hash table
            hashtable.Add(1, " india");
            hashtable.Add(91, " maharashtra");
            hashtable.Add(32, " pune");

            foreach(DictionaryEntry sample in hashtable)
            {
                Console.WriteLine(sample);
            }


            SortedList sortlist = new SortedList();  // sort deta in order of key assendig order
            sortlist.Add(2, "up");
            sortlist.Add(1, " rajasthan ");
            sortlist.Add(4, " tamilnadu");
            sortlist.Add(3, " maharashtra");

            // sortlist.Count();

            Console.WriteLine(sortlist.Count+"  count ");

            foreach (DictionaryEntry state in sortlist)
            {
                Console.WriteLine($"{state.Key}     {state.Value}");
            }

            for (int i = 0; i < sortlist.Count; i++)
            {
                Console.WriteLine(sortlist.Keys+""+sortlist.Values);
            }

        }
    }
}
