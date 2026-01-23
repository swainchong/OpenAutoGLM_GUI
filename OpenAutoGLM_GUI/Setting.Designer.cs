namespace OpenAutoGLM_GUI
{
    partial class Setting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.Browse = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.api_key = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.save = new MaterialSkin.Controls.MaterialButton();
            this.cancel = new MaterialSkin.Controls.MaterialButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.browse2 = new System.Windows.Forms.Button();
            this.adbPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.adbSite = new System.Windows.Forms.LinkLabel();
            this.autoglmSite = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(377, 156);
            this.Browse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(87, 34);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(99, 156);
            this.path.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.path.Multiline = true;
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(279, 34);
            this.path.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "main.py path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(96, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "choose where main.py (Open-AutoGLM) is located";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(99, 246);
            this.url.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.url.Multiline = true;
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(365, 34);
            this.url.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "url";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(96, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "third-party services url";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(99, 358);
            this.model.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.model.Multiline = true;
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(365, 34);
            this.model.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "model";
            // 
            // api_key
            // 
            this.api_key.Location = new System.Drawing.Point(99, 439);
            this.api_key.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.api_key.Multiline = true;
            this.api_key.Name = "api_key";
            this.api_key.PasswordChar = '*';
            this.api_key.Size = new System.Drawing.Size(365, 58);
            this.api_key.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "API Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(95, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "get it from your third-party service";
            // 
            // save
            // 
            this.save.AutoSize = false;
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.save.Depth = 0;
            this.save.HighEmphasis = true;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(125, 539);
            this.save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save.MouseState = MaterialSkin.MouseState.HOVER;
            this.save.Name = "save";
            this.save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.save.Size = new System.Drawing.Size(114, 46);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.save.UseAccentColor = false;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.AutoSize = false;
            this.cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancel.Depth = 0;
            this.cancel.HighEmphasis = true;
            this.cancel.Icon = null;
            this.cancel.Location = new System.Drawing.Point(330, 539);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancel.Name = "cancel";
            this.cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancel.Size = new System.Drawing.Size(114, 46);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancel.UseAccentColor = true;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // browse2
            // 
            this.browse2.Location = new System.Drawing.Point(377, 42);
            this.browse2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browse2.Name = "browse2";
            this.browse2.Size = new System.Drawing.Size(87, 34);
            this.browse2.TabIndex = 0;
            this.browse2.Text = "browse";
            this.browse2.UseVisualStyleBackColor = true;
            this.browse2.Click += new System.EventHandler(this.browse2_Click);
            // 
            // adbPath
            // 
            this.adbPath.Location = new System.Drawing.Point(99, 42);
            this.adbPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adbPath.Multiline = true;
            this.adbPath.Name = "adbPath";
            this.adbPath.Size = new System.Drawing.Size(279, 34);
            this.adbPath.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "adbPath";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(96, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "choose where adb.exe is located";
            // 
            // adbSite
            // 
            this.adbSite.AutoSize = true;
            this.adbSite.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adbSite.Location = new System.Drawing.Point(355, 81);
            this.adbSite.Name = "adbSite";
            this.adbSite.Size = new System.Drawing.Size(89, 20);
            this.adbSite.TabIndex = 5;
            this.adbSite.TabStop = true;
            this.adbSite.Text = "Official site";
            this.adbSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.adbSite_LinkClicked);
            // 
            // autoglmSite
            // 
            this.autoglmSite.AutoSize = true;
            this.autoglmSite.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoglmSite.Location = new System.Drawing.Point(473, 195);
            this.autoglmSite.Name = "autoglmSite";
            this.autoglmSite.Size = new System.Drawing.Size(58, 20);
            this.autoglmSite.TabIndex = 5;
            this.autoglmSite.TabStop = true;
            this.autoglmSite.Text = "Github";
            this.autoglmSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.adbSite_LinkClicked);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 603);
            this.Controls.Add(this.autoglmSite);
            this.Controls.Add(this.adbSite);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.api_key);
            this.Controls.Add(this.model);
            this.Controls.Add(this.url);
            this.Controls.Add(this.adbPath);
            this.Controls.Add(this.path);
            this.Controls.Add(this.browse2);
            this.Controls.Add(this.Browse);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Setting";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox api_key;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialButton save;
        private MaterialSkin.Controls.MaterialButton cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button browse2;
        private System.Windows.Forms.TextBox adbPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel adbSite;
        private System.Windows.Forms.LinkLabel autoglmSite;
    }
}