using System;
using System.Windows.Forms;

namespace TrainingPractice_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра состоит из трех уровней, где в каждом из них вам предстоит найти отличия на картинках\nКликайте мышкой,где нашли отличие", "Информация об игре");
        }

        private void начатьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
