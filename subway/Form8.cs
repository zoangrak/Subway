using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subway
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form9 showForm9 = new Form9();
            showForm9.StartPosition = FormStartPosition.Manual;
            showForm9.Location = new Point(this.Location.X, this.Location.Y);
            showForm9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form9 showForm9 = new Form9();
            showForm9.StartPosition = FormStartPosition.Manual;
            showForm9.Location = new Point(this.Location.X, this.Location.Y);
            showForm9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form9 showForm9 = new Form9();
            showForm9.StartPosition = FormStartPosition.Manual;
            showForm9.Location = new Point(this.Location.X, this.Location.Y);
            showForm9.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form13 showForm13 = new Form13();
            showForm13.StartPosition = FormStartPosition.Manual;
            showForm13.Location = new Point(this.Location.X, this.Location.Y);
            showForm13.Show();
        }
    }
}
