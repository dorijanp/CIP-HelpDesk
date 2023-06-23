namespace CIP_HelpDesk {
    partial class FrmUser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvUserTickets = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnNewTicket = new MaterialSkin.Controls.MaterialButton();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserTickets
            // 
            this.dgvUserTickets.AllowUserToAddRows = false;
            this.dgvUserTickets.AllowUserToDeleteRows = false;
            this.dgvUserTickets.AllowUserToOrderColumns = true;
            this.dgvUserTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserTickets.Location = new System.Drawing.Point(22, 127);
            this.dgvUserTickets.Margin = new System.Windows.Forms.Padding(100);
            this.dgvUserTickets.Name = "dgvUserTickets";
            this.dgvUserTickets.ReadOnly = true;
            this.dgvUserTickets.RowHeadersWidth = 51;
            this.dgvUserTickets.RowTemplate.Height = 28;
            this.dgvUserTickets.Size = new System.Drawing.Size(759, 455);
            this.dgvUserTickets.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(19, 101);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(155, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Vaši prijašnji zahtjevi:";
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewTicket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNewTicket.Depth = 0;
            this.btnNewTicket.HighEmphasis = true;
            this.btnNewTicket.Icon = null;
            this.btnNewTicket.Location = new System.Drawing.Point(658, 71);
            this.btnNewTicket.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewTicket.Size = new System.Drawing.Size(123, 36);
            this.btnNewTicket.TabIndex = 4;
            this.btnNewTicket.Text = "Novi zahtjev";
            this.btnNewTicket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNewTicket.UseAccentColor = false;
            this.btnNewTicket.UseVisualStyleBackColor = true;
            this.btnNewTicket.Click += new System.EventHandler(this.btnNewTicket_Click);
            // 
            // pbLogout
            // 
            this.pbLogout.BackColor = System.Drawing.Color.Transparent;
            this.pbLogout.Image = global::CIP_HelpDesk.Properties.Resources.logout;
            this.pbLogout.Location = new System.Drawing.Point(751, 20);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(49, 50);
            this.pbLogout.TabIndex = 5;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pbLogout);
            this.Controls.Add(this.btnNewTicket);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dgvUserTickets);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUser";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUserTickets;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnNewTicket;
        private System.Windows.Forms.PictureBox pbLogout;
    }
}