namespace CIP_HelpDesk.Models {
    partial class FrmClosedTicketsReport {
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
            this.dgvClosedTickets = new System.Windows.Forms.DataGridView();
            this.btnDeleteTicket = new MaterialSkin.Controls.MaterialButton();
            this.txtFilter = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pbArrowBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClosedTickets
            // 
            this.dgvClosedTickets.AllowUserToAddRows = false;
            this.dgvClosedTickets.AllowUserToDeleteRows = false;
            this.dgvClosedTickets.AllowUserToOrderColumns = true;
            this.dgvClosedTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvClosedTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClosedTickets.Location = new System.Drawing.Point(13, 122);
            this.dgvClosedTickets.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClosedTickets.Name = "dgvClosedTickets";
            this.dgvClosedTickets.ReadOnly = true;
            this.dgvClosedTickets.RowHeadersWidth = 51;
            this.dgvClosedTickets.RowTemplate.Height = 24;
            this.dgvClosedTickets.Size = new System.Drawing.Size(769, 306);
            this.dgvClosedTickets.TabIndex = 0;
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteTicket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteTicket.Depth = 0;
            this.btnDeleteTicket.HighEmphasis = true;
            this.btnDeleteTicket.Icon = null;
            this.btnDeleteTicket.Location = new System.Drawing.Point(13, 78);
            this.btnDeleteTicket.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteTicket.Size = new System.Drawing.Size(138, 36);
            this.btnDeleteTicket.TabIndex = 1;
            this.btnDeleteTicket.Text = "Izbriši zahtjev";
            this.btnDeleteTicket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteTicket.UseAccentColor = false;
            this.btnDeleteTicket.UseVisualStyleBackColor = true;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.AnimateReadOnly = false;
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Depth = 0;
            this.txtFilter.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.LeadingIcon = null;
            this.txtFilter.Location = new System.Drawing.Point(483, 67);
            this.txtFilter.MaxLength = 50;
            this.txtFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFilter.Multiline = false;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(299, 50);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.Text = "";
            this.txtFilter.TrailingIcon = null;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(372, 69);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(113, 48);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Pretraži prema opisu zahtjeva:";
            // 
            // pbArrowBack
            // 
            this.pbArrowBack.BackColor = System.Drawing.Color.Transparent;
            this.pbArrowBack.Image = global::CIP_HelpDesk.Properties.Resources.arrow_back;
            this.pbArrowBack.Location = new System.Drawing.Point(11, 20);
            this.pbArrowBack.Name = "pbArrowBack";
            this.pbArrowBack.Size = new System.Drawing.Size(30, 44);
            this.pbArrowBack.TabIndex = 4;
            this.pbArrowBack.TabStop = false;
            this.pbArrowBack.Click += new System.EventHandler(this.pbArrowBack_Click);
            // 
            // FrmClosedTicketsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.pbArrowBack);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnDeleteTicket);
            this.Controls.Add(this.dgvClosedTickets);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmClosedTicketsReport";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmClosedTicketsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClosedTickets;
        private MaterialSkin.Controls.MaterialButton btnDeleteTicket;
        private MaterialSkin.Controls.MaterialTextBox txtFilter;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pbArrowBack;
    }
}