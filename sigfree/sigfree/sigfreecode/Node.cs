using System;
using System.Collections.Generic;

using System.Text;
using System.Collections;
using System.Linq;
namespace sigfree_demo_
{
    public class Node:IEnumerable,IEnumerator
    {
        //
        /// <summary>
        /// 
        /// </summary>
        /// 
        ArrayList NodeList = new ArrayList();
        private int Position = -1;
        //--------------------------------------------------------------------------
        public string name;
        public string[] operands;
        public string type;
        public string addr;

        public Node()
        {
            this.name = null;
            this.operands=null;
            this.type = null;
            this.addr ="";
        }
        public Node(string n, string[] opr)//without type without addr;
        {
            this.name = n;
            this.operands = opr;
            this.type = null;
            this.addr = "";
        }

        public Node(string n, string[] opr, string type)//for instruction without address
        {
            this.name = n;
            this.operands = opr;
            this.type = type;
            this.addr = "";
        }
        public Node(string n, string[] opr, string type, string addr)//for instruction with address
        {
            this.name = n;
            this.operands = opr;
            this.type = type;
            this.addr = addr;
        }
        public Node(Node n)
        {
            this.name = n.name;
            this.operands = n.operands;
            this.type = n.type;
            this.addr = n.addr;
        }

        public Node(Node[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                this.name = n[i].name;
                this.operands = n[i].operands;
                this.type = n[i].type;
                this.addr = n[i].addr;
            }
        }
        public void SetAddr(Node n, String addr) //for assign address
        {
            this.name = n.name;
            this.operands = n.operands;
            this.type = n.type;
            this.addr = addr;
        }
        public void disp(Node n)
        {
            Console.WriteLine();
            Console.Write(n.name + "\t ");
            if (n.operands != null)
            {
                foreach (String c in n.operands)
                {
                    Console.Write(c.ToString() + " ");
                }
            }
            else
                Console.Write("NULL ");

            Console.Write("\n\t---------------(Type-" + n.type + ")");
            Console.Write("-----(Address-" + n.addr + ")");

        }

        public void disp_W_edge(Node n)
        {
            //Console.WriteLine();
            Console.Write(n.name + "\t ");
            if (n.operands != null)
            {
                foreach (String c in n.operands)
                {
                    Console.Write(c.ToString() + " ");
                }
            }
            else
            { 
                Console.Write("NULL "); 
            }

            Console.Write(" (Type-" + n.type + ")");
            Console.Write(" (Address-" + n.addr + ")");

        }

        public void set_type(String typ)
        {
            this.type = typ;
        }


        /* Needed since Implementing IEnumerable*/
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        /* Needed since Implementing IEnumerator*/
        public bool MoveNext()
        {
            if (Position < NodeList.Count - 1)
            {
                ++Position;
                return true;
            }
            return false;
        }
        public void Reset()
        {
            Position = -1;
        }
        public object Current
        {
            get
            {
                return NodeList[Position];
            }
        }

        internal void SetAddr(Node x, int i)
        {
            throw new NotImplementedException();
        }
    }
}
   