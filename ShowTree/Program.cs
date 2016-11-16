using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTree
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter hte hight level of a Btree:");
            double level = double.Parse( Console.ReadLine());
            // Number of max nodes in a given lavel k is 2^k
            double nodes = Math.Pow(2.0,level);
            Console.WriteLine("Number of max nodes in a given lavel {0} is {1}", level, nodes);

            // Number of max nodes in a given tree with lavel k is 2^(k+1) - 1
            double totalnodes = Math.Pow(2.0, (level + 1.0)) - 1;
            Console.WriteLine("Number of max nodes in a given tree with depth {0} is {1}", level, totalnodes);
            

            // Construct tree from stack
            //ConstructTreeFromStack();


            // Construct Tree Manually
            //ConstructTreeManually();

            Console.ReadKey();

        }

        private static void ConstructTreeFromStack()
        {
            Stack<int> _stack2 = new Stack<int>();
            var rand = new Random();
            for (int i= 0; i < 10; i++)
            {
                _stack2.Push(rand.Next(1,99));
            }

            //_stack2.Push(1);
            //_stack2.Push(2);
            //_stack2.Push(3);
            //_stack2.Push(4);
            //_stack2.Push(5);
            //_stack2.Push(6);
            //_stack2.Push(7);

            //Stack<int> _stack = new Stack<int>();
            BTree tr = new BTree();
            Node root = tr.MakeRoot(50);            
            while (_stack2.Count > 0)
            {
                tr.Addnode(root, _stack2.Pop(), 0);
            }
            tr.PrintTree(root);

        }

        private static void ConstructTreeManually()
        {
            // Print the tree
            BTree tr = new BTree();
            Node root = tr.MakeRoot(50);
            tr.PrintTree(root);

            string cki;
            do
            {
                cki = Console.ReadLine();
                Console.WriteLine(": " + cki.ToString());

                int p;
                if (int.TryParse(cki, out p))
                {
                    tr.Addnode(root, p, 0);
                    tr.PrintTree(root);
                }
            } while (cki != "q");
        }
    }
}
