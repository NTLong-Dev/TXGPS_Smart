using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nckh
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            using (nckhEntities db = new nckhEntities())
            {
                var groupedData = db.canh_bao
                                    .GroupBy(cb => cb.tenp)
                                    .Select(g => new
                                    {
                                        TenPhong = g.Key,
                                        Count = g.Count()
                                    })
                                    .ToList();

                chart1.DataSource = groupedData;
                chart1.Series["Cảnh Báo"].XValueMember = "TenPhong";
                chart1.Series["Cảnh Báo"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chart1.Series["Cảnh Báo"].YValueMembers = "Count";
                chart1.Series["Cảnh Báo"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            }

        }
    }
}
