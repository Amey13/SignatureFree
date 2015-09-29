using System;
using System.Collections.Generic;

using System.Text;

namespace sigfree_demo_
{
    class Edge
    {
        Node from;
        Node to;
        String value;

        public Edge()
        {
            this.from = null;
            this.to = null;
            this.value = null;
        }
      public  Edge(Node from, Node to,String value)
        {
            this.from = from;
            this.to = to;
            this.value = value;

        }
      public void disp(Edge e)
      {
          Console.Write("\n Edge\nFrom->");
          //Console.WriteLine(e.from. + "--" + e.to.ToString());
          e.to.disp_W_edge(to);
          Console.Write("\n\tName ( "+ e.value+" )\nTo->\t");
          e.from.disp_W_edge(from);
      }

    }
}


