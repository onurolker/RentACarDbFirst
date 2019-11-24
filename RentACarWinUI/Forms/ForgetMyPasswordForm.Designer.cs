namespace RentACarWinUI.Forms
{
    partial class ForgetMyPasswordForm
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
            this.txtFMPWMailAdress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnFMPWSend = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // txtFMPWMailAdress
            // 
            this.txtFMPWMailAdress.Depth = 0;
            this.txtFMPWMailAdress.Hint = "";
            this.txtFMPWMailAdress.Location = new System.Drawing.Point(51, 101);
            this.txtFMPWMailAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFMPWMailAdress.Name = "txtFMPWMailAdress";
            this.txtFMPWMailAdress.PasswordChar = '\0';
            this.txtFMPWMailAdress.SelectedText = "";
            this.txtFMPWMailAdress.SelectionLength = 0;
            this.txtFMPWMailAdress.SelectionStart = 0;
            this.txtFMPWMailAdress.Size = new System.Drawing.Size(178, 23);
            this.txtFMPWMailAdress.TabIndex = 3;
            this.txtFMPWMailAdress.Text = "Mail Adresi";
            this.txtFMPWMailAdress.UseSystemPasswordChar = false;
            // 
            // btnFMPWSend
            // 
            this.btnFMPWSend.AutoSize = true;
            this.btnFMPWSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFMPWSend.Depth = 0;
            this.btnFMPWSend.Location = new System.Drawing.Point(165, 153);
            this.btnFMPWSend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFMPWSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFMPWSend.Name = "btnFMPWSend";
            this.btnFMPWSend.Primary = false;
            this.btnFMPWSend.Size = new System.Drawing.Size(66, 36);
            this.btnFMPWSend.TabIndex = 4;
            this.btnFMPWSend.Text = "GÖNDER";
            this.btnFMPWSend.UseVisualStyleBackColor = true;
            // 
            // ForgetMyPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 221);
            this.Controls.Add(this.btnFMPWSend);
            this.Controls.Add(this.txtFMPWMailAdress);
            this.Name = "ForgetMyPasswordForm";
            this.Text = "ForgetMyPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtFMPWMailAdress;
        private MaterialSkin.Controls.MaterialFlatButton btnFMPWSend;
    }
}