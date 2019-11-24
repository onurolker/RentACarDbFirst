namespace RentACarWinUI.Forms
{
    partial class RentACarMainForm
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
            this.btnSignUp = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSignIn = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilimiGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profiliDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralananlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOutUser = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignUp.Depth = 0;
            this.btnSignUp.Location = new System.Drawing.Point(355, 26);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Primary = false;
            this.btnSignUp.Size = new System.Drawing.Size(57, 36);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Üye Ol";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.AutoSize = true;
            this.btnSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignIn.Depth = 0;
            this.btnSignIn.Location = new System.Drawing.Point(439, 26);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Primary = false;
            this.btnSignIn.Size = new System.Drawing.Size(76, 36);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Giriş Yap";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçlarToolStripMenuItem,
            this.profilimToolStripMenuItem,
            this.uyelerToolStripMenuItem,
            this.arabaEkleToolStripMenuItem,
            this.kiralananlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçlarıListeleToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // araçlarıListeleToolStripMenuItem
            // 
            this.araçlarıListeleToolStripMenuItem.Name = "araçlarıListeleToolStripMenuItem";
            this.araçlarıListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.araçlarıListeleToolStripMenuItem.Text = "Araçları Listele";
            this.araçlarıListeleToolStripMenuItem.Click += new System.EventHandler(this.araçlarıListeleToolStripMenuItem_Click);
            // 
            // profilimToolStripMenuItem
            // 
            this.profilimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilimiGörüntüleToolStripMenuItem,
            this.profiliDüzenleToolStripMenuItem});
            this.profilimToolStripMenuItem.Name = "profilimToolStripMenuItem";
            this.profilimToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.profilimToolStripMenuItem.Text = "Profilim";
            // 
            // profilimiGörüntüleToolStripMenuItem
            // 
            this.profilimiGörüntüleToolStripMenuItem.Name = "profilimiGörüntüleToolStripMenuItem";
            this.profilimiGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.profilimiGörüntüleToolStripMenuItem.Text = "Profilimi Görüntüle";
            this.profilimiGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.profilimiGörüntüleToolStripMenuItem_Click);
            // 
            // profiliDüzenleToolStripMenuItem
            // 
            this.profiliDüzenleToolStripMenuItem.Name = "profiliDüzenleToolStripMenuItem";
            this.profiliDüzenleToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.profiliDüzenleToolStripMenuItem.Text = "Profili Düzenle";
            this.profiliDüzenleToolStripMenuItem.Click += new System.EventHandler(this.profiliDüzenleToolStripMenuItem_Click);
            // 
            // uyelerToolStripMenuItem
            // 
            this.uyelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeleriGörüntüleToolStripMenuItem});
            this.uyelerToolStripMenuItem.Name = "uyelerToolStripMenuItem";
            this.uyelerToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.uyelerToolStripMenuItem.Text = "Üyeler";
            // 
            // üyeleriGörüntüleToolStripMenuItem
            // 
            this.üyeleriGörüntüleToolStripMenuItem.Name = "üyeleriGörüntüleToolStripMenuItem";
            this.üyeleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.üyeleriGörüntüleToolStripMenuItem.Text = "Üyeleri Görüntüle";
            this.üyeleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.üyeleriGörüntüleToolStripMenuItem_Click);
            // 
            // arabaEkleToolStripMenuItem
            // 
            this.arabaEkleToolStripMenuItem.Name = "arabaEkleToolStripMenuItem";
            this.arabaEkleToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.arabaEkleToolStripMenuItem.Text = "Araba Ekle";
            this.arabaEkleToolStripMenuItem.Click += new System.EventHandler(this.arabaEkleToolStripMenuItem_Click);
            // 
            // kiralananlarToolStripMenuItem
            // 
            this.kiralananlarToolStripMenuItem.Name = "kiralananlarToolStripMenuItem";
            this.kiralananlarToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.kiralananlarToolStripMenuItem.Text = "Kiralananlar";
            this.kiralananlarToolStripMenuItem.Click += new System.EventHandler(this.kiralananlarToolStripMenuItem_Click);
            // 
            // btnOutUser
            // 
            this.btnOutUser.AutoSize = true;
            this.btnOutUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOutUser.Depth = 0;
            this.btnOutUser.Location = new System.Drawing.Point(523, 26);
            this.btnOutUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOutUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOutUser.Name = "btnOutUser";
            this.btnOutUser.Primary = false;
            this.btnOutUser.Size = new System.Drawing.Size(75, 36);
            this.btnOutUser.TabIndex = 4;
            this.btnOutUser.Text = "ÇIKIŞ YAP";
            this.btnOutUser.UseVisualStyleBackColor = true;
            // 
            // RentACarMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.btnOutUser);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnSignUp);
            this.Name = "RentACarMainForm";
            this.Text = "RentACarMainForm";
            this.Load += new System.EventHandler(this.RentACarMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnSignUp;
        private MaterialSkin.Controls.MaterialFlatButton btnSignIn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilimiGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profiliDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeleriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralananlarToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFlatButton btnOutUser;
    }
}