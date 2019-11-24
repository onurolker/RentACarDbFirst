namespace RentACarWinUI.Forms.Admin
{
    partial class AddNewModelForm
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
            this.lblModel = new MaterialSkin.Controls.MaterialLabel();
            this.txtModelName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddNewModel = new MaterialSkin.Controls.MaterialFlatButton();
            this.cmbMark = new System.Windows.Forms.ComboBox();
            this.lblMark = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Depth = 0;
            this.lblModel.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblModel.Location = new System.Drawing.Point(41, 146);
            this.lblModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(77, 19);
            this.lblModel.TabIndex = 13;
            this.lblModel.Text = "Marka Adı";
            // 
            // txtModelName
            // 
            this.txtModelName.Depth = 0;
            this.txtModelName.Hint = "";
            this.txtModelName.Location = new System.Drawing.Point(150, 146);
            this.txtModelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.PasswordChar = '\0';
            this.txtModelName.SelectedText = "";
            this.txtModelName.SelectionLength = 0;
            this.txtModelName.SelectionStart = 0;
            this.txtModelName.Size = new System.Drawing.Size(178, 23);
            this.txtModelName.TabIndex = 12;
            this.txtModelName.UseSystemPasswordChar = false;
            // 
            // btnAddNewModel
            // 
            this.btnAddNewModel.AutoSize = true;
            this.btnAddNewModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNewModel.Depth = 0;
            this.btnAddNewModel.Location = new System.Drawing.Point(233, 203);
            this.btnAddNewModel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddNewModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddNewModel.Name = "btnAddNewModel";
            this.btnAddNewModel.Primary = false;
            this.btnAddNewModel.Size = new System.Drawing.Size(93, 36);
            this.btnAddNewModel.TabIndex = 11;
            this.btnAddNewModel.Text = "Model Ekle";
            this.btnAddNewModel.UseVisualStyleBackColor = true;
            // 
            // cmbMark
            // 
            this.cmbMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMark.FormattingEnabled = true;
            this.cmbMark.Location = new System.Drawing.Point(150, 105);
            this.cmbMark.Name = "cmbMark";
            this.cmbMark.Size = new System.Drawing.Size(178, 21);
            this.cmbMark.TabIndex = 14;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Depth = 0;
            this.lblMark.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMark.Location = new System.Drawing.Point(38, 107);
            this.lblMark.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(80, 19);
            this.lblMark.TabIndex = 16;
            this.lblMark.Text = "Marka Seç";
            // 
            // AddNewModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 305);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.cmbMark);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.btnAddNewModel);
            this.Name = "AddNewModelForm";
            this.Text = "AddNewModelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblModel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtModelName;
        private MaterialSkin.Controls.MaterialFlatButton btnAddNewModel;
        private System.Windows.Forms.ComboBox cmbMark;
        private MaterialSkin.Controls.MaterialLabel lblMark;
    }
}