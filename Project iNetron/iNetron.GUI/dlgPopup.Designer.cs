namespace iNetron.GUI
{
    partial class dlgPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgPopup));
            this.pnlBdy = new System.Windows.Forms.Panel();
            this.btnYes = new iNetron.GUI.Controls.iButton();
            this.btnNo = new iNetron.GUI.Controls.iButton();
            this.lblwarning = new System.Windows.Forms.Label();
            this.pbWarnBox = new System.Windows.Forms.PictureBox();
            this.pnlBdy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarnBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBdy
            // 
            this.pnlBdy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.pnlBdy.Controls.Add(this.btnYes);
            this.pnlBdy.Controls.Add(this.btnNo);
            this.pnlBdy.Controls.Add(this.lblwarning);
            this.pnlBdy.Controls.Add(this.pbWarnBox);
            this.pnlBdy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBdy.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBdy.ForeColor = System.Drawing.Color.White;
            this.pnlBdy.Location = new System.Drawing.Point(1, 1);
            this.pnlBdy.Name = "pnlBdy";
            this.pnlBdy.Size = new System.Drawing.Size(518, 248);
            this.pnlBdy.TabIndex = 0;
            this.pnlBdy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.this_MouseDown);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(234, 196);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(268, 27);
            this.btnYes.TabIndex = 8;
            this.btnYes.Text = "Take Responsibility and Continue Anyway";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(124, 196);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(104, 27);
            this.btnNo.TabIndex = 7;
            this.btnNo.Text = "Cancel";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarning.Location = new System.Drawing.Point(119, 40);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(349, 84);
            this.lblwarning.TabIndex = 1;
            this.lblwarning.Text = "Denial of Service attacks are illegal unless given\r\nexplicit permission from the " +
    "target administrator.\r\n\r\nYou must confirm your action.";
            // 
            // pbWarnBox
            // 
            this.pbWarnBox.Image = global::iNetron.GUI.Properties.Resources.warning_64;
            this.pbWarnBox.Location = new System.Drawing.Point(25, 40);
            this.pbWarnBox.Name = "pbWarnBox";
            this.pbWarnBox.Size = new System.Drawing.Size(76, 76);
            this.pbWarnBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbWarnBox.TabIndex = 0;
            this.pbWarnBox.TabStop = false;
            // 
            // dlgPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(520, 250);
            this.Controls.Add(this.pnlBdy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dlgPopup";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Action";
            this.pnlBdy.ResumeLayout(false);
            this.pnlBdy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarnBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBdy;
        private System.Windows.Forms.PictureBox pbWarnBox;
        private System.Windows.Forms.Label lblwarning;
        private Controls.iButton btnYes;
        private Controls.iButton btnNo;
    }
}