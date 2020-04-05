namespace FinanceSystem.forms
{
    partial class Home
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
            this.buttonOrderControl = new System.Windows.Forms.Button();
            this.buttonProductControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOrderControl
            // 
            this.buttonOrderControl.Location = new System.Drawing.Point(14, 14);
            this.buttonOrderControl.Name = "buttonOrderControl";
            this.buttonOrderControl.Size = new System.Drawing.Size(204, 392);
            this.buttonOrderControl.TabIndex = 0;
            this.buttonOrderControl.Text = "Order Control";
            this.buttonOrderControl.UseVisualStyleBackColor = true;
            this.buttonOrderControl.Click += new System.EventHandler(this.buttonOrderControl_Click);
            // 
            // buttonProductControl
            // 
            this.buttonProductControl.Location = new System.Drawing.Point(230, 14);
            this.buttonProductControl.Name = "buttonProductControl";
            this.buttonProductControl.Size = new System.Drawing.Size(204, 392);
            this.buttonProductControl.TabIndex = 2;
            this.buttonProductControl.Text = "Product Control";
            this.buttonProductControl.UseVisualStyleBackColor = true;
            this.buttonProductControl.Click += new System.EventHandler(this.buttonProductControl_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 417);
            this.Controls.Add(this.buttonProductControl);
            this.Controls.Add(this.buttonOrderControl);
            this.MaximumSize = new System.Drawing.Size(931, 917);
            this.MinimumSize = new System.Drawing.Size(464, 456);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonOrderControl;
        private System.Windows.Forms.Button buttonProductControl;
    }
}

