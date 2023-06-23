namespace CIP_HelpDesk {
    partial class FrmEmployee {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployee));
            this.cboTickets = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rbtnNewTickets = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnActiveTickets = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtComment = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnCloseTicket = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUser = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDate = new MaterialSkin.Controls.MaterialTextBox();
            this.cboPriority = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnAcceptTicket = new MaterialSkin.Controls.MaterialButton();
            this.btnClosedTicketsReport = new MaterialSkin.Controls.MaterialButton();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTickets
            // 
            this.cboTickets.AutoResize = false;
            this.cboTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTickets.Depth = 0;
            this.cboTickets.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTickets.DropDownHeight = 174;
            this.cboTickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTickets.DropDownWidth = 121;
            this.cboTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTickets.FormattingEnabled = true;
            this.cboTickets.IntegralHeight = false;
            this.cboTickets.ItemHeight = 43;
            this.cboTickets.Location = new System.Drawing.Point(15, 142);
            this.cboTickets.MaxDropDownItems = 4;
            this.cboTickets.MouseState = MaterialSkin.MouseState.OUT;
            this.cboTickets.Name = "cboTickets";
            this.cboTickets.Size = new System.Drawing.Size(207, 49);
            this.cboTickets.StartIndex = 0;
            this.cboTickets.TabIndex = 0;
            this.cboTickets.SelectedIndexChanged += new System.EventHandler(this.cboTickets_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(15, 107);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(58, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Zahtjev:";
            // 
            // rbtnNewTickets
            // 
            this.rbtnNewTickets.AutoSize = true;
            this.rbtnNewTickets.Depth = 0;
            this.rbtnNewTickets.Location = new System.Drawing.Point(240, 154);
            this.rbtnNewTickets.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnNewTickets.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnNewTickets.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnNewTickets.Name = "rbtnNewTickets";
            this.rbtnNewTickets.Ripple = true;
            this.rbtnNewTickets.Size = new System.Drawing.Size(126, 37);
            this.rbtnNewTickets.TabIndex = 3;
            this.rbtnNewTickets.TabStop = true;
            this.rbtnNewTickets.Text = "Novi zahtjevi";
            this.rbtnNewTickets.UseVisualStyleBackColor = true;
            // 
            // rbtnActiveTickets
            // 
            this.rbtnActiveTickets.AutoSize = true;
            this.rbtnActiveTickets.Depth = 0;
            this.rbtnActiveTickets.Location = new System.Drawing.Point(390, 154);
            this.rbtnActiveTickets.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnActiveTickets.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnActiveTickets.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnActiveTickets.Name = "rbtnActiveTickets";
            this.rbtnActiveTickets.Ripple = true;
            this.rbtnActiveTickets.Size = new System.Drawing.Size(142, 37);
            this.rbtnActiveTickets.TabIndex = 4;
            this.rbtnActiveTickets.TabStop = true;
            this.rbtnActiveTickets.Text = "Aktivni zahtjevi";
            this.rbtnActiveTickets.UseVisualStyleBackColor = true;
            this.rbtnActiveTickets.CheckedChanged += new System.EventHandler(this.rbtnActiveTickets_CheckedChanged);
            // 
            // txtComment
            // 
            this.txtComment.AnimateReadOnly = false;
            this.txtComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtComment.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.Depth = 0;
            this.txtComment.HideSelection = true;
            this.txtComment.Location = new System.Drawing.Point(447, 277);
            this.txtComment.MaxLength = 255;
            this.txtComment.MouseState = MaterialSkin.MouseState.OUT;
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.ReadOnly = false;
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComment.SelectedText = "";
            this.txtComment.SelectionLength = 0;
            this.txtComment.SelectionStart = 0;
            this.txtComment.ShortcutsEnabled = true;
            this.txtComment.Size = new System.Drawing.Size(316, 119);
            this.txtComment.TabIndex = 6;
            this.txtComment.TabStop = false;
            this.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComment.UseSystemPasswordChar = false;
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseTicket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCloseTicket.Depth = 0;
            this.btnCloseTicket.HighEmphasis = true;
            this.btnCloseTicket.Icon = null;
            this.btnCloseTicket.Location = new System.Drawing.Point(615, 534);
            this.btnCloseTicket.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCloseTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCloseTicket.Size = new System.Drawing.Size(150, 36);
            this.btnCloseTicket.TabIndex = 7;
            this.btnCloseTicket.Text = "Zatvori zahtjev";
            this.btnCloseTicket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCloseTicket.UseAccentColor = false;
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnCloseTicket_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(37, 243);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Korisnik";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(37, 327);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Datum stvaranja";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(37, 413);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(33, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Opis";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(444, 243);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(70, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Komentar";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(444, 413);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(56, 19);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Prioritet";
            // 
            // txtUser
            // 
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.LeadingIcon = null;
            this.txtUser.Location = new System.Drawing.Point(40, 274);
            this.txtUser.MaxLength = 50;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(182, 50);
            this.txtUser.TabIndex = 13;
            this.txtUser.Text = "";
            this.txtUser.TrailingIcon = null;
            // 
            // txtDate
            // 
            this.txtDate.AnimateReadOnly = false;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Depth = 0;
            this.txtDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDate.LeadingIcon = null;
            this.txtDate.Location = new System.Drawing.Point(40, 349);
            this.txtDate.MaxLength = 50;
            this.txtDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDate.Multiline = false;
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(182, 50);
            this.txtDate.TabIndex = 14;
            this.txtDate.Text = "";
            this.txtDate.TrailingIcon = null;
            // 
            // cboPriority
            // 
            this.cboPriority.AutoResize = false;
            this.cboPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboPriority.Depth = 0;
            this.cboPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPriority.DropDownHeight = 174;
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.DropDownWidth = 121;
            this.cboPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.IntegralHeight = false;
            this.cboPriority.ItemHeight = 43;
            this.cboPriority.Items.AddRange(new object[] {
            "",
            "Nizak",
            "Srednji",
            "Visok"});
            this.cboPriority.Location = new System.Drawing.Point(447, 435);
            this.cboPriority.MaxDropDownItems = 4;
            this.cboPriority.MouseState = MaterialSkin.MouseState.OUT;
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(151, 49);
            this.cboPriority.StartIndex = 0;
            this.cboPriority.TabIndex = 16;
            // 
            // txtDescription
            // 
            this.txtDescription.AnimateReadOnly = false;
            this.txtDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Depth = 0;
            this.txtDescription.HideSelection = true;
            this.txtDescription.Location = new System.Drawing.Point(40, 435);
            this.txtDescription.MaxLength = 255;
            this.txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(360, 119);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.TabStop = false;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-9, 208);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(815, 23);
            this.materialDivider1.TabIndex = 18;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btnAcceptTicket
            // 
            this.btnAcceptTicket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAcceptTicket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAcceptTicket.Depth = 0;
            this.btnAcceptTicket.HighEmphasis = true;
            this.btnAcceptTicket.Icon = null;
            this.btnAcceptTicket.Location = new System.Drawing.Point(615, 155);
            this.btnAcceptTicket.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAcceptTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAcceptTicket.Name = "btnAcceptTicket";
            this.btnAcceptTicket.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAcceptTicket.Size = new System.Drawing.Size(152, 36);
            this.btnAcceptTicket.TabIndex = 19;
            this.btnAcceptTicket.Text = "Preuzmi zahtjev";
            this.btnAcceptTicket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAcceptTicket.UseAccentColor = false;
            this.btnAcceptTicket.UseVisualStyleBackColor = true;
            this.btnAcceptTicket.Click += new System.EventHandler(this.btnAcceptTicket_Click);
            // 
            // btnClosedTicketsReport
            // 
            this.btnClosedTicketsReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClosedTicketsReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClosedTicketsReport.Depth = 0;
            this.btnClosedTicketsReport.HighEmphasis = true;
            this.btnClosedTicketsReport.Icon = null;
            this.btnClosedTicketsReport.Location = new System.Drawing.Point(544, 78);
            this.btnClosedTicketsReport.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClosedTicketsReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClosedTicketsReport.Name = "btnClosedTicketsReport";
            this.btnClosedTicketsReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClosedTicketsReport.Size = new System.Drawing.Size(235, 36);
            this.btnClosedTicketsReport.TabIndex = 20;
            this.btnClosedTicketsReport.Text = "Arhiva završenih zahtjeva";
            this.btnClosedTicketsReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClosedTicketsReport.UseAccentColor = false;
            this.btnClosedTicketsReport.UseVisualStyleBackColor = true;
            this.btnClosedTicketsReport.Click += new System.EventHandler(this.btnClosedTicketsReport_Click);
            // 
            // pbLogout
            // 
            this.pbLogout.BackColor = System.Drawing.Color.Transparent;
            this.pbLogout.Image = ((System.Drawing.Image)(resources.GetObject("pbLogout.Image")));
            this.pbLogout.Location = new System.Drawing.Point(745, 20);
            this.pbLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(51, 51);
            this.pbLogout.TabIndex = 21;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pbLogout);
            this.Controls.Add(this.btnClosedTicketsReport);
            this.Controls.Add(this.btnAcceptTicket);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cboPriority);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnCloseTicket);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.rbtnActiveTickets);
            this.Controls.Add(this.rbtnNewTickets);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cboTickets);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEmployee";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cboTickets;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton rbtnNewTickets;
        private MaterialSkin.Controls.MaterialRadioButton rbtnActiveTickets;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtComment;
        private MaterialSkin.Controls.MaterialButton btnCloseTicket;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txtUser;
        private MaterialSkin.Controls.MaterialTextBox txtDate;
        private MaterialSkin.Controls.MaterialComboBox cboPriority;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescription;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton btnAcceptTicket;
        private MaterialSkin.Controls.MaterialButton btnClosedTicketsReport;
        private System.Windows.Forms.PictureBox pbLogout;
    }
}