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

namespace subway
{
    public partial class Form13 : Form
    {
        private string[] rowContents;
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Form11.rowContents[0]);
            if (Form11.rowContents != null && Form11.rowContents.Length >= 6)
            {
                label1.Text = Form11.rowContents[0];
                label2.Text = Form11.rowContents[1];
                label3.Text = Form11.rowContents[2];
                label4.Text = Form11.rowContents[3];
                label5.Text = Form11.rowContents[4];
                label6.Text = Form11.rowContents[5];

                label7.Text = Form7.cookie + " / " + Form7.drink;
            }
            else
            {
                // Form7에서 넘어온 경우
                label1.Text = Form1.menu;
                label2.Text = Form2.bread;
                label3.Text = Form3.cheese;
                label4.Text = Form4.vege;
                label5.Text = Form5.sauce;
                label6.Text = Form6.add;

                label7.Text = Form7.cookie + " / " + Form7.drink;
            }
        }

        private string[] LoadFileContents()
        {
            try
            {
                List<string> fileLines = new List<string>();
                using (StreamReader reader = new StreamReader(Form10.filename + ".txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        fileLines.Add(line);
                    }
                }
                return fileLines.ToArray();
            }
            catch (Exception ex)
            {
                // 파일 읽기 오류 처리를 수행하거나 예외를 throw하여 알리는 것이 좋습니다.
                return null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form10 showForm10 = new Form10();
            showForm10.StartPosition = FormStartPosition.Manual;
            showForm10.Location = new Point(this.Location.X, this.Location.Y);
            showForm10.Show();
        }

        // 확인 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제 창으로 넘어가는 중...");
            this.Visible = false;
            Form8 showForm8 = new Form8();
            showForm8.StartPosition = FormStartPosition.Manual;
            showForm8.Location = new Point(this.Location.X, this.Location.Y);
            showForm8.Show();
        }

        private void AppendToFile(string fileName, List<string> content)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                if (content != null && content.Count > 0)
                {
                    writer.WriteLine(string.Join(", ", content));
                }
                else
                {
                    writer.WriteLine(); // 빈 줄 입력
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_LabelUpdated(string labelContent) // vege
        {
            label4.Text = labelContent;
        }

        private void Form5_LabelUpdated(string labelContent) // sauce
        {
            label5.Text = labelContent;
        }

        private void Form6_LabelUpdated(string labelContent) // add
        {
            label6.Text = labelContent;
        }

        private void Form7_LabelUpdated(string labelContent) // set
        {
            label7.Text = labelContent;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
