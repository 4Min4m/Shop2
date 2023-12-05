using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forooshgah
{
     
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int allow;
        public int allow1;
        public int allow2;

          threeTableF1 hh = new threeTableF1();
          public string txt1;
          public string txt2;
          public string txt3;
          public string txt4;
        //for modat zaman 
         public  int[] Tajamo_khdmatdehi3 = new int[4];
         public  int[] Tajamo_khdmatdehi4 = new int[4];
        // for khedmatdehi first one
         public  int[] khdmatdehi_first = new int[8];
         public  int[] tajamo_first = new int[8];
         public  int[] FPtajamo_First = new int[8];
         // for khedmatdehi second one
         public  int[] khdmatdehi_second = new int[8];
         public  int[] tajamo_second = new int[8];
         public  int[] FPtajamo_second = new int[8];

        private void button1_Click(object sender, EventArgs e)
        {
            tozi__ehtemali zz=new tozi__ehtemali();
            Form2 kk = new Form2();
           // this.Visible = false;
            //می فرستد اون ور

            for (int i = 0; i < 4; i++)
            {       
                kk.s_Tajamo_khdmatdehi3[i] = Tajamo_khdmatdehi3[i];
                kk.s_Tajamo_khdmatdehi4[i] = Tajamo_khdmatdehi4[i];
                kk.s_dady2[i] = Tajamo_khdmatdehi4[i];
            }
            for (int i = 0; i < 8; i++)
            {
                kk.s_FPtajamo_First[i] = FPtajamo_First[i];
                kk.s_tajamo_first[i] = tajamo_first[i];
                //............
                kk.s_FPtajamo_second[i] = FPtajamo_second[i];
                kk.s_tajamo_second[i] = tajamo_second[i];
            }

                kk.x = textBox1.Text;
                kk.y = textBox2.Text;

                if (Int32.Parse(textBox1.Text) > 10000 || (Int32.Parse(textBox1.Text)) == 0 || Int32.Parse(textBox2.Text) <= 0)
                { MessageBox.Show("حداکثر تعداد مشتری 10000 است" + "\nاعداد را بزرگــتر از صفر وارد کنید"); }
                else if (allow == 0 || allow1==0 || allow2==0)
                { MessageBox.Show("تـــایید انجام نشده است"); }
                else

                    kk.ShowDialog();

                
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox3.Text = 30.ToString();
            textBox4.Text = 15.ToString();
            textBox5.Text = 20.ToString();
            textBox6.Text = 35.ToString();
            ////////////////////      
            textBox1.Text =10.ToString();
            textBox2.Text =1.ToString() ;
           ///////////////////////////////////////////////////////
            //کامپیوتر اول
             textBox7. Text = 25. ToString();
             textBox8. Text = 20. ToString();
             textBox9. Text = 10. ToString();
            textBox10.Text = 15.ToString();
            textBox11.Text = 5. ToString();
            textBox12.Text = 10.ToString();
            textBox13.Text = 5. ToString();
            textBox14.Text = 10.ToString();


            //کامپیوتر دوم
            textBox22.Text = 20.ToString();
            textBox21.Text = 23.ToString();
            textBox20.Text = 8.ToString();
            textBox19.Text = 12.ToString();
            textBox18.Text = 5.ToString();
            textBox17.Text = 15.ToString();
            textBox16.Text = 7.ToString();
            textBox15.Text = 10.ToString();

            //....................................

            label19.Enabled = false;
            label52.Enabled = false;
            label85.Enabled = false;




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int _isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out _isNumber);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int _isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out _isNumber);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
         //   if (w == 0)
          //  {
              
          //  }
        }

        private void button3_Click(object sender, EventArgs e)
        {
 
            /////////////////////
            txt1 = textBox3.Text;
            txt2 = textBox4.Text;
            txt3 = textBox5.Text;
            txt4 = textBox6.Text;
            hh.ss1(ref txt1, ref txt2, ref txt3, ref txt4);
            //...................................

           label11.Text = 1.ToString();
           label12.Text = hh.dady2[hh.ii].ToString();
           label14.Text = hh.dady2[hh.ii+1].ToString();
           label16.Text = hh.dady2[hh.ii + 2].ToString();
           label18.Text = hh.dady2[hh.ii + 3].ToString();
           label13.Text =(hh.dady2[hh.ii] + 1).ToString();
           label15.Text = (hh.dady2[hh.ii + 1]+1).ToString();
           label17.Text = (hh.dady2[hh.ii + 2] + 1).ToString();

            //........
           label7.Text = hh.dady1[hh.ii].ToString();
           label8.Text = hh.dady1[hh.ii+1].ToString();
           label9.Text = hh.dady1[hh.ii+2].ToString();
           label10.Text = hh.dady1[hh.ii+3].ToString();

            //.................
           Tajamo_khdmatdehi3[hh.ii] =int.Parse( label12.Text);
           Tajamo_khdmatdehi3[hh.ii+1] = int.Parse(label14.Text);
           Tajamo_khdmatdehi3[hh.ii + 2] = int.Parse(label16.Text);
           Tajamo_khdmatdehi3[hh.ii + 3] = int.Parse(label18.Text);

           Tajamo_khdmatdehi4[hh.ii] = int.Parse(label11.Text);
           Tajamo_khdmatdehi4[hh.ii + 1] = int.Parse(label13.Text);
           Tajamo_khdmatdehi4[hh.ii + 2] = int.Parse(label15.Text);
           Tajamo_khdmatdehi4[hh.ii + 3] = int.Parse(label17.Text);


           if (hh.dady2[hh.ii + 3] > 100 || hh.dady2[hh.ii + 3] < 100)
           {
               MessageBox.Show("در صـــد وارد شده خارج از محدوده است \n\n (1-100) ");
               label19.Enabled = false;
               allow = 0;

           }
           else
           {
               label19.Enabled = true ;
               allow = 1;
           }
         
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // نـــفر اول
            int i=0;
            label28.Text= textBox7. Text; 
            label29.Text= textBox8. Text ;
            label30.Text= textBox9. Text ;
            label31.Text =textBox10.Text ;
            label32.Text= textBox11.Text ; 
            label33.Text= textBox12.Text ; 
            label34.Text =textBox13.Text ;
            label35.Text =textBox14.Text;

         khdmatdehi_first[0] =int.Parse( label28.Text );
         khdmatdehi_first[1] = int.Parse(label29.Text);
         khdmatdehi_first[2] = int.Parse(label30.Text);
         khdmatdehi_first[3] = int.Parse(label31.Text);
         khdmatdehi_first[4] = int.Parse(label32.Text);
         khdmatdehi_first[5] = int.Parse(label33.Text);
         khdmatdehi_first[6] = int.Parse(label34.Text);
         khdmatdehi_first[7]= int.Parse(label35.Text);

         tajamo_first[i] = khdmatdehi_first[i];
            for (int y = 0; y < 7; y++)
            {
                
                tajamo_first[y + 1] = tajamo_first[y] + khdmatdehi_first[y + 1];
            }

            label36.Text = tajamo_first[0].ToString();
            label38.Text = tajamo_first[1].ToString();
            label40.Text = tajamo_first[2].ToString();
            label42.Text = tajamo_first[3].ToString();
            label44.Text = tajamo_first[4].ToString();
            label46.Text = tajamo_first[5].ToString();
            label48.Text = tajamo_first[6].ToString();
            label50.Text = tajamo_first[7].ToString();

            label37.Text = 1.ToString();
            label39.Text = (tajamo_first[0]+1).ToString();
            label41.Text = (tajamo_first[1]+1).ToString();
            label43.Text = (tajamo_first[2]+1).ToString();
            label45.Text = (tajamo_first[3]+1).ToString();
            label47.Text = (tajamo_first[4]+1).ToString();
            label49.Text = (tajamo_first[5]+1).ToString();
            label51.Text = (tajamo_first[6]+1).ToString();

            //....
         
          FPtajamo_First[0] =int.Parse( label37.Text) ;
          FPtajamo_First[1] = int.Parse(label39.Text);
          FPtajamo_First[2] = int.Parse(label41.Text);
          FPtajamo_First[3] = int.Parse(label43.Text);
          FPtajamo_First[4] = int.Parse(label45.Text);
          FPtajamo_First[5] = int.Parse(label47.Text);
          FPtajamo_First[6] = int.Parse(label49.Text);
          FPtajamo_First[7] = int.Parse(label51.Text);

          if (tajamo_first[7] > 100 || tajamo_first[7] < 100)
          {
              MessageBox.Show("در صـــد وارد شده خارج از محدوده است \n\n (1-100) ");
              label52.Enabled = false;
              allow1 = 0;

          }
          else
          {
              label52.Enabled = true ;
              allow1 = 1;
          }

        }
