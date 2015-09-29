using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;// RE used in ascii filtering  
using System.IO; //for path..etc
using System.Threading;//for Multi-threading..
using System.Diagnostics;//for using external process/exe
using mshtml;
using SHDocVw;  //is the name of the layout engine for the Microsoft Windows version of Internet Explorer.
//add from this location C:\Program Files\Microsoft.NET\Primary Interop Assemblies\Microsoft.mshtml.dll
//using SHDocVw;
//using NDde.Client;  // Creating an instance of Internet explorer
//add from this location C:\Windows\System32\shdocvw.dll
namespace sigfree_demo_
{

    public partial class Sigfree : Form
    {
        public string ieurls = "";
        public static String current_Url = "", prev_url = "";
        public static int Total_inst;//stores the total number instructions
        public static int Useless;//stores Useless instructions
        public static Int32 T_count;

        // Volatile is used as hint to the compiler that this data
        // member will be accessed by multiple threads.
      

        public Sigfree()
        {
            InitializeComponent();
        }
        public string GetActiveWindowTitle(int handle)
        {
            string sTitle = string.Empty;
            const int nChars = 256;
         
            StringBuilder Buff = new StringBuilder(nChars);
            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                sTitle = Buff.ToString();
            }
            return sTitle;
        }
        private string GetActiveWindowClass(IntPtr hwnd)
        {
            StringBuilder lpClassName = new StringBuilder(256);
            GetClassName(hwnd, lpClassName, lpClassName.Capacity);

            return lpClassName.ToString();

        }
        
        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(int hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;
        public int wbHandle = 0;
        public int ieHandle = 0;
        public int prevForeGroundWindowHandle = 0;

        private ShellWindows shellWindows = new ShellWindowsClass();

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            while (progressBar1.Value < 100  )
            progressBar1.Value += 10;

            if (progressBar1.Value >= 90)
            {
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                timer1.Stop();
                Trace();
            }
        }
        public void Trace()
        {
            count_Non_Ascii = 0;
            Useless = 0;//initiate Useless to zero..
            Total_inst = 0;
            listBox1.Visible = true;
            String Non_Ascii_Url = "";
            String URL_bytes = "";

            string sClass = "";
            string sTitle = "";
            wbHandle = GetForegroundWindow();//This function returns the handle to the foreground window — the window with which the user is currently working. 
            sClass = GetActiveWindowClass((IntPtr)wbHandle);
            sTitle = GetActiveWindowTitle(wbHandle);

            string web_ie;
            listBox1.Items.Clear();
            LB_A_Filt.Items.Clear();//first clear All the elements
            LB_Bytes.Items.Clear();//first clear All the elements
            LB_inst.Items.Clear();
            LB_CTI.Items.Clear();
            lb_count_NonAscii.Items.Clear();
            lb_each_useless.Items.Clear();
            lb_Each_tot.Items.Clear();
            Int32 t = 0;
            foreach (SHDocVw.InternetExplorer ie in shellWindows)
            {
                try
                {
                    web_ie = Path.GetFileNameWithoutExtension(ie.FullName).ToLower();

                    if (web_ie.Equals("iexplore"))
                    {
                        current_Url = ie.LocationURL;
                        if (String.Compare(current_Url, prev_url) != 0)//check and display different url's only
                        {
                          
                            listBox1.Items.Add("Traced URL" + "---" + ie.LocationURL.ToString());
                            Non_Ascii_Url = FirstPhase.Filter_Ascii(ie.LocationURL.ToString() , ref count_Non_Ascii);//Filter_Ascii which accept the doc.url and Filter it and return Non Ascii Char String
                            //Non_Ascii_Url = FirstPhase.Filter_Ascii(ie.LocationURL.ToString() + "▼ ┐┴ƒ", ref count_Non_Ascii);//Filter_Ascii which accept the doc.url and Filter it and return Non Ascii Char String

                            
                            LB_A_Filt.Items.Add(Non_Ascii_Url.ToString());//add elements
                            //add no of counts 
                            lb_count_NonAscii.Items.Add(count_Non_Ascii.ToString());
                          
                            t = t + count_Non_Ascii;
                           lb_NA_Count.Text = (t.ToString());//Display the Noumber of Non Ascii charactors found in Url
                           URL_bytes = FirstPhase.Con_Byte(Non_Ascii_Url); //the Function Con_Byte which accept the Non Ascii Char and return equivalent Byte Repsentation..
                            

                            LB_Bytes.Items.Add(URL_bytes.ToString());//add elements

                            Node[] All_inst;//all instructions distilled from bytes
                            All_inst = SecPhase.Get_Inst (URL_bytes,ref Total_inst).ToArray();
                            lb_Each_tot.Items.Add(All_inst.Count().ToString());//count no of instr

                            //-------------------------------------------------------------START--------adding each instruction in to list view
                            String Str_all_inst="";
                            foreach (Node tmp_N in All_inst)
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
                                Str_all_inst=Str_all_inst +"*"+tmp_inst.ToString();
                            }
                            //----------------------------------------------------------------------------END-----------------------------------------------------------------------------------

                            //-------------------------------------------get Illegal instr
                            // convert all_inst node array to Node List
                            List<Node> All_inst_L = new List<Node>();
                            All_inst_L.AddRange(All_inst);
                            Node[] CTI_inst_N;//all usless CTI  instructions, distilled from bytes

                            CTI_inst_N = SecPhase.seperate(All_inst_L, ref Useless).ToArray();
                          
                                
                         
                            
                            String Str_Uselss_instr="";
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
                                Str_Uselss_instr=Str_Uselss_instr+"$"+tmp_inst.ToString();
                            }
                            //-----------------------------------fingding invalid MOV  instr (reg assignment instruction)



                            Node[] Mov_inst_N;//all usless MOV ( reg assignment) instructions distilled from bytes

                            Mov_inst_N = get_Mov_inst(All_inst_L).ToArray();


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
                                Str_Uselss_instr=Str_Uselss_instr+"$"+tmp_inst.ToString();
                            }
                            lb_each_useless.Items.Add((CTI_inst_N.Count()+Mov_inst_N .Count()).ToString());
                            //-----------------------------------END-------of fingding invalid MOV  instr (reg assignment instruction)
                            
                            //-------------------------------------------END of getting Sep instr------------------------
                            //store In to the DB
                            try
                            {
                                String NonAscii="No";
                                if(count_Non_Ascii==0)
                                {
                                    NonAscii="No";
                                    Decimal xno = 0;
                                    xno = connectToDB.getSrno();
                                    connectToDB.StoreInDB(xno, ie.LocationURL, DateTime.Now, NonAscii);
                                }else
                                {
                                    NonAscii="Yes";
                                    Decimal xno = 0;
                                    xno = connectToDB.getSrno();

                                    String stat = "UnBlocked";
                                    if(Useless>14)
                                        stat = "Blocked";
                                        
                                    else
                                    stat = "UnBlocked";
                                    connectToDB.StoreInDB(xno, ie.LocationURL, DateTime.Now, NonAscii);
                                    //connectToDB.StoreInstr(xno, Non_Ascii_Url, "sdf", Str_all_inst,  Convert.ToDecimal(All_inst.Count()), Str_Uselss_instr, Convert.ToDecimal(Useless), "Blocked");
                                    connectToDB.StoreInstr(xno, Non_Ascii_Url, URL_bytes, Str_all_inst, Convert.ToDecimal(All_inst.Count()), Str_Uselss_instr, Convert.ToDecimal(Useless), stat);
                                  /*  connectToDB.StoreInstr(
                                        xno,
                                        Non_Ascii_Url,
                                        URL_bytes, 
                                        Str_all_inst,
                                        Str_all_inst,
                                        All_inst.Count,
                                        Str_Uselss_instr,
                                        Convert.ToDecimal(Useless),
                                        "");*/
                                }
                               

                            }
                            catch(Exception e)
                            {
                                MessageBox.Show("Database Error" + e.Message.ToString());
                            }
                            prev_url = ie.LocationURL;
                        }
                    }
                }
                catch (Exception ex)
                {

                    //listBox1.Items.Clear();
                    timer1.Stop();
                    MessageBox.Show("Error occure..! " + ex.ToString());



                    ieurls = "";
                    Program.currentURL = "";
                }
            }
            //}
            if (listBox1.Items.Count <= 0)
            {
                Program.currentURL = "";
            }


            Lab_Trace_URL.Text = "Trace Count=" + ++T_count;
            //lab_ULess.Text = Convert.ToString( Useless);
            //lab_Total.Text = Convert.ToString(Total_inst);
           
        }
       
     

       public static Int32 count_Non_Ascii = 0;//count non ascii chars
       

       


      

     

   
        List<Node> Mov_N_List; //store mov instruuctions...
        public List<Node> get_Mov_inst(List<Node> all_inst_node_L)
        {
            Node[] all_inst;
         
            Mov_N_List = new List<Node>();
            all_inst = all_inst_node_L.ToArray();
            int count_M = 0;
            foreach (Node x in all_inst)
            {
                if (x.name.Equals("mov") || x.name.Equals("MOV") || x.name.Equals("movs") || x.name.Equals("MOVS") || x.name.Equals("movsx") || x.name.Equals("MOVSX") || x.name.Equals("movzx") || x.name.Equals("MOVZX"))
                {
                    //Mov_N[count_M] = new Node(x);
                    if (x.operands.Count() >= 2)//this is if mov inst contain two opernds then it is valid command
                    {
                        Mov_N_List.Add(x);
                    }
                }
                count_M++;
            }
          

            List<Node> UL_Mov; //store useless (i.e. illegal ) mov instr
            UL_Mov = Chk_stat(Mov_N_List);


            return UL_Mov;
        }
        public List<Node> Chk_stat(List<Node> Mov_N_List)
        {

            HashSet<Operand> All_opr = new HashSet<Operand>();
            List<Node> UL_Mov = new List<Node>();
            String[] REGS = new String[] { "eax", "ebx", "ecx", "edx", "esi", "edi", "ebp", "esp", "si", "di", "bp", "sp" };
            String[] f_regs;
            //Node temp = new Node();

            foreach (Node temp in Mov_N_List)
            {


                string first = temp.operands[0];
                string sec = temp.operands[1];

                if (REGS.Contains(first))
                {
                    Operand op = new Operand(first, "undef");
                    //first check for reference
                    if (REGS.Contains(sec))
                    {
                        if (op.state.Equals("dd"))
                        {
                            op.state = "def-ref";
                            UL_Mov.Add(temp);//here we added the undef-ref reg's inst in useless Mov list
                            Useless++;
                        }
                        if (op.state.Equals("undef"))
                        {
                            op.state = "undef-ref";
                            UL_Mov.Add(temp);//here we added the undef-ref reg's inst in useless Mov list
                            Useless++;
                        }
                    }
                    if (!REGS.Contains(sec))//first check is sec operand is another than regs it another than REGS the they are definde ie assignde some  Mem address
                    {

                        if (op.state == "def")
                        {
                            op.state = "ref";
                        }
                        else
                        {
                            op.state = "def";
                        }
                    }
                    if (All_opr.Contains(op))
                    {
                        //op.state = "dd";
                        if (op.state == "dd")
                        {
                            op.state = "dd";//ref
                        }
                        else
                        {
                            op.state = "dd";

                        }
                        UL_Mov.Add(temp);//here we added the def-def reg's inst in useless Mov list
                        Useless++;
                    }
                    All_opr.Add(op);
                }
            }
            //Console.WriteLine("from temp");
            //foreach (Operand x in All_opr)
            //{
            //    x.disp(x);
            //}
            return UL_Mov;

        }
        private void Sigfree_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
 
        }

        private void Btn_trace_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            //timer1.Interval=100;  
            timer1.Start();
          
           
        }

        private void Btn_DispData_Click(object sender, EventArgs e)
        {
            Dispaly_Data d = new Dispaly_Data();
            d.ShowDialog();
        }

    }
}