namespace nckh
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hồSơCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tb = new System.Windows.Forms.ToolStripTextBox();
            this.tk = new System.Windows.Forms.ToolStripMenuItem();
            this.truyCậpWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_body = new System.Windows.Forms.Panel();
            this.dtt = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtt)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hồSơCáNhânToolStripMenuItem
            // 
            this.hồSơCáNhânToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hồSơCáNhânToolStripMenuItem.Image")));
            this.hồSơCáNhânToolStripMenuItem.Name = "hồSơCáNhânToolStripMenuItem";
            this.hồSơCáNhânToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.hồSơCáNhânToolStripMenuItem.Text = "Thông Tin";
            this.hồSơCáNhânToolStripMenuItem.Click += new System.EventHandler(this.hồSơCáNhânToolStripMenuItem_Click);
            // 
            // cd
            // 
            this.cd.Image = ((System.Drawing.Image)(resources.GetObject("cd.Image")));
            this.cd.Name = "cd";
            this.cd.Size = new System.Drawing.Size(78, 24);
            this.cd.Text = "Cài Đặt";
            this.cd.Click += new System.EventHandler(this.caiToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơCáNhânToolStripMenuItem,
            this.cd,
            this.tb,
            this.tk,
            this.truyCậpWebToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(601, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tb
            // 
            this.tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(200, 24);
            this.tb.Tag = "";
            this.tb.Click += new System.EventHandler(this.tb_Click);
            // 
            // tk
            // 
            this.tk.Image = ((System.Drawing.Image)(resources.GetObject("tk.Image")));
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(32, 24);
            this.tk.Click += new System.EventHandler(this.tk_Click);
            // 
            // truyCậpWebToolStripMenuItem
            // 
            this.truyCậpWebToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("truyCậpWebToolStripMenuItem.Image")));
            this.truyCậpWebToolStripMenuItem.Name = "truyCậpWebToolStripMenuItem";
            this.truyCậpWebToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.truyCậpWebToolStripMenuItem.Text = "Thống Kê";
            this.truyCậpWebToolStripMenuItem.Click += new System.EventHandler(this.truyCậpWebToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel_body
            // 
            this.panel_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_body.Controls.Add(this.dtt);
            this.panel_body.Controls.Add(this.guna2Panel1);
            this.panel_body.Location = new System.Drawing.Point(0, 27);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1029, 610);
            this.panel_body.TabIndex = 1;
            // 
            // dtt
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dtt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtt.ColumnHeadersHeight = 15;
            this.dtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.tentb,
            this.sp,
            this.tc,
            this.doct});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtt.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dtt.Location = new System.Drawing.Point(0, 59);
            this.dtt.Name = "dtt";
            this.dtt.RowHeadersVisible = false;
            this.dtt.RowHeadersWidth = 51;
            this.dtt.Size = new System.Drawing.Size(1026, 548);
            this.dtt.TabIndex = 5;
            this.dtt.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Cyan;
            this.dtt.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dtt.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtt.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtt.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtt.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dtt.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.dtt.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtt.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtt.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtt.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtt.ThemeStyle.HeaderStyle.Height = 15;
            this.dtt.ThemeStyle.ReadOnly = false;
            this.dtt.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.dtt.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtt.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtt.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtt.ThemeStyle.RowsStyle.Height = 22;
            this.dtt.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.dtt.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtt_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID";
            this.Id.FillWeight = 112.3096F;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // tentb
            // 
            this.tentb.DataPropertyName = "Tentb";
            this.tentb.FillWeight = 112.3096F;
            this.tentb.HeaderText = "Mã Thiết Bị";
            this.tentb.MinimumWidth = 6;
            this.tentb.Name = "tentb";
            // 
            // sp
            // 
            this.sp.DataPropertyName = "Tenp";
            this.sp.FillWeight = 112.3096F;
            this.sp.HeaderText = "Số Phòng";
            this.sp.MinimumWidth = 6;
            this.sp.Name = "sp";
            // 
            // tc
            // 
            this.tc.DataPropertyName = "Cp";
            this.tc.FillWeight = 112.3096F;
            this.tc.HeaderText = "Tên Chủ Phòng";
            this.tc.MinimumWidth = 6;
            this.tc.Name = "tc";
            // 
            // doct
            // 
            this.doct.FillWeight = 50.76142F;
            this.doct.HeaderText = "Số Liệu Đo";
            this.doct.MinimumWidth = 6;
            this.doct.Name = "doct";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1029, 241);
            this.guna2Panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1025, 636);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thiết Bị";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtt)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem hồSơCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel_body;
        private Guna.UI2.WinForms.Guna2DataGridView dtt;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentb;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewButtonColumn doct;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripTextBox tb;
        private System.Windows.Forms.ToolStripMenuItem truyCậpWebToolStripMenuItem;
    }
}