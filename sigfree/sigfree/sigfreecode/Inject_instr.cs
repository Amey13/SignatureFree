using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sigfree_demo_;
using System.Diagnostics;
namespace sigfree_demo_
{
    public partial class Inject_instr : Form
    {
        public Inject_instr()
        {
            InitializeComponent();
        }
        public List<String> add_in_LB(Node[] x)
        {
            List<String> All_Items=new List<string>();
            foreach (Node tmp_N in x)
            {
                
                String tmp_inst = "";
                tmp_inst = tmp_inst + " " + tmp_N.name;
                if (tmp_N.operands != null)
                {
                    foreach (String c in tmp_N.operands)
                    {
                        tmp_inst = tmp_inst + " " + c.ToString();
                    }
                }
                else
                    tmp_inst = tmp_inst + " NULL ";
                //tmp_inst = tmp_inst+" " + tmp_N.type ;
                tmp_inst = tmp_inst + " " + tmp_N.addr;
                All_Items.Add(tmp_inst.ToString());//add each instruction
            }
            return All_Items;
        }
        private void Inject_instr_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false ; 
            //btn_next.Enabled = false;
            //first add static commands in list box

            listBox1.Items.Clear();
          
            Inj_instr.AddRange(get_inst_Custom().ToArray());

            lab_Total.Text = Inj_instr.Count.ToString();//display total instructions..
           
            listBox1.Items.AddRange(add_in_LB(Inj_instr.ToArray()).ToArray());


            String[] CTI_inst = new String[] { "BOUND", "CALL", "ENTER", "INT", "INTO", "IRET", "JA", "JAE", "JB", "JBE", "JC", "JCXZ", "JE", "JECXZ", "JG", "JGE", "JL", "JLE", "JMP", "JNAE", "JNB", "JNBE", "JNC", "JNE", "JNG", "JNGE", "JNL", "JNLE", "JNO", "JNP", "JNS", "JNZ", "JO", "JP", "JPE", "JPO", "JS", "JZ", "LEAVE", "LOOP", "LOOPE", "LOOPNE", "LOOPNZ", "LOOPZ", "RET", "RET" };
            String[] REGS = new String[] { "eax", "ebx", "ecx", "edx", "esi", "edi", "ebp", "esp", "si", "di", "bp", "sp" };
            //cb_inst.AutoCompleteCustomSource.AddRange(CTI_inst);

            cb_inst.Items.AddRange(CTI_inst);
           cb_op1.Items.AddRange(REGS);
           cb_op2.Items.AddRange(REGS);


          
        }
     public  static  List<Node> Inj_instr=new List<Node>();
        public Boolean IsValid()//check wether the injected command is valid or not..
        {
            try
            {
                if (cb_inst.Text == "" || cb_op1.Text == "" )
                {
                 
                   return false;
                }
            }
            catch 
            {
            }

             return true;
        }
        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Node T_Inj_inst = new Node();
                T_Inj_inst.name = cb_inst.Text;

                String[] t_oprs = new String[2];
                t_oprs[0] = cb_op1.Text;
                t_oprs[1] = cb_op2.Text;

                T_Inj_inst.operands = t_oprs;

                String T_prev_addr;
                if (Inj_instr.Count  ==0)
                {
                    T_prev_addr = "0x1";
                }else
                T_prev_addr = Inj_instr.Last().addr.ToString();//get the address of last instruction...
                //---------Removing 0x ferom string

                string[] t_addr;//= operand; //to remove \x if present
                if (T_prev_addr.Contains("0x"))
                {
                    char[] Split = {  'x' };
                    t_addr = T_prev_addr.Split(Split, StringSplitOptions.RemoveEmptyEntries);
                    T_prev_addr =t_addr[1].ToString();

                }


                int curr_addr;
                curr_addr = Convert.ToInt32(T_prev_addr);
                curr_addr++;
                T_Inj_inst.addr = curr_addr.ToString();
                T_Inj_inst.type="legal";
                Inj_instr.Add(T_Inj_inst);

