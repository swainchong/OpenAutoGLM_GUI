namespace OpenAutoGLM_GUI
{
    partial class AutoGLM_GUI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoGLM_GUI));
            this.devicesList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.disconnect = new AntdUI.ButtonShadow();
            this.connect = new AntdUI.ButtonShadow();
            this.ip = new AntdUI.Input();
            this.port = new AntdUI.InputNumber();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.adbResp = new AntdUI.Input();
            this.chatList1 = new AntdUI.Chat.ChatList();
            this.input = new AntdUI.Input();
            this.send = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.useSelect = new AntdUI.Checkbox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitter1 = new AntdUI.Splitter();
            this.splitter2 = new AntdUI.Splitter();
            this.splitter3 = new AntdUI.Splitter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter1)).BeginInit();
            this.splitter1.Panel1.SuspendLayout();
            this.splitter1.Panel2.SuspendLayout();
            this.splitter1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter2)).BeginInit();
            this.splitter2.Panel1.SuspendLayout();
            this.splitter2.Panel2.SuspendLayout();
            this.splitter2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter3)).BeginInit();
            this.splitter3.Panel1.SuspendLayout();
            this.splitter3.Panel2.SuspendLayout();
            this.splitter3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // devicesList
            // 
            this.devicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devicesList.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.devicesList.FormattingEnabled = true;
            this.devicesList.Location = new System.Drawing.Point(4, 37);
            this.devicesList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.devicesList.Name = "devicesList";
            this.devicesList.Size = new System.Drawing.Size(361, 31);
            this.devicesList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "connectedDevices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(176, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 20, 1, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // disconnect
            // 
            this.disconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disconnect.ForeActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.disconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.disconnect.Location = new System.Drawing.Point(196, 63);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(170, 54);
            this.disconnect.TabIndex = 3;
            this.disconnect.Text = "dicconnect";
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // connect
            // 
            this.connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connect.ForeActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.connect.Location = new System.Drawing.Point(3, 63);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(169, 54);
            this.connect.TabIndex = 2;
            this.connect.Text = "connect";
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // ip
            // 
            this.ip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ip.Location = new System.Drawing.Point(3, 3);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(169, 54);
            this.ip.TabIndex = 0;
            this.ip.Text = "192.168.100.200";
            // 
            // port
            // 
            this.port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.port.Location = new System.Drawing.Point(196, 3);
            this.port.Name = "port";
            this.port.ShowControl = false;
            this.port.Size = new System.Drawing.Size(170, 54);
            this.port.TabIndex = 1;
            this.port.Text = "6666";
            this.port.Value = new decimal(new int[] {
            6666,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Setting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 32);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Setting
            // 
            this.Setting.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(86, 28);
            this.Setting.Text = "Setting";
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // adbResp
            // 
            this.adbResp.AutoScroll = true;
            this.adbResp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.adbResp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adbResp.Location = new System.Drawing.Point(3, 76);
            this.adbResp.Multiline = true;
            this.adbResp.Name = "adbResp";
            this.adbResp.ReadOnly = true;
            this.adbResp.Size = new System.Drawing.Size(363, 545);
            this.adbResp.TabIndex = 3;
            // 
            // chatList1
            // 
            this.chatList1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chatList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatList1.IconLess = true;
            this.chatList1.Location = new System.Drawing.Point(0, 0);
            this.chatList1.Name = "chatList1";
            this.chatList1.Size = new System.Drawing.Size(809, 525);
            this.chatList1.TabIndex = 11;
            this.chatList1.Text = "chatList1";
            // 
            // input
            // 
            this.input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input.Location = new System.Drawing.Point(0, 0);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(803, 170);
            this.input.TabIndex = 5;
            // 
            // send
            // 
            this.send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.send.Depth = 0;
            this.send.Icon = null;
            this.send.Location = new System.Drawing.Point(741, 107);
            this.send.Mini = true;
            this.send.MouseState = MaterialSkin.MouseState.HOVER;
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(62, 63);
            this.send.TabIndex = 13;
            this.send.Text = "materialFloatingActionButton1";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // useSelect
            // 
            this.useSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.useSelect.Location = new System.Drawing.Point(3, 3);
            this.useSelect.Name = "useSelect";
            this.useSelect.Size = new System.Drawing.Size(216, 37);
            this.useSelect.TabIndex = 4;
            this.useSelect.Text = "Use selected device";
            this.toolTip1.SetToolTip(this.useSelect, "Use selected device shown on SelectedDevices List, if there is only one device co" +
        "nnected, NO NEED to check.");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 6000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter1.Location = new System.Drawing.Point(0, 32);
            this.splitter1.Name = "splitter1";
            // 
            // splitter1.Panel1
            // 
            this.splitter1.Panel1.Controls.Add(this.splitter3);
            // 
            // splitter1.Panel2
            // 
            this.splitter1.Panel2.Controls.Add(this.splitter2);
            this.splitter1.Size = new System.Drawing.Size(1182, 748);
            this.splitter1.SplitterDistance = 369;
            this.splitter1.TabIndex = 14;
            // 
            // splitter2
            // 
            this.splitter2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitter2.Panel1
            // 
            this.splitter2.Panel1.Controls.Add(this.chatList1);
            // 
            // splitter2.Panel2
            // 
            this.splitter2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitter2.Size = new System.Drawing.Size(809, 748);
            this.splitter2.SplitterDistance = 525;
            this.splitter2.TabIndex = 0;
            // 
            // splitter3
            // 
            this.splitter3.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter3.Location = new System.Drawing.Point(0, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitter3.Panel1
            // 
            this.splitter3.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitter3.Panel2
            // 
            this.splitter3.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitter3.Size = new System.Drawing.Size(369, 748);
            this.splitter3.SplitterDistance = 120;
            this.splitter3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel1.Controls.Add(this.connect, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.port, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.disconnect, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ip, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.adbResp, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.devicesList, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(369, 624);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.useSelect, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(809, 219);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.send);
            this.panel1.Controls.Add(this.input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 170);
            this.panel1.TabIndex = 15;
            // 
            // AutoGLM_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 780);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AutoGLM_GUI";
            this.Text = "AutoGLM GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitter1.Panel1.ResumeLayout(false);
            this.splitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter1)).EndInit();
            this.splitter1.ResumeLayout(false);
            this.splitter2.Panel1.ResumeLayout(false);
            this.splitter2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter2)).EndInit();
            this.splitter2.ResumeLayout(false);
            this.splitter3.Panel1.ResumeLayout(false);
            this.splitter3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter3)).EndInit();
            this.splitter3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox devicesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Setting;
        private AntdUI.Chat.ChatList chatList1;
        private AntdUI.Input input;
        private MaterialSkin.Controls.MaterialFloatingActionButton send;
        private AntdUI.Input adbResp;
        private AntdUI.Checkbox useSelect;
        private System.Windows.Forms.ToolTip toolTip1;
        private AntdUI.Input ip;
        private AntdUI.InputNumber port;
        private AntdUI.ButtonShadow connect;
        private AntdUI.ButtonShadow disconnect;
        private AntdUI.Splitter splitter1;
        private AntdUI.Splitter splitter3;
        private AntdUI.Splitter splitter2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
    }
}

