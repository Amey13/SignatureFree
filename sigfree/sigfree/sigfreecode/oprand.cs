using System;
using System.Collections.Generic;

using System.Text;
using System.Collections;
namespace sigfree_demo_
{
    class Operand : IEnumerable, IEnumerator
    {
        public String opr;
        public String state;

        public Operand()
        {
            opr = null;
            state = "undef";
        }
        public Operand(string opr,string state)
        {
            this.opr = opr;
            this.state= state;
        }


        public void disp(Operand oprnd)
        {

            Console.WriteLine(" " + oprnd.opr + " " + oprnd.state);
           
        }




        ArrayList OprList = new ArrayList();
        private int Position = -1;

        /* Needed since Implementing IEnumerable*/
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        /* Needed since Implementing IEnumerator*/
        public bool MoveNext()
        {
            if (Position < OprList.Count - 1)
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
                return OprList[Position];
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is Operand)
            {
                Operand op = obj as Operand;
                if (this.opr == op.opr && this.state == op.state)
                    return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + opr.GetHashCode();
            hash = (hash * 7) + state.GetHashCode();
            return hash;
        }
    }
   
}
