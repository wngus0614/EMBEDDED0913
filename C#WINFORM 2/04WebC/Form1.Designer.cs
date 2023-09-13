namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.com_port = new System.Windows.Forms.ComboBox();
            this.conn_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.led_off_btn = new System.Windows.Forms.Button();
            this.led_on_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.led_txt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tmp_txt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.light_txt = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dis_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.com_port);
            this.groupBox1.Controls.Add(this.conn_btn);
            this.groupBox1.Location = new System.Drawing.Point(38, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONNECTION";
            // 
            // com_port
            // 
            this.com_port.FormattingEnabled = true;
            this.com_port.Location = new System.Drawing.Point(6, 36);
            this.com_port.Name = "com_port";
            this.com_port.Size = new System.Drawing.Size(121, 23);
            this.com_port.TabIndex = 1;
            // 
            // conn_btn
            // 
            this.conn_btn.Location = new System.Drawing.Point(150, 35);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(75, 24);
            this.conn_btn.TabIndex = 0;
            this.conn_btn.Text = "연결";
            this.conn_btn.UseVisualStyleBackColor = true;
            this.conn_btn.Click += new System.EventHandler(this.conn_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.led_off_btn);
            this.groupBox2.Controls.Add(this.led_on_btn);
            this.groupBox2.Location = new System.Drawing.Point(38, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 86);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED";
            // 
            // led_off_btn
            // 
            this.led_off_btn.Location = new System.Drawing.Point(150, 24);
            this.led_off_btn.Name = "led_off_btn";
            this.led_off_btn.Size = new System.Drawing.Size(75, 46);
            this.led_off_btn.TabIndex = 1;
            this.led_off_btn.Text = "OFF";
            this.led_off_btn.UseVisualStyleBackColor = true;
            this.led_off_btn.Click += new System.EventHandler(this.led_off_btn_Click);
            // 
            // led_on_btn
            // 
            this.led_on_btn.Location = new System.Drawing.Point(23, 24);
            this.led_on_btn.Name = "led_on_btn";
            this.led_on_btn.Size = new System.Drawing.Size(75, 46);
            this.led_on_btn.TabIndex = 0;
            this.led_on_btn.Text = "ON";
            this.led_on_btn.UseVisualStyleBackColor = true;
            this.led_on_btn.Click += new System.EventHandler(this.led_on_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.led_txt);
            this.groupBox3.Location = new System.Drawing.Point(38, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 47);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "점등 상태";
            // 
            // led_txt
            // 
            this.led_txt.Enabled = false;
            this.led_txt.Location = new System.Drawing.Point(0, 16);
            this.led_txt.Name = "led_txt";
            this.led_txt.Size = new System.Drawing.Size(242, 25);
            this.led_txt.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tmp_txt);
            this.groupBox4.Location = new System.Drawing.Point(38, 314);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 47);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "온도 센서";
            // 
            // tmp_txt
            // 
            this.tmp_txt.Enabled = false;
            this.tmp_txt.Location = new System.Drawing.Point(0, 16);
            this.tmp_txt.Name = "tmp_txt";
            this.tmp_txt.Size = new System.Drawing.Size(242, 25);
            this.tmp_txt.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.light_txt);
            this.groupBox5.Location = new System.Drawing.Point(38, 376);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 47);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "조도 센서";
            // 
            // light_txt
            // 
            this.light_txt.Enabled = false;
            this.light_txt.Location = new System.Drawing.Point(0, 16);
            this.light_txt.Name = "light_txt";
            this.light_txt.Size = new System.Drawing.Size(242, 25);
            this.light_txt.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dis_txt);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox6.Location = new System.Drawing.Point(38, 445);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(242, 47);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "초음파 센서";
            // 
            // dis_txt
            // 
            this.dis_txt.Enabled = false;
            this.dis_txt.Location = new System.Drawing.Point(0, 16);
            this.dis_txt.Name = "dis_txt";
            this.dis_txt.Size = new System.Drawing.Size(242, 25);
            this.dis_txt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 509);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox com_port;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button led_off_btn;
        private System.Windows.Forms.Button led_on_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox led_txt;
        private System.Windows.Forms.TextBox tmp_txt;
        private System.Windows.Forms.TextBox light_txt;
        private System.Windows.Forms.TextBox dis_txt;
    }
}

