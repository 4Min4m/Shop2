using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


 public class tozi__ehtemali
{


     //two array 3_4
    public int[] s_Tajamo_khdmatdehi3 = new int[4];
    public int[] s_Tajamo_khdmatdehi4 = new int[4];


     //
  //  public int[] s_khdmatdehi_first = new int[8];
    public int[] s_tajamo_first = new int[8];
    public int[] s_FPtajamo_First = new int[8];

     //----------------------------------------
    public int[] s_tajamo_second = new int[8];
    public int[] s_FPtajamo_second = new int[8];
     //----------------------------------------
   // public string A_B;
  int ss;
  public  int w_time;
  public int list12;
  public int t;
   // string str;
   // int a;
   // int b;
   // int i;

    Random random = new Random();

   //  public int min(int[,] arrtable)
   // {
   //    arrtable []
    //    return 5;
   // }

    
    private void temporary(ref string  cha, ref string  pre_cha)
    {
        if (t == 1)
        {
            string temp = cha;
        }
        else
        {
            string temp = cha;
            pre_cha = temp;
        }
        // return a;
    }


    private  void  temporary(ref int a,ref int b)
    {
        if (a > b)
        {
            int temp = b;
            t = 1;
        }
        else
        {
            int temp = b;
            a = temp;
            t = 0;
        }
       // return a;
    }

    public int taeen(int a, int b, int i, int[] arrvoroody, int[,] arrtable, ref int[] s_FPtajamo_First, ref int[] s_tajamo_first, ref int[] s_FPtajamo_second,  int[] s_tajamo_second)
    {
     
        if (b > a)
        {
            if (a >= arrvoroody[i])
            {
                //arrtable[i + 1, 2] = a;
                ss = a;
                w_time = a - arrvoroody[i];
               
            }
            else
            {
               // arrtable[i + 1, 2] = arrvoroody[i + 1];
                ss = arrvoroody[i];
                w_time = 0;
            }
        }
      else  if (b < a)
        {
            if (b >= arrvoroody[i])
            {
               // arrtable[i + 1, 2] = b;
                ss = b;
                w_time = b - arrvoroody[i];
            }
            else
            {
              //  arrtable[i + 1, 2] = arrvoroody[i + 1];
                ss = arrvoroody[i];
                w_time = 0;
            }
        }
        else if (b == a)
        {
            if (a <= arrvoroody[i])
            {
                //arrtable[i + 1, 2] = a;
                ss = arrvoroody[i];
                w_time = 0;
            }
            else
            {
                // arrtable[i + 1, 2] = arrvoroody[i + 1];
                ss = a;
                w_time = a - arrvoroody[i];
            }
        }

        return ss;



    }

    public void big_compare(ref int a, ref int b, ref string cha, ref string pre_cha, ref string x2, int i, int[] arrvoroody, int[,] arrtable, ref int[] s_FPtajamo_First, ref int[] s_tajamo_first, ref int[] s_FPtajamo_second, ref int[] s_tajamo_second)
    {
        if (b > a)
        {
            if ((a < arrvoroody[i] && arrvoroody[i] < b))
            {

                taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first,ref s_FPtajamo_second,  s_tajamo_second);
                //  Comparer A or B  
         //if(first A/B = second A/B)

                int s2 = char_condition3(ref cha,ref pre_cha,ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);


                string str = cha;
                if (cha == "B" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "A")
                {
                    //B
                    arrtable[i, 1] = s2;
                    arrtable[i, 2] = ss;
                    arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 0];                             
                    cha = "B";

                }
                else if (cha == "B" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";

                }
                else if (cha == "A" && pre_cha == "B")
                {
                    //B
                    arrtable[i, 1] = s2;
                    arrtable[i, 2] = ss;
                    arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 0];
                    cha = "B";
                }

                
            }
//cccccccccccccccccccccccccccccccccccccccccc
            else if ((a > arrvoroody[i] && b < arrvoroody[i]))
            {
                taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second,  s_tajamo_second);
                //  Comparer A or B           
                int s2 = char_condition3(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);

                string str = cha;
                if (cha == "B" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "A")
                {
                    //B
                    arrtable[i, 1] = s2;
                    arrtable[i, 2] = ss;
                    arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 0];
                    cha = "B";
                }
                else if (cha == "B" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "B")
                {
                    //B
                    arrtable[i, 1] = s2;
                    arrtable[i, 2] = ss;
                    arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 0];
                    cha = "B";
                }

            }



  //ccccccccccccccccccccccccccccccccccccc
            else if ((a > arrvoroody[i] && arrvoroody[i] < b))
        {
            taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second,  s_tajamo_second);
            //  Comparer A or B           
            int s2 = char_condition3(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
            string str = cha;

            if (cha == "B" && pre_cha == "A")
            {
                //A
                arrtable[i, 4] = s2;
                arrtable[i, 5] = ss;
                arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 3];
                cha = "A";

            }
            else if (cha == "A" && pre_cha == "A")
            {
                //B
                arrtable[i, 1] = s2;
                arrtable[i, 2] = ss;
                arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 0];
                cha = "B";
            }
            else if (cha == "B" && pre_cha == "B")
            {
                //A
                arrtable[i, 4] = s2;
                arrtable[i, 5] = ss;
                arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 3];
                cha = "A";

            }
            else if (cha == "A" && pre_cha == "B")
            {
                //B
                arrtable[i, 1] = s2;
                arrtable[i, 2] = ss;
                arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 0];
                cha = "B";
            }

        }
            else if (a == arrvoroody[i])
        {


            taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second,  s_tajamo_second);
            //  Comparer A or B           
            int s2 = char_condition3(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
            string str = cha;
 
            if (cha == "B" && pre_cha == "A")
            {
                //A
                arrtable[i, 4] = s2;
                arrtable[i, 5] = ss;
                arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 3];
                cha = "A";
            }
            else if (cha == "A" && pre_cha == "A")
            {
                //B
                arrtable[i, 1] = s2;
                arrtable[i, 2] = ss;
                arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 0];
                cha = "B";
            }
            else if (cha == "B" && pre_cha == "B")
            {
                //A
                arrtable[i, 4] = s2;
                arrtable[i, 5] = ss;
                arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 3];
                cha = "A";
            }
            else if (cha == "A" && pre_cha == "B")
            {
                //B
                arrtable[i, 1] = s2;
                arrtable[i, 2] = ss;
                arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 0];
                cha = "B";
            }

        }
            else if (b == arrvoroody[i])
        {
            taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, s_tajamo_second);
            //  Comparer A or B           
            int s2 = char_condition1(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
            
            string str = cha;
            if (cha == "B" && pre_cha == "A")
            {
                //A
                arrtable[i, 4] = s2;
                arrtable[i, 5] = ss;
                arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 3];
                cha = "A";
            }
            else if (cha == "A" && pre_cha == "A")
            {
                //A
                arrtable[i, 4] = s2;
                arrtable[i, 5] = ss;
                arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 3];
                cha = "A";
            }
            else if (cha == "B" && pre_cha == "B")
            {
                //A
                arrtable[i, 4] = s2;
                arrtable[i, 5] = ss;
                arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 3];
                cha = "A";

            }
            else if (cha == "A" && pre_cha == "B")
            {
                //A
                arrtable[i, 4] = s2;
                arrtable[i, 5] = ss;
                arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 3];
                cha = "A";
            }
        }
            else if ((a < arrvoroody[i] && arrvoroody[i] > b))
        {
            taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second,  s_tajamo_second);
            //  Comparer A or B           
            int s2 = char_condition1(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
            string str = cha;
            if (cha == "B" && pre_cha == "A")
            {
                //A
                arrtable[i, 4] = s2;
                arrtable[i, 5] = ss;
                arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 3];
                cha = "A";
            }
            else if (cha == "A" && pre_cha == "A")
            {
                //A
                arrtable[i, 4] = s2;
                arrtable[i, 5] = ss;
                arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 3];
                cha = "A";
            }
            else if (cha == "B" && pre_cha == "B")
            {
                //A
                arrtable[i, 4] = s2;
                arrtable[i, 5] = ss;
                arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 3];
                cha = "A";
            }
            else if (cha == "A" && pre_cha == "B")
            {
                //A
                arrtable[i, 4] = s2;
                arrtable[i, 5] = ss;
                arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                temporary(ref a, ref b);
                temporary(ref cha, ref pre_cha);
                b = arrtable[i, 3];
                cha = "A";
            }

        }
   
    }

        else if (b < a)
        {
            //حالت غیر ممکن
            if ((a < arrvoroody[i] && arrvoroody[i] < b))
            {
                taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, s_tajamo_second);
                //  Comparer A or B           
                int s2 = char_condition2(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                string str = cha;
                if (cha == "B" && pre_cha == "A")
                {
                    //B
                    arrtable[i, 1] = s2;
                    arrtable[i, 2] = ss;
                    arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 0];
                    cha = "B";
                }
                else if (cha == "A" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "B" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }

            }
                //ccccccccccccccccccccccccccccc
            else if ((a > arrvoroody[i] && b < arrvoroody[i]))
            {
                taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, s_tajamo_second);
                //  Comparer A or B           
                int s2 = char_condition2(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);

                string str = cha;
                if (cha == "B" && pre_cha == "A")
                {
                    //B
                    arrtable[i, 1] = s2;
                    arrtable[i, 2] = ss;
                    arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 0];
                    cha = "B";
                }
                else if (cha == "A" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "B" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }

            }


                //cccccccccccccccccccccccccccccccc



            else if ((a > arrvoroody[i] && b > arrvoroody[i]))
            {
                taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second,  s_tajamo_second);
                //  Comparer A or B           
                int s2 = char_condition5(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);

                string str = cha;
                if (cha == "B" && pre_cha == "A")
                {
                    //B
                    arrtable[i, 1] = s2;
                    arrtable[i, 2] = ss;
                    arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 0];
                    cha = "B";
                }
                else if (cha == "A" && pre_cha == "A")
                {
                    //B
                    arrtable[i, 1] = s2;
                    arrtable[i, 2] = ss;
                    arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 0];
                    cha = "B";
                }
                else if (cha == "B" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }

            }
            else if (a == arrvoroody[i])
            {
                taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, s_tajamo_second);
                //  Comparer A or B           
                int s2 = char_condition1(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);

                string str = cha;
                if (cha == "B" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "B" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }

            }

            else if ((b == arrvoroody[i]))
            {
                taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second,  s_tajamo_second);
                //  Comparer A or B           
                int s2 = char_condition2(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);

                string str = cha;
                if (cha == "B" && pre_cha == "A")
                {
                    //B
                    arrtable[i, 1] = s2;
                    arrtable[i, 2] = ss;
                    arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 0];
                    cha = "B";
                }
                else if (cha == "A" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "B" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }

            }
            else if ((a < arrvoroody[i] && arrvoroody[i] > b))
            {

                taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second,s_tajamo_second);
                //  Comparer A or B           
                int s2 = char_condition1(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);

                string str = cha;
                if (cha == "B" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "B" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }

            }

        }

        else if (b == a)
        {
            if (a > arrvoroody[i])
            {
                taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second,s_tajamo_second);
                //  Comparer A or B           
                int s2 = char_condition4(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);

                string str = cha;
                if (cha == "B" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "A")
                {
                    //B
                    arrtable[i, 1] = s2;
                    arrtable[i, 2] = ss;
                    arrtable[i, 0] = arrtable[i, 1] + arrtable[i, 2];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 0];
                    cha = "B";
                }
                else if (cha == "B" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }

            }
            else if (a == arrvoroody[i])
            {
                taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, s_tajamo_second);
                //  Comparer A or B           
                int s2 = char_condition1(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                string str = cha;
                if (cha == "B" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "B" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }

            }
            else if (a < arrvoroody[i])
            {
                taeen(a, b, i, arrvoroody, arrtable, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, s_tajamo_second);
                //  Comparer A or B           
                int s2 = char_condition1(ref cha, ref pre_cha, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                string str = cha;

                if (cha == "B" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "A")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "B" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }
                else if (cha == "A" && pre_cha == "B")
                {
                    //A
                    arrtable[i, 4] = s2;
                    arrtable[i, 5] = ss;
                    arrtable[i, 3] = arrtable[i, 4] + arrtable[i, 5];
                    temporary(ref a, ref b);
                    temporary(ref cha, ref pre_cha);
                    b = arrtable[i, 3];
                    cha = "A";
                }

            }

        }

     //   pre_cha = cha;
        



    }


    public int modat_zaman(int s,ref int[] s_Tajamo_khdmatdehi3,ref int[] s_Tajamo_khdmatdehi4 )
    {

        if ((s <= s_Tajamo_khdmatdehi3 [0]) && (s >= s_Tajamo_khdmatdehi4[0]))
        {
           // s = 40.ToString();
            s = 1;
        }
        else if ((s <= s_Tajamo_khdmatdehi3[1]) && (s >= s_Tajamo_khdmatdehi4[1]))
        {
            s = 2;
        }
        else if ((s <= s_Tajamo_khdmatdehi3[2]) && (s >= s_Tajamo_khdmatdehi4[2]))
        {
            s = 3;
        }
        else if ((s == 0) || (s >= s_Tajamo_khdmatdehi4[3]))
        {
            s = 4;
        }
        return s;

    }

    #region char_condition

    public int ran_num_service(string type, int rnd_num, ref int[] s_FPtajamo_First, ref int[] s_tajamo_first,ref int[] s_FPtajamo_second,ref int[] s_tajamo_second)
    {

        switch (type)
        {
            case "A":
            case "a":
                {
                    if ((rnd_num <= s_tajamo_first[0]) && (rnd_num >= 1))
                    {
                        // s = 40.ToString();
                        rnd_num = 1;
                    }
                    else if ((rnd_num <= s_tajamo_first[1]) && (rnd_num >= s_FPtajamo_First[1]))
                    {
                        rnd_num = 2;
                    }
                    else if ((rnd_num <= s_tajamo_first[2]) && (rnd_num >= s_FPtajamo_First[2]))
                    {
                        rnd_num = 3;
                    }
                    else if ((rnd_num <= s_tajamo_first[3]) && (rnd_num >= s_FPtajamo_First[3]))
                    {
                        rnd_num = 4;
                    }
                    else if ((rnd_num <= s_tajamo_first[4]) && (rnd_num >= s_FPtajamo_First[4]))
                    {
                        rnd_num = 5;
                    }
                    else if ((rnd_num <= s_tajamo_first[5]) && (rnd_num >= s_FPtajamo_First[5]))
                    {
                        rnd_num = 6;
                    }
                    else if ((rnd_num <= s_tajamo_first[6]) && (rnd_num >= s_FPtajamo_First[6]))
                    {
                        rnd_num = 7;
                    }
                    else if ((rnd_num == 0) || (rnd_num >= s_FPtajamo_First[7]))
                    {
                        rnd_num = 8;
                    }
                    return rnd_num;

                    break;
                }
            case "B":
            case "b":
                {
                    if ((rnd_num <= s_tajamo_second[0]) && (rnd_num >= 1))
                    {
                        // rnd_num = 40.ToString();
                        rnd_num = 1;
                    }
                    else if ((rnd_num <= s_tajamo_second[1]) && (rnd_num >= s_FPtajamo_second[1]))
                    {
                        rnd_num = 2;
                    }
                    else if ((rnd_num <= s_tajamo_second[2]) && (rnd_num >= s_FPtajamo_second[2]))
                    {
                        rnd_num = 3;
                    }
                    else if ((rnd_num <= s_tajamo_second[3]) && (rnd_num >= s_FPtajamo_second[3]))
                    {
                        rnd_num = 4;
                    }
                    else if ((rnd_num <= s_tajamo_second[4]) && (rnd_num >= s_FPtajamo_second[4]))
                    {
                        rnd_num = 5;
                    }
                    else if ((rnd_num <= s_tajamo_second[5]) && (rnd_num >= s_FPtajamo_second[5]))
                    {
                        rnd_num = 6;
                    }
                    else if ((rnd_num <= s_tajamo_second[6]) && (rnd_num >= s_FPtajamo_second[6]))
                    {
                        rnd_num = 7;
                    }
                    else if ((rnd_num == 0) || (rnd_num >= s_FPtajamo_second[7]))
                    {
                        rnd_num = 8 ;
                    }
                    return rnd_num;
                    break;
                }
          
            default:

                break;

        }
        return rnd_num;

    }
    #endregion

    //888888888888888888888888888888888888888888888888888888

    public int char_condition3(ref string cha, ref string pre_cha, ref int[] s_FPtajamo_First, ref int[] s_tajamo_first, ref int[] s_FPtajamo_second, ref int[] s_tajamo_second)
        {
            int s = 0;
            //........................................
            if (cha  == "B" && pre_cha == "A" )
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                //.........
                list12 = randomA;
                
                //.........
              //  cha = "A";
            }
            else if ( cha  == "A" && pre_cha == "A")
            {
                int randomB = random.Next(0, 100);
                s = ran_num_service("B", randomB, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomB;
            }
            else if (cha  == "B"&& pre_cha == "B")
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomA;
               // cha = "A";
            }
            else if (cha == "A" && pre_cha == "B")
            {
                int randomB = random.Next(0, 100);
                s = ran_num_service("B", randomB, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomB;
               // cha = "B";
            }
            //........................................
          return  s;
        }

  //  000000000000000000000000000000000000000000

    public int char_condition1(ref string cha, ref string pre_cha, ref int[] s_FPtajamo_First, ref int[] s_tajamo_first, ref int[] s_FPtajamo_second, ref int[] s_tajamo_second)
        {
            int s = 0;
            //........................................
            if (cha == "B" && pre_cha == "A")
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomA;
               // cha = "A";
            }
            else if (cha == "A" && pre_cha == "A")
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomA;
               // cha = "A";
            }
            else if (cha == "B" && pre_cha == "B")
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomA;
               // cha = "A";
            }
            else if (cha == "A" && pre_cha == "B")
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomA;
              //  cha = "A";
            }
            return s;
        }
        //  000000000000000000000000000000000000000000

    public int char_condition5(ref string cha, ref string pre_cha, ref int[] s_FPtajamo_First, ref int[] s_tajamo_first, ref int[] s_FPtajamo_second, ref int[] s_tajamo_second)
        {
            int s = 0;
            //........................................
            if (cha == "B" && pre_cha == "A")
            {
                int randomB = random.Next(0, 100);
                s = ran_num_service("B", randomB, ref s_FPtajamo_First, ref s_tajamo_first,ref s_FPtajamo_second,ref s_tajamo_second);
                list12 = randomB;
               // cha = "B";
            }
            else if (cha == "A" && pre_cha == "A")
            {
                int randomB = random.Next(0, 100);
                s = ran_num_service("B", randomB, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomB;
            }
            else if (cha == "B" && pre_cha == "B")
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomA;
            }
            else if (cha == "A" && pre_cha == "B")
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomA;
            }
            return s;
        }
    //  000000000000000000000000000000000000000000
    public int char_condition4(ref string cha, ref string pre_cha, ref int[] s_FPtajamo_First, ref int[] s_tajamo_first, ref int[] s_FPtajamo_second, ref int[] s_tajamo_second)
        {
            int s = 0;
            //........................................
            if (cha == "B" && pre_cha == "A")
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomA;
            }
            else if (cha == "A" && pre_cha == "A")
            {
                int randomB = random.Next(0, 100);
                s = ran_num_service("B", randomB, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomB;
            }
            else if (cha == "B" && pre_cha == "B")
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomA;
            }
            else if (cha == "A" && pre_cha == "B")
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomA;
            }
            return s;
        }


    public int char_condition2(ref string cha, ref string pre_cha, ref int[] s_FPtajamo_First, ref int[] s_tajamo_first, ref int[] s_FPtajamo_second, ref int[] s_tajamo_second)
        {
            int s = 0;
            //........................................
            if (cha == "B" && pre_cha == "A")
            {
                int randomB = random.Next(0, 100);
                s = ran_num_service("B", randomB, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomB;
            }
            else if (cha == "A" && pre_cha == "A")
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);

                list12 = randomA;
            }
            else if (cha == "B" && pre_cha == "B")
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomA;
               // cha = "A";
            }
            else if (cha == "A" && pre_cha == "B")
            {
                int randomA = random.Next(0, 100);
                s = ran_num_service("A", randomA, ref s_FPtajamo_First, ref s_tajamo_first, ref s_FPtajamo_second, ref s_tajamo_second);
                list12 = randomA;
            }
            return s;
        }
    //000000000000000000000000000000000000000000000000
  
     //تــــــوجه : برای بی ها از دو دو آرایه جدا استفاده می شود و برای ای هم جدا گانه
     //ولی هر چهار پارامتر در تابع استفاده میشوند













    
}




