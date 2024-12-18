using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static nckh.Form3;
using static System.Net.Mime.MediaTypeNames;

namespace nckh
{
    public partial class Form2 : Form
    {
        nckhEntities nckh = new nckhEntities();
        private Form form3Instance;
        public Form2()
        {
            InitializeComponent();

        }
        public void load()
        {
            var result = from c in nckh.QL_PD select c;     
            dtt.DataSource = result.ToList();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            load();
        }

        private void caiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form3Instance != null)
            {
                form3Instance.Close();
                form3Instance = null;
            }
            OpenChildForm(new Form4());
            load();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form3Instance != null)
            {
                form3Instance.Close(); 
                form3Instance = null; 
            }
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void hồSơCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                if (form3Instance != null)
                {
                    form3Instance.Close();
                    form3Instance = null;
                }
                load();
                currentFormChild.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtt.Columns[e.ColumnIndex].Name == "doct")
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = dtt.Rows[rowIndex];
                string tentb = selectedRow.Cells["tentb"].Value.ToString();
                string tp = selectedRow.Cells["sp"].Value.ToString();
                if (form3Instance != null)
                {
                    form3Instance.Close(); 
                }
                form3Instance = new Form3(tentb, tp);
                    form3Instance.Show();
              
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tk_Click(object sender, EventArgs e)
        {
            if (form3Instance != null)
            {
                form3Instance.Close();
                form3Instance = null;
            }
            String ma = tb.Text;
            var result = from c in nckh.QL_PD where c.Tentb == ma select c;
            if (ma == "")
            {
                MessageBox.Show("Không để trống");
                load();
            }else if(!result.Any())
            {
                MessageBox.Show("Không tìm thấy thiết bị");
                load();
            }
            else
            {
               

                dtt.DataSource = result.ToList();

            }
        }

        private void tb_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void truyCậpWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form3Instance != null)
            {
                form3Instance.Close();
                form3Instance = null;
            }
            OpenChildForm(new Form5());
            
        }
    }
}
