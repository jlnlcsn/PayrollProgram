namespace PayrollProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelID = new Label();
            labelName = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            labelRate = new Label();
            txtRate = new TextBox();
            txtHours = new TextBox();
            labelHours = new Label();
            labelOT = new Label();
            txtOTRate = new TextBox();
            labelOTRate = new Label();
            txtOTHours = new TextBox();
            labelDeductions = new Label();
            checkBoxPagIBIG = new CheckBox();
            checkBoxPhilHealth = new CheckBox();
            checkBoxSSS = new CheckBox();
            labelPagIBIG = new Label();
            labelPhilHealth = new Label();
            txtPagIBIG = new TextBox();
            txtPhilHealth = new TextBox();
            txtSSS = new TextBox();
            labelSSS = new Label();
            button1 = new Button();
            btnReset = new Button();
            panel1 = new Panel();
            btnTaxTable = new Button();
            btnBreakdown = new Button();
            labelNetIncome = new Label();
            labelTax = new Label();
            labelDeduct = new Label();
            labelGrossPay = new Label();
            label12 = new Label();
            dgvBreakdown = new DataGridView();
            labelOTHours = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBreakdown).BeginInit();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelID.Location = new Point(21, 22);
            labelID.Name = "labelID";
            labelID.Size = new Size(100, 21);
            labelID.TabIndex = 0;
            labelID.Text = "Employee ID:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(21, 88);
            labelName.Name = "labelName";
            labelName.Size = new Size(127, 21);
            labelName.TabIndex = 1;
            labelName.Text = "Employee Name:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(21, 46);
            txtID.Name = "txtID";
            txtID.Size = new Size(326, 29);
            txtID.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(21, 112);
            txtName.Name = "txtName";
            txtName.Size = new Size(326, 29);
            txtName.TabIndex = 3;
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRate.Location = new Point(21, 153);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(110, 21);
            labelRate.TabIndex = 4;
            labelRate.Text = "Rate per Hour:";
            // 
            // txtRate
            // 
            txtRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRate.Location = new Point(21, 177);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(326, 29);
            txtRate.TabIndex = 5;
            // 
            // txtHours
            // 
            txtHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHours.Location = new Point(21, 244);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(326, 29);
            txtHours.TabIndex = 6;
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHours.Location = new Point(21, 220);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(220, 21);
            labelHours.TabIndex = 7;
            labelHours.Text = "Hours Worked (w/o overtime):";
            // 
            // labelOT
            // 
            labelOT.AutoSize = true;
            labelOT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOT.Location = new Point(21, 289);
            labelOT.Name = "labelOT";
            labelOT.Size = new Size(78, 21);
            labelOT.TabIndex = 8;
            labelOT.Text = "Overtime:";
            // 
            // txtOTRate
            // 
            txtOTRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOTRate.Location = new Point(157, 320);
            txtOTRate.Name = "txtOTRate";
            txtOTRate.Size = new Size(190, 29);
            txtOTRate.TabIndex = 9;
            // 
            // labelOTRate
            // 
            labelOTRate.AutoSize = true;
            labelOTRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOTRate.Location = new Point(41, 323);
            labelOTRate.Name = "labelOTRate";
            labelOTRate.Size = new Size(110, 21);
            labelOTRate.TabIndex = 10;
            labelOTRate.Text = "Rate per Hour:";
            // 
            // txtOTHours
            // 
            txtOTHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOTHours.Location = new Point(157, 360);
            txtOTHours.Name = "txtOTHours";
            txtOTHours.Size = new Size(190, 29);
            txtOTHours.TabIndex = 11;
            // 
            // labelDeductions
            // 
            labelDeductions.AutoSize = true;
            labelDeductions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDeductions.ForeColor = Color.DarkSlateGray;
            labelDeductions.Location = new Point(377, 20);
            labelDeductions.Name = "labelDeductions";
            labelDeductions.Size = new Size(262, 21);
            labelDeductions.TabIndex = 12;
            labelDeductions.Text = "Government Deductions (auto):";
            // 
            // checkBoxPagIBIG
            // 
            checkBoxPagIBIG.AutoSize = true;
            checkBoxPagIBIG.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxPagIBIG.Location = new Point(377, 52);
            checkBoxPagIBIG.Name = "checkBoxPagIBIG";
            checkBoxPagIBIG.Size = new Size(94, 24);
            checkBoxPagIBIG.TabIndex = 13;
            checkBoxPagIBIG.Text = "Pag-IBIG";
            checkBoxPagIBIG.UseVisualStyleBackColor = true;
            // 
            // checkBoxPhilHealth
            // 
            checkBoxPhilHealth.AutoSize = true;
            checkBoxPhilHealth.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxPhilHealth.Location = new Point(377, 92);
            checkBoxPhilHealth.Name = "checkBoxPhilHealth";
            checkBoxPhilHealth.Size = new Size(113, 24);
            checkBoxPhilHealth.TabIndex = 14;
            checkBoxPhilHealth.Text = "PhilHealth";
            checkBoxPhilHealth.UseVisualStyleBackColor = true;
            // 
            // checkBoxSSS
            // 
            checkBoxSSS.AutoSize = true;
            checkBoxSSS.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxSSS.Location = new Point(377, 132);
            checkBoxSSS.Name = "checkBoxSSS";
            checkBoxSSS.Size = new Size(55, 24);
            checkBoxSSS.TabIndex = 15;
            checkBoxSSS.Text = "SSS";
            checkBoxSSS.UseVisualStyleBackColor = true;
            // 
            // labelPagIBIG
            // 
            labelPagIBIG.AutoSize = true;
            labelPagIBIG.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPagIBIG.Location = new Point(487, 52);
            labelPagIBIG.Name = "labelPagIBIG";
            labelPagIBIG.Size = new Size(72, 21);
            labelPagIBIG.TabIndex = 16;
            labelPagIBIG.Text = "";
            // 
            // txtPagIBIG
            // 
            txtPagIBIG.BackColor = Color.WhiteSmoke;
            txtPagIBIG.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPagIBIG.Location = new Point(565, 49);
            txtPagIBIG.Name = "txtPagIBIG";
            txtPagIBIG.ReadOnly = true;
            txtPagIBIG.Size = new Size(140, 29);
            txtPagIBIG.TabIndex = 17;
            txtPagIBIG.Text = "0";
            txtPagIBIG.TextAlign = HorizontalAlignment.Right;
            // 
            // labelPhilHealth
            // 
            labelPhilHealth.AutoSize = true;
            labelPhilHealth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPhilHealth.Location = new Point(475, 92);
            labelPhilHealth.Name = "labelPhilHealth";
            labelPhilHealth.Size = new Size(84, 21);
            labelPhilHealth.TabIndex = 18;
            labelPhilHealth.Text = "";
            // 
            // txtPhilHealth
            // 
            txtPhilHealth.BackColor = Color.WhiteSmoke;
            txtPhilHealth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhilHealth.Location = new Point(565, 89);
            txtPhilHealth.Name = "txtPhilHealth";
            txtPhilHealth.ReadOnly = true;
            txtPhilHealth.Size = new Size(140, 29);
            txtPhilHealth.TabIndex = 19;
            txtPhilHealth.Text = "0";
            txtPhilHealth.TextAlign = HorizontalAlignment.Right;
            // 
            // labelSSS
            // 
            labelSSS.AutoSize = true;
            labelSSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSSS.Location = new Point(526, 136);
            labelSSS.Name = "labelSSS";
            labelSSS.Size = new Size(40, 21);
            labelSSS.TabIndex = 20;
            labelSSS.Text = "";
            // 
            // txtSSS
            // 
            txtSSS.BackColor = Color.WhiteSmoke;
            txtSSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSSS.Location = new Point(565, 133);
            txtSSS.Name = "txtSSS";
            txtSSS.ReadOnly = true;
            txtSSS.Size = new Size(140, 29);
            txtSSS.TabIndex = 21;
            txtSSS.Text = "0";
            txtSSS.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(549, 177);
            button1.Name = "button1";
            button1.Size = new Size(160, 30);
            button1.TabIndex = 22;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.OrangeRed;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(377, 177);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(160, 30);
            btnReset.TabIndex = 23;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnTaxTable);
            panel1.Controls.Add(btnBreakdown);
            panel1.Controls.Add(labelNetIncome);
            panel1.Controls.Add(labelTax);
            panel1.Controls.Add(labelDeduct);
            panel1.Controls.Add(labelGrossPay);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(377, 213);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 202);
            panel1.TabIndex = 24;
            // 
            // btnTaxTable
            // 
            btnTaxTable.BackColor = Color.Turquoise;
            btnTaxTable.FlatStyle = FlatStyle.Flat;
            btnTaxTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaxTable.ForeColor = Color.White;
            btnTaxTable.Location = new Point(12, 165);
            btnTaxTable.Name = "btnTaxTable";
            btnTaxTable.Size = new Size(150, 30);
            btnTaxTable.TabIndex = 33;
            btnTaxTable.Text = "Tax Table";
            btnTaxTable.UseVisualStyleBackColor = false;
            btnTaxTable.Click += btnTaxTable_Click;
            // 
            // btnBreakdown
            // 
            btnBreakdown.BackColor = Color.MediumSlateBlue;
            btnBreakdown.FlatStyle = FlatStyle.Flat;
            btnBreakdown.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBreakdown.ForeColor = Color.White;
            btnBreakdown.Location = new Point(168, 165);
            btnBreakdown.Name = "btnBreakdown";
            btnBreakdown.Size = new Size(150, 30);
            btnBreakdown.TabIndex = 34;
            btnBreakdown.Text = "Breakdown";
            btnBreakdown.UseVisualStyleBackColor = false;
            btnBreakdown.Click += btnBreakdown_Click;
            // 
            // labelNetIncome
            // 
            labelNetIncome.AutoSize = true;
            labelNetIncome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNetIncome.Location = new Point(12, 134);
            labelNetIncome.Name = "labelNetIncome";
            labelNetIncome.Size = new Size(93, 21);
            labelNetIncome.TabIndex = 32;
            labelNetIncome.Text = "Net Income:";
            // 
            // labelTax
            // 
            labelTax.AutoSize = true;
            labelTax.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTax.Location = new Point(33, 106);
            labelTax.Name = "labelTax";
            labelTax.Size = new Size(34, 21);
            labelTax.TabIndex = 31;
            labelTax.Text = "Tax:";
            // 
            // labelDeduct
            // 
            labelDeduct.AutoSize = true;
            labelDeduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDeduct.Location = new Point(33, 75);
            labelDeduct.Name = "labelDeduct";
            labelDeduct.Size = new Size(91, 21);
            labelDeduct.TabIndex = 30;
            labelDeduct.Text = "Deductions:";
            // 
            // labelGrossPay
            // 
            labelGrossPay.AutoSize = true;
            labelGrossPay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGrossPay.Location = new Point(12, 45);
            labelGrossPay.Name = "labelGrossPay";
            labelGrossPay.Size = new Size(81, 21);
            labelGrossPay.TabIndex = 29;
            labelGrossPay.Text = "Gross Pay:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(60, 7);
            label12.Name = "label12";
            label12.Size = new Size(206, 21);
            label12.TabIndex = 27;
            label12.Text = "SALARY BREAKDOWN";
            // 
            // dgvBreakdown
            // 
            dgvBreakdown.BackgroundColor = Color.WhiteSmoke;
            dgvBreakdown.BorderStyle = BorderStyle.FixedSingle;
            dgvBreakdown.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBreakdown.Location = new Point(12, 430);
            dgvBreakdown.Name = "dgvBreakdown";
            dgvBreakdown.ReadOnly = true;
            dgvBreakdown.RowHeadersVisible = false;
            dgvBreakdown.RowTemplate.Height = 30;
            dgvBreakdown.Size = new Size(701, 130);
            dgvBreakdown.TabIndex = 25;
            dgvBreakdown.AllowUserToAddRows = false;
            dgvBreakdown.AllowUserToDeleteRows = false;
            dgvBreakdown.AllowUserToResizeRows = false;
            dgvBreakdown.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBreakdown.ColumnCount = 2;
            dgvBreakdown.Columns[0].Name = "Item";
            dgvBreakdown.Columns[0].Width = 420;
            dgvBreakdown.Columns[1].Name = "Amount";
            dgvBreakdown.Columns[1].Width = 260;
            dgvBreakdown.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // 
            // labelOTHours
            // 
            labelOTHours.AutoSize = true;
            labelOTHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOTHours.Location = new Point(41, 363);
            labelOTHours.Name = "labelOTHours";
            labelOTHours.Size = new Size(91, 21);
            labelOTHours.TabIndex = 26;
            labelOTHours.Text = "OT Hours:";
            // (Overtime radio buttons removed; OT fields are directly editable)
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(728, 575);
            Controls.Add(dgvBreakdown);
            Controls.Add(labelOTHours);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnReset);
            Controls.Add(labelSSS);
            Controls.Add(txtSSS);
            Controls.Add(txtPhilHealth);
            Controls.Add(txtPagIBIG);
            Controls.Add(labelPhilHealth);
            Controls.Add(labelPagIBIG);
            Controls.Add(checkBoxSSS);
            Controls.Add(checkBoxPhilHealth);
            Controls.Add(checkBoxPagIBIG);
            Controls.Add(labelDeductions);
            Controls.Add(txtOTHours);
            Controls.Add(labelOTRate);
            Controls.Add(txtOTRate);
            Controls.Add(labelOT);
            Controls.Add(labelHours);
            Controls.Add(txtHours);
            Controls.Add(txtRate);
            Controls.Add(labelRate);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(labelName);
            Controls.Add(labelID);
            Name = "Form1";
            Text = "Payroll Program";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBreakdown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelID;
        private Label labelName;
        private TextBox txtID;
        private TextBox txtName;
        private Label labelRate;
        private TextBox txtRate;
        private TextBox txtHours;
        private Label labelHours;
        private Label labelOT;
        private TextBox txtOTRate;
        private Label labelOTRate;
        private TextBox txtOTHours;
        private Label labelDeductions;
        private CheckBox checkBoxPagIBIG;
        private CheckBox checkBoxPhilHealth;
        private CheckBox checkBoxSSS;
        private Label labelPagIBIG;
        private Label labelPhilHealth;
        private TextBox txtPagIBIG;
        private TextBox txtPhilHealth;
        private TextBox txtSSS;
        private Label labelSSS;
        private Button button1;
        private Button btnReset;
        private Panel panel1;
        private Label labelOTHours;
        
        private Label label12;
        private Label labelDeduct;
        private Label labelGrossPay;
        private Label labelTax;
        private Button btnTaxTable;
        private Button btnBreakdown;
        private Label labelNetIncome;
        private DataGridView dgvBreakdown;
    }
}
