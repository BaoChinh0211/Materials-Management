namespace QLVT
{
    partial class CreateLoginForm
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
            this.groupBoxCreateLogin = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.radUSER = new System.Windows.Forms.RadioButton();
            this.radCHINHANH = new System.Windows.Forms.RadioButton();
            this.radCONGTY = new System.Windows.Forms.RadioButton();
            this.cbbUsername = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLoginName = new System.Windows.Forms.Label();
            this.groupBoxCreateLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCreateLogin
            // 
            this.groupBoxCreateLogin.Controls.Add(this.btnThoat);
            this.groupBoxCreateLogin.Controls.Add(this.btnCreate);
            this.groupBoxCreateLogin.Controls.Add(this.radUSER);
            this.groupBoxCreateLogin.Controls.Add(this.radCHINHANH);
            this.groupBoxCreateLogin.Controls.Add(this.radCONGTY);
            this.groupBoxCreateLogin.Controls.Add(this.cbbUsername);
            this.groupBoxCreateLogin.Controls.Add(this.txtPassword);
            this.groupBoxCreateLogin.Controls.Add(this.txtLogin);
            this.groupBoxCreateLogin.Controls.Add(this.labelRole);
            this.groupBoxCreateLogin.Controls.Add(this.labelUsername);
            this.groupBoxCreateLogin.Controls.Add(this.labelPassword);
            this.groupBoxCreateLogin.Controls.Add(this.labelLoginName);
            this.groupBoxCreateLogin.Location = new System.Drawing.Point(12, 11);
            this.groupBoxCreateLogin.Name = "groupBoxCreateLogin";
            this.groupBoxCreateLogin.Size = new System.Drawing.Size(643, 307);
            this.groupBoxCreateLogin.TabIndex = 0;
            this.groupBoxCreateLogin.TabStop = false;
            this.groupBoxCreateLogin.Text = "Tạo tài khoản";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnThoat.Location = new System.Drawing.Point(450, 233);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCreate.Location = new System.Drawing.Point(298, 233);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Tạo tài khoản";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // radUSER
            // 
            this.radUSER.AutoSize = true;
            this.radUSER.Location = new System.Drawing.Point(408, 189);
            this.radUSER.Name = "radUSER";
            this.radUSER.Size = new System.Drawing.Size(51, 17);
            this.radUSER.TabIndex = 9;
            this.radUSER.TabStop = true;
            this.radUSER.Text = "USER";
            this.radUSER.UseVisualStyleBackColor = true;
            // 
            // radCHINHANH
            // 
            this.radCHINHANH.AutoSize = true;
            this.radCHINHANH.Location = new System.Drawing.Point(298, 189);
            this.radCHINHANH.Name = "radCHINHANH";
            this.radCHINHANH.Size = new System.Drawing.Size(78, 17);
            this.radCHINHANH.TabIndex = 8;
            this.radCHINHANH.TabStop = true;
            this.radCHINHANH.Text = "CHINHANH";
            this.radCHINHANH.UseVisualStyleBackColor = true;
            // 
            // radCONGTY
            // 
            this.radCONGTY.AutoSize = true;
            this.radCONGTY.Location = new System.Drawing.Point(193, 189);
            this.radCONGTY.Name = "radCONGTY";
            this.radCONGTY.Size = new System.Drawing.Size(66, 17);
            this.radCONGTY.TabIndex = 7;
            this.radCONGTY.TabStop = true;
            this.radCONGTY.Text = "CONGTY";
            this.radCONGTY.UseVisualStyleBackColor = true;
            // 
            // cbbUsername
            // 
            this.cbbUsername.FormattingEnabled = true;
            this.cbbUsername.Location = new System.Drawing.Point(193, 152);
            this.cbbUsername.Name = "cbbUsername";
            this.cbbUsername.Size = new System.Drawing.Size(242, 21);
            this.cbbUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(193, 111);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(242, 21);
            this.txtPassword.TabIndex = 5;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(193, 67);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(242, 21);
            this.txtLogin.TabIndex = 4;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(99, 191);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(38, 13);
            this.labelRole.TabIndex = 3;
            this.labelRole.Text = "Vai trò";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(99, 155);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(99, 114);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(51, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Mật khẩu";
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.Location = new System.Drawing.Point(99, 70);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(62, 13);
            this.labelLoginName.TabIndex = 0;
            this.labelLoginName.Text = "Login Name";
            // 
            // CreateLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 330);
            this.Controls.Add(this.groupBoxCreateLogin);
            this.Name = "CreateLoginForm";
            this.Text = "CreateLoginForm";
            this.Load += new System.EventHandler(this.CreateLoginForm_Load);
            this.groupBoxCreateLogin.ResumeLayout(false);
            this.groupBoxCreateLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreateLogin;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLoginName;
        private System.Windows.Forms.RadioButton radUSER;
        private System.Windows.Forms.RadioButton radCHINHANH;
        private System.Windows.Forms.RadioButton radCONGTY;
        private System.Windows.Forms.ComboBox cbbUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnThoat;
    }
}