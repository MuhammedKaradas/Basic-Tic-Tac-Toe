using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proje3_tic_tac_toe
{
    public partial class Form1 : Form
    {
        string x = "X", o = "O";
        int xPlayer = 0, oPlayer = 0, xSayac = 0, oSayac = 0, oyuncuSirasi = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Tic Tac Toe";
            string yol = @"C:\playerRank.txt";
            FileInfo dosya1 = new FileInfo(yol);
            if (dosya1.Exists)
            {
                StreamReader oku = new StreamReader(yol);
                string satir;
                satir = oku.ReadLine();
                label2.Text = satir;
                if (satir == "O")
                {
                    oyuncuSirasi = 1;
                }
                oku.Close();
            }
            else
            {
                label2.Text = "X";
            }

        }

        public void playerRankSave(string rank)
        {
            StreamWriter playerRank = new StreamWriter(@"C:\playerRank.txt");
            playerRank.WriteLine(rank);
            playerRank.Close();
        }

        public void kazanan()
        {
                if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")//1
                {
                    //1-4-7
                    MessageBox.Show("X Kazandı...");
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")//2
                {
                    //2-5-8
                    MessageBox.Show("X Kazandı...");
                    button1.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button9.Enabled = false;
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")//3
                {
                    //3-6-9
                    MessageBox.Show("X Kazandı...");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")//4
                {
                    //1-5-9
                    MessageBox.Show("X Kazandı...");
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")//5
                {
                    //3-5-7
                    MessageBox.Show("X Kazandı...");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button4.Enabled = false;
                    button6.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                else if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")//6
                {
                    //1-2-3
                    MessageBox.Show("X Kazandı...");
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")//7
                {
                    //4-5-6
                    MessageBox.Show("X Kazandı...");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")//8
                {
                    //7-8-9
                    MessageBox.Show("X Kazandı...");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                }
                 /*---------------oOOOo--------------*/
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")//1
                {
                    //1-4-7
                    MessageBox.Show("O Kazandı...");
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")//2
                {
                    //2-5-8
                    MessageBox.Show("O Kazandı...");
                    button1.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button9.Enabled = false;
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")//3
                {
                    //3-6-9
                    MessageBox.Show("O Kazandı...");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")//4
                {
                    //1-5-9
                    MessageBox.Show("O Kazandı...");
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")//5
                {
                    //3-5-7
                    MessageBox.Show("O Kazandı...");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button4.Enabled = false;
                    button6.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")//6
                {
                    //1-2-3
                    MessageBox.Show("O Kazandı...");
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")//7
                {
                    //4-5-6
                    MessageBox.Show("O Kazandı...");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")//8
                {
                    //7-8-9
                    MessageBox.Show("O Kazandı...");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                }
                else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                 {
                     MessageBox.Show("Berabere...");
                     button1.Text = "";
                     button2.Text = "";
                     button3.Text = "";
                     button4.Text = "";
                     button5.Text = "";
                     button6.Text = "";
                     button7.Text = "";
                     button8.Text = "";
                     button9.Text = "";
 
                     button1.Enabled = true;
                     button2.Enabled = true;
                     button3.Enabled = true;
                     button4.Enabled = true;
                     button5.Enabled = true;
                     button6.Enabled = true;
                     button7.Enabled = true;
                     button8.Enabled = true;
                     button9.Enabled = true;
             }
                
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            
            if (oyuncuSirasi == 0)
            {
                button2.Text = x;
                label2.Text = o;
                oyuncuSirasi++;
                xSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
            else if (oyuncuSirasi==1)
            {
                button2.Text = o;
                label2.Text = x;
                oyuncuSirasi =0;
                oSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            if (oyuncuSirasi == 0)
            {
                button3.Text = x;
                label2.Text = o;
                oyuncuSirasi++;
                xSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
            else if (oyuncuSirasi == 1)
            {
                button3.Text = o;
                label2.Text = x;
                oyuncuSirasi = 0;
                oSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            if (oyuncuSirasi == 0)
            {
                button5.Text = x;
                label2.Text = o;
                oyuncuSirasi++;
                xSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
            else if (oyuncuSirasi == 1)
            {
                button5.Text = o;
                label2.Text = x;
                oyuncuSirasi = 0;
                oSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (oyuncuSirasi == 0)
            {
                button4.Text = x;
                label2.Text = o;
                oyuncuSirasi++;
                xSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
            else if (oyuncuSirasi == 1)
            {
                button4.Text = o;
                label2.Text = x;
                oyuncuSirasi = 0;
                oSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            if (oyuncuSirasi == 0)
            {
                button9.Text = x;
                label2.Text = o;
                oyuncuSirasi++;
                xSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
            else if (oyuncuSirasi == 1)
            {
                button9.Text = o;
                label2.Text = x;
                oyuncuSirasi = 0;
                oSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
        }
        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // playerRankSave();
            this.Close();
        }

        public void yeniOyunToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geliştirici: Muhammed Karadaş");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            if (oyuncuSirasi == 0)
            {
                button7.Text = x;
                label2.Text = o;
                oyuncuSirasi++;
                xSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
            else if (oyuncuSirasi == 1)
            {
                button7.Text = o;
                label2.Text = x;
                oyuncuSirasi = 0;
                oSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            if (oyuncuSirasi == 0)
            {
                button8.Text = x;
                label2.Text = o;
                oyuncuSirasi++;
                xSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
            else if (oyuncuSirasi == 1)
            {
                button8.Text = o;
                label2.Text = x;
                oyuncuSirasi = 0;
                oSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            if (oyuncuSirasi == 0)
            {
                button6.Text = x;
                label2.Text = o;
                oyuncuSirasi++;
                xSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
            else if (oyuncuSirasi == 1)
            {
                button6.Text = o;
                label2.Text = x;
                oyuncuSirasi = 0;
                oSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (oyuncuSirasi==0)
            {
                button1.Text = x;
                label2.Text = o;
                oyuncuSirasi++;
                xSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
            else if (oyuncuSirasi == 1)
            {
                button1.Text = o;
                label2.Text = x;
                oyuncuSirasi = 0;
                oSayac++;
                kazanan();
                playerRankSave(label2.Text);
            }
        }
    }
}