                listBox1.Items.Clear();
                listBox1.Items.AddRange(add_in_LB(Inj_instr.ToArray()).ToArray());
                btn_next.Enabled = true;
                lab_Total.Text = Inj_instr.Count.ToString();

            }
        }
        public Node[] get_inst_Custom()
        {
            String[] n0_op = new string[] { "5b" };
            String[] n1_op = new string[] { "eax", "10" };
            //String[] n2_op = new string[] { "" };
            String[] n2_op = { "esi" };
            String[] n3_op = new string[] { "eax", "0" };

            String[] n4_op = new string[] { "ebx", "06" };
            String[] n5_op = new string[] { "eax", "ebx" };
            String[] n6_op = new string[] { "ecx", "07" };
            String[] n7_op = new string[] { "ecx" };
            String[] n8_op = new string[] { "1032" };






            //String[] n1_op = new string[] { "[ds:esi]" };
            //String[] n4_op = new string[] { "10","3985" };
            //String[] n5_op = new string[] { "01", "40" };
            //String[] n6_op = new string[] { "130","0562" };
            //String[] n7_op = new string[] { "015", "130" };
            //String[] n8_op = new string[] { "012", "740" };
            //String[] n9_op = new string[] { "450", "740" };
            //String[] n10_op = new string[] { "150","115" };
            //String[] n11_op = new string[] { "46", "4543" };
            //String[] n12_op = new string[] { "489", "740" };
            //String[] n13_op = new string[] { "463", "740" };
            //String[] n14_op = new string[] { "4637", "740" };
            //String[] n15_op = new string[] { "ZXXCW", "740" };


            Node[] A_Nodes = new Node[9];
            //List<Node>A_Nodes=new List<Node>() ;


            A_Nodes[0] = new Node("CALL", n0_op, "legal");
            A_Nodes[1] = new Node("MOV", n1_op, "legal");
            A_Nodes[2] = new Node("POP", n2_op, "legal");
            A_Nodes[3] = new Node("MOV", n3_op, "legal");
            //A_Nodes.AddRange(A_Nodes1);

            A_Nodes[4] = new Node("MVI ", n4_op, "legal");
            A_Nodes[5] = new Node("MOV ", n5_op, "legal");
            A_Nodes[6] = new Node("MVI ", n6_op, "legal");
            A_Nodes[7] = new Node("ADD", n7_op, "legal");
            A_Nodes[8] = new Node("STA", n8_op, "legal");


          






            //A_Nodes[4] = new Node("lds", n4_op, "legal");
            //A_Nodes[5] = new Node("sbb", n5_op, "legal");
            //A_Nodes[6] = new Node("pop", n6_op, "legal");
            //A_Nodes[7] = new Node("xchg", n7_op, "legal") ;
            //A_Nodes[8] = new Node("rcr", n8_op, "legal");
            //A_Nodes[9] = new Node("pop", n9_op, "legal");
            //A_Nodes[10] = new Node("jmp", n10_op, "legal");
            //A_Nodes[11] = new Node("Mov", n11_op, "legal");
            //A_Nodes[12] = new Node("inc", n12_op, "legal");
            //A_Nodes[13] = new Node("inc", n13_op, "legal");
            //A_Nodes[14] = new Node("lods", n14_op, "legal");
            //A_Nodes[15] = new Node("ZZCRF", n15_op, "illegal"); //illegal which is not recognized by cpu


            int i = 1024;
            foreach (Node x in A_Nodes)
            {
                x.SetAddr(x, "0x"+i.ToString());
                i++;
            }

            return A_Nodes;

        }

       

        private void btn_remv_Click(object sender, EventArgs e)
        {
            try
            {
                int x;
                x = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(x);
                Inj_instr.RemoveAt(x);
            }
            catch
            {
                MessageBox.Show("Please Select  Instruction First ", "Delete Instruction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            LB_inst.Items.Clear();
            LB_CTI.Items.Clear();
            
            //-------------------------------------------get Illegal instr
            // convert all_inst node array to Node List
            List<Node> All_inst_L = new List<Node>();
            All_inst_L.AddRange(Inj_instr);
            Sigfree obj = new Sigfree(); //created obj to access sub in Sigfree class..
            //for display all instr in LB_Instr
            foreach (Node tmp_N in All_inst_L)
            {
                String tmp_inst = "";
                tmp_inst = tmp_inst + " " + tmp_N.name;
                if (tmp_N.operands != null)
                {
                    foreach (String c in tmp_N.operands)
                    {
                        tmp_inst = tmp_inst + " " + c.ToString();
                    }
                }
                else
                    tmp_inst = tmp_inst + " NULL ";
                //tmp_inst = tmp_inst+" " + tmp_N.type ;
                tmp_inst = tmp_inst + " " + tmp_N.addr;
                LB_inst.Items.Add(tmp_inst.ToString());//add each instruction

                ShowInfectdURL(tmp_inst.ToString());
            }


            //-------------------------------------------get Illegal instr

           
            // convert all_inst node array to Node List
         
            Node[] CTI_inst_N;//all usless CTI  instructions, distilled from bytes
            CTI_inst_N = SecPhase.seperate(All_inst_L, ref Sigfree.Useless).ToArray();

            //for display in LB_CTI
            foreach (Node tmp_N in CTI_inst_N)
            {
                String tmp_inst = "";
                tmp_inst = tmp_inst + " " + tmp_N.name;
                if (tmp_N.operands != null)
                {
                    foreach (String c in tmp_N.operands)
                    {
                        tmp_inst = tmp_inst + " " + c.ToString();
                    }
                }
                else
                    tmp_inst = tmp_inst + " NULL ";
                //tmp_inst = tmp_inst+" " + tmp_N.type ;
                tmp_inst = tmp_inst + " " + tmp_N.addr;
                LB_CTI.Items.Add(tmp_inst.ToString());//add each instruction
            }










            //-----------------------------------fingding invalid MOV  instr (reg assignment instruction)



            Node[] Mov_inst_N;//all usless MOV ( reg assignment) instructions distilled from bytes

            Mov_inst_N = obj.get_Mov_inst(All_inst_L).ToArray();


            //for display in LB_CTI
            foreach (Node tmp_N in Mov_inst_N)
            {
                String tmp_inst = "";
                tmp_inst = tmp_inst + " " + tmp_N.name;
                if (tmp_N.operands != null)
                {
                    foreach (String c in tmp_N.operands)
                    {
                        tmp_inst = tmp_inst + " " + c.ToString();
                    }
                }
                else
                    tmp_inst = tmp_inst + " NULL ";
                //tmp_inst = tmp_inst+" " + tmp_N.type ;
                tmp_inst = tmp_inst + " " + tmp_N.addr;
                LB_CTI.Items.Add(tmp_inst.ToString());//add each instruction
            }

            //-----------------------------------END-------of fingding invalid MOV  instr (reg assignment instruction)

            lab_ULess.Text = LB_CTI.Items.Count.ToString();

            if (LB_CTI.Items.Count > 0)
            {
                pictureBox1.Visible = true; 
                MessageBox.Show("Request blocked\nRequest Contains Malicious Instructions", "Sigfree Alert", MessageBoxButtons.OK,MessageBoxIcon.Exclamation  );

                
            }
            else 
            {
                Process p = new Process();
                try
                {
                    p.StartInfo.FileName = "iexplore";
                    p.StartInfo.Arguments = textBox1.Text;
                    p.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            TB_injectedURL.Text  = textBox1.Text + inst_bytes.ToString ();

        }
        public String inst_bytes;
        public void ShowInfectdURL(string each_Instr)
        {
            
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            Byte[] bytes = encoding.GetBytes(each_Instr);
            TB_injectedURL.Text = textBox1.Text; 
            foreach (var tmp in bytes)
            inst_bytes =inst_bytes + tmp.ToString();
        }
        
      
  
       

       

        
    }
}
