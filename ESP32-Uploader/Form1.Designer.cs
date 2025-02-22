namespace ESP32_Uploader
{
    partial class ESP32Uploader
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radio_512000 = new System.Windows.Forms.RadioButton();
            this.radio_230400 = new System.Windows.Forms.RadioButton();
            this.radio_256000 = new System.Windows.Forms.RadioButton();
            this.radio_115200 = new System.Windows.Forms.RadioButton();
            this.radio_921600 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.upload_but = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.com_port = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.install_progress = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.file_status = new System.Windows.Forms.Label();
            this.open_file_pathmainfile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.path_to_file = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.InitialDirectory = "Documents";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.upload_but);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.install_progress);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 562);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radio_512000);
            this.groupBox3.Controls.Add(this.radio_230400);
            this.groupBox3.Controls.Add(this.radio_256000);
            this.groupBox3.Controls.Add(this.radio_115200);
            this.groupBox3.Controls.Add(this.radio_921600);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(249, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 138);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // radio_512000
            // 
            this.radio_512000.AutoSize = true;
            this.radio_512000.Location = new System.Drawing.Point(142, 80);
            this.radio_512000.Name = "radio_512000";
            this.radio_512000.Size = new System.Drawing.Size(61, 17);
            this.radio_512000.TabIndex = 8;
            this.radio_512000.TabStop = true;
            this.radio_512000.Text = "512000";
            this.radio_512000.UseVisualStyleBackColor = true;
            this.radio_512000.CheckedChanged += new System.EventHandler(this.radio_512000_CheckedChanged);
            // 
            // radio_230400
            // 
            this.radio_230400.AutoSize = true;
            this.radio_230400.Location = new System.Drawing.Point(142, 57);
            this.radio_230400.Name = "radio_230400";
            this.radio_230400.Size = new System.Drawing.Size(61, 17);
            this.radio_230400.TabIndex = 7;
            this.radio_230400.TabStop = true;
            this.radio_230400.Text = "230400";
            this.radio_230400.UseVisualStyleBackColor = true;
            this.radio_230400.CheckedChanged += new System.EventHandler(this.radio_230400_CheckedChanged);
            // 
            // radio_256000
            // 
            this.radio_256000.AutoSize = true;
            this.radio_256000.Location = new System.Drawing.Point(14, 104);
            this.radio_256000.Name = "radio_256000";
            this.radio_256000.Size = new System.Drawing.Size(61, 17);
            this.radio_256000.TabIndex = 6;
            this.radio_256000.TabStop = true;
            this.radio_256000.Text = "256000";
            this.radio_256000.UseVisualStyleBackColor = true;
            this.radio_256000.CheckedChanged += new System.EventHandler(this.radio_256000_CheckedChanged);
            // 
            // radio_115200
            // 
            this.radio_115200.AutoSize = true;
            this.radio_115200.Location = new System.Drawing.Point(14, 81);
            this.radio_115200.Name = "radio_115200";
            this.radio_115200.Size = new System.Drawing.Size(61, 17);
            this.radio_115200.TabIndex = 5;
            this.radio_115200.TabStop = true;
            this.radio_115200.Text = "115200";
            this.radio_115200.UseVisualStyleBackColor = true;
            this.radio_115200.CheckedChanged += new System.EventHandler(this.radio_115200_CheckedChanged);
            // 
            // radio_921600
            // 
            this.radio_921600.AutoSize = true;
            this.radio_921600.Checked = true;
            this.radio_921600.Location = new System.Drawing.Point(14, 58);
            this.radio_921600.Name = "radio_921600";
            this.radio_921600.Size = new System.Drawing.Size(61, 17);
            this.radio_921600.TabIndex = 4;
            this.radio_921600.TabStop = true;
            this.radio_921600.Text = "921600";
            this.radio_921600.UseVisualStyleBackColor = true;
            this.radio_921600.CheckedChanged += new System.EventHandler(this.radio_921600_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "Select upload speed";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(627, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(345, 402);
            this.textBox1.TabIndex = 7;
            // 
            // upload_but
            // 
            this.upload_but.Enabled = false;
            this.upload_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_but.Location = new System.Drawing.Point(33, 501);
            this.upload_but.Name = "upload_but";
            this.upload_but.Size = new System.Drawing.Size(110, 38);
            this.upload_but.TabIndex = 6;
            this.upload_but.Text = "Upload";
            this.upload_but.UseMnemonic = false;
            this.upload_but.UseVisualStyleBackColor = true;
            this.upload_but.Click += new System.EventHandler(this.upload_but_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.com_port);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(27, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 138);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // com_port
            // 
            this.com_port.Location = new System.Drawing.Point(13, 66);
            this.com_port.Name = "com_port";
            this.com_port.Size = new System.Drawing.Size(149, 20);
            this.com_port.TabIndex = 2;
            this.com_port.TextChanged += new System.EventHandler(this.com_port_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 38);
            this.label6.TabIndex = 1;
            this.label6.Text = "Write COM Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(749, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Terminal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "ESP32 Uploader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(787, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ESP32 Uploader by VL_PLAY Games";
            // 
            // install_progress
            // 
            this.install_progress.Location = new System.Drawing.Point(650, 475);
            this.install_progress.Name = "install_progress";
            this.install_progress.Size = new System.Drawing.Size(300, 25);
            this.install_progress.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.file_status);
            this.groupBox1.Controls.Add(this.open_file_pathmainfile);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.path_to_file);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // file_status
            // 
            this.file_status.AutoSize = true;
            this.file_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_status.Location = new System.Drawing.Point(10, 125);
            this.file_status.Name = "file_status";
            this.file_status.Size = new System.Drawing.Size(0, 17);
            this.file_status.TabIndex = 4;
            // 
            // open_file_pathmainfile
            // 
            this.open_file_pathmainfile.Location = new System.Drawing.Point(290, 66);
            this.open_file_pathmainfile.Name = "open_file_pathmainfile";
            this.open_file_pathmainfile.Size = new System.Drawing.Size(75, 23);
            this.open_file_pathmainfile.TabIndex = 3;
            this.open_file_pathmainfile.Text = "Open";
            this.open_file_pathmainfile.UseVisualStyleBackColor = true;
            this.open_file_pathmainfile.Click += new System.EventHandler(this.open_file_pathmainfile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "(.merged.bin)";
            // 
            // path_to_file
            // 
            this.path_to_file.Location = new System.Drawing.Point(13, 95);
            this.path_to_file.Name = "path_to_file";
            this.path_to_file.Size = new System.Drawing.Size(352, 20);
            this.path_to_file.TabIndex = 1;
            this.path_to_file.TextChanged += new System.EventHandler(this.path_to_file_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write path to file";
            // 
            // ESP32Uploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Name = "ESP32Uploader";
            this.Text = "ESP32 Uploader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar install_progress;
        private System.Windows.Forms.TextBox path_to_file;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox com_port;
        private System.Windows.Forms.Button upload_but;
        private System.Windows.Forms.Button open_file_pathmainfile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label file_status;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radio_512000;
        private System.Windows.Forms.RadioButton radio_230400;
        private System.Windows.Forms.RadioButton radio_256000;
        private System.Windows.Forms.RadioButton radio_115200;
        private System.Windows.Forms.RadioButton radio_921600;
        private System.Windows.Forms.Label label7;
    }
}

