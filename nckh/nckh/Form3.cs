using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Guna.UI2.WinForms;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using Excel = Microsoft.Office.Interop.Excel;

namespace nckh
{
    public partial class Form3 : Form
    {
        nckhEntities nckh = new nckhEntities();
        public string ttb { get; set; }
        public string sophong { get; set; }
             private bool isDeviceNotFoundNotified = false;
             private bool notConnect = false;
             private bool isClicked = false;
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "GMOdi5drKDN4rsISqF0GXKX7vOMQacNbDkPALDvk",
            BasePath = "https://nckh-b8aaa-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private Timer timer;
        public Form3(string Ten, string So)
        {
            InitializeComponent();
            this.ttb = Ten;
            this.sophong = So;
        }

        async Task LoadDataAsync()
        {
            var result = from c in nckh.canh_bao
                         where c.tenp == sophong
                         select c;
            tg.DataSource = result.ToList();

            FirebaseResponse res = await Task.Run(() => client.Get(@"HeThong"));
                Dictionary<string, Data> data = JsonConvert.DeserializeObject<Dictionary<string, Data>>(res.Body.ToString());
                Chuyen(data);
            
        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("Không thể kết nối đến Firebase.");
                return;
            }

            if (!isClicked)
            {
                isClicked = false;   
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            await LoadDataAsync();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            if (!isClicked)
            {
                await LoadDataAsync();
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel(tg);
        }

        private void ExportToExcel(DataGridView dataGridView)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;
            worksheet.Name = "Data";
            for (int i = 1; i <= dataGridView.Rows.Count; i++)
            {
                for (int j = 1; j <= dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i, j] = dataGridView.Rows[i - 1].Cells[j - 1].Value;
                }
            }
        }

        public class Data
        {
            public int cua { get; set; }
            public long nongdokhi { get; set; }
            public bool lcd { get; set; }
            public bool coi { get; set; }
            public bool quat { get; set; }
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        void Chuyen(Dictionary<string, Data> record)
        {

            bool found = false;
         
            foreach (var item in record)
            {
                string tb = ttb;
                if (item.Key == tb)
                {
                    found = true;
                    if (item.Value.nongdokhi > 500)
                    {
                        label2.Text = $"Cảnh Báo Khí Độc Cao: {item.Value.nongdokhi}\n - Thời gian: {DateTime.Now}";
                        label1.Visible = false;
                        label2.Visible = true;
                        string cb = label2.Text;
                        canh_bao canh = new canh_bao()
                        {
                            Canhbao = cb,
                            tenp = sophong
                        };
                        nckh.canh_bao.Add(canh);
                        nckh.SaveChanges();
                        tg.DataSource = (from c in nckh.canh_bao
                                         where c.tenp == sophong
                                         select c).ToList();
                    }
                    else if(item.Value.nongdokhi == 0 && !notConnect)
                    {
                        notConnect = true;
                        MessageBox.Show($"Thiết bị không hoạt động");
                    }
                    else
                    {
                        label1.Text = $"Nồng độ khí: {item.Value.nongdokhi} - Thiết bị: {item.Key}";
                        label1.Visible = true;
                        label2.Visible = false;
                    }
                    break;  
                }
            }

            if (!found && !isDeviceNotFoundNotified)
            {
                this.Hide();
                isDeviceNotFoundNotified = true;
                MessageBox.Show($"Không tìm thấy thiết bị: {ttb}");
                
            }   


        }
        private void button2_Click(object sender, EventArgs e) { }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            isClicked = true;
            if (timer != null)
            {
                timer.Stop();
            }
            string selectedDateString = datatk.Value.ToString("yyyy-MM-dd");//gán chuỗi

            var canhBaoList = nckh.canh_bao.ToList();

            var result = from c in canhBaoList
                         let datetimePart = c.Canhbao.Split('\n').LastOrDefault()?.Replace(" - Thời gian: ", "").Trim()
                         where datetimePart != null && DateTime.TryParse(datetimePart, out DateTime parsedDate)
                         && parsedDate.ToString("yyyy-MM-dd") == selectedDateString //Tách chuỗi
                         select c;

            tg.DataSource = result.ToList();
        }

        private void tg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            isClicked = false;
            timer.Start(); 
        }
    }
}
