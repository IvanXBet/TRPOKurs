namespace Klomove374
{
    partial class Form1
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
            this.buttonSingin = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.singin = new System.Windows.Forms.Label();
            this.inputLogin = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonSingin
            // 
            this.buttonSingin.BackColor = System.Drawing.Color.Orange;
            this.buttonSingin.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.buttonSingin.ForeColor = System.Drawing.Color.White;
            this.buttonSingin.Location = new System.Drawing.Point(302, 245);
            this.buttonSingin.Name = "buttonSingin";
            this.buttonSingin.Size = new System.Drawing.Size(335, 42);
            this.buttonSingin.TabIndex = 0;
            this.buttonSingin.Text = "Войти";
            this.buttonSingin.UseVisualStyleBackColor = false;
            this.buttonSingin.Click += new System.EventHandler(this.buttonSingin_Click);
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.login.BackColor = System.Drawing.Color.Linen;
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.login.Location = new System.Drawing.Point(302, 141);
            this.login.Margin = new System.Windows.Forms.Padding(10);
            this.login.MaxLength = 20;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(335, 31);
            this.login.TabIndex = 1;
            this.login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.password.BackColor = System.Drawing.Color.Linen;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.password.Location = new System.Drawing.Point(302, 191);
            this.password.MaxLength = 20;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(335, 31);
            this.password.TabIndex = 2;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // singin
            // 
            this.singin.AutoSize = true;
            this.singin.Font = new System.Drawing.Font("Yu Gothic UI Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singin.ForeColor = System.Drawing.Color.Linen;
            this.singin.Location = new System.Drawing.Point(297, 77);
            this.singin.Name = "singin";
            this.singin.Size = new System.Drawing.Size(97, 38);
            this.singin.TabIndex = 3;
            this.singin.Text = "Sing in";
            // 
            // inputLogin
            // 
            this.inputLogin.AutoSize = true;
            this.inputLogin.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14F);
            this.inputLogin.ForeColor = System.Drawing.Color.Linen;
            this.inputLogin.Location = new System.Drawing.Point(147, 139);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(136, 25);
            this.inputLogin.TabIndex = 4;
            this.inputLogin.Text = "Введите логин";
            // 
            // inputPassword
            // 
            this.inputPassword.AutoSize = true;
            this.inputPassword.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.inputPassword.ForeColor = System.Drawing.Color.Linen;
            this.inputPassword.Location = new System.Drawing.Point(135, 191);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(143, 25);
            this.inputPassword.TabIndex = 5;
            this.inputPassword.Text = "Введите пароль";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(531, 98);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 23);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Регистрация";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(830, 449);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.singin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.buttonSingin);
            this.Name = "Form1";
            this.Text = "login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSingin;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label singin;
        private System.Windows.Forms.Label inputLogin;
        private System.Windows.Forms.Label inputPassword;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

