namespace CIP_HelpDesk {
    partial class FrmNewTicket {
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
            this.txtDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnSubmit = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pbArrowBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowBack)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.AnimateReadOnly = false;
            this.txtDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Depth = 0;
            this.txtDescription.HideSelection = true;
            this.txtDescription.Location = new System.Drawing.Point(91, 124);
            this.txtDescription.MaxLength = 255;
            this.txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ReadOnly = false;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(405, 134);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.TabStop = false;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.UseSystemPasswordChar = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.HighEmphasis = true;
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(220, 309);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubmit.Size = new System.Drawing.Size(148, 36);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Pošalji zahjtev";
            this.btnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSubmit.UseAccentColor = false;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(88, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Opis problema:";
            // 
            // pbArrowBack
            // 
            this.pbArrowBack.BackColor = System.Drawing.Color.Transparent;
            this.pbArrowBack.Image = global::CIP_HelpDesk.Properties.Resources.arrow_back;
            this.pbArrowBack.Location = new System.Drawing.Point(5, 21);
            this.pbArrowBack.Name = "pbArrowBack";
            this.pbArrowBack.Size = new System.Drawing.Size(27, 43);
            this.pbArrowBack.TabIndex = 4;
            this.pbArrowBack.TabStop = false;
            this.pbArrowBack.Click += new System.EventHandler(this.pbArrowBack_Click);
            // 
            // FrmNewTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pbArrowBack);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDescription);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmNewTicket";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                        Novi zahtjev za CIP";
            ((System.ComponentModel.ISupportInitialize)(this.pbArrowBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescription;
        private MaterialSkin.Controls.MaterialButton btnSubmit;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pbArrowBack;
    }
}