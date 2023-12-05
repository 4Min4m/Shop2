using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace forooshgah
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
 
  public string x;
  public string y;
  public int i = 0;
  public  string  cha;
  public string pre_cha;
  public string x2;
  public int value1;
  tozi__ehtemali f = new tozi__ehtemali();


  public int[] s_Tajamo_khdmatdehi3 = new int[4];
  public int[] s_Tajamo_khdmatdehi4 = new int[4];
  public  int[] s_dady2 = new int[4];  
        //......................First one
  public  int[] s_tajamo_first = new int[8];
  public  int[] s_FPtajamo_First =new int[8];
        //..................... second one
  public   int[] s_tajamo_second = new int[8];
  public int[] s_FPtajamo_second = new int[8];
        //.....................


 int gg;       
        private void Form2_Load(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
          
       int array_count = Convert .ToInt32(x);
       int minute = Convert.ToInt32 (y);
      // int  =Convert.ToInt32(textBox1.Text); 

            //--------------------------------
      // threeT.ss2(ref s_dady2[3]);
            //--------------------------------
      
            Random random = new Random();
            tozi__ehtemali nn = new tozi__ehtemali();



            
            Queue<string > queue = new Queue<string >();

            for (int d = 1; d <= array_count; d++)
            {
                //روزها
              //  listBox1.Items.Add(d+1);
                //اعداد تصادفی روی صف
               //.. int randomNumber = random.Next(0, 67);
                int randomNumber = random.Next(0, s_dady2[3]+1);
                queue.Enqueue(randomNumber.ToString());
            }
            
            #region declare arrays
                      
            // تعریف آرایه ها.
            string [] array = new string [queue.Count];
            string[] arrlist3 = new string[ array_count];
            int[] arrvoroody = new int[array_count];
            int[] arrlist5 = new int[array_count];

            int[,] arrtable = new int[10000,10000];

            #endregion
      //      f.min(arrtable );
            //--------------------------------------
            //   پر کردن لیست 1 
            for (int aa = 1; aa <= array_count ; aa++)
            {
                listBox1.Items.Add(aa);
            }
            #region Copy the Queue to the int array
            //   پر کردن لیست 2 
         //   while (minute <50)
            //{
            queue.CopyTo(array, 0);
            array[0] = "-";
            listBox2.Items.Add(array[0]);

            for(int d=1;d < array_count;d++)
            {                          
                listBox2.Items.Add(array[d]);
            }
          //  }
            #endregion
            //--------------------------------------

          //  پر کردن لیست باکس 3
            listBox3.Items.Add(array[0]);
            for (int d = 1; d < array_count; d++)
            {

              listBox3.Items.Add(  (nn.modat_zaman(Int32.Parse(array[d]), ref s_Tajamo_khdmatdehi3,ref s_Tajamo_khdmatdehi4)).ToString()  );
                //listBox3.Items.Add(nn.modat_zaman(Int32.Parse(array[d]).ToString(), ref s_Tajamo_khdmatdehi3,ref s_Tajamo_khdmatdehi4));               
            }
            listBox3.Items.CopyTo(arrlist3,0);


            //  پر کردن لیست باکس 4
 #region    add listbox4


            arrvoroody[0] = 0;
            listBox4 .Items .Add (arrvoroody[0]);
            for (int d=0;d < array_count;d++)
            {
                if (d < array_count - 1)
                {
                    a = Int32.Parse(arrlist3[d + 1]);
                    b = arrvoroody[d] + a;
                    arrvoroody[d + 1] = b;
                    //arrlist4.CopyTo(arrlist5, 0);
                    listBox4.Items.Add(b);
                }

            }  
       

            #endregion



 #region sum listbox
            //do the cast<> to type that your numbers are         
          string  ff = listBox4.Items.Cast<int>().Sum().ToString ();
 #endregion

      /*
             listBox5.Items.Add(0);
            for (int d = 1; d <= array_count; d++)
            {
                int randomNum = random.Next(0, 102);
                listBox11.Items.Add(randomNum);
                listBox6.Items.Add(nn.ran_num_service("A", randomNum));
                //زمان شروع خدمت           
                arrlist5[0] = 0;
                int xx= arrlist5[0];
                int yy = nn.ran_num_service("A", randomNum) + xx;
                listBox7.Items.Add(b);

            }
       */
        //  nn.GG(out  s_khdmatdehi_first, out  s_tajamo_first);
//*********************************************************
          int randomA = random.Next(0, 100);
            //.........
          listBox11.Items.Add(randomA);
            //.........
          arrtable [i,5] = arrvoroody[i] = 0;
          listBox12.Items.Add(0);
          int s = nn.ran_num_service("A", randomA, ref  s_FPtajamo_First, ref  s_tajamo_first,ref s_FPtajamo_second,ref s_tajamo_second);
          arrtable[i, 4] = s;
          cha  = "A";
          pre_cha = cha;
          arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
//1
          a = arrtable[i, 3];
           
          i = i + 1;
          //2 Intto  b first time
          if (a > arrvoroody[i])
          {
              arrtable[i, 2] = arrvoroody[i];
              listBox12.Items.Add(0);
              int randomB = random.Next(0, 100);
              //.........
              listBox11.Items.Add(randomB);
              //.........
              s = f.ran_num_service("B", randomB, ref s_FPtajamo_First, ref s_tajamo_first,ref s_FPtajamo_second,ref s_tajamo_second );
              arrtable[i, 1] = s;
              cha = "B";
              x2 = cha;
              arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
              b = arrtable[i, 0];
          }
          else
          {

            arrtable[i, 5] = arrvoroody[i];
            listBox12.Items.Add(0);
            randomA = random.Next(0, 100);
            //.........
            listBox11.Items.Add(randomA);
            //.........
            s = f.ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
            arrtable[i, 4] = s;
            cha = "A";
            x2 = cha;
            arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
            b=arrtable[i, 3];
              //Intto  b first time
          }
  //2..   
 
        // یک متغیر هم برای تعداد محاسبات و array_count
           // هم برای تعداد لیست های 2 و 3 و 4 است 

          int record_no = array_count ;
          int w = record_no - 2;
          for (int d=0; d < w; d++)
          {
              i = i + 1;
              //next service start No.

              //where shoud it be?
              f.big_compare(ref a, ref b, ref cha, ref pre_cha, ref x2, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first,ref s_FPtajamo_second,ref s_tajamo_second );
              listBox11.Items.Add(f.list12);
              listBox12.Items.Add(f.w_time);

          }




         int t=-1;
         var stories = 1;      
         int r=0;        
                 while (stories <= array_count)
                 {
                    
                     t += 1;
                     r = 0;
                     listBox10.Items.Add(arrtable[t, r]);
                     listBox9.Items.Add(arrtable[t, r + 1]);
                     listBox8.Items.Add(arrtable[t, r + 2]);
                     listBox7.Items.Add(arrtable[t, r + 3]);
                     listBox6.Items.Add(arrtable[t, r + 4]);
                     listBox5.Items.Add(arrtable[t, r + 5]);
                   //  if (Int32.Parse(listBox7.Items[t].ToString()) > 7 || Int32.Parse(listBox10.Items[t].ToString()) > 7)
                   //     stories  = 500;
                 //    else             
                        stories++; 
                   
                }


                 

                     //لیست باکس ها جمع 
                     for (int z = 1; z < array_count; z++)
                     {
                         // int gg=0;
                         gg += Int32.Parse(listBox3.Items[z].ToString());

                     }

                     label45.Text = Convert.ToString(gg);

                     //فروشنده اول  :جمع زمان خدمتدهی
                     string khedmatdehi_time_1 = listBox6.Items.Cast<int>().Sum().ToString();
                     label46.Text = khedmatdehi_time_1;
                     //فروشنده دوم  :جمع زمان خدمتدهی
                     string khedmatdehi_time_2 = listBox9.Items.Cast<int>().Sum().ToString();
                     label47.Text = khedmatdehi_time_2;

                     string queue_waiting = listBox12.Items.Cast<int>().Sum().ToString();
                     label65.Text = queue_waiting;
                     //جمع مدت انتظار مشتریان
                     label57.Text = queue_waiting;
                     //مجموع تعداد مشتریان
                     label66.Text = listBox1.GetItemText(array_count) + " = ";
                     string ws = listBox1.GetItemText(array_count);

                     //متوسط مدت انتظار هر مشتری***********
                     float vv = ((float)(Convert.ToInt32(queue_waiting)) / (float)(Int32.Parse(ws)));
                     label67.Text = (string.Format("{0:f2}", vv)) + " * " + minute;
                     label94.Text = ((vv) * ((float)(minute))).ToString() + "  min";

                     //متوسط مدت انتظار مشتریان منتظر
                     label68.Text = queue_waiting;
                     int wa = 0;

                     for (int ww = 0; ww < array_count; ww++)
                     {

                         if (listBox12.Items[ww].ToString() != "0")
                         {
                             wa = wa += 1;
                         }
                     }

                     label70.Text = wa.ToString();
                     float vvv = ((float)(Convert.ToInt32(queue_waiting)) / (float)((wa)));
                     label71.Text = "=" + (string.Format("{0:f2}", vvv)) + " * " + minute;
                     label95.Text = ((vvv) * ((float)(minute))).ToString() + "  min";

                     //-------------//  آخرین عدد پایان خدمت َاول و دوم //--------------



                     int maxValue = 0;
                     if (listBox7.Items.Count > 0)
                     {
                         maxValue = Convert.ToInt32(listBox7.Items[0]);
                     }
                     for (int ss = 0; ss < listBox7.Items.Count; ss++)
                     {
                         if (maxValue < Convert.ToInt32(listBox7.Items[ss]))
                         {
                             maxValue = Convert.ToInt32(listBox7.Items[ss]);
                         }
                     }


                     if (listBox10.Items.Count > 0)
                     {
                         value1 = Convert.ToInt32(listBox10.Items[0]);
                     }

                     for (int ss = 0; ss < listBox10.Items.Count; ss++)
                     {
                         if (value1 < Convert.ToInt32(listBox10.Items[ss]))
                         {
                             value1 = Convert.ToInt32(listBox10.Items[ss]);
                         }
                     }

                     if (maxValue >= value1)
                     { label56.Text = maxValue.ToString() + "  " + "دقیقـــــه"; }
                     else
                     { label56.Text = value1.ToString() + "  " + "دقیقـــــه"; ; }





                     //------------------------ درصد مشغولیت فروشنده اول
                     label72.Text = label46.Text;
                     label74.Text = maxValue.ToString();
                     float v4 = ((float)(Convert.ToInt32(label72.Text)) / (float)((Int32.Parse(label74.Text))));
                     label78.Text = "=" + (string.Format("{0:f2}", v4)) + " " + "%";
                     //-------------------------درصد مشغولیت فروشنده دوم
                     label77.Text = label47.Text;
                     label75.Text = value1.ToString();
                     float v5 = ((float)(Convert.ToInt32(label77.Text)) / (float)((Int32.Parse(label75.Text))));
                     label79.Text = "=" + (string.Format("{0:f2}", v5)) + " " + "%";


                     //-------------------------------درصد افراد انتظار کشیده یا احتمال انتظار هر مشتری

                     label50.Text = wa.ToString();
                     label80.Text = listBox1.GetItemText(array_count);
                     float v6 = ((float)(Convert.ToInt32(label50.Text)) / (float)((Int32.Parse(label80.Text))));
                     label81.Text = "=" + (string.Format("{0:f2}", v6)); //+ " * " + minute;
                   //  label96.Text = ((v6) * ((float)(minute))).ToString() + "  min";
                     label96.Visible = false;


                     //-------------------------------* 15 متوسط مدت بین دو ورود

                     label82.Text = label45.Text;
                     label84.Text = listBox1.GetItemText(array_count - 1);
                     float v7 = ((float)(Convert.ToInt32(label82.Text)) / (float)((Int32.Parse(label84.Text))));
                     label85.Text = "=" + (string.Format("{0:f2}", v7)) + " * " + minute;
                     label97.Text =((v7) * ((float)(minute))).ToString() + "  min";

                     //------------------------------ متوسط ودت خدمت دهی فروشنده اول * 15

                     label86.Text = label46.Text;
                     label88.Text = listBox1.GetItemText(array_count - 1);
                     float v8 = ((float)(Convert.ToInt32(label86.Text)) / (float)((Int32.Parse(label88.Text))));
                     label89.Text = "=" + (string.Format("{0:f2}", v8)) + " * " + minute;
                     label98.Text = ((v8) * ((float)(minute))).ToString() + "  min";



                     //------------------------------ متوسط ودت خدمت دهی فروشنده دوم *15 
                     label90.Text = label47.Text;
                     label92.Text = listBox1.GetItemText(array_count - 1);
                     float v9 = ((float)(Convert.ToInt32(label90.Text)) / (float)((Int32.Parse(label92.Text))));
                     label93.Text = "=" + (string.Format("{0:f2}", v9)) + " * " + minute;
                     label99.Text = ((v9) * ((float)(minute))).ToString() + "  min";
                     //احتمال بیکاری فروشنده اول

                     //احتمال بیکاری فروشنده دوم

                     //احتمال انتظار
                 
          
      }//from load

        private void button1_Click(object sender, EventArgs e)
        {
            listBox5.ClearSelected();
            listBox6.ClearSelected();
            listBox7.ClearSelected();
            listBox8.ClearSelected();
            listBox9.ClearSelected();
            listBox10.ClearSelected();
            listBox4.ClearSelected();
            listBox3.ClearSelected();
            listBox2.ClearSelected();
            listBox1.ClearSelected();
            listBox11.ClearSelected();
            listBox12.ClearSelected();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

     toolTip1.Show("refresh all listboxes", button1,e.X , e.Y-30);

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(button1);
        }




          }


        }




      




