namespace ReidBlackmonPA6
{
    partial class frmCWID
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
            this.lblCWID = new System.Windows.Forms.Label();
            this.txtCWID = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCWID
            // 
            this.lblCWID.AutoSize = true;
            this.lblCWID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCWID.Location = new System.Drawing.Point(12, 9);
            this.lblCWID.Name = "lblCWID";
            this.lblCWID.Size = new System.Drawing.Size(137, 20);
            this.lblCWID.TabIndex = 0;
            this.lblCWID.Text = "Enter Your CWID:";
            // 
            // txtCWID
            // 
            this.txtCWID.Location = new System.Drawing.Point(176, 6);
            this.txtCWID.Name = "txtCWID";
            this.txtCWID.Size = new System.Drawing.Size(126, 29);
            this.txtCWID.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(176, 41);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(52, 30);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(245, 41);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCWID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 91);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtCWID);
            this.Controls.Add(this.lblCWID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmCWID";
            this.Text = "CWID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCWID;
        private System.Windows.Forms.TextBox txtCWID;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnClose;
    }
}

