using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caro
{
    public partial class Form1 : Form
    {
        int nguoichoi = 0;
        int play = 1;
        int[,] a = new int[10, 10];// cac phan tu 0,1,2 0 - ko bam, 1 - nguoichoi1, 2 nguoichoi2
        public Form1()
        {
            InitializeComponent();
            int i = 0, j = 0;
            for (i = 0; i < 10; i++)
                for (j = 0; j < 10; j++)
                    a[i, j] = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 0;
            j = 0;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button1.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button1.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }
        private int kiemtrathang(int I, int J)
        {
            int kq = 0;
            int t1 = 0, t2 = 0, doc = 0, ngang = 0;
            int i = 0, j = 0;
            int giatri = 0;
            i = I;
            j = J;
            giatri = a[I, J];
            while (i >= 0 && j >= 0 && a[i, j] == giatri)
            {
                t1++;
                i--;
                j--;
            }
            i = I + 1;
            j = J + 1;
            while (i < 10 && j < 10 && a[i, j] == giatri)
            {
                t1++;
                i++;
                j++;
            }
            ///tinh gia tri duong cheo t2
            ///
            i = I;
            j = J;
            while (i >= 0 && j < 10 && a[i, j] == giatri)
            {
                t2++;
                i--;
                j++;
            }
            i = I + 1;
            j = J - 1;
            while (i < 10 && j >= 0 && a[i, j] == giatri)
            {
                t2++;
                i++;
                j--;
            }
            i = I;
            j = J;
            while (i >= 0 && a[i, j] == giatri)
            {
                doc++;
                i--;
            }
            i = I + 1;
            j = J;
            while (i < 10 && a[i, j] == giatri)
            {
                doc++;
                i++;
            }
            //tinh duong ngang
            i = I;
            j = J;
            while (j >= 0 && a[i, j] == giatri)
            {
                ngang++;
                j--;
            }
            i = I;
            j = J + 1;
            while (j < 10 && a[i, j] == giatri)
            {
                ngang++;
                j++;
            }
            if (t1 == 4 || t2 == 4 || doc == 4 || ngang == 4)
                kq = 1;
            return kq;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 0;
            j = 1;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button2.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button2.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 0;
            j = 2;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button3.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button3.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 0;
            j = 3;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button4.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button4.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0, j = 4;

            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button5.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button5.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 1;
            j = 0;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button20.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button20.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 1;
            j = 1;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button19.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button19.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 1;
            j = 2;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button18.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button18.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 1;
            j = 3;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button17.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button17.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 1;
            j = 4;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button16.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button16.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 2;
            j = 0;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button30.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button30.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 2;
            j = 1;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button29.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button29.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 2;
            j = 2;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button28.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button28.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 2;
            j = 3;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button27.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button27.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 2;
            j = 4;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button26.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button26.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 3;
            j = 0;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button40.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button40.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 3;
            j = 1;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button39.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button39.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 3;
            j = 2;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button38.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button38.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 3;
            j = 3;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button37.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button37.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 3;
            j = 4;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button36.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button36.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            i = 4;
            j = 0;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button50.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button50.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button49_Click(object sender, EventArgs e)
        {

            int i = 0, j = 0;
            i = 4;
            j = 1;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button49.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button49.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button48_Click(object sender, EventArgs e)
        {

            int i = 0, j = 0;
            i = 4;
            j = 2;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button48.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button48.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button47_Click(object sender, EventArgs e)
        {

            int i = 0, j = 0;
            i = 4;
            j = 3;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button47.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button47.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }
        }

        private void button46_Click(object sender, EventArgs e)
        {

            int i = 0, j = 0;
            i = 4;
            j = 4;
            if (play == 1 && a[i, j] == 0)
            {
                if (nguoichoi == 0)
                {
                    button46.Text = "X";
                    a[i, j] = 1;
                }
                else
                {
                    button46.Text = "O";
                    a[i, j] = 2;
                }
                if (kiemtrathang(i, j) == 1)
                {
                    play = 0;
                    lbkq.Text = "nguoi choi thang la: " + nguoichoi.ToString();
                }
                thaydoinguoichoi();

            }

        }
        private void thaydoinguoichoi()
        {
            if(play ==1)
            {
                nguoichoi++;
                nguoichoi = nguoichoi % 2;
                lbnguoichoi.Text = "nguoi choi hien tai la" + nguoichoi.ToString();
            }
           
        }
    }
}
