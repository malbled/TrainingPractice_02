using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrainingPractice_02
{
    public partial class Form2 : Form
    {
        Point[] level1;
        Point[] level2;
        Point[] level3;
        int counter = 0;
        int dop;
        public Form2()
        {
            InitializeComponent();
            picBox1.Image = Properties.Resources.img1_1;
            picBox2.Image = Properties.Resources.img1_2;
            captionLabel.Text = "Для разминки начнем с рисунков, на которых нужно найти 8 отличий";
            txtLabel.Text = "Найдено отличий: 0";
            Text = "Уровень 1";
            level1 = new Point[] { new Point(86, 196)
                               , new Point(67, 313)
                               , new Point(206, 280)
                               , new Point(300, 327)
                               , new Point(472, 365)
                               , new Point(543, 309)
                               , new Point(612, 245)
                               , new Point(458, 148)};

            level2 = new Point[] { new Point(27, 398)
                               , new Point(120, 289)
                               , new Point(205, 154)
                               , new Point(326, 332)
                               , new Point(446, 292)
                               , new Point(611, 452)
                               , new Point(606, 226)
                               , new Point(427, 79)};

            level3 = new Point[] { new Point(303, 73)
                               , new Point(316, 215)
                               , new Point(570, 114)
                               , new Point(430, 254)
                               , new Point(468, 291)
                               , new Point(572, 303)
                               , new Point(607, 378)
                               , new Point(616, 449)
                               , new Point(201, 424)};
            dop = 1;
        }

        private void picBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(dop == 1)
            {
                for (int i = 0; i < level1.Length; i++)
                {
                    if (Math.Abs(e.X - level1[i].X) <= 30 && Math.Abs(e.Y - level1[i].Y) <= 30)
                    {
                        counter++;
                        Graphics g1 = picBox1.CreateGraphics();
                        g1.DrawEllipse(new Pen(Color.Magenta, 6), level1[i].X - 30, level1[i].Y - 30, 55, 55);
                        Graphics g2 = picBox2.CreateGraphics();
                        g2.DrawEllipse(new Pen(Color.Lime, 6), level1[i].X - 30, level1[i].Y - 30, 55, 55);
                        txtLabel.Text = $"Найдено отличий: {counter}";
                    }
                }
                if (counter == 8)
                {
                    btn.Visible = true;
                    dop = 2;
                    picBox1.Enabled = false;
                    picBox2.Enabled = false;
                    captionLabel.Text = "Вы нашли все отличия, можете переходить на уровень 2";
                    counter = 0;
                }
            }
            if (dop == 2)
            {
                for (int i = 0; i < level2.Length; i++)
                {
                    if (Math.Abs(e.X - level2[i].X) <= 30 && Math.Abs(e.Y - level2[i].Y) <= 30)
                    {
                        counter++;
                        Graphics g1 = picBox1.CreateGraphics();
                        g1.DrawEllipse(new Pen(Color.Magenta, 6), level2[i].X - 30, level2[i].Y - 30, 55, 55);
                        Graphics g2 = picBox2.CreateGraphics();
                        g2.DrawEllipse(new Pen(Color.Lime, 6), level2[i].X - 30, level2[i].Y - 30, 55, 55);
                        txtLabel.Text = $"Найдено отличий: {counter}";
                    }
                }
                if (counter == 8)
                {
                    btn.Visible = true;
                    dop = 3;
                    picBox1.Enabled = false;
                    picBox2.Enabled = false;
                    captionLabel.Text = "Вы нашли все отличия, можете переходить на уровень 3";
                    counter = 0;
                }
            }
            if (dop == 3)
            {

                for (int i = 0; i < level3.Length; i++)
                {
                    if (Math.Abs(e.X - level3[i].X) <= 30 && Math.Abs(e.Y - level3[i].Y) <= 30)
                    {
                        counter++;
                        Graphics g1 = picBox1.CreateGraphics();
                        g1.DrawEllipse(new Pen(Color.Magenta, 6), level3[i].X - 30, level3[i].Y - 30, 55, 55);
                        Graphics g2 = picBox2.CreateGraphics();
                        g2.DrawEllipse(new Pen(Color.Lime, 6), level3[i].X - 30, level3[i].Y - 30, 55, 55);
                        txtLabel.Text = $"Найдено отличий: {counter}";
                    }
                }
                if (counter == 9)
                {
                    btn.Visible = true;
                    dop = 4;
                    picBox1.Enabled = false;
                    picBox2.Enabled = false;
                    captionLabel.Text = "Вы нашли все отличия, спасибо за игру";
                    txtLabel.Text = "";
                    counter = 0;
                }
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(dop == 2)
            {
                btn.Visible = false;
                picBox1.Enabled = true;
                picBox2.Enabled = true;
                picBox1.Image = Properties.Resources.img2_1;
                picBox2.Image = Properties.Resources.img2_2;
                txtLabel.Text = $"Найдено отличий: 0";
                captionLabel.Text = "Необходимо найти 8 отличий";
                Text = "Уровень 2";
            }
            if (dop == 3)
            {
                btn.Visible = false;
                picBox1.Enabled = true;
                picBox2.Enabled = true;
                picBox1.Image = Properties.Resources.img3_1;
                picBox2.Image = Properties.Resources.img3_2;
                txtLabel.Text = $"Найдено отличий: 0";
                captionLabel.Text = "Усложним задачу: на этих рисунках нужно найти 9 отличий";
                Text = "Уровень 3";
                btn.Text = "Exit";
            }
            if(dop == 4)
            {
                this.Close();
            }
        }
    }
}
