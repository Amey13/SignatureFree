using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
namespace sigfree_demo_
{
    class SecPhase
    {
        public static List<Node> Get_Inst(String URL_Bytes,ref int Total_inst)
        {
            Process p = new Process();
            try
            {
                p.StartInfo.FileName = "ConvertShellcode.exe";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            // URL_Bytes;//
            p.StartInfo.Arguments = URL_Bytes;//"\\xEB\\x08\\xBA\\xBA\\x4D\\x11\\x86\\x7C\\xFF\\xD2\\xCC\\xE8\\xF3\\xFF\\xFF\\xFF\\x63";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
            char[] tokenizers = { '\r', '\n' };
            string[] tokens = p.StandardOutput.ReadToEnd().Split(tokenizers, StringSplitOptions.RemoveEmptyEntries);//store  Multiple lines 
            p.WaitForExit();


            List<Node> inst = new List<Node>();
            List<String> Temp_inst = new List<String>();

            if (tokens.Length > 4)
            {

                for (int lp = 4; lp < tokens.Length; lp++)
                {
                    Node n = new Node();
                    //Console.WriteLine(lp + "     " + tokens[lp]);

                    Total_inst++;//count instructions..
                    Temp_inst.Add(tokens[lp]);//we get single line in Temp_inst now we can seperate opcode and operands

                    foreach (string x in Temp_inst)//here we get a  one line whch have 1 instruction and all operands in short A NODE
                    {
                        String Replced;
                        //x.Replace(","," ");

                        List<String> T_inst_parts = new List<String>();
                        String[] t_all_words;
                        if (x != "")
                        {

                            //if (x.Contains(','))

                            Replced = x.Replace(",", " ");
                            //Console.WriteLine(", found");

                            t_all_words = Replced.Split(' ');//t_all_words this array have all words i.e. addrs opcode N operands 
                            T_inst_parts.AddRange(t_all_words);
                            String[] temp_S;
                            temp_S = T_inst_parts.ToArray();//here also we get the 

                            n.addr = temp_S[0];
                            //index of 1 blank spce which can not be removed by me..
                            n.name = temp_S[2];
                            List<string> oprands = new List<String>();
                            for (int lp2 = 3; lp2 < temp_S.Length; lp2++)
                            {
                                oprands.Add(temp_S[lp2]);
                            }
                            n.operands = oprands.ToArray();
                            n.type = "legal";
                        }
                    }
                    inst.Add(n);
                }
            }
            else
            {
                return inst;

            }
            //adding instr manually.....
            // inst.AddRange(Inject_instr.Inj_instr.ToArray());
            return inst;
        }

        public static List<Node> seperate(List<Node> all_Instr, ref int Useless)//get all inst and return seperated instrctions
        {
            List<Edge> all_Edg = new List<Edge>();
            List<Node> dis_ins = new List<Node>();    //store illegal distilled instruction Nodes
            List<Node> E_A_Nodes = new List<Node>();// new Node[16];//store illegal distilled External Address Instruction Nodes

            // dis_ins[i] = new Node();
            int i = 0;
            Node[] all_Instr_node;

            all_Instr_node = all_Instr.ToArray();//Convert from list of nodes...->To-> array of node -
            Node x_inst = new Node();//later used to Store each node  from all_Inst_node list

            //foreach (Node x_inst in all_Instr_node)
            for (int loop = 0; loop < all_Instr_node.Length; loop++)
            {
                x_inst = all_Instr_node[loop];//get each node in to x_inst from all_Inst_node
                if (x_inst.type.Equals("illegal"))
                {
                    //dis_ins[i] = new Node();
                    //dis_ins[i] = x_inst;//add nodes who are illegal
                    dis_ins.Add(x_inst);
                }
                else
                {

                    //------------gettin starting and endign address...of all instructions.
                    Node F_inst = new Node();
                    F_inst = all_Instr.First();
                    Node L_inst = new Node();
                    L_inst = all_Instr.Last();

                    Int32 F_addr = 0, L_addr = 0;
                    string[] t_addr;//= operand; //to remove \x if present
                    if (F_inst.addr.Contains("0x"))
                    {
                        //char[] Split = { '0', 'x' };
                        char[] Split = { 'x' };
                        t_addr = F_inst.addr.Split(Split, StringSplitOptions.RemoveEmptyEntries);
                        //F_addr = Int32.Parse(t_addr[1], System.Globalization.NumberStyles.HexNumber);
                        F_addr = Int32.Parse(t_addr[1], System.Globalization.NumberStyles.HexNumber);
                    }
                    else
                    {
                        F_addr = Int32.Parse(F_inst.addr, System.Globalization.NumberStyles.HexNumber);
                    }

                    if (L_inst.addr.Contains("0x"))
                    {
                        //char[] Split = { '0', 'x' };
                        char[] Split = { 'x' };
                        t_addr = L_inst.addr.Split(Split, StringSplitOptions.RemoveEmptyEntries);
                        //L_addr = Int32.Parse(t_addr[1], System.Globalization.NumberStyles.HexNumber);
                        L_addr = Int32.Parse(t_addr[1], System.Globalization.NumberStyles.HexNumber);
                    }
                    else
                    {
                        L_addr = Int32.Parse(L_inst.addr, System.Globalization.NumberStyles.HexNumber);
                    }
                    //------------------------
                    if ( CTI_Check(x_inst))              //checked for Control Transfer Insruction. if is cti then check 4 cti address is in our Address scope or not
                    {
                        //dis_ins[i] = x_inst;//already leaga instruction
                        dis_ins.Add(x_inst);

                        foreach (String operand in x_inst.operands)//check for each operand
                        {
                            Int32 addr = 0;

                            string[] t_op;//= operand; //to remove \x if present
                            //addr = Convert.ToInt32(operand);//here we have all addrrs in int so convert it in int //this addr means if operand contains any address
                            if (operand.Contains("0x"))//here first check the operand is direct Memory address (which is in Hex(0x) format ) or Operand is Genearal purpose resistor (Eax,Ebx)
                            {
                                char[] Split = { 'x' };

                                t_op = operand.Split(Split, StringSplitOptions.RemoveEmptyEntries);
                                addr = Int32.Parse(t_op[1], System.Globalization.NumberStyles.HexNumber);
                                //addr = Int32.Parse(t_op[1]);
                                if (addr < F_addr || addr > L_addr)// as our assumption we hava address scope 0-16 so assign  it in 
                                {
                                    x_inst.type = "ExtAddNode";
                                    //Node[] t =null;
                                    //t=new Node[](target_node(Node x_inst,String addr.ToString()));
                                    //dis_ins[i] = x_inst; //store the Nodes which are having external address nodes..
                                    //dis_ins = target_node(all_Instr, addr.ToString()); //this to check target node
                                    //target_node(all_Instr, addr.ToString());
                                    E_A_Nodes.Add(x_inst);
                                    Useless++;

                                    //------excluding self instruction from all target instruction to avoid self Edge loop

                                    List<Node> Temp_all_inst;
                                    Temp_all_inst = all_Instr;
                                    Temp_all_inst.Remove(x_inst);//HERE     we exclude the current instruction from all instructions
                                    //------

                                    List<Node> T_nodes = new List<Node>(); //store list of Target nodes
                                    T_nodes = target_node(Temp_all_inst, operand);//pass all inst's Lode-list with the operand of inst to find any target inst node present or not...!
                                    if (T_nodes.Count > 0)//add edge between current node and target node
                                    {
                                        Node[] T_target_N;
                                        T_target_N = T_nodes.ToArray();
                                        for (int al_tmp = 0; al_tmp < T_target_N.Length; al_tmp++)
                                        {                                   //from                            To                                    name of edge
                                            Edge e = new Edge(all_Instr_node[loop], T_target_N[al_tmp], all_Instr_node[loop].addr);
                                            all_Edg.Add(e);
                                            e.disp(e);

                                        }
                                    }

                                }
                                else
                                {
                                    // Console.WriteLine("No ExtAddCall");
                                }
                            }
                        }
                    }
                    else//if not CTI add edge between current and predecessor
                    {

                        if (loop < all_Instr_node.Count() - 1)
                        {

                            Edge e = new Edge(all_Instr_node[loop], all_Instr_node[loop + 1], all_Instr_node[loop].addr);
                            // Normal edges ........................
                            //     all_Edg.Add(e);
                            //    e.disp(e);
                        }
                    }
                }
                i++;
            }


            if (E_A_Nodes.Count > 0)
            {
                Node[] temp_n;
                temp_n = E_A_Nodes.ToArray();
                //if (temp_n != null)//if not null then 
                {
                    Console.WriteLine("\nExt Addr Node");
                    temp_n[0].disp(temp_n[0]);//to display all External address instructons..
                }
                return E_A_Nodes;
            }
            else
            {
                return dis_ins;
            }
        }

        public static  bool CTI_Check(Node X_inst) // check for CTI from all legal instructions
        {
            String[] CTI_inst = new String[] { "BOUND", "CALL", "ENTER", "INT", "INTO", "IRET", "JA", "JAE", "JB", "JBE", "JC", "JCXZ", "JE", "JECXZ", "JG", "JGE", "JL", "JLE", "JMP", "JNAE", "JNB", "JNBE", "JNC", "JNE", "JNG", "JNGE", "JNL", "JNLE", "JNO", "JNP", "JNS", "JNZ", "JO", "JP", "JPE", "JPO", "JS", "JZ", "LEAVE", "LOOP", "LOOPE", "LOOPNE", "LOOPNZ", "LOOPZ", "RET", "RET" };

            if (CTI_inst.Contains(X_inst.name.ToUpper()))
            {
                Console.WriteLine("\n\nThe cti = " + X_inst.name.ToUpper());
                return true;
            }
            else
            {
                return false;
            }    //Console.WriteLine("the non CTI = " + X_inst.name.ToUpper());
        }



        //Function to get istruction/s return Target matched node/s
        public static  List<Node> target_node(List<Node> inst, String Srch_op)//get istruction return Target matched nodes
        {
            List<Node> f_nodes = new List<Node>();//= new Node[16];//found nodes
            //Node[] f_nodes = null;//found nodes
            //List<Node> f_nodes = null; //here we create list of nodes
            Node[] inst_temp;
            inst_temp = inst.ToArray();
            int i = 0;
            //foreach (Node temp in inst)
            Node temp = new Node();
            for (int loop = 0; loop < inst_temp.Length; loop++)
            {
                //Node temp = new Node(inst[i]);

                temp = inst_temp[i];
                //temp = inst[i];
                //temp.operands[0] = inst[i].operands[0];
                //temp.operands[1] = inst[i].operands[1];
                //if (temp.operands[0].Equals(Srch_op) || temp.operands[1].Equals( Srch_op))//leaver future edit for each operand
                //foreach(string opr in temp.operands)
                if (temp.operands.Contains(Srch_op))
                {
                    f_nodes.Add(temp);
                    //return temp;
                }
                i++;
            }

            return f_nodes;

        }

    }
}
