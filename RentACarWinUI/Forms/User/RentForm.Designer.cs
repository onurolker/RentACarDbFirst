namespace RentACarWinUI.Forms.User
{
    partial class RentForm
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
            this.pictureBoxShowCar = new System.Windows.Forms.PictureBox();
            this.btnRent = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblDay = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDesc = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.lblDayOfPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblSellYear = new MaterialSkin.Controls.MaterialLabel();
            this.lblDayPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblChasisNo = new MaterialSkin.Controls.MaterialLabel();
            this.lblKM = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Chasis = new MaterialSkin.Controls.MaterialLabel();
            this.lblMark_Model = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Sasi = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_KM = new MaterialSkin.Controls.MaterialLabel();
            this.lblMarkAndModel = new MaterialSkin.Controls.MaterialLabel();
            this.lblDiscount = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.lblDiscountResult = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalPrice = new MaterialSkin.Controls.MaterialLabel();
            this.txtDay = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxShowCar
            // 
            this.pictureBoxShowCar.Location = new System.Drawing.Point(34, 80);
            this.pictureBoxShowCar.Name = "pictureBoxShowCar";
            this.pictureBoxShowCar.Size = new System.Drawing.Size(332, 157);
            this.pictureBoxShowCar.TabIndex = 20;
            this.pictureBoxShowCar.TabStop = false;
            // 
            // btnRent
            // 
            this.btnRent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRent.Depth = 0;
            this.btnRent.Location = new System.Drawing.Point(694, 486);
            this.btnRent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRent.Name = "btnRent";
            this.btnRent.Primary = false;
            this.btnRent.Size = new System.Drawing.Size(105, 47);
            this.btnRent.TabIndex = 30;
            this.btnRent.Text = "Kirala";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Depth = 0;
            this.lblDay.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDay.Location = new System.Drawing.Point(387, 279);
            this.lblDay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(266, 19);
            this.lblDay.TabIndex = 29;
            this.lblDay.Text = "KİRALAMAK İSTEDİĞİNİZ GÜN SAYISI:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDesc);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblDayOfPrice);
            this.groupBox1.Controls.Add(this.lblSellYear);
            this.groupBox1.Controls.Add(this.lblDayPrice);
            this.groupBox1.Controls.Add(this.lblChasisNo);
            this.groupBox1.Controls.Add(this.lblKM);
            this.groupBox1.Controls.Add(this.lbl_Chasis);
            this.groupBox1.Controls.Add(this.lblMark_Model);
            this.groupBox1.Controls.Add(this.lbl_Sasi);
            this.groupBox1.Controls.Add(this.lbl_KM);
            this.groupBox1.Controls.Add(this.lblMarkAndModel);
            this.groupBox1.Location = new System.Drawing.Point(43, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 195);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Depth = 0;
            this.lblDesc.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDesc.Location = new System.Drawing.Point(143, 143);
            this.lblDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(0, 19);
            this.lblDesc.TabIndex = 27;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescription.Location = new System.Drawing.Point(6, 143);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(92, 19);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Açıklaması :";
            // 
            // lblDayOfPrice
            // 
            this.lblDayOfPrice.AutoSize = true;
            this.lblDayOfPrice.Depth = 0;
            this.lblDayOfPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDayOfPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDayOfPrice.Location = new System.Drawing.Point(143, 123);
            this.lblDayOfPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDayOfPrice.Name = "lblDayOfPrice";
            this.lblDayOfPrice.Size = new System.Drawing.Size(0, 19);
            this.lblDayOfPrice.TabIndex = 26;
            // 
            // lblSellYear
            // 
            this.lblSellYear.AutoSize = true;
            this.lblSellYear.Depth = 0;
            this.lblSellYear.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSellYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSellYear.Location = new System.Drawing.Point(143, 100);
            this.lblSellYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSellYear.Name = "lblSellYear";
            this.lblSellYear.Size = new System.Drawing.Size(0, 19);
            this.lblSellYear.TabIndex = 25;
            // 
            // lblDayPrice
            // 
            this.lblDayPrice.AutoSize = true;
            this.lblDayPrice.Depth = 0;
            this.lblDayPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDayPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDayPrice.Location = new System.Drawing.Point(5, 123);
            this.lblDayPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDayPrice.Name = "lblDayPrice";
            this.lblDayPrice.Size = new System.Drawing.Size(103, 19);
            this.lblDayPrice.TabIndex = 20;
            this.lblDayPrice.Text = "Günlük Ücret :";
            // 
            // lblChasisNo
            // 
            this.lblChasisNo.AutoSize = true;
            this.lblChasisNo.Depth = 0;
            this.lblChasisNo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblChasisNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblChasisNo.Location = new System.Drawing.Point(143, 71);
            this.lblChasisNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblChasisNo.Name = "lblChasisNo";
            this.lblChasisNo.Size = new System.Drawing.Size(0, 19);
            this.lblChasisNo.TabIndex = 24;
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Depth = 0;
            this.lblKM.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKM.Location = new System.Drawing.Point(143, 47);
            this.lblKM.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(0, 19);
            this.lblKM.TabIndex = 23;
            // 
            // lbl_Chasis
            // 
            this.lbl_Chasis.AutoSize = true;
            this.lbl_Chasis.Depth = 0;
            this.lbl_Chasis.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Chasis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Chasis.Location = new System.Drawing.Point(5, 100);
            this.lbl_Chasis.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Chasis.Name = "lbl_Chasis";
            this.lbl_Chasis.Size = new System.Drawing.Size(76, 19);
            this.lbl_Chasis.TabIndex = 19;
            this.lbl_Chasis.Text = "Satış Yılı :";
            // 
            // lblMark_Model
            // 
            this.lblMark_Model.AutoSize = true;
            this.lblMark_Model.Depth = 0;
            this.lblMark_Model.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMark_Model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMark_Model.Location = new System.Drawing.Point(143, 23);
            this.lblMark_Model.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMark_Model.Name = "lblMark_Model";
            this.lblMark_Model.Size = new System.Drawing.Size(0, 19);
            this.lblMark_Model.TabIndex = 22;
            // 
            // lbl_Sasi
            // 
            this.lbl_Sasi.AutoSize = true;
            this.lbl_Sasi.Depth = 0;
            this.lbl_Sasi.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Sasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Sasi.Location = new System.Drawing.Point(5, 71);
            this.lbl_Sasi.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Sasi.Name = "lbl_Sasi";
            this.lbl_Sasi.Size = new System.Drawing.Size(115, 19);
            this.lbl_Sasi.TabIndex = 18;
            this.lbl_Sasi.Text = "Şasi Numarası :";
            // 
            // lbl_KM
            // 
            this.lbl_KM.AutoSize = true;
            this.lbl_KM.Depth = 0;
            this.lbl_KM.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_KM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_KM.Location = new System.Drawing.Point(6, 47);
            this.lbl_KM.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_KM.Name = "lbl_KM";
            this.lbl_KM.Size = new System.Drawing.Size(54, 19);
            this.lbl_KM.TabIndex = 17;
            this.lbl_KM.Text = "KM\'si :";
            // 
            // lblMarkAndModel
            // 
            this.lblMarkAndModel.AutoSize = true;
            this.lblMarkAndModel.Depth = 0;
            this.lblMarkAndModel.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMarkAndModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMarkAndModel.Location = new System.Drawing.Point(5, 23);
            this.lblMarkAndModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMarkAndModel.Name = "lblMarkAndModel";
            this.lblMarkAndModel.Size = new System.Drawing.Size(105, 19);
            this.lblMarkAndModel.TabIndex = 16;
            this.lblMarkAndModel.Text = "Marka-Model :";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Depth = 0;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDiscount.Location = new System.Drawing.Point(526, 320);
            this.lblDiscount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(127, 18);
            this.lblDiscount.TabIndex = 32;
            this.lblDiscount.Text = "İNDİRİM TUTARI :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(527, 366);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 18);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "TOPLAM TUTAR:";
            // 
            // lblDiscountResult
            // 
            this.lblDiscountResult.AutoSize = true;
            this.lblDiscountResult.Depth = 0;
            this.lblDiscountResult.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDiscountResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDiscountResult.Location = new System.Drawing.Point(679, 320);
            this.lblDiscountResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDiscountResult.Name = "lblDiscountResult";
            this.lblDiscountResult.Size = new System.Drawing.Size(17, 19);
            this.lblDiscountResult.TabIndex = 34;
            this.lblDiscountResult.Text = "0";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Depth = 0;
            this.lblTotalPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(679, 365);
            this.lblTotalPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(17, 19);
            this.lblTotalPrice.TabIndex = 35;
            this.lblTotalPrice.Text = "0";
            // 
            // txtDay
            // 
            this.txtDay.Depth = 0;
            this.txtDay.Hint = "";
            this.txtDay.Location = new System.Drawing.Point(683, 275);
            this.txtDay.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDay.Name = "txtDay";
            this.txtDay.PasswordChar = '\0';
            this.txtDay.SelectedText = "";
            this.txtDay.SelectionLength = 0;
            this.txtDay.SelectionStart = 0;
            this.txtDay.Size = new System.Drawing.Size(116, 23);
            this.txtDay.TabIndex = 36;
            this.txtDay.UseSystemPasswordChar = false;
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 558);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDiscountResult);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.pictureBoxShowCar);
            this.Name = "RentForm";
            this.Text = "RentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxShowCar;
        private MaterialSkin.Controls.MaterialFlatButton btnRent;
        private MaterialSkin.Controls.MaterialLabel lblDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel lblDesc;
        private MaterialSkin.Controls.MaterialLabel lblDescription;
        private MaterialSkin.Controls.MaterialLabel lblDayOfPrice;
        private MaterialSkin.Controls.MaterialLabel lblSellYear;
        private MaterialSkin.Controls.MaterialLabel lblDayPrice;
        private MaterialSkin.Controls.MaterialLabel lblChasisNo;
        private MaterialSkin.Controls.MaterialLabel lblKM;
        private MaterialSkin.Controls.MaterialLabel lbl_Chasis;
        private MaterialSkin.Controls.MaterialLabel lblMark_Model;
        private MaterialSkin.Controls.MaterialLabel lbl_Sasi;
        private MaterialSkin.Controls.MaterialLabel lbl_KM;
        private MaterialSkin.Controls.MaterialLabel lblMarkAndModel;
        private MaterialSkin.Controls.MaterialLabel lblDiscount;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialLabel lblDiscountResult;
        private MaterialSkin.Controls.MaterialLabel lblTotalPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDay;
    }
}