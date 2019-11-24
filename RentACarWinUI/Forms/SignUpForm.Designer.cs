namespace RentACarWinUI.Forms
{
    partial class SignUpForm
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
            this.lblRegister = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddUser = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtSignUpMailAdress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSignUpPW = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Depth = 0;
            this.lblRegister.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRegister.Location = new System.Drawing.Point(58, 98);
            this.lblRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(182, 19);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "KULLANICI KAYIT FORMU";
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSize = true;
            this.btnAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUser.Depth = 0;
            this.btnAddUser.Location = new System.Drawing.Point(176, 260);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Primary = false;
            this.btnAddUser.Size = new System.Drawing.Size(64, 36);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "KAYDOL";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtSignUpMailAdress
            // 
            this.txtSignUpMailAdress.Depth = 0;
            this.txtSignUpMailAdress.Hint = "";
            this.txtSignUpMailAdress.Location = new System.Drawing.Point(62, 144);
            this.txtSignUpMailAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSignUpMailAdress.Name = "txtSignUpMailAdress";
            this.txtSignUpMailAdress.PasswordChar = '\0';
            this.txtSignUpMailAdress.SelectedText = "";
            this.txtSignUpMailAdress.SelectionLength = 0;
            this.txtSignUpMailAdress.SelectionStart = 0;
            this.txtSignUpMailAdress.Size = new System.Drawing.Size(178, 23);
            this.txtSignUpMailAdress.TabIndex = 2;
            this.txtSignUpMailAdress.Text = "Mail Adresi";
            this.txtSignUpMailAdress.UseSystemPasswordChar = false;
            // 
            // txtSignUpPW
            // 
            this.txtSignUpPW.Depth = 0;
            this.txtSignUpPW.Hint = "";
            this.txtSignUpPW.Location = new System.Drawing.Point(62, 188);
            this.txtSignUpPW.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSignUpPW.Name = "txtSignUpPW";
            this.txtSignUpPW.PasswordChar = '\0';
            this.txtSignUpPW.SelectedText = "";
            this.txtSignUpPW.SelectionLength = 0;
            this.txtSignUpPW.SelectionStart = 0;
            this.txtSignUpPW.Size = new System.Drawing.Size(178, 23);
            this.txtSignUpPW.TabIndex = 3;
            this.txtSignUpPW.Text = "Şifre";
            this.txtSignUpPW.UseSystemPasswordChar = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 348);
            this.Controls.Add(this.txtSignUpPW);
            this.Controls.Add(this.txtSignUpMailAdress);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblRegister);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblRegister;
        private MaterialSkin.Controls.MaterialFlatButton btnAddUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSignUpMailAdress;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSignUpPW;
    }
}