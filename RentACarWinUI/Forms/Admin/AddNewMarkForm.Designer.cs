namespace RentACarWinUI.Forms.Admin
{
    partial class AddNewMarkForm
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
            this.txtMarkName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddNewMark = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblMark = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtMarkName
            // 
            this.txtMarkName.Depth = 0;
            this.txtMarkName.Hint = "";
            this.txtMarkName.Location = new System.Drawing.Point(132, 111);
            this.txtMarkName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMarkName.Name = "txtMarkName";
            this.txtMarkName.PasswordChar = '\0';
            this.txtMarkName.SelectedText = "";
            this.txtMarkName.SelectionLength = 0;
            this.txtMarkName.SelectionStart = 0;
            this.txtMarkName.Size = new System.Drawing.Size(178, 23);
            this.txtMarkName.TabIndex = 9;
            this.txtMarkName.UseSystemPasswordChar = false;
            // 
            // btnAddNewMark
            // 
            this.btnAddNewMark.AutoSize = true;
            this.btnAddNewMark.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNewMark.Depth = 0;
            this.btnAddNewMark.Location = new System.Drawing.Point(215, 168);
            this.btnAddNewMark.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddNewMark.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddNewMark.Name = "btnAddNewMark";
            this.btnAddNewMark.Primary = false;
            this.btnAddNewMark.Size = new System.Drawing.Size(95, 36);
            this.btnAddNewMark.TabIndex = 8;
            this.btnAddNewMark.Text = "Marka Ekle";
            this.btnAddNewMark.UseVisualStyleBackColor = true;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Depth = 0;
            this.lblMark.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMark.Location = new System.Drawing.Point(23, 111);
            this.lblMark.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(77, 19);
            this.lblMark.TabIndex = 10;
            this.lblMark.Text = "Marka Adı";
            // 
            // AddNewMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 268);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.txtMarkName);
            this.Controls.Add(this.btnAddNewMark);
            this.Name = "AddNewMarkForm";
            this.Text = "AddNewMarkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtMarkName;
        private MaterialSkin.Controls.MaterialFlatButton btnAddNewMark;
        private MaterialSkin.Controls.MaterialLabel lblMark;
    }
}