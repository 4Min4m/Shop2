using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using forooshgah;

 
   public  class threeTableF1
    {
       //public string   aa;
       public int ii = 0;
       public int[] dady1 = new int[4];
       public int[] dady2 = new int[4];
       

       public void ss1(ref string txt1,ref string txt2,ref string txt3,ref string txt4)
       {

           int a = 0;

           Form1 mm = new Form1();
           
             dady1[ii] =  int.Parse(txt1) ;
             dady1[ii+1] = int.Parse(txt2) ;
             dady1[ii + 2] = int.Parse(txt3);
             dady1[ii + 3] = int.Parse(txt4);
 
             a= dady2[ii] = dady1[ii];
             dady2[ii+1] = dady1[ii+1] + a;
             dady2[ii+2]= dady2[ii + 1] + dady1[ii + 2];
             dady2[ii + 3] = dady2[ii + 2] + dady1[ii + 3];
           //////////////////////////////////
              
       }
    //   public int[] ss2(ref int day)
     //  {

      // return new dady2[] ;

    //   }




    }

