using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        s1 s1 = new s1();       //1
        s2 s2 = new s2();     //2
        //s3 s3 = new s3();     //3
        //s4 s4 = new s4();     //4
        //s5 s5 = new s5();     //5
        //s6 s6 = new s6();     //6
        //s7 s7 = new s7();     //7
        //s8 s8 = new s8();     //8
        //s9 s9 = new s9();     //9
        //s10 s10 = new s10();  //10
        //s11 s11 = new s11();  //11
        //s12 s12 = new s12();  //12
        //s13 s13 = new s13();  //13
        //s14 s14 = new s14();  //14
        //s15 s15 = new s15();  //15
        //s16 s16 = new s16();  //16
        //s17 s17 = new s17();  //17
        //s18 s18 = new s18();  //18
        //s19 s19 = new s19();  //19
        //s20 s20 = new s20();  //20
        //s21 s21 = new s21();  //21
        //s22 s22 = new s22();  //22
        //s23 s23 = new s23();  //23
        //s24 s24 = new s24();  //24
        //s25 s25 = new s25();  //25
        //s26 s26 = new s26();  //26
        //s27 s27 = new s27();  //27
        //s28 s28 = new s28();  //28
        //s29 s29 = new s29();  //29
        //s30 s30 = new s30();  //30
        //s31 s31 = new s31();  //31
        //s32 s32 = new s32();  //32
        //s33 s33 = new s33();  //33
        //s34 s34 = new s34();  //34
        //s35 s35 = new s35();  //35
        //s36 s36 = new s36();  //36
        //s37 s37 = new s37();  //37
        //s38 s38 = new s38();  //38
        //s39 s39 = new s39();  //39
        //s40 s40 = new s40();  //40
        //s41 s41 = new s41();  //41
        //s42 s42 = new s42();  //42
        //s43 s43 = new s43();  //43
        //s44 s44 = new s44();  //44
        //s45 s45 = new s45();  //45
        //s46 s46 = new s46();  //46
        //s47 s47 = new s47();  //47
        //s48 s48 = new s48();  //48
        //s49 s49 = new s49();  //49

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //1
            if(s1.benar == 1)   
                soal1.BackColor = Color.Lime; 
            else if (s1.benar == 2)
                soal1.BackColor = Color.Red;
           
            // DONT TRY THIS AT HOME
            //2
            if (s2.benar == 1)
                soal2.BackColor = Color.Lime;
            else if (s2.benar == 2)
                soal2.BackColor = Color.Red;

            /*
            //3
            if (s3.benar == 1)
                soal3.BackColor = Color.Lime;
            else if (s3.benar == 2)
                soal3.BackColor = Color.Red;
            
            //4
            if (s4.benar == 1)
                soal4.BackColor = Color.Lime;
            else if (s4.benar == 2)
                soal4.BackColor = Color.Red;

            //5
            if (s5.benar == true)
                soal5.BackColor = Color.Lime;
            else if (s5.benar == false)
                soal5.BackColor = Color.Red;
            
            //6
            if (s6.benar == true)
                soal6.BackColor = Color.Lime;
            else if (s6.benar == false)
                soal6.BackColor = Color.Red;
            //7
            if (s7.benar == true)
                soal7.BackColor = Color.Lime;
            else if (s7.benar == false)
                soal7.BackColor = Color.Red;

            //8
            if (s8.benar == true)
                soal8.BackColor = Color.Lime;
            else if (s8.benar == false)
                soal8.BackColor = Color.Red;

            //9
            if (s9.benar == true)
                soal9.BackColor = Color.Lime;
            else if (s9.benar == false)
                soal9.BackColor = Color.Red;
            
            //10
            if (s10.benar == true)
                soal10.BackColor = Color.Lime;
            else if (s10.benar == false)
                soal10.BackColor = Color.Red;

            //11
            if (s11.benar == true)
                soal11.BackColor = Color.Lime;
            else if (s11.benar == false)
                soal11.BackColor = Color.Red;

            //12
            if (s12.benar == true)
                soal12.BackColor = Color.Lime;
            else if (s12.benar == false)
                soal12.BackColor = Color.Red;

            //13
            if (s13.benar == true)
                soal13.BackColor = Color.Lime;
            else if (s13.benar == false)
                soal13.BackColor = Color.Red;

            //14
            if (s14.benar == true)
                soal14.BackColor = Color.Lime;
            else if (s14.benar == false)
                soal14.BackColor = Color.Red;

            //15
            if (s15.benar == true)
                soal15.BackColor = Color.Lime;
            else if (s15.benar == false)
                soal5.BackColor = Color.Red;

            //16
            if (s16.benar == true)
                soal16.BackColor = Color.Lime;
            else if (s6.benar == false)
                soal16.BackColor = Color.Red;
            //17
            if (s17.benar == true)
                soal17.BackColor = Color.Lime;
            else if (s17.benar == false)
                soal17.BackColor = Color.Red;

            //18
            if (s18.benar == true)
                soal18.BackColor = Color.Lime;
            else if (s18.benar == false)
                soal18.BackColor = Color.Red;

            //19
            if (s19.benar == true)
                soal1.BackColor = Color.Lime;
            else if (s19.benar == false)
                soal19.BackColor = Color.Red;

            //20
            if (s20.benar == true)
                soal20.BackColor = Color.Lime;
            else if (s20.benar == false)
                soal20.BackColor = Color.Red;

            //21
            if (s21.benar == true)
                soal21.BackColor = Color.Lime;
            else if (s1.benar == false)
                soal21.BackColor = Color.Red;

            //22
            if (s22.benar == true)
                soal22.BackColor = Color.Lime;
            else if (s22.benar == false)
                soal2.BackColor = Color.Red;

            //23
            if (s23.benar == true)
                soal23.BackColor = Color.Lime;
            else if (s23.benar == false)
                soal23.BackColor = Color.Red;

            //24
            if (s24.benar == true)
                soal24.BackColor = Color.Lime;
            else if (s24.benar == false)
                soal24.BackColor = Color.Red;

            //25
            if (s25.benar == true)
                soal25.BackColor = Color.Lime;
            else if (s25.benar == false)
                soal25.BackColor = Color.Red;

            //26
            if (s26.benar == true)
                soal26.BackColor = Color.Lime;
            else if (s26.benar == false)
                soal26.BackColor = Color.Red;

            //27
            if (s27.benar == true)
                soal27.BackColor = Color.Lime;
            else if (s27.benar == false)
                soal27.BackColor = Color.Red;

            //28
            if (s28.benar == true)
                soal28.BackColor = Color.Lime;
            else if (s28.benar == false)
                soal28.BackColor = Color.Red;

            //29
            if (s29.benar == 1)
                soal29.BackColor = Color.Lime;
            else if (s29.benar == 2)
                soal29.BackColor = Color.Red;

            //30
            if (s30.benar == 1)
                soal30.BackColor = Color.Lime;
            else if (s30.benar == 2)
                soal30.BackColor = Color.Red;

            //31
            if (s31.benar == 1)
                soal31.BackColor = Color.Lime;
            else if (s31.benar == 2)
                soal31.BackColor = Color.Red;

            //32
            if (s32.benar == 1)
                soal32.BackColor = Color.Lime;
            else if (s32.benar == 2)
                soal32.BackColor = Color.Red;

            //33
            if (s33.benar == 1)
                soal33.BackColor = Color.Lime;
            else if (s33.benar == 2)
                soal33.BackColor = Color.Red;

            //34
            if (s34.benar == 1)
                soal34.BackColor = Color.Lime;
            else if (s34.benar == 2)
                soal34.BackColor = Color.Red;

            //35
            if (s35.benar == 1)
                soal35.BackColor = Color.Lime;
            else if (s35.benar == 2)
                soal35.BackColor = Color.Red;

            //36
            if (s36.benar == 1)
                soal36.BackColor = Color.Lime;
            else if (s36.benar == 2)
                soal36.BackColor = Color.Red;

            //37
            if (s37.benar == 1)
                soal37.BackColor = Color.Lime;
            else if (s7.benar == 2)
                soal37.BackColor = Color.Red;

            //38
            if (s38.benar == 1)
                soal38.BackColor = Color.Lime;
            else if (s38.benar == 2)
                soal38.BackColor = Color.Red;

            //39
            if (s39.benar == 1)
                soal39.BackColor = Color.Lime;
            else if (s39.benar == 2)
                soal39.BackColor = Color.Red;

            //40
            if (s40.benar == 1)
                soal40.BackColor = Color.Lime;
            else if (s40.benar == 2)
                soal40.BackColor = Color.Red;

            //41
            if (s41.benar == 1)
                soal41.BackColor = Color.Lime;
            else if (s41.benar == 2)
                soal41.BackColor = Color.Red;

            //42
            if (s42.benar == 1)
                soal42.BackColor = Color.Lime;
            else if (s42.benar == 2)
                soal42.BackColor = Color.Red;

            //43
            if (s43.benar == 1)
                soal43.BackColor = Color.Lime;
            else if (s43.benar == 2)
                soal43.BackColor = Color.Red;

            //44
            if (s44.benar == 1)
                soal44.BackColor = Color.Lime;
            else if (s44.benar == 2)
                soal44.BackColor = Color.Red;

            //45
            if (s45.benar == 1)
                soal45.BackColor = Color.Lime;
            else if (s45.benar == 2)
                soal45.BackColor = Color.Red;

            //46
            if (s46.benar == 1)
                soal46.BackColor = Color.Lime;
            else if (s46.benar == 2)
                soal46.BackColor = Color.Red;

            //47
            if (s47.benar == 1)
                soal47.BackColor = Color.Lime;
            else if (s47.benar == 2)
                soal47.BackColor = Color.Red;

            //48
            if (s48.benar == 1)
                soal48.BackColor = Color.Lime;
            else if (s48.benar == 2)
                soal48.BackColor = Color.Red;

            //49
            if (s49.benar == 1)
                soal49.BackColor = Color.Lime;
            else if (s49.benar == 2)
                soal49.BackColor = Color.Red;

            */

        }

        private void soal1_Click(object sender, EventArgs e) // 49 x
        {
             s1.ShowDialog();   //// dicopy ping 1000
        }

        private void soal2_Click(object sender, EventArgs e)
        {
            s2.ShowDialog();
        }
    }
}
