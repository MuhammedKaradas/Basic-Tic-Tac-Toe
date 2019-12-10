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

namespace proje3_tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Tic Tac Toe";
            label2.Text = "X";
        }

        int xPlayer = 0, oPlayer = 0, xSayac = 0, oSayac = 0, oyuncuSirasi = 0;
        int[] xKonum = new int[9];
        int[] oKonum = new int[9];
        string x = "X",o="O";
        //string filePath= @"C:\\playerRank.txt";
        //FileStream playerRank = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);

        
        FileStream fs = File.Create(@"C:playerRank.txt");//klasör içerisine dosya oluşturma 
        StreamWriter playerRank = new StreamWriter("C:\\playerRank.txt");
        public void kazanan()
        {
            /*if (1 ==)
            {
                
            }*/
            for (int i = 0; i < xKonum.Length; i++)
            {
                if (xKonum[0] == xKonum[3] && xKonum[3] == xKonum[6] && xKonum[0] == xKonum[6])//1
                {
                    //1-4-7
                    MessageBox.Show("X1 Kazandı...");
                    return;
                }
                else if(xKonum[1] == xKonum[4] && xKonum[4] == xKonum[7] && xKonum[1] == xKonum[7])//2
                {
                    //2-5-8
                    MessageBox.Show("X2 Kazandı...");
                    return;
                }
                else if (xKonum[2] == xKonum[5] && xKonum[5] == xKonum[8] && xKonum[2] == xKonum[8])//3
                {
                    //3-6-9
                    MessageBox.Show("X3 Kazandı...");
                    return;
                }
                else if (xKonum[0] == xKonum[4] && xKonum[4] == xKonum[8] && xKonum[0] == xKonum[8])//4
                {
                    //1-5-9
                    MessageBox.Show("X4 Kazandı...");
                    return;
                }
                else if (xKonum[2] == xKonum[4] && xKonum[4] == xKonum[6] && xKonum[2] == xKonum[6])//5
                {
                    //3-5-7
                    MessageBox.Show("X5 Kazandı...");
                    return;
                }
                else if (xKonum[0] == xKonum[1] && xKonum[1] == xKonum[2] && xKonum[0] == xKonum[2])//6
                {
                    //1-2-3
                    MessageBox.Show("X6 Kazandı...");
                    return;
                }
                else if (xKonum[3] == xKonum[4] && xKonum[4] == xKonum[5] && xKonum[3] == xKonum[5])//7
                {
                    //4-5-6
                    MessageBox.Show("X7 Kazandı...");
                    return;
                }
                else if (xKonum[6] == xKonum[7] && xKonum[7] == xKonum[8] && xKonum[6] == xKonum[8])//8
                {
                    //7-8-9
                    MessageBox.Show("X8 Kazandı...");
                    return;
                }
                else
                {
                    MessageBox.Show("Hata!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (oyuncuSirasi == 0)
            {
                button2.Text = x;
                label2.Text = o;

                //xKonum[1] = 2;
                oyuncuSirasi++;
                xSayac++;
            }
            else if (oyuncuSirasi==1)
            {
                button2.Text = o;
                label2.Text = x;
                oKonum[1] = 2;
                oyuncuSirasi =0;
                oSayac++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            if (oyuncuSirasi == 0)
            {
                button3.Text = x;
                label2.Text = o;
                //xKonum[2] = 3;
                oyuncuSirasi++;
                xSayac++;
            }
            else if (oyuncuSirasi == 1)
            {
                button3.Text = o;
                label2.Text = x;
                oKonum[2] = 3;
                oyuncuSirasi = 0;
                oSayac++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            if (oyuncuSirasi == 0)
            {
                button5.Text = x;
                label2.Text = o;
                //xKonum[4] = 2;
                oyuncuSirasi++;
                xSayac++;
            }
            else if (oyuncuSirasi == 1)
            {
                button5.Text = o;
                label2.Text = x;
                oKonum[4] = 2;
                oyuncuSirasi = 0;
                oSayac++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (oyuncuSirasi == 0)
            {
                button4.Text = x;
                label2.Text = o;
                xKonum[3] = 1;
                oyuncuSirasi++;
                xSayac++;
            }
            else if (oyuncuSirasi == 1)
            {
                button4.Text = o;
                label2.Text = x;
                oKonum[3] = 32313;
                oyuncuSirasi = 0;
                oSayac++;
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
            }
            else if (oyuncuSirasi == 1)
            {
                button9.Text = o;
                label2.Text = x;
                oyuncuSirasi = 0;
                oSayac++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            if (oyuncuSirasi == 0)
            {
                button7.Text = x;
                label2.Text = o;
                xKonum[6] = 1;
                oyuncuSirasi++;
                xSayac++;
            }
            else if (oyuncuSirasi == 1)
            {
                button7.Text = o;
                label2.Text = x;
                oyuncuSirasi = 0;
                oSayac++;
                
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            if (oyuncuSirasi == 0)
            {
                button8.Text = x;
                label2.Text = o;
                //xKonum[7] = 2;
                oyuncuSirasi++;
                xSayac++;
            }
            else if (oyuncuSirasi == 1)
            {
                button8.Text = o;
                label2.Text = x;
                oyuncuSirasi = 0;
                oSayac++;
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
            }
            else if (oyuncuSirasi == 1)
            {
                button6.Text = o;
                label2.Text = x;
                oyuncuSirasi = 0;
                oSayac++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (oyuncuSirasi==0)
            {
                button1.Text = x;
                label2.Text = o;
                xKonum[0] = 1;
                oyuncuSirasi++;
                xSayac++;
            }
            else if (oyuncuSirasi == 1)
            {
                button1.Text = o;
                label2.Text = x;
                oKonum[0] = 1;
                oyuncuSirasi = 0;
               /* if (oSayac==2)
                {
                    MessageBox.Show("Sayac 3 O kazandi");
                }*/
               oSayac++;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
