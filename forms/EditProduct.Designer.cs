namespace FinanceSystem.forms
{
    partial class EditProduct
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.checkBoxConfirmChanges = new System.Windows.Forms.CheckBox();
            this.labelStockReserved = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelProductRetail = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.labelProductCode = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.numericUpDownReserved = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRetail = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownReserved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownRetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1148, 48);
            this.panelTop.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.buttonSaveChanges);
            this.mainPanel.Controls.Add(this.checkBoxConfirmChanges);
            this.mainPanel.Controls.Add(this.labelStockReserved);
            this.mainPanel.Controls.Add(this.labelWeight);
            this.mainPanel.Controls.Add(this.labelProductRetail);
            this.mainPanel.Controls.Add(this.labelProductPrice);
            this.mainPanel.Controls.Add(this.labelProductCode);
            this.mainPanel.Controls.Add(this.labelProductName);
            this.mainPanel.Controls.Add(this.numericUpDownReserved);
            this.mainPanel.Controls.Add(this.numericUpDownStock);
            this.mainPanel.Controls.Add(this.numericUpDownRetail);
            this.mainPanel.Controls.Add(this.numericUpDownPrice);
            this.mainPanel.Controls.Add(this.textBoxProductCode);
            this.mainPanel.Controls.Add(this.textBoxProductName);
            this.mainPanel.Controls.Add(this.numericUpDownWeight);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 48);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1148, 195);
            this.mainPanel.TabIndex = 1;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(854, 132);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(183, 38);
            this.buttonSaveChanges.TabIndex = 14;
            this.buttonSaveChanges.Text = "Save";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Visible = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_ClickAsync);
            // 
            // checkBoxConfirmChanges
            // 
            this.checkBoxConfirmChanges.AutoSize = true;
            this.checkBoxConfirmChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxConfirmChanges.Location = new System.Drawing.Point(581, 132);
            this.checkBoxConfirmChanges.Name = "checkBoxConfirmChanges";
            this.checkBoxConfirmChanges.Size = new System.Drawing.Size(228, 33);
            this.checkBoxConfirmChanges.TabIndex = 13;
            this.checkBoxConfirmChanges.Text = "Confirm changes";
            this.checkBoxConfirmChanges.UseVisualStyleBackColor = true;
            this.checkBoxConfirmChanges.CheckedChanged +=
                new System.EventHandler(this.checkBoxConfirmChanges_CheckedChanged);
            // 
            // labelStockReserved
            // 
            this.labelStockReserved.AutoSize = true;
            this.labelStockReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelStockReserved.Location = new System.Drawing.Point(808, 10);
            this.labelStockReserved.Name = "labelStockReserved";
            this.labelStockReserved.Size = new System.Drawing.Size(196, 29);
            this.labelStockReserved.TabIndex = 12;
            this.labelStockReserved.Text = "Stock / Reserved";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelWeight.Location = new System.Drawing.Point(699, 10);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(88, 29);
            this.labelWeight.TabIndex = 11;
            this.labelWeight.Text = "Weight";
            // 
            // labelProductRetail
            // 
            this.labelProductRetail.AutoSize = true;
            this.labelProductRetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelProductRetail.Location = new System.Drawing.Point(619, 10);
            this.labelProductRetail.Name = "labelProductRetail";
            this.labelProductRetail.Size = new System.Drawing.Size(55, 29);
            this.labelProductRetail.TabIndex = 10;
            this.labelProductRetail.Text = "Sell";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelProductPrice.Location = new System.Drawing.Point(525, 10);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(53, 29);
            this.labelProductPrice.TabIndex = 9;
            this.labelProductPrice.Text = "Buy";
            // 
            // labelProductCode
            // 
            this.labelProductCode.AutoSize = true;
            this.labelProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelProductCode.Location = new System.Drawing.Point(386, 10);
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(72, 29);
            this.labelProductCode.TabIndex = 8;
            this.labelProductCode.Text = "Code";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelProductName.Location = new System.Drawing.Point(104, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(167, 29);
            this.labelProductName.TabIndex = 7;
            this.labelProductName.Text = "Product Name";
            // 
            // numericUpDownReserved
            // 
            this.numericUpDownReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.numericUpDownReserved.Location = new System.Drawing.Point(938, 54);
            this.numericUpDownReserved.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            this.numericUpDownReserved.Name = "numericUpDownReserved";
            this.numericUpDownReserved.Size = new System.Drawing.Size(99, 35);
            this.numericUpDownReserved.TabIndex = 6;
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.numericUpDownStock.Location = new System.Drawing.Point(814, 54);
            this.numericUpDownStock.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(99, 35);
            this.numericUpDownStock.TabIndex = 5;
            // 
            // numericUpDownRetail
            // 
            this.numericUpDownRetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.numericUpDownRetail.Location = new System.Drawing.Point(610, 54);
            this.numericUpDownRetail.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.numericUpDownRetail.MaximumSize = new System.Drawing.Size(87, 0);
            this.numericUpDownRetail.MinimumSize = new System.Drawing.Size(87, 0);
            this.numericUpDownRetail.Name = "numericUpDownRetail";
            this.numericUpDownRetail.Size = new System.Drawing.Size(87, 35);
            this.numericUpDownRetail.TabIndex = 4;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(516, 54);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.numericUpDownPrice.MaximumSize = new System.Drawing.Size(87, 0);
            this.numericUpDownPrice.MinimumSize = new System.Drawing.Size(87, 0);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(87, 35);
            this.numericUpDownPrice.TabIndex = 3;
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxProductCode.Location = new System.Drawing.Point(363, 54);
            this.textBoxProductCode.MaximumSize = new System.Drawing.Size(145, 35);
            this.textBoxProductCode.MinimumSize = new System.Drawing.Size(145, 35);
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.Size = new System.Drawing.Size(145, 35);
            this.textBoxProductCode.TabIndex = 2;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxProductName.Location = new System.Drawing.Point(64, 54);
            this.textBoxProductName.MaximumSize = new System.Drawing.Size(291, 35);
            this.textBoxProductName.MinimumSize = new System.Drawing.Size(291, 35);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(291, 35);
            this.textBoxProductName.TabIndex = 1;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.numericUpDownWeight.Location = new System.Drawing.Point(715, 54);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(61, 35);
            this.numericUpDownWeight.TabIndex = 0;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 243);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelTop);
            this.MaximumSize = new System.Drawing.Size(1164, 282);
            this.MinimumSize = new System.Drawing.Size(1164, 282);
            this.Name = "EditProduct";
            this.Text = "Edit Product";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownReserved)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownRetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownWeight)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label labelStockReserved;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelProductRetail;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label labelProductCode;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.NumericUpDown numericUpDownReserved;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.NumericUpDown numericUpDownRetail;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.CheckBox checkBoxConfirmChanges;
    }
}