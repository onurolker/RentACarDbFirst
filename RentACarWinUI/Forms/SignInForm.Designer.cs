namespace RentACarWinUI.Forms
{
    partial class SignInForm
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
            this.txtSignInPW = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSignInMailAdress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSignIn = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAddUser = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblSignInForgetPW = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtSignInPW
            // 
            this.txtSignInPW.Depth = 0;
            this.txtSignInPW.Hint = "";
            this.txtSignInPW.Location = new System.Drawing.Point(62, 146);
            this.txtSignInPW.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSignInPW.Name = "txtSignInPW";
            this.txtSignInPW.PasswordChar = '\0';
            this.txtSignInPW.SelectedText = "";
            this.txtSignInPW.SelectionLength = 0;
            this.txtSignInPW.SelectionStart = 0;
            this.txtSignInPW.Size = new System.Drawing.Size(178, 23);
            this.txtSignInPW.TabIndex = 7;
            this.txtSignInPW.Text = "Şifre";
            this.txtSignInPW.UseSystemPasswordChar = false;
            // 
            // txtSignInMailAdress
            // 
            this.txtSignInMailAdress.Depth = 0;
            this.txtSignInMailAdress.Hint = "";
            this.txtSignInMailAdress.Location = new System.Drawing.Point(62, 102);
            this.txtSignInMailAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSignInMailAdress.Name = "txtSignInMailAdress";
            this.txtSignInMailAdress.PasswordChar = '\0';
            this.txtSignInMailAdress.SelectedText = "";
            this.txtSignInMailAdress.SelectionLength = 0;
            this.txtSignInMailAdress.SelectionStart = 0;
            this.txtSignInMailAdress.Size = new System.Drawing.Size(178, 23);
            this.txtSignInMailAdress.TabIndex = 6;
            this.txtSignInMailAdress.Text = "Mail Adresi";
            this.txtSignInMailAdress.UseSystemPasswordChar = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.AutoSize = true;
            this.btnSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignIn.Depth = 0;
            this.btnSignIn.Location = new System.Drawing.Point(112, 189);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Primary = false;
            this.btnSignIn.Size = new System.Drawing.Size(76, 36);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Giriş Yap";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUser.Depth = 0;
            this.btnAddUser.Location = new System.Drawing.Point(112, 237);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Primary = false;
            this.btnAddUser.Size = new System.Drawing.Size(76, 36);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "KAYDOL";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblSignInForgetPW
            // 
            this.lblSignInForgetPW.AutoSize = true;
            this.lblSignInForgetPW.Depth = 0;
            this.lblSignInForgetPW.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSignInForgetPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSignInForgetPW.Location = new System.Drawing.Point(87, 289);
            this.lblSignInForgetPW.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSignInForgetPW.Name = "lblSignInForgetPW";
            this.lblSignInForgetPW.Size = new System.Drawing.Size(118, 19);
            this.lblSignInForgetPW.TabIndex = 9;
            this.lblSignInForgetPW.Text = "Şifremi Unuttum";
            this.lblSignInForgetPW.Click += new System.EventHandler(this.lblSignInForgetPW_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 344);
            this.Controls.Add(this.lblSignInForgetPW);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtSignInPW);
            this.Controls.Add(this.txtSignInMailAdress);
            this.Controls.Add(this.btnSignIn);
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtSignInPW;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSignInMailAdress;
        private MaterialSkin.Controls.MaterialFlatButton btnSignIn;
        private MaterialSkin.Controls.MaterialFlatButton btnAddUser;
        private MaterialSkin.Controls.MaterialLabel lblSignInForgetPW;
    }
}