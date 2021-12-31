
namespace Final_Project_CNPM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xuiCustomPictureBox1 = new XanderUI.XUICustomPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiCustomPictureBox1
            // 
            this.xuiCustomPictureBox1.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCustomPictureBox1.Color2 = System.Drawing.Color.DodgerBlue;
            this.xuiCustomPictureBox1.FilterAlpha = 200;
            this.xuiCustomPictureBox1.FilterEnabled = true;
            this.xuiCustomPictureBox1.Image = null;
            this.xuiCustomPictureBox1.IsElipse = false;
            this.xuiCustomPictureBox1.IsParallax = false;
            this.xuiCustomPictureBox1.Location = new System.Drawing.Point(671, 209);
            this.xuiCustomPictureBox1.Name = "xuiCustomPictureBox1";
            this.xuiCustomPictureBox1.Size = new System.Drawing.Size(150, 150);
            this.xuiCustomPictureBox1.TabIndex = 0;
            this.xuiCustomPictureBox1.Text = "xuiCustomPictureBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(562, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(81, 224);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(133, 30);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(81, 295);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(122, 30);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            // 
            // usernameInput
            // 
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameInput.Location = new System.Drawing.Point(230, 222);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(198, 32);
            this.usernameInput.TabIndex = 5;
            // 
            // passwordInput
            // 
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInput.Location = new System.Drawing.Point(230, 293);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(198, 32);
            this.passwordInput.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSubmit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.ButtonImage")));
            this.btnSubmit.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSubmit.ButtonText = "Submit";
            this.btnSubmit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSubmit.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.CornerRadius = 5;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSubmit.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSubmit.Location = new System.Drawing.Point(228, 387);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 50);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(902, 511);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.xuiCustomPictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICustomPictureBox xuiCustomPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private XanderUI.XUIButton btnSubmit;
    }
}