// نــــــــــــفر دومی
        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            label76.Text = textBox22.Text;
            label75.Text = textBox21.Text;
            label74.Text = textBox20.Text;
            label73.Text = textBox19.Text;
            label72.Text = textBox18.Text;
            label71.Text = textBox17.Text;
            label70.Text = textBox16.Text;
            label69.Text = textBox15.Text;

            // نــــــــــــفر دومی
            khdmatdehi_second[0] = int.Parse(label76.Text);
            khdmatdehi_second[1] = int.Parse(label75.Text);
            khdmatdehi_second[2] = int.Parse(label74.Text);
            khdmatdehi_second[3] = int.Parse(label73.Text);
            khdmatdehi_second[4] = int.Parse(label72.Text);
            khdmatdehi_second[5] = int.Parse(label71.Text);
            khdmatdehi_second[6] = int.Parse(label70.Text);
            khdmatdehi_second[7] = int.Parse(label69.Text);

            tajamo_second[i] = khdmatdehi_second[i];
            for (int y = 0; y < 7; y++)
            {

                tajamo_second[y + 1] = tajamo_second[y] + khdmatdehi_second[y + 1];
            }

            label67.Text = tajamo_second[0].ToString();
            label65.Text = tajamo_second[1].ToString();
            label63.Text = tajamo_second[2].ToString();
            label61.Text = tajamo_second[3].ToString();
            label59.Text = tajamo_second[4].ToString();
            label57.Text = tajamo_second[5].ToString();
            label55.Text = tajamo_second[6].ToString();
            label53.Text = tajamo_second[7].ToString();

            label68.Text = 1.ToString();
            label66.Text = (tajamo_second[0] + 1).ToString();
            label64.Text = (tajamo_second[1] + 1).ToString();
            label62.Text = (tajamo_second[2] + 1).ToString();
            label60.Text = (tajamo_second[3] + 1).ToString();
            label58.Text = (tajamo_second[4] + 1).ToString();
            label56.Text = (tajamo_second[5] + 1).ToString();
            label54.Text = (tajamo_second[6] + 1).ToString();

 //........
            FPtajamo_second[0] = int.Parse(label68.Text);
            FPtajamo_second[1] = int.Parse(label66.Text);
            FPtajamo_second[2] = int.Parse(label64.Text);
            FPtajamo_second[3] = int.Parse(label62.Text);
            FPtajamo_second[4] = int.Parse(label60.Text);
            FPtajamo_second[5] = int.Parse(label58.Text);
            FPtajamo_second[6] = int.Parse(label56.Text);
            FPtajamo_second[7] = int.Parse(label54.Text);


            if (tajamo_second[7] > 100 || tajamo_second[7] < 100)
            {
                MessageBox.Show("در صـــد وارد شده خارج از محدوده است \n\n (1-100) ");
                label85.Enabled = false;
                allow2 = 0;

            }
            else
            {
                label85.Enabled = true;
                allow2 = 1;
            }









        }
    }
}
