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
            this.devicesList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.adbResp = new AntdUI.Input();
            this.chatList1 = new AntdUI.Chat.ChatList();
            this.input = new AntdUI.Input();
            this.send = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.useSelect = new AntdUI.Checkbox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.port = new AntdUI.InputNumber();
            this.ip = new AntdUI.Input();
            this.connect = new AntdUI.ButtonShadow();
            this.disconnect = new AntdUI.ButtonShadow();
            this.materialCard1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // devicesList
            // 
            this.devicesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devicesList.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.devicesList.FormattingEnabled = true;
            this.devicesList.Location = new System.Drawing.Point(22, 52);
            this.devicesList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.devicesList.Name = "devicesList";
            this.devicesList.Size = new System.Drawing.Size(298, 31);
            this.devicesList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "connectedDevices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCard1.Controls.Add(this.disconnect);
            this.materialCard1.Controls.Add(this.connect);
            this.materialCard1.Controls.Add(this.ip);
            this.materialCard1.Controls.Add(this.port);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(28, 49);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(350, 132);
            this.materialCard1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Setting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 32);
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
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCard2.Controls.Add(this.adbResp);
            this.materialCard2.Controls.Add(this.devicesList);
            this.materialCard2.Controls.Add(this.label1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(28, 209);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(350, 544);
            this.materialCard2.TabIndex = 10;
            // 
            // adbResp
            // 
            this.adbResp.AutoScroll = true;
            this.adbResp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.adbResp.Location = new System.Drawing.Point(17, 91);
            this.adbResp.Multiline = true;
            this.adbResp.Name = "adbResp";
            this.adbResp.ReadOnly = true;
            this.adbResp.Size = new System.Drawing.Size(314, 434);
            this.adbResp.TabIndex = 3;
            // 
            // chatList1
            // 
            this.chatList1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chatList1.IconLess = true;
            this.chatList1.Location = new System.Drawing.Point(408, 49);
            this.chatList1.Name = "chatList1";
            this.chatList1.Size = new System.Drawing.Size(654, 568);
            this.chatList1.TabIndex = 11;
            this.chatList1.Text = "chatList1";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(395, 652);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(664, 101);
            this.input.TabIndex = 5;
            // 
            // send
            // 
            this.send.Depth = 0;
            this.send.Icon = null;
            this.send.Location = new System.Drawing.Point(1009, 690);
            this.send.Mini = true;
            this.send.MouseState = MaterialSkin.MouseState.HOVER;
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(40, 63);
            this.send.TabIndex = 13;
            this.send.Text = "materialFloatingActionButton1";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // useSelect
            // 
            this.useSelect.Location = new System.Drawing.Point(398, 623);
            this.useSelect.Name = "useSelect";
            this.useSelect.Size = new System.Drawing.Size(216, 23);
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
            // port
            // 
            this.port.Location = new System.Drawing.Point(177, 14);
            this.port.Name = "port";
            this.port.ShowControl = false;
            this.port.Size = new System.Drawing.Size(143, 46);
            this.port.TabIndex = 1;
            this.port.Value = new decimal(new int[] {
            6666,
            0,
            0,
            0});
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(17, 14);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(143, 46);
            this.ip.TabIndex = 0;
            this.ip.Text = "192.168.100.200";
            // 
            // connect
            // 
            this.connect.ForeActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.connect.Location = new System.Drawing.Point(17, 66);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(143, 56);
            this.connect.TabIndex = 2;
            this.connect.Text = "connect";
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // disconnect
            // 
            this.disconnect.ForeActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.disconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.disconnect.Location = new System.Drawing.Point(177, 66);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(143, 56);
            this.disconnect.TabIndex = 3;
            this.disconnect.Text = "dicconnect";
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // AutoGLM_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 765);
            this.Controls.Add(this.useSelect);
            this.Controls.Add(this.send);
            this.Controls.Add(this.input);
            this.Controls.Add(this.chatList1);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AutoGLM_GUI";
            this.Text = "AutoGLM GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox devicesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Setting;
        private MaterialSkin.Controls.MaterialCard materialCard2;
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
    }
}

