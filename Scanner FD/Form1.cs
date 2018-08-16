using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Scanner_FD
{
    public partial class Form1 : Form
    {
        string key=null,temp;

        public Form1()
        {
            InitializeComponent();
            Status.Text = "Status = Diam";
            pilDrive.DataSource = DriveInfo.GetDrives().ToList();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            temp = key + @"Windows\System32";
            Console.WriteLine(temp);
            if (Directory.Exists(temp)) {
                DialogResult pilSure = MessageBox.Show("Apakah kamu yakin untuk melakukan proses scan terhadap drive ini? Kami mendeteksi adanya file system yang sangat sensitif (No, Recommended)", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(pilSure == DialogResult.Yes)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/c attrib -s -h /s /d " + key + "*.* & attrib –s –h –r /s /d " + key + "*.* & rmdir /s /q " + key + "recycler & del /s /f " + key + "recycler & del " + key + "007.exe & del " + key + "*.lnk";
                    process.StartInfo = startInfo;
                    Console.WriteLine("Jadi");
                    process.Start();
                    Status.Text = "Status = Berjalan... Mohon tunggu sebentar";
                    process.WaitForExit();
                    Status.Text = "Status = Sukses";
                }
                else if (pilSure == DialogResult.No)
                {
                    Console.WriteLine("Ga Jadi");
                    MessageBox.Show("Pilih direktori lain yang ingin di scan", "Konfirmasi");
                    Status.Text = "Status = Diam";
                }
            }
            else
            {
                Console.WriteLine("Gas ajalah");
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c attrib -s -h /s /d " + key + "*.* & attrib –s –h –r /s /d " + key + "*.* & rmdir /s /q " + key + "recycler & del /s /f " + key + "recycler & del " + key + "007.exe & del " + key + "*.lnk";
                process.StartInfo = startInfo;
                process.Start();
                Status.Text = "Status = Berjalan... Mohon tunggu sebentar";
                process.WaitForExit();
                Status.Text = "Status = Sukses";
            }
        }
        
        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void author_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/SiiJere");
        }

        private void tutorial_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.jealno.com/scannerfd.html");
        }

        private void pilDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            key = pilDrive.Text;
        }

        private void about_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Versi 1.1\rChangelog:\r1. Perubahan istilah pada aplikasi" +
                "\r2. Penambahan direct download aplikasi\r\rKlik OK untuk mengecek pembaharuan aplikasi\rKlik Cancel untuk kembali", "Update", MessageBoxButtons.OKCancel);
            
            
            if (check==DialogResult.OK)
            {
                System.Diagnostics.Process.Start("http://www.jealno.com/gudang/");
            }
            else if (check == DialogResult.Cancel)
            {

            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            pilDrive.DataSource = DriveInfo.GetDrives().ToList();
        }

    }
}
