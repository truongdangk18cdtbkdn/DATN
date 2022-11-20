namespace Mitsu_SCADA_WINFORM_v6
{
    partial class formPopupWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVentilationOpen = new System.Windows.Forms.Button();
            this.btnVentilationClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turn On / Turn Off";
            // 
            // btnVentilationOpen
            // 
            this.btnVentilationOpen.BackColor = System.Drawing.Color.Green;
            this.btnVentilationOpen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentilationOpen.Location = new System.Drawing.Point(45, 78);
            this.btnVentilationOpen.Name = "btnVentilationOpen";
            this.btnVentilationOpen.Size = new System.Drawing.Size(127, 50);
            this.btnVentilationOpen.TabIndex = 2;
            this.btnVentilationOpen.Text = "ON";
            this.btnVentilationOpen.UseVisualStyleBackColor = false;
            this.btnVentilationOpen.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnVentilationClose
            // 
            this.btnVentilationClose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnVentilationClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentilationClose.Location = new System.Drawing.Point(45, 143);
            this.btnVentilationClose.Name = "btnVentilationClose";
            this.btnVentilationClose.Size = new System.Drawing.Size(127, 49);
            this.btnVentilationClose.TabIndex = 3;
            this.btnVentilationClose.Text = "OFF";
            this.btnVentilationClose.UseVisualStyleBackColor = false;
            this.btnVentilationClose.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // formPopupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 230);
            this.Controls.Add(this.btnVentilationClose);
            this.Controls.Add(this.btnVentilationOpen);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPopupWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventilation Fan Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVentilationOpen;
        private System.Windows.Forms.Button btnVentilationClose;
    }
}