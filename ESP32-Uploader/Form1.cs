using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ESP32_Uploader
{
    public partial class ESP32Uploader: Form
    {
        String path_to_main_file = "";
        short com_num = 0;
        long upload_speed = 921600;

        public ESP32Uploader()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 1);
            e.Graphics.DrawLine(blackPen, 600, 0, 600, 600);
        }


        private void open_file_pathmainfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "BIN Files (*.bin)|*.bin",
                Title = "Select Firmware file"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path_to_file.Text = openFileDialog.FileName;
            }
        }

        private void ValidateUploadButton()
        {
            // Проверяем, что путь не пустой, содержит ".bin" и COM-порт больше 0
            bool isValid = !string.IsNullOrEmpty(path_to_main_file) &&
                           path_to_main_file.EndsWith(".bin", StringComparison.OrdinalIgnoreCase) &&
                           com_num > 0 &&
                           upload_speed > 0;

            upload_but.Enabled = isValid; // Включаем или отключаем кнопку
        }

        // Обновляем COM-порт
        private void com_port_TextChanged(object sender, EventArgs e)
        {
            if (short.TryParse(com_port.Text.Replace("COM", ""), out short portNum))
            {
                com_num = portNum;
            }
            else
            {
                com_num = 0; // Если не удалось распознать номер порта
            }
            ValidateUploadButton(); // Проверяем кнопку
        }

        private void upload_but_Click(object sender, EventArgs e)
        {

        }

        private bool check_file_exist(String path)
        {
            return File.Exists(path);
        }

        private void path_to_file_TextChanged(object sender, EventArgs e)
        {
            if (check_file_exist(path_to_file.Text))
            { 
                path_to_main_file = path_to_file.Text;
                file_status.Text = "File found";
                file_status.ForeColor = Color.Green;
                ValidateUploadButton();
            }
            else
            {
                file_status.Text = "File not found";
                file_status.ForeColor = Color.Red;
            }

        }

        private void radio_921600_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_921600.Checked) upload_speed = 921600;
        }

        private void radio_115200_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_115200.Checked) upload_speed = 115200;
        }

        private void radio_256000_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_256000.Checked) upload_speed = 256000;
        }

        private void radio_230400_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_230400.Checked) upload_speed = 230400;
        }

        private void radio_512000_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_512000.Checked) upload_speed = 512000;
        }
    }
}
