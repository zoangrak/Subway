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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form12 showForm12 = new Form12();
            showForm12.StartPosition = FormStartPosition.Manual;
            showForm12.Location = new Point(this.Location.X, this.Location.Y);
            showForm12.Show();
        }
    }
}
