
namespace Oblig5
{
    partial class Banken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banken));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bLogout = new System.Windows.Forms.Button();
            this.bTransfer = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.pLogin = new System.Windows.Forms.Panel();
            this.bLoginDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tPw = new System.Windows.Forms.TextBox();
            this.tUser = new System.Windows.Forms.TextBox();
            this.lFeilPW = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tUserdisplay = new System.Windows.Forms.TextBox();
            this.bExit = new System.Windows.Forms.Button();
            this.pAccount = new System.Windows.Forms.Panel();
            this.bSettInn = new System.Windows.Forms.Button();
            this.bUttakPeng = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tSettInn = new System.Windows.Forms.TextBox();
            this.tTaUt = new System.Windows.Forms.TextBox();
            this.tSaldo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pLogin.SuspendLayout();
            this.pAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.bLogout);
            this.panel1.Controls.Add(this.bTransfer);
            this.panel1.Controls.Add(this.bLogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 530);
            this.panel1.TabIndex = 0;
            // 
            // bLogout
            // 
            this.bLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.bLogout.Enabled = false;
            this.bLogout.FlatAppearance.BorderSize = 0;
            this.bLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bLogout.Location = new System.Drawing.Point(0, 272);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(192, 53);
            this.bLogout.TabIndex = 4;
            this.bLogout.Text = "Logout";
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // bTransfer
            // 
            this.bTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.bTransfer.Enabled = false;
            this.bTransfer.FlatAppearance.BorderSize = 0;
            this.bTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTransfer.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bTransfer.Location = new System.Drawing.Point(0, 219);
            this.bTransfer.Name = "bTransfer";
            this.bTransfer.Size = new System.Drawing.Size(192, 53);
            this.bTransfer.TabIndex = 3;
            this.bTransfer.Text = "Transfer";
            this.bTransfer.UseVisualStyleBackColor = true;
            // 
            // bLogin
            // 
            this.bLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.bLogin.FlatAppearance.BorderSize = 0;
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bLogin.Location = new System.Drawing.Point(0, 166);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(192, 53);
            this.bLogin.TabIndex = 1;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 156);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lStatus.Location = new System.Drawing.Point(211, 12);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(163, 32);
            this.lStatus.TabIndex = 1;
            this.lStatus.Text = "Dashboard";
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pLogin.Controls.Add(this.bLoginDetails);
            this.pLogin.Controls.Add(this.label1);
            this.pLogin.Controls.Add(this.label3);
            this.pLogin.Controls.Add(this.tPw);
            this.pLogin.Controls.Add(this.tUser);
            this.pLogin.Controls.Add(this.lFeilPW);
            this.pLogin.Controls.Add(this.label2);
            this.pLogin.Location = new System.Drawing.Point(240, 79);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(554, 415);
            this.pLogin.TabIndex = 2;
            this.pLogin.Visible = false;
            // 
            // bLoginDetails
            // 
            this.bLoginDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLoginDetails.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLoginDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bLoginDetails.Location = new System.Drawing.Point(22, 295);
            this.bLoginDetails.Name = "bLoginDetails";
            this.bLoginDetails.Size = new System.Drawing.Size(192, 53);
            this.bLoginDetails.TabIndex = 5;
            this.bLoginDetails.Text = "Login";
            this.bLoginDetails.UseVisualStyleBackColor = true;
            this.bLoginDetails.Click += new System.EventHandler(this.bLoginDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(250, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(19, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fødelsnr";
            // 
            // tPw
            // 
            this.tPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPw.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tPw.Location = new System.Drawing.Point(253, 172);
            this.tPw.Name = "tPw";
            this.tPw.PasswordChar = '•';
            this.tPw.Size = new System.Drawing.Size(198, 27);
            this.tPw.TabIndex = 3;
            this.tPw.Text = "1234";
            // 
            // tUser
            // 
            this.tUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tUser.Location = new System.Drawing.Point(22, 172);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(201, 27);
            this.tUser.TabIndex = 3;
            this.tUser.Text = "07128912345";
            // 
            // lFeilPW
            // 
            this.lFeilPW.AutoSize = true;
            this.lFeilPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFeilPW.ForeColor = System.Drawing.Color.Maroon;
            this.lFeilPW.Location = new System.Drawing.Point(19, 212);
            this.lFeilPW.Name = "lFeilPW";
            this.lFeilPW.Size = new System.Drawing.Size(198, 16);
            this.lFeilPW.TabIndex = 0;
            this.lFeilPW.Text = "Feil fødselsnr eller passord";
            this.lFeilPW.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter login details";
            // 
            // tUserdisplay
            // 
            this.tUserdisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tUserdisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tUserdisplay.Enabled = false;
            this.tUserdisplay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUserdisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tUserdisplay.Location = new System.Drawing.Point(424, 20);
            this.tUserdisplay.Name = "tUserdisplay";
            this.tUserdisplay.Size = new System.Drawing.Size(267, 27);
            this.tUserdisplay.TabIndex = 3;
            // 
            // bExit
            // 
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.Color.White;
            this.bExit.Location = new System.Drawing.Point(795, 12);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(25, 32);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "X";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // pAccount
            // 
            this.pAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pAccount.Controls.Add(this.bSettInn);
            this.pAccount.Controls.Add(this.bUttakPeng);
            this.pAccount.Controls.Add(this.label4);
            this.pAccount.Controls.Add(this.label7);
            this.pAccount.Controls.Add(this.label6);
            this.pAccount.Controls.Add(this.label5);
            this.pAccount.Controls.Add(this.tSettInn);
            this.pAccount.Controls.Add(this.tTaUt);
            this.pAccount.Controls.Add(this.tSaldo);
            this.pAccount.Location = new System.Drawing.Point(240, 79);
            this.pAccount.Name = "pAccount";
            this.pAccount.Size = new System.Drawing.Size(554, 415);
            this.pAccount.TabIndex = 6;
            this.pAccount.Visible = false;
            // 
            // bSettInn
            // 
            this.bSettInn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSettInn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSettInn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bSettInn.Location = new System.Drawing.Point(22, 310);
            this.bSettInn.Name = "bSettInn";
            this.bSettInn.Size = new System.Drawing.Size(192, 53);
            this.bSettInn.TabIndex = 5;
            this.bSettInn.Text = "Sett Inn";
            this.bSettInn.UseVisualStyleBackColor = true;
            this.bSettInn.Click += new System.EventHandler(this.bSettInn_Click);
            // 
            // bUttakPeng
            // 
            this.bUttakPeng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUttakPeng.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUttakPeng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.bUttakPeng.Location = new System.Drawing.Point(22, 168);
            this.bUttakPeng.Name = "bUttakPeng";
            this.bUttakPeng.Size = new System.Drawing.Size(192, 53);
            this.bUttakPeng.TabIndex = 5;
            this.bUttakPeng.Text = "Ta ut";
            this.bUttakPeng.UseVisualStyleBackColor = true;
            this.bUttakPeng.Click += new System.EventHandler(this.bUttakPeng_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Account";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(265, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hvor mye ønsker du å sette inn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(265, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ønsket mengde for utak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(19, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Saldo";
            // 
            // tSettInn
            // 
            this.tSettInn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tSettInn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSettInn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSettInn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tSettInn.Location = new System.Drawing.Point(268, 325);
            this.tSettInn.Name = "tSettInn";
            this.tSettInn.ShortcutsEnabled = false;
            this.tSettInn.Size = new System.Drawing.Size(183, 27);
            this.tSettInn.TabIndex = 3;
            this.tSettInn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericChecker);
            // 
            // tTaUt
            // 
            this.tTaUt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tTaUt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tTaUt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTaUt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tTaUt.Location = new System.Drawing.Point(268, 183);
            this.tTaUt.Name = "tTaUt";
            this.tTaUt.ShortcutsEnabled = false;
            this.tTaUt.Size = new System.Drawing.Size(183, 27);
            this.tTaUt.TabIndex = 3;
            this.tTaUt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericChecker);
            // 
            // tSaldo
            // 
            this.tSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSaldo.Enabled = false;
            this.tSaldo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tSaldo.Location = new System.Drawing.Point(22, 102);
            this.tSaldo.Name = "tSaldo";
            this.tSaldo.Size = new System.Drawing.Size(241, 27);
            this.tSaldo.TabIndex = 3;
            // 
            // Banken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(836, 530);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.tUserdisplay);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pAccount);
            this.Controls.Add(this.pLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Banken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Banken_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.pAccount.ResumeLayout(false);
            this.pAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tUserdisplay;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tPw;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.Button bLoginDetails;
        private System.Windows.Forms.Button bTransfer;
        private System.Windows.Forms.Panel pAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lFeilPW;
        private System.Windows.Forms.Button bSettInn;
        private System.Windows.Forms.Button bUttakPeng;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tSettInn;
        private System.Windows.Forms.TextBox tTaUt;
        private System.Windows.Forms.TextBox tSaldo;
    }
}

