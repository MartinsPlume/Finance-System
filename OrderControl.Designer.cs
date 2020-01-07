namespace FinanceSystem
{
    partial class OrderControl
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonInvoice = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.ColumnMarkOrder = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarkOrder});
            this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(1184, 709);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonRefresh);
            this.panelTop.Controls.Add(this.buttonInvoice);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1184, 52);
            this.panelTop.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dataGridViewOrders);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 52);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1184, 709);
            this.panelMain.TabIndex = 2;
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInvoice.Location = new System.Drawing.Point(12, 12);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Size = new System.Drawing.Size(121, 34);
            this.buttonInvoice.TabIndex = 0;
            this.buttonInvoice.Text = "Invoice";
            this.buttonInvoice.UseVisualStyleBackColor = true;
            this.buttonInvoice.Click += new System.EventHandler(this.buttonInvoice_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(139, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(121, 34);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // ColumnMarkOrder
            // 
            this.ColumnMarkOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnMarkOrder.HeaderText = "Mark Order";
            this.ColumnMarkOrder.Name = "ColumnMarkOrder";
            this.ColumnMarkOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnMarkOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnMarkOrder.Width = 85;
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.MaximumSize = new System.Drawing.Size(1200, 1500);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "OrderControl";
            this.Text = "OrderControl";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonInvoice;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnMarkOrder;
    }
}