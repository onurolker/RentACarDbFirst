namespace RentACarWinUI.Forms.Admin
{
    partial class ListUsersForm
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
            this.dgvListUsers = new System.Windows.Forms.DataGridView();
            this.btnDeleteUser = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnIsAdmin = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListUsers
            // 
            this.dgvListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUsers.Location = new System.Drawing.Point(41, 75);
            this.dgvListUsers.Name = "dgvListUsers";
            this.dgvListUsers.Size = new System.Drawing.Size(336, 353);
            this.dgvListUsers.TabIndex = 3;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteUser.Depth = 0;
            this.btnDeleteUser.Location = new System.Drawing.Point(457, 133);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Primary = false;
            this.btnDeleteUser.Size = new System.Drawing.Size(172, 66);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "Kullanıcıyı Sil";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnIsAdmin
            // 
            this.btnIsAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIsAdmin.Depth = 0;
            this.btnIsAdmin.Location = new System.Drawing.Point(457, 242);
            this.btnIsAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIsAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIsAdmin.Name = "btnIsAdmin";
            this.btnIsAdmin.Primary = false;
            this.btnIsAdmin.Size = new System.Drawing.Size(172, 66);
            this.btnIsAdmin.TabIndex = 10;
            this.btnIsAdmin.Text = "Admin Yap";
            this.btnIsAdmin.UseVisualStyleBackColor = true;
            // 
            // ListUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIsAdmin);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.dgvListUsers);
            this.Name = "ListUsersForm";
            this.Text = "ListUsersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListUsers;
        private MaterialSkin.Controls.MaterialFlatButton btnDeleteUser;
        private MaterialSkin.Controls.MaterialFlatButton btnIsAdmin;
    }
}