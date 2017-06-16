namespace HttpAction
{
    partial class HttpAction
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label_ip = new System.Windows.Forms.Label();
            this.textBox_show_http_data = new System.Windows.Forms.TextBox();
            this.comboBoxHttpType = new System.Windows.Forms.ComboBox();
            this.label_post_parm = new System.Windows.Forms.Label();
            this.textBox_post_parm = new System.Windows.Forms.TextBox();
            this.label_http_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(122, 12);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(100, 22);
            this.textBox_ip.TabIndex = 1;
            this.textBox_ip.Text = "http://";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(15, 38);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Location = new System.Drawing.Point(101, 15);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(15, 12);
            this.label_ip.TabIndex = 3;
            this.label_ip.Text = "IP";
            // 
            // textBox_show_http_data
            // 
            this.textBox_show_http_data.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_show_http_data.Location = new System.Drawing.Point(15, 67);
            this.textBox_show_http_data.Multiline = true;
            this.textBox_show_http_data.Name = "textBox_show_http_data";
            this.textBox_show_http_data.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_show_http_data.Size = new System.Drawing.Size(531, 447);
            this.textBox_show_http_data.TabIndex = 4;
            // 
            // comboBoxHttpType
            // 
            this.comboBoxHttpType.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxHttpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHttpType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxHttpType.FormattingEnabled = true;
            this.comboBoxHttpType.Items.AddRange(new object[] {
            "get",
            "post"});
            this.comboBoxHttpType.Location = new System.Drawing.Point(15, 12);
            this.comboBoxHttpType.Name = "comboBoxHttpType";
            this.comboBoxHttpType.Size = new System.Drawing.Size(80, 20);
            this.comboBoxHttpType.TabIndex = 5;
            this.comboBoxHttpType.SelectedIndexChanged += new System.EventHandler(this.comboBoxHttpType_SelectedIndexChanged);
            // 
            // label_post_parm
            // 
            this.label_post_parm.AutoSize = true;
            this.label_post_parm.Location = new System.Drawing.Point(228, 15);
            this.label_post_parm.Name = "label_post_parm";
            this.label_post_parm.Size = new System.Drawing.Size(29, 12);
            this.label_post_parm.TabIndex = 6;
            this.label_post_parm.Text = "parm";
            // 
            // textBox_post_parm
            // 
            this.textBox_post_parm.Location = new System.Drawing.Point(263, 12);
            this.textBox_post_parm.Name = "textBox_post_parm";
            this.textBox_post_parm.Size = new System.Drawing.Size(283, 22);
            this.textBox_post_parm.TabIndex = 7;
            // 
            // label_http_status
            // 
            this.label_http_status.AutoSize = true;
            this.label_http_status.Location = new System.Drawing.Point(122, 41);
            this.label_http_status.Name = "label_http_status";
            this.label_http_status.Size = new System.Drawing.Size(64, 12);
            this.label_http_status.TabIndex = 8;
            this.label_http_status.Text = "Http Status : ";
            // 
            // HttpAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 526);
            this.Controls.Add(this.label_http_status);
            this.Controls.Add(this.textBox_post_parm);
            this.Controls.Add(this.label_post_parm);
            this.Controls.Add(this.comboBoxHttpType);
            this.Controls.Add(this.textBox_show_http_data);
            this.Controls.Add(this.label_ip);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_ip);
            this.Name = "HttpAction";
            this.Text = "HttpAction";
            this.Load += new System.EventHandler(this.FormHttpAction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.TextBox textBox_show_http_data;
        private System.Windows.Forms.ComboBox comboBoxHttpType;
        private System.Windows.Forms.Label label_post_parm;
        private System.Windows.Forms.TextBox textBox_post_parm;
        private System.Windows.Forms.Label label_http_status;
    }
}

