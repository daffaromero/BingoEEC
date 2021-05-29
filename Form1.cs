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
        s3 s3 = new s3();     //3
        s4 s4 = new s4();     //4
        s5 s5 = new s5();     //5
        s6 s6 = new s6();     //6
        s7 s7 = new s7();     //7
        s8 s8 = new s8();     //8
        s9 s9 = new s9();     //9
        s10 s10 = new s10();  //10
        s11 s11 = new s11();  //11
        s12 s12 = new s12();  //12
        s13 s13 = new s13();  //13
        s14 s14 = new s14();  //14
        s15 s15 = new s15();  //15
        s16 s16 = new s16();  //16
        s17 s17 = new s17();  //17
        s18 s18 = new s18();  //18
        s19 s19 = new s19();  //19
        s20 s20 = new s20();  //20
        s21 s21 = new s21();  //21
        s22 s22 = new s22();  //22
        s23 s23 = new s23();  //23
        s24 s24 = new s24();  //24
        s25 s25 = new s25();  //25
        s26 s26 = new s26();  //26
        s27 s27 = new s27();  //27
        s28 s28 = new s28();  //28
        s29 s29 = new s29();  //29
        s30 s30 = new s30();  //30
        s31 s31 = new s31();  //31
        s32 s32 = new s32();  //32
        s33 s33 = new s33();  //33
        s34 s34 = new s34();  //34
        s35 s35 = new s35();  //35
        s36 s36 = new s36();  //36
        s37 s37 = new s37();  //37
        s38 s38 = new s38();  //38
        s39 s39 = new s39();  //39
        s40 s40 = new s40();  //40
        s41 s41 = new s41();  //41
        s42 s42 = new s42();  //42
        s43 s43 = new s43();  //43
        s44 s44 = new s44();  //44
        s45 s45 = new s45();  //45
        s46 s46 = new s46();  //46
        s47 s47 = new s47();  //47
        s48 s48 = new s48();  //48
        s49 s49 = new s49();  //49

        public Form1()
        {
            InitializeComponent();
        }

        public int teamnum = 0;
        public int teamnummod = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //1
            if (s1.benars1 == 1)
                soal1.BackColor = Color.DeepSkyBlue;
            else if (s1.benars1 == 2)
                soal1.BackColor = Color.SpringGreen;
            else if (s1.benars1 == 3)
                soal1.BackColor = Color.Goldenrod;

            // DONT TRY THIS AT HOME
            // Arizona State University -Dafrom
            //2
            if (s2.benar == 1)
                soal2.BackColor = Color.DeepSkyBlue;
            else if (s2.benar == 2)
                soal2.BackColor = Color.SpringGreen;
            else if (s2.benar == 3)
                soal2.BackColor = Color.Goldenrod;


            ////3
            if (s3.benar == 1)
                soal3.BackColor = Color.DeepSkyBlue;
            else if (s3.benar == 2)
                soal3.BackColor = Color.SpringGreen;
            else if (s3.benar == 3)
                soal3.BackColor = Color.Goldenrod;

            ////4
            if (s4.benar == 1)
                soal4.BackColor = Color.DeepSkyBlue;
            else if (s4.benar == 2)
                soal4.BackColor = Color.SpringGreen;
            else if (s4.benar == 3)
                soal4.BackColor = Color.Goldenrod;

            ////5
            if (s5.benar == 1)
                soal5.BackColor = Color.DeepSkyBlue;
            else if (s5.benar == 2)
                soal5.BackColor = Color.SpringGreen;
            else if (s5.benar == 3)
                soal5.BackColor = Color.Goldenrod;

            ////6
            if (s6.benar == 1)
                soal6.BackColor = Color.DeepSkyBlue;
            else if (s6.benar == 2)
                soal6.BackColor = Color.SpringGreen;
            else if (s6.benar == 3)
                soal6.BackColor = Color.Goldenrod;
            ////7
            if (s7.benar == 1)
                soal7.BackColor = Color.DeepSkyBlue;
            else if (s7.benar == 2)
                soal7.BackColor = Color.SpringGreen;
            else if (s7.benar == 3)
                soal7.BackColor = Color.Goldenrod;

            ////8
            if (s8.benar == 1)
                soal8.BackColor = Color.DeepSkyBlue;
            else if (s8.benar == 2)
                soal8.BackColor = Color.SpringGreen;
            else if (s8.benar == 3)
                soal8.BackColor = Color.Goldenrod;

            ////9
            if (s9.benar == 1)
                soal9.BackColor = Color.DeepSkyBlue;
            else if (s9.benar == 2)
                soal9.BackColor = Color.SpringGreen;
            else if (s9.benar == 3)
                soal9.BackColor = Color.Goldenrod;

            //10
            if (s10.benar == 1)
                soal10.BackColor = Color.DeepSkyBlue;
            else if (s10.benar == 2)
                soal10.BackColor = Color.SpringGreen;
            else if (s10.benar == 3)
                soal10.BackColor = Color.Goldenrod;

            //11
            if (s11.benar == 1)
                soal11.BackColor = Color.DeepSkyBlue;
            else if (s11.benar == 2)
                soal11.BackColor = Color.SpringGreen;
            else if (s11.benar == 3)
                soal11.BackColor = Color.Goldenrod;

            // DONT TRY THIS AT HOME
            // Arizona State University -Dafrom
            //12
            if (s12.benar == 1)
                soal12.BackColor = Color.DeepSkyBlue;
            else if (s12.benar == 2)
                soal2.BackColor = Color.SpringGreen;
            else if (s12.benar == 3)
                soal2.BackColor = Color.Goldenrod;


            ////13
            if (s13.benar == 1)
                soal13.BackColor = Color.DeepSkyBlue;
            else if (s13.benar == 2)
                soal13.BackColor = Color.SpringGreen;
            else if (s13.benar == 3)
                soal13.BackColor = Color.Goldenrod;

            ////14
            if (s14.benar == 1)
                soal14.BackColor = Color.DeepSkyBlue;
            else if (s14.benar == 2)
                soal14.BackColor = Color.SpringGreen;
            else if (s14.benar == 3)
                soal14.BackColor = Color.Goldenrod;

            ////15
            if (s15.benar == 1)
                soal15.BackColor = Color.DeepSkyBlue;
            else if (s15.benar == 2)
                soal15.BackColor = Color.SpringGreen;
            else if (s15.benar == 3)
                soal15.BackColor = Color.Goldenrod;

            ////16
            if (s16.benar == 1)
                soal16.BackColor = Color.DeepSkyBlue;
            else if (s16.benar == 2)
                soal16.BackColor = Color.SpringGreen;
            else if (s16.benar == 3)
                soal16.BackColor = Color.Goldenrod;
            ////17
            if (s17.benar == 1)
                soal17.BackColor = Color.DeepSkyBlue;
            else if (s17.benar == 2)
                soal17.BackColor = Color.SpringGreen;
            else if (s17.benar == 3)
                soal17.BackColor = Color.Goldenrod;

            ////18
            if (s18.benar == 1)
                soal18.BackColor = Color.DeepSkyBlue;
            else if (s18.benar == 2)
                soal18.BackColor = Color.SpringGreen;
            else if (s18.benar == 3)
                soal18.BackColor = Color.Goldenrod;

            ////19
            if (s19.benar == 1)
                soal19.BackColor = Color.DeepSkyBlue;
            else if (s19.benar == 2)
                soal19.BackColor = Color.SpringGreen;
            else if (s19.benar == 3)
                soal19.BackColor = Color.Goldenrod;

            //20
            if (s20.benar == 1)
                soal20.BackColor = Color.DeepSkyBlue;
            else if (s20.benar == 2)
                soal20.BackColor = Color.SpringGreen;
            else if (s20.benar == 3)
                soal20.BackColor = Color.Goldenrod;

            //21
            if (s21.benar == 1)
                soal21.BackColor = Color.DeepSkyBlue;
            else if (s21.benar == 2)
                soal21.BackColor = Color.SpringGreen;
            else if (s21.benar == 3)
                soal21.BackColor = Color.Goldenrod;

            // DONT TRY THIS AT HOME
            // Arizona State University -Dafrom
            //22
            if (s22.benar == 1)
                soal22.BackColor = Color.DeepSkyBlue;
            else if (s22.benar == 2)
                soal22.BackColor = Color.SpringGreen;
            else if (s22.benar == 3)
                soal22.BackColor = Color.Goldenrod;


            ////23
            if (s23.benar == 1)
                soal23.BackColor = Color.DeepSkyBlue;
            else if (s23.benar == 2)
                soal23.BackColor = Color.SpringGreen;
            else if (s23.benar == 3)
                soal23.BackColor = Color.Goldenrod;

            ////24
            if (s24.benar == 1)
                soal24.BackColor = Color.DeepSkyBlue;
            else if (s24.benar == 2)
                soal24.BackColor = Color.SpringGreen;
            else if (s24.benar == 3)
                soal24.BackColor = Color.Goldenrod;

            ////25
            if (s25.benar == 1)
                soal25.BackColor = Color.DeepSkyBlue;
            else if (s25.benar == 2)
                soal25.BackColor = Color.SpringGreen;
            else if (s25.benar == 3)
                soal25.BackColor = Color.Goldenrod;

            ////26
            if (s26.benar == 1)
                soal26.BackColor = Color.DeepSkyBlue;
            else if (s26.benar == 2)
                soal26.BackColor = Color.SpringGreen;
            else if (s26.benar == 3)
                soal26.BackColor = Color.Goldenrod;
            ////27
            if (s27.benar == 1)
                soal27.BackColor = Color.DeepSkyBlue;
            else if (s27.benar == 2)
                soal27.BackColor = Color.SpringGreen;
            else if (s27.benar == 3)
                soal27.BackColor = Color.Goldenrod;

            ////28
            if (s28.benar == 1)
                soal28.BackColor = Color.DeepSkyBlue;
            else if (s28.benar == 2)
                soal28.BackColor = Color.SpringGreen;
            else if (s28.benar == 3)
                soal28.BackColor = Color.Goldenrod;

            ////29
            if (s29.benar == 1)
                soal29.BackColor = Color.DeepSkyBlue;
            else if (s29.benar == 2)
                soal29.BackColor = Color.SpringGreen;
            else if (s29.benar == 3)
                soal29.BackColor = Color.Goldenrod;

            //30
            if (s30.benar == 1)
                soal30.BackColor = Color.DeepSkyBlue;
            else if (s30.benar == 2)
                soal30.BackColor = Color.SpringGreen;
            else if (s30.benar == 3)
                soal30.BackColor = Color.Goldenrod;

            //31
            if (s31.benar == 1)
                soal31.BackColor = Color.DeepSkyBlue;
            else if (s31.benar == 2)
                soal31.BackColor = Color.SpringGreen;
            else if (s31.benar == 3)
                soal31.BackColor = Color.Goldenrod;

            // DONT TRY THIS AT HOME
            // Arizona State University -Dafrom
            //22
            if (s32.benar == 1)
                soal32.BackColor = Color.DeepSkyBlue;
            else if (s32.benar == 2)
                soal32.BackColor = Color.SpringGreen;
            else if (s32.benar == 3)
                soal32.BackColor = Color.Goldenrod;


            ////33
            if (s33.benar == 1)
                soal33.BackColor = Color.DeepSkyBlue;
            else if (s33.benar == 2)
                soal33.BackColor = Color.SpringGreen;
            else if (s33.benar == 3)
                soal33.BackColor = Color.Goldenrod;

            ////34
            if (s34.benar == 1)
                soal34.BackColor = Color.DeepSkyBlue;
            else if (s34.benar == 2)
                soal34.BackColor = Color.SpringGreen;
            else if (s34.benar == 3)
                soal34.BackColor = Color.Goldenrod;

            ////35
            if (s35.benar == 1)
                soal35.BackColor = Color.DeepSkyBlue;
            else if (s35.benar == 2)
                soal35.BackColor = Color.SpringGreen;
            else if (s35.benar == 3)
                soal35.BackColor = Color.Goldenrod;

            ////36
            if (s36.benar == 1)
                soal36.BackColor = Color.DeepSkyBlue;
            else if (s36.benar == 2)
                soal36.BackColor = Color.SpringGreen;
            else if (s36.benar == 3)
                soal36.BackColor = Color.Goldenrod;
            ////37
            if (s37.benar == 1)
                soal37.BackColor = Color.DeepSkyBlue;
            else if (s37.benar == 2)
                soal37.BackColor = Color.SpringGreen;
            else if (s37.benar == 3)
                soal37.BackColor = Color.Goldenrod;

            ////38
            if (s38.benar == 1)
                soal38.BackColor = Color.DeepSkyBlue;
            else if (s38.benar == 2)
                soal38.BackColor = Color.SpringGreen;
            else if (s38.benar == 3)
                soal38.BackColor = Color.Goldenrod;

            ////39
            if (s39.benar == 1)
                soal39.BackColor = Color.DeepSkyBlue;
            else if (s39.benar == 2)
                soal39.BackColor = Color.SpringGreen;
            else if (s39.benar == 3)
                soal39.BackColor = Color.Goldenrod;

            //40
            if (s40.benar == 1)
                soal40.BackColor = Color.DeepSkyBlue;
            else if (s40.benar == 2)
                soal40.BackColor = Color.SpringGreen;
            else if (s40.benar == 3)
                soal40.BackColor = Color.Goldenrod;

            //41
            if (s41.benar == 1)
                soal41.BackColor = Color.DeepSkyBlue;
            else if (s41.benar == 2)
                soal41.BackColor = Color.SpringGreen;
            else if (s41.benar == 3)
                soal41.BackColor = Color.Goldenrod;

            // DONT TRY THIS AT HOME
            // Arizona State University -Dafrom
            //42
            if (s42.benar == 1)
                soal42.BackColor = Color.DeepSkyBlue;
            else if (s42.benar == 2)
                soal42.BackColor = Color.SpringGreen;
            else if (s42.benar == 3)
                soal42.BackColor = Color.Goldenrod;


            ////43
            if (s43.benar == 1)
                soal43.BackColor = Color.DeepSkyBlue;
            else if (s43.benar == 2)
                soal43.BackColor = Color.SpringGreen;
            else if (s43.benar == 3)
                soal43.BackColor = Color.Goldenrod;

            ////44
            if (s44.benar == 1)
                soal44.BackColor = Color.DeepSkyBlue;
            else if (s44.benar == 2)
                soal44.BackColor = Color.SpringGreen;
            else if (s44.benar == 3)
                soal44.BackColor = Color.Goldenrod;

            ////45
            if (s45.benar == 1)
                soal45.BackColor = Color.DeepSkyBlue;
            else if (s45.benar == 2)
                soal45.BackColor = Color.SpringGreen;
            else if (s45.benar == 3)
                soal45.BackColor = Color.Goldenrod;

            ////46
            if (s46.benar == 1)
                soal46.BackColor = Color.DeepSkyBlue;
            else if (s46.benar == 2)
                soal46.BackColor = Color.SpringGreen;
            else if (s46.benar == 3)
                soal46.BackColor = Color.Goldenrod;
            ////47
            if (s47.benar == 1)
                soal47.BackColor = Color.DeepSkyBlue;
            else if (s47.benar == 2)
                soal47.BackColor = Color.SpringGreen;
            else if (s47.benar == 3)
                soal47.BackColor = Color.Goldenrod;

            ////48
            if (s48.benar == 1)
                soal48.BackColor = Color.DeepSkyBlue;
            else if (s48.benar == 2)
                soal48.BackColor = Color.SpringGreen;
            else if (s48.benar == 3)
                soal48.BackColor = Color.Goldenrod;

            ////49
            if (s49.benar == 1)
                soal49.BackColor = Color.DeepSkyBlue;
            else if (s49.benar == 2)
                soal49.BackColor = Color.SpringGreen;
            else if (s49.benar == 3)
                soal49.BackColor = Color.Goldenrod;

           
        }

        
        private void soal1_Click(object sender, EventArgs e) // 49 x
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if(teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s1._textBox = StringTeamNum;
                s1._teamNumInt = teamnummod;
            } else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s1._textBox = StringTeamNum;
                s1._teamNumInt = realteamnum;
            }
            
            s1.ShowDialog();   //// dicopy ping 1000
        }

        private void soal2_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s2._textBox = StringTeamNum;
                s2._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s2._textBox = StringTeamNum;
                s2._teamNumInt = realteamnum;
            }

            s2.ShowDialog();
        }

        private void soal3_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s3._textBox = StringTeamNum;
                s3._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s3._textBox = StringTeamNum;
                s3._teamNumInt = realteamnum;
            }

            s3.ShowDialog();
        }

        private void soal4_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s4._textBox = StringTeamNum;
                s4._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s4._textBox = StringTeamNum;
                s4._teamNumInt = realteamnum;
            }
            s4.ShowDialog();
        }

        private void soal5_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s5._textBox = StringTeamNum;
                s5._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s5._textBox = StringTeamNum;
                s5._teamNumInt = realteamnum;
            }

            s5.ShowDialog();
        }

        private void soal6_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s6._textBox = StringTeamNum;
                s6._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s6._textBox = StringTeamNum;
                s6._teamNumInt = realteamnum;
            }

            s6.ShowDialog();
        }

        private void soal7_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s7._textBox = StringTeamNum;
                s7._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s7._textBox = StringTeamNum;
                s7._teamNumInt = realteamnum;
            }

            s7.ShowDialog();
        }

        private void soal8_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s8._textBox = StringTeamNum;
                s8._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s8._textBox = StringTeamNum;
                s8._teamNumInt = realteamnum;
            }

            s8.ShowDialog();
        }

        private void soal9_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s9._textBox = StringTeamNum;
                s9._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s9._textBox = StringTeamNum;
                s9._teamNumInt = realteamnum;
            }

            s9.ShowDialog();
        }

        private void soal10_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s10._textBox = StringTeamNum;
                s10._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s10._textBox = StringTeamNum;
                s10._teamNumInt = realteamnum;
            }

            s10.ShowDialog();
        }

        private void soal11_Click(object sender, EventArgs e) // 49 x
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s11._textBox = StringTeamNum;
                s11._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s11._textBox = StringTeamNum;
                s11._teamNumInt = realteamnum;
            }

            s11.ShowDialog();   //// dicopy ping 1000
        }

        private void soal12_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s12._textBox = StringTeamNum;
                s12._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s12._textBox = StringTeamNum;
                s12._teamNumInt = realteamnum;
            }

            s12.ShowDialog();
        }

        private void soal13_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s13._textBox = StringTeamNum;
                s13._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s13._textBox = StringTeamNum;
                s13._teamNumInt = realteamnum;
            }

            s13.ShowDialog();
        }

        private void soal14_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s14._textBox = StringTeamNum;
                s14._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s14._textBox = StringTeamNum;
                s14._teamNumInt = realteamnum;
            }
            s14.ShowDialog();
        }

        private void soal15_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s15._textBox = StringTeamNum;
                s15._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s15._textBox = StringTeamNum;
                s15._teamNumInt = realteamnum;
            }

            s15.ShowDialog();
        }

        private void soal16_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s16._textBox = StringTeamNum;
                s16._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s16._textBox = StringTeamNum;
                s16._teamNumInt = realteamnum;
            }

            s16.ShowDialog();
        }

        private void soal17_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s17._textBox = StringTeamNum;
                s17._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s17._textBox = StringTeamNum;
                s17._teamNumInt = realteamnum;
            }

            s17.ShowDialog();
        }

        private void soal18_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s18._textBox = StringTeamNum;
                s18._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s18._textBox = StringTeamNum;
                s18._teamNumInt = realteamnum;
            }

            s18.ShowDialog();
        }

        private void soal19_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s19._textBox = StringTeamNum;
                s19._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s19._textBox = StringTeamNum;
                s19._teamNumInt = realteamnum;
            }

            s19.ShowDialog();
        }

        private void soal20_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s20._textBox = StringTeamNum;
                s20._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s20._textBox = StringTeamNum;
                s20._teamNumInt = realteamnum;
            }

            s20.ShowDialog();
        }

        private void soal21_Click(object sender, EventArgs e) // 49 x
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s21._textBox = StringTeamNum;
                s21._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s21._textBox = StringTeamNum;
                s21._teamNumInt = realteamnum;
            }

            s21.ShowDialog();   //// dicopy ping 1000
        }

        private void soal22_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s22._textBox = StringTeamNum;
                s22._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s22._textBox = StringTeamNum;
                s22._teamNumInt = realteamnum;
            }

            s22.ShowDialog();
        }

        private void soal23_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s23._textBox = StringTeamNum;
                s23._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s23._textBox = StringTeamNum;
                s23._teamNumInt = realteamnum;
            }

            s23.ShowDialog();
        }

        private void soal24_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s24._textBox = StringTeamNum;
                s24._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s24._textBox = StringTeamNum;
                s24._teamNumInt = realteamnum;
            }
            s24.ShowDialog();
        }

        private void soal25_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s25._textBox = StringTeamNum;
                s25._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s25._textBox = StringTeamNum;
                s25._teamNumInt = realteamnum;
            }

            s25.ShowDialog();
        }

        private void soal26_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s26._textBox = StringTeamNum;
                s26._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s26._textBox = StringTeamNum;
                s26._teamNumInt = realteamnum;
            }

            s26.ShowDialog();
        }

        private void soal27_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s27._textBox = StringTeamNum;
                s27._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s27._textBox = StringTeamNum;
                s27._teamNumInt = realteamnum;
            }

            s27.ShowDialog();
        }

        private void soal28_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s28._textBox = StringTeamNum;
                s28._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s28._textBox = StringTeamNum;
                s28._teamNumInt = realteamnum;
            }

            s28.ShowDialog();
        }

        private void soal29_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s29._textBox = StringTeamNum;
                s29._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s29._textBox = StringTeamNum;
                s29._teamNumInt = realteamnum;
            }

            s29.ShowDialog();
        }

        private void soal20_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s30._textBox = StringTeamNum;
                s30._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s30._textBox = StringTeamNum;
                s30._teamNumInt = realteamnum;
            }

            s30.ShowDialog();
        }

        private void soal31_Click(object sender, EventArgs e) // 49 x
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s31._textBox = StringTeamNum;
                s31._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s31._textBox = StringTeamNum;
                s31._teamNumInt = realteamnum;
            }

            s31.ShowDialog();   //// dicopy ping 1000
        }

        private void soal32_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s32._textBox = StringTeamNum;
                s32._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s32._textBox = StringTeamNum;
                s32._teamNumInt = realteamnum;
            }

            s32.ShowDialog();
        }

        private void soal33_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s3._textBox = StringTeamNum;
                s33._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s33._textBox = StringTeamNum;
                s33._teamNumInt = realteamnum;
            }

            s33.ShowDialog();
        }

        private void soal34_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s34._textBox = StringTeamNum;
                s34._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s34._textBox = StringTeamNum;
                s34._teamNumInt = realteamnum;
            }
            s34.ShowDialog();
        }

        private void soal35_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s35._textBox = StringTeamNum;
                s35._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s35._textBox = StringTeamNum;
                s35._teamNumInt = realteamnum;
            }

            s35.ShowDialog();
        }

        private void soal36_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s36._textBox = StringTeamNum;
                s36._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s36._textBox = StringTeamNum;
                s36._teamNumInt = realteamnum;
            }

            s36.ShowDialog();
        }

        private void soal37_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s37._textBox = StringTeamNum;
                s37._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s37._textBox = StringTeamNum;
                s37._teamNumInt = realteamnum;
            }

            s37.ShowDialog();
        }

        private void soal38_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s38._textBox = StringTeamNum;
                s38._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s38._textBox = StringTeamNum;
                s38._teamNumInt = realteamnum;
            }

            s38.ShowDialog();
        }

        private void soal39_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s39._textBox = StringTeamNum;
                s39._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s39._textBox = StringTeamNum;
                s39._teamNumInt = realteamnum;
            }

            s39.ShowDialog();
        }

        private void soal40_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s40._textBox = StringTeamNum;
                s40._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s40._textBox = StringTeamNum;
                s40._teamNumInt = realteamnum;
            }

            s40.ShowDialog();
        }

        private void soal41_Click(object sender, EventArgs e) // 49 x
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s41._textBox = StringTeamNum;
                s41._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s41._textBox = StringTeamNum;
                s41._teamNumInt = realteamnum;
            }

            s41.ShowDialog();   //// dicopy ping 1000
        }

        private void soal42_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s42._textBox = StringTeamNum;
                s42._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s42._textBox = StringTeamNum;
                s42._teamNumInt = realteamnum;
            }

            s42.ShowDialog();
        }

        private void soal43_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s43._textBox = StringTeamNum;
                s43._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s43._textBox = StringTeamNum;
                s43._teamNumInt = realteamnum;
            }

            s43.ShowDialog();
        }

        private void soal44_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s44._textBox = StringTeamNum;
                s44._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s44._textBox = StringTeamNum;
                s44._teamNumInt = realteamnum;
            }
            s44.ShowDialog();
        }

        private void soal45_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s45._textBox = StringTeamNum;
                s45._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s45._textBox = StringTeamNum;
                s45._teamNumInt = realteamnum;
            }

            s45.ShowDialog();
        }

        private void soal46_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s46._textBox = StringTeamNum;
                s46._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s46._textBox = StringTeamNum;
                s46._teamNumInt = realteamnum;
            }

            s46.ShowDialog();
        }

        private void soal47_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s47._textBox = StringTeamNum;
                s47._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s47._textBox = StringTeamNum;
                s47._teamNumInt = realteamnum;
            }

            s47.ShowDialog();
        }

        private void soal48_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s48._textBox = StringTeamNum;
                s48._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s48._textBox = StringTeamNum;
                s48._teamNumInt = realteamnum;
            }

            s48.ShowDialog();
        }

        private void soal49_Click(object sender, EventArgs e)
        {
            teamnum++;
            teamnummod = teamnum % 3;
            if (teamnummod != 0)
            {
                string StringTeamNum = teamnummod.ToString();
                s49._textBox = StringTeamNum;
                s49._teamNumInt = teamnummod;
            }
            else if (teamnummod == 0)
            {
                int realteamnum = 3;
                string StringTeamNum = realteamnum.ToString();
                s49._textBox = StringTeamNum;
                s49._teamNumInt = realteamnum;
            }

            s49.ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
