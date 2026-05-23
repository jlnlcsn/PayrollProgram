namespace PayrollProgram
{
    partial class Form2
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
            taxTable = new TableLayoutPanel();
            SuspendLayout();
            // 
            // taxTable
            // 
            taxTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            taxTable.ColumnCount = 3;
            taxTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            taxTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            taxTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            taxTable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taxTable.Location = new Point(0, 0);
            taxTable.Name = "taxTable";
            taxTable.RowCount = 7;
            taxTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            taxTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            taxTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            taxTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            taxTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            taxTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            taxTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            taxTable.Size = new Size(429, 526);
            taxTable.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 526);
            Controls.Add(taxTable);
            Name = "Form2";
            Text = "Tax Table";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel taxTable;
    }
}