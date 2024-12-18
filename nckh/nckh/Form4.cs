using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace nckh
{
    public partial class Form4 : Form
    {
        nckhEntities nckh = new nckhEntities();

        public Form4()
        {
            InitializeComponent();
            dtg.CellClick += dtg_CellClick;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var result = from c in nckh.QL_PD select c;
            dtg.DataSource = result.ToList();
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BindData();
            }
        }

        private void BindData()
        {
            ClearBindings();
            id.DataBindings.Add(new Binding("Text", dtg.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged));
            ttb.DataBindings.Add(new Binding("Text", dtg.DataSource, "Tentb", true, DataSourceUpdateMode.OnPropertyChanged));
            tp.DataBindings.Add(new Binding("Text", dtg.DataSource, "Tenp", true, DataSourceUpdateMode.OnPropertyChanged));
            cp.DataBindings.Add(new Binding("Text", dtg.DataSource, "Cp", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void ClearBindings()
        {
            id.DataBindings.Clear();
            ttb.DataBindings.Clear();
            tp.DataBindings.Clear();
            cp.DataBindings.Clear();

            id.Text = "ID Tự Cập Nhật";
            ttb.Text = string.Empty;
            tp.Text = string.Empty;
            cp.Text = string.Empty;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var issetTb = from c in nckh.QL_PD where c.Tentb == ttb.Text select c;
                var issetTp = from c in nckh.QL_PD where c.Tenp == tp.Text select c;
                if (issetTb.Any())
                {
                    MessageBox.Show("Đã Tồn Tại Thiết Bị");
                }
                else if (issetTp.Any())
                {
                    MessageBox.Show("Đã Tồn Tại Phòng");
                }
                else
                {
                    QL_PD ql = new QL_PD()
                    {
                        Tentb = ttb.Text,
                        Tenp = tp.Text,
                        Cp = cp.Text,
                    };

                    nckh.QL_PD.Add(ql);
                    nckh.SaveChanges();
                    LoadData();
                    (Application.OpenForms["Form2"] as Form2)?.load();
                    ClearBindings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int idToUpdate = Convert.ToInt32(id.Text);
                    QL_PD entity = nckh.QL_PD.Find(idToUpdate);
                        entity.Tentb = ttb.Text;
                        entity.Tenp = tp.Text;
                        entity.Cp = cp.Text;
                        nckh.SaveChanges();
                        LoadData();
                        (Application.OpenForms["Form2"] as Form2)?.load();
                        ClearBindings();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int idToDelete = Convert.ToInt32(id.Text);
                    var entity = nckh.QL_PD.Find(idToDelete);
                    if (entity != null)
                    {                       
                        nckh.QL_PD.Remove(entity);
                        nckh.SaveChangesAsync();
                        LoadData();
                        (Application.OpenForms["Form2"] as Form2)?.load();
                        ClearBindings();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

