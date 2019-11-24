namespace RentACarWinUI.Forms
{
    partial class ListCarForm
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
            this.lblCars = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewShowCar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Depth = 0;
            this.lblCars.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCars.Location = new System.Drawing.Point(296, 86);
            this.lblCars.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(84, 19);
            this.lblCars.TabIndex = 1;
            this.lblCars.Text = "ARABALAR";
            // 
            // dataGridViewShowCar
            // 
            this.dataGridViewShowCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCar.Location = new System.Drawing.Point(0, 156);
            this.dataGridViewShowCar.Name = "dataGridViewShowCar";
            this.dataGridViewShowCar.Size = new System.Drawing.Size(801, 294);
            this.dataGridViewShowCar.TabIndex = 2;
            // 
            // ListCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewShowCar);
            this.Controls.Add(this.lblCars);
            this.Name = "ListCarForm";
            this.Text = "ListCarForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblCars;
        private System.Windows.Forms.DataGridView dataGridViewShowCar;
    }
}