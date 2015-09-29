using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sigfree_demo_
{
    class connectToDB
    {
        static string conn = @"Data Source=.;Initial Catalog=SigFreeDB;Integrated Security=True";
        request_info s = new request_info();
        //static DataClasses1DataContext d = new DataClasses1DataContext(conn);
        DataClasses1DataContext d = new DataClasses1DataContext();
        public static int getSrno()
        {
            //Selection
            DataClasses1DataContext d = new DataClasses1DataContext();

            var num = from u in d.request_infos orderby u.srno descending select u.srno;
            foreach (var a in num)
            {
                return Convert.ToInt32(a + 1);
            }
            return 0;
        }
        public static void StoreInDB(Decimal xno ,String xurl, DateTime DTime, String ConAscii)
        {
           
            //Insertion
           DataClasses1DataContext d = new DataClasses1DataContext(conn);
            request_info s1 = new request_info
            {
                srno = xno,
                url = xurl.ToString(),
                date_time = Convert.ToDateTime(DTime),
                contain_NON_ascii = ConAscii
            };

            d.request_infos.InsertOnSubmit(s1);
            // Submit the change to the database.
            try
            {
                d.SubmitChanges();

            }
            catch (Exception e)
            {
                d.SubmitChanges();
            }
        }
        public static void StoreInstr(Decimal no,String non_ASCII_chars, String eq_bytes,String instr01,Decimal num_instr,String uselessInstr, Decimal num_useless,String status )
        {
            //Decimal xno = 0;
            //xno = connectToDB.getSrno();
            //Insertion
            DataClasses1DataContext d = new DataClasses1DataContext(conn);
            Instr s1 = new Instr 
            {
                srno = no,
               non_ASCII_chars=non_ASCII_chars ,
               eq_byte=eq_bytes,
               instr01=instr01 ,
               num_instr=num_instr ,
               useless_instr=uselessInstr,
               num_useless=num_useless,
               status =status
            };
            
            d.Instrs.InsertOnSubmit(s1);
            // Submit the change to the database.
            try
            {
                d.SubmitChanges();

            }
            catch (Exception e)
            {
                
                d.SubmitChanges();
            }
        }

        public BindingSource ViewReq()
        {
            request_info r = new request_info();
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = from u in d.request_infos orderby u.srno descending select u;
            return bs1;
        }

        public BindingSource ViewInstr()
        {
            Instr s = new Instr();
            BindingSource bs = new BindingSource();
            bs.DataSource = from u in d.Instrs orderby u.srno descending select u;
            return bs;
        }
        
    }
}
