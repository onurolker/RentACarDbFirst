namespace RentACarWinUI.Forms.Admin
{
    partial class AddCarForm
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
            this.grpBoxAddCar = new System.Windows.Forms.GroupBox();
            this.richtxtDescription = new System.Windows.Forms.RichTextBox();
            this.dateTimeSalesDate = new System.Windows.Forms.DateTimePicker();
            this.cmbMark = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.lblTrade = new MaterialSkin.Controls.MaterialLabel();
            this.lblModel = new MaterialSkin.Controls.MaterialLabel();
            this.lblChassis = new MaterialSkin.Controls.MaterialLabel();
            this.lblKm = new MaterialSkin.Controls.MaterialLabel();
            this.lblYearOfSale = new MaterialSkin.Controls.MaterialLabel();
            this.lblDayOfPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddTrade = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAddModel = new MaterialSkin.Controls.MaterialFlatButton();
            this.flowLayoutPanelForPictureBox = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPictureChoose = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAddCar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblCarImages = new MaterialSkin.Controls.MaterialLabel();
            this.txtSignUpMailAdress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtKm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDayOfPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grpBoxAddCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxAddCar
            // 
            this.grpBoxAddCar.Controls.Add(this.txtDayOfPrice);
            this.grpBoxAddCar.Controls.Add(this.txtKm);
            this.grpBoxAddCar.Controls.Add(this.txtSignUpMailAdress);
            this.grpBoxAddCar.Controls.Add(this.btnAddModel);
            this.grpBoxAddCar.Controls.Add(this.btnAddTrade);
            this.grpBoxAddCar.Controls.Add(this.lblDescription);
            this.grpBoxAddCar.Controls.Add(this.lblDayOfPrice);
            this.grpBoxAddCar.Controls.Add(this.lblYearOfSale);
            this.grpBoxAddCar.Controls.Add(this.lblKm);
            this.grpBoxAddCar.Controls.Add(this.lblChassis);
            this.grpBoxAddCar.Controls.Add(this.lblModel);
            this.grpBoxAddCar.Controls.Add(this.lblTrade);
            this.grpBoxAddCar.Controls.Add(this.richtxtDescription);
            this.grpBoxAddCar.Controls.Add(this.dateTimeSalesDate);
            this.grpBoxAddCar.Controls.Add(this.cmbMark);
            this.grpBoxAddCar.Controls.Add(this.cmbModel);
            this.grpBoxAddCar.Location = new System.Drawing.Point(43, 71);
            this.grpBoxAddCar.Name = "grpBoxAddCar";
            this.grpBoxAddCar.Size = new System.Drawing.Size(541, 399);
            this.grpBoxAddCar.TabIndex = 45;
            this.grpBoxAddCar.TabStop = false;
            this.grpBoxAddCar.Text = "ARABA EKLEME FORMU";
            // 
            // richtxtDescription
            // 
            this.richtxtDescription.Location = new System.Drawing.Point(191, 286);
            this.richtxtDescription.Name = "richtxtDescription";
            this.richtxtDescription.Size = new System.Drawing.Size(219, 96);
            this.richtxtDescription.TabIndex = 39;
            this.richtxtDescription.Text = "";
            // 
            // dateTimeSalesDate
            // 
            this.dateTimeSalesDate.Location = new System.Drawing.Point(191, 194);
            this.dateTimeSalesDate.Name = "dateTimeSalesDate";
            this.dateTimeSalesDate.Size = new System.Drawing.Size(219, 20);
            this.dateTimeSalesDate.TabIndex = 38;
            // 
            // cmbMark
            // 
            this.cmbMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMark.FormattingEnabled = true;
            this.cmbMark.Location = new System.Drawing.Point(191, 38);
            this.cmbMark.Name = "cmbMark";
            this.cmbMark.Size = new System.Drawing.Size(140, 21);
            this.cmbMark.TabIndex = 33;
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.Location = new System.Drawing.Point(191, 74);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(140, 21);
            this.cmbModel.TabIndex = 44;
            // 
            // lblTrade
            // 
            this.lblTrade.AutoSize = true;
            this.lblTrade.Depth = 0;
            this.lblTrade.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTrade.Location = new System.Drawing.Point(43, 38);
            this.lblTrade.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(63, 19);
            this.lblTrade.TabIndex = 45;
            this.lblTrade.Text = "Marka : ";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Depth = 0;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblModel.Location = new System.Drawing.Point(45, 74);
            this.lblModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(61, 18);
            this.lblModel.TabIndex = 46;
            this.lblModel.Text = "Model : ";
            // 
            // lblChassis
            // 
            this.lblChassis.AutoSize = true;
            this.lblChassis.Depth = 0;
            this.lblChassis.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblChassis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblChassis.Location = new System.Drawing.Point(44, 116);
            this.lblChassis.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblChassis.Name = "lblChassis";
            this.lblChassis.Size = new System.Drawing.Size(115, 19);
            this.lblChassis.TabIndex = 47;
            this.lblChassis.Text = "Şasi Numarası :";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Depth = 0;
            this.lblKm.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblKm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKm.Location = new System.Drawing.Point(44, 155);
            this.lblKm.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(82, 19);
            this.lblKm.TabIndex = 48;
            this.lblKm.Text = "Kilometre :";
            // 
            // lblYearOfSale
            // 
            this.lblYearOfSale.AutoSize = true;
            this.lblYearOfSale.Depth = 0;
            this.lblYearOfSale.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblYearOfSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblYearOfSale.Location = new System.Drawing.Point(44, 195);
            this.lblYearOfSale.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblYearOfSale.Name = "lblYearOfSale";
            this.lblYearOfSale.Size = new System.Drawing.Size(80, 19);
            this.lblYearOfSale.TabIndex = 49;
            this.lblYearOfSale.Text = "Satış Yılı : ";
            // 
            // lblDayOfPrice
            // 
            this.lblDayOfPrice.AutoSize = true;
            this.lblDayOfPrice.Depth = 0;
            this.lblDayOfPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDayOfPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDayOfPrice.Location = new System.Drawing.Point(44, 235);
            this.lblDayOfPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDayOfPrice.Name = "lblDayOfPrice";
            this.lblDayOfPrice.Size = new System.Drawing.Size(95, 19);
            this.lblDayOfPrice.TabIndex = 50;
            this.lblDayOfPrice.Text = "Günlük Fiyat:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescription.Location = new System.Drawing.Point(46, 286);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 19);
            this.lblDescription.TabIndex = 51;
            this.lblDescription.Text = "Açıklama :";
            // 
            // btnAddTrade
            // 
            this.btnAddTrade.AutoSize = true;
            this.btnAddTrade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTrade.Depth = 0;
            this.btnAddTrade.Location = new System.Drawing.Point(351, 29);
            this.btnAddTrade.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddTrade.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTrade.Name = "btnAddTrade";
            this.btnAddTrade.Primary = false;
            this.btnAddTrade.Size = new System.Drawing.Size(95, 36);
            this.btnAddTrade.TabIndex = 52;
            this.btnAddTrade.Text = "Marka Ekle";
            this.btnAddTrade.UseVisualStyleBackColor = true;
            // 
            // btnAddModel
            // 
            this.btnAddModel.AutoSize = true;
            this.btnAddModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddModel.Depth = 0;
            this.btnAddModel.Location = new System.Drawing.Point(351, 65);
            this.btnAddModel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Primary = false;
            this.btnAddModel.Size = new System.Drawing.Size(93, 36);
            this.btnAddModel.TabIndex = 53;
            this.btnAddModel.Text = "Model Ekle";
            this.btnAddModel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelForPictureBox
            // 
            this.flowLayoutPanelForPictureBox.Location = new System.Drawing.Point(211, 506);
            this.flowLayoutPanelForPictureBox.Name = "flowLayoutPanelForPictureBox";
            this.flowLayoutPanelForPictureBox.Size = new System.Drawing.Size(373, 148);
            this.flowLayoutPanelForPictureBox.TabIndex = 49;
            // 
            // btnPictureChoose
            // 
            this.btnPictureChoose.AutoSize = true;
            this.btnPictureChoose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPictureChoose.Depth = 0;
            this.btnPictureChoose.Location = new System.Drawing.Point(591, 506);
            this.btnPictureChoose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPictureChoose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPictureChoose.Name = "btnPictureChoose";
            this.btnPictureChoose.Primary = false;
            this.btnPictureChoose.Size = new System.Drawing.Size(110, 36);
            this.btnPictureChoose.TabIndex = 54;
            this.btnPictureChoose.Text = "Fotoğraf Seç";
            this.btnPictureChoose.UseVisualStyleBackColor = true;
            // 
            // btnAddCar
            // 
            this.btnAddCar.AutoSize = true;
            this.btnAddCar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCar.Depth = 0;
            this.btnAddCar.Location = new System.Drawing.Point(480, 663);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddCar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Primary = false;
            this.btnAddCar.Size = new System.Drawing.Size(104, 36);
            this.btnAddCar.TabIndex = 55;
            this.btnAddCar.Text = "Arabayı Ekle";
            this.btnAddCar.UseVisualStyleBackColor = true;
            // 
            // lblCarImages
            // 
            this.lblCarImages.AutoSize = true;
            this.lblCarImages.Depth = 0;
            this.lblCarImages.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCarImages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCarImages.Location = new System.Drawing.Point(46, 506);
            this.lblCarImages.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCarImages.Name = "lblCarImages";
            this.lblCarImages.Size = new System.Drawing.Size(123, 19);
            this.lblCarImages.TabIndex = 54;
            this.lblCarImages.Text = "Araba Resimleri :";
            // 
            // txtSignUpMailAdress
            // 
            this.txtSignUpMailAdress.Depth = 0;
            this.txtSignUpMailAdress.Hint = "";
            this.txtSignUpMailAdress.Location = new System.Drawing.Point(191, 112);
            this.txtSignUpMailAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSignUpMailAdress.Name = "txtSignUpMailAdress";
            this.txtSignUpMailAdress.PasswordChar = '\0';
            this.txtSignUpMailAdress.SelectedText = "";
            this.txtSignUpMailAdress.SelectionLength = 0;
            this.txtSignUpMailAdress.SelectionStart = 0;
            this.txtSignUpMailAdress.Size = new System.Drawing.Size(178, 23);
            this.txtSignUpMailAdress.TabIndex = 54;
            this.txtSignUpMailAdress.UseSystemPasswordChar = false;
            // 
            // txtKm
            // 
            this.txtKm.Depth = 0;
            this.txtKm.Hint = "";
            this.txtKm.Location = new System.Drawing.Point(191, 151);
            this.txtKm.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtKm.Name = "txtKm";
            this.txtKm.PasswordChar = '\0';
            this.txtKm.SelectedText = "";
            this.txtKm.SelectionLength = 0;
            this.txtKm.SelectionStart = 0;
            this.txtKm.Size = new System.Drawing.Size(178, 23);
            this.txtKm.TabIndex = 55;
            this.txtKm.UseSystemPasswordChar = false;
            // 
            // txtDayOfPrice
            // 
            this.txtDayOfPrice.Depth = 0;
            this.txtDayOfPrice.Hint = "";
            this.txtDayOfPrice.Location = new System.Drawing.Point(191, 231);
            this.txtDayOfPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDayOfPrice.Name = "txtDayOfPrice";
            this.txtDayOfPrice.PasswordChar = '\0';
            this.txtDayOfPrice.SelectedText = "";
            this.txtDayOfPrice.SelectionLength = 0;
            this.txtDayOfPrice.SelectionStart = 0;
            this.txtDayOfPrice.Size = new System.Drawing.Size(178, 23);
            this.txtDayOfPrice.TabIndex = 56;
            this.txtDayOfPrice.UseSystemPasswordChar = false;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 730);
            this.Controls.Add(this.lblCarImages);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnPictureChoose);
            this.Controls.Add(this.flowLayoutPanelForPictureBox);
            this.Controls.Add(this.grpBoxAddCar);
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            this.grpBoxAddCar.ResumeLayout(false);
            this.grpBoxAddCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxAddCar;
        private System.Windows.Forms.RichTextBox richtxtDescription;
        private System.Windows.Forms.DateTimePicker dateTimeSalesDate;
        public System.Windows.Forms.ComboBox cmbMark;
        public System.Windows.Forms.ComboBox cmbModel;
        private MaterialSkin.Controls.MaterialLabel lblDescription;
        private MaterialSkin.Controls.MaterialLabel lblDayOfPrice;
        private MaterialSkin.Controls.MaterialLabel lblYearOfSale;
        private MaterialSkin.Controls.MaterialLabel lblKm;
        private MaterialSkin.Controls.MaterialLabel lblChassis;
        private MaterialSkin.Controls.MaterialLabel lblModel;
        private MaterialSkin.Controls.MaterialLabel lblTrade;
        private MaterialSkin.Controls.MaterialFlatButton btnAddModel;
        private MaterialSkin.Controls.MaterialFlatButton btnAddTrade;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelForPictureBox;
        private MaterialSkin.Controls.MaterialFlatButton btnPictureChoose;
        private MaterialSkin.Controls.MaterialFlatButton btnAddCar;
        private MaterialSkin.Controls.MaterialLabel lblCarImages;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDayOfPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtKm;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSignUpMailAdress;
    }
}