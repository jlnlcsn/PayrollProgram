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
            radioBtn_YesDeduct = new RadioButton();
            radioBtn_NoDeduct = new RadioButton();
            labelPagIBIG = new Label();
            labelPhilHealth = new Label();
            txtPagIBIG = new TextBox();
            txtPhilHealth = new TextBox();
            txtSSS = new TextBox();
            labelSSS = new Label();
            button1 = new Button();
            panel1 = new Panel();
            btnReset = new Button();
            btnTaxTable = new Button();
            labelNetIncome = new Label();
            labelTax = new Label();
            labelDeduct = new Label();
            labelGrossPay = new Label();
            label12 = new Label();
            panel2 = new Panel();
            labelOTHours = new Label();
            panel3 = new Panel();
            radioBtn_NoOT = new RadioButton();
            radioBtn_YesOT = new RadioButton();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            labelDeductions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDeductions.Location = new Point(377, 20);
            labelDeductions.Name = "labelDeductions";
            labelDeductions.Size = new Size(182, 21);
            labelDeductions.TabIndex = 12;
            labelDeductions.Text = "Government Deductions:";
            // 
            // radioBtn_YesDeduct
            // 
            radioBtn_YesDeduct.AutoSize = true;
            radioBtn_YesDeduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioBtn_YesDeduct.Location = new Point(565, 18);
            radioBtn_YesDeduct.Name = "radioBtn_YesDeduct";
            radioBtn_YesDeduct.Size = new Size(51, 25);
            radioBtn_YesDeduct.TabIndex = 13;
            radioBtn_YesDeduct.TabStop = true;
            radioBtn_YesDeduct.Text = "Yes";
            radioBtn_YesDeduct.UseVisualStyleBackColor = true;
            // 
            // radioBtn_NoDeduct
            // 
            radioBtn_NoDeduct.AutoSize = true;
            radioBtn_NoDeduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioBtn_NoDeduct.Location = new Point(622, 18);
            radioBtn_NoDeduct.Name = "radioBtn_NoDeduct";
            radioBtn_NoDeduct.Size = new Size(49, 25);
            radioBtn_NoDeduct.TabIndex = 14;
            radioBtn_NoDeduct.TabStop = true;
            radioBtn_NoDeduct.Text = "No";
            radioBtn_NoDeduct.UseVisualStyleBackColor = true;
            // 
            // labelPagIBIG
            // 
            labelPagIBIG.AutoSize = true;
            labelPagIBIG.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPagIBIG.Location = new Point(411, 52);
            labelPagIBIG.Name = "labelPagIBIG";
            labelPagIBIG.Size = new Size(72, 21);
            labelPagIBIG.TabIndex = 15;
            labelPagIBIG.Text = "Pag-IBIG:";
            // 
            // labelPhilHealth
            // 
            labelPhilHealth.AutoSize = true;
            labelPhilHealth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPhilHealth.Location = new Point(399, 92);
            labelPhilHealth.Name = "labelPhilHealth";
            labelPhilHealth.Size = new Size(84, 21);
            labelPhilHealth.TabIndex = 16;
            labelPhilHealth.Text = "PhilHealth:";
            // 
            // txtPagIBIG
            // 
            txtPagIBIG.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPagIBIG.Location = new Point(489, 49);
            txtPagIBIG.Name = "txtPagIBIG";
            txtPagIBIG.Size = new Size(214, 29);
            txtPagIBIG.TabIndex = 17;
            // 
            // txtPhilHealth
            // 
            txtPhilHealth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhilHealth.Location = new Point(489, 89);
            txtPhilHealth.Name = "txtPhilHealth";
            txtPhilHealth.Size = new Size(214, 29);
            txtPhilHealth.TabIndex = 18;
            // 
            // txtSSS
            // 
            txtSSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSSS.Location = new Point(489, 133);
            txtSSS.Name = "txtSSS";
            txtSSS.Size = new Size(214, 29);
            txtSSS.TabIndex = 19;
            // 
            // labelSSS
            // 
            labelSSS.AutoSize = true;
            labelSSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSSS.Location = new Point(443, 136);
            labelSSS.Name = "labelSSS";
            labelSSS.Size = new Size(40, 21);
            labelSSS.TabIndex = 20;
            labelSSS.Text = "SSS:";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(377, 177);
            button1.Name = "button1";
            button1.Size = new Size(326, 30);
            button1.TabIndex = 21;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnTaxTable);
            panel1.Controls.Add(labelNetIncome);
            panel1.Controls.Add(labelTax);
            panel1.Controls.Add(labelDeduct);
            panel1.Controls.Add(labelGrossPay);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(377, 213);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 202);
            panel1.TabIndex = 22;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.OrangeRed;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(12, 165);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 30);
            btnReset.TabIndex = 34;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnTaxTable
            // 
            btnTaxTable.BackColor = Color.Turquoise;
            btnTaxTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaxTable.Location = new Point(168, 165);
            btnTaxTable.Name = "btnTaxTable";
            btnTaxTable.Size = new Size(150, 30);
            btnTaxTable.TabIndex = 33;
            btnTaxTable.Text = "Tax Table";
            btnTaxTable.UseVisualStyleBackColor = false;
            btnTaxTable.Click += btnTaxTable_Click;
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
            label12.Location = new Point(77, 7);
            label12.Name = "label12";
            label12.Size = new Size(176, 21);
            label12.TabIndex = 27;
            label12.Text = "SALARY BREAKDOWN";
            // 
            // panel2
            // 
            panel2.Location = new Point(377, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 202);
            panel2.TabIndex = 23;
            // 
            // labelOTHours
            // 
            labelOTHours.AutoSize = true;
            labelOTHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOTHours.Location = new Point(41, 363);
            labelOTHours.Name = "labelOTHours";
            labelOTHours.Size = new Size(113, 21);
            labelOTHours.TabIndex = 26;
            labelOTHours.Text = "Hours Worked:";
            // 
            // panel3
            // 
            panel3.Controls.Add(radioBtn_NoOT);
            panel3.Controls.Add(radioBtn_YesOT);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(338, 397);
            panel3.TabIndex = 24;
            // 
            // radioBtn_NoOT
            // 
            radioBtn_NoOT.AutoSize = true;
            radioBtn_NoOT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioBtn_NoOT.Location = new Point(145, 275);
            radioBtn_NoOT.Name = "radioBtn_NoOT";
            radioBtn_NoOT.Size = new Size(49, 25);
            radioBtn_NoOT.TabIndex = 1;
            radioBtn_NoOT.TabStop = true;
            radioBtn_NoOT.Text = "No";
            radioBtn_NoOT.UseVisualStyleBackColor = true;
            // 
            // radioBtn_YesOT
            // 
            radioBtn_YesOT.AutoSize = true;
            radioBtn_YesOT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioBtn_YesOT.Location = new Point(93, 275);
            radioBtn_YesOT.Name = "radioBtn_YesOT";
            radioBtn_YesOT.Size = new Size(51, 25);
            radioBtn_YesOT.TabIndex = 0;
            radioBtn_YesOT.TabStop = true;
            radioBtn_YesOT.Text = "Yes";
            radioBtn_YesOT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 427);
            Controls.Add(labelOTHours);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(labelSSS);
            Controls.Add(txtSSS);
            Controls.Add(txtPhilHealth);
            Controls.Add(txtPagIBIG);
            Controls.Add(labelPhilHealth);
            Controls.Add(labelPagIBIG);
            Controls.Add(radioBtn_NoDeduct);
            Controls.Add(radioBtn_YesDeduct);
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
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Payroll Program";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private RadioButton radioBtn_YesDeduct;
        private RadioButton radioBtn_NoDeduct;
        private Label labelPagIBIG;
        private Label labelPhilHealth;
        private TextBox txtPagIBIG;
        private TextBox txtPhilHealth;
        private TextBox txtSSS;
        private Label labelSSS;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Label labelOTHours;
        private Panel panel3;
        private RadioButton radioBtn_YesOT;
        private RadioButton radioBtn_NoOT;
        private Label label12;
        private Label labelDeduct;
        private Label labelGrossPay;
        private Label labelTax;
        private Button btnTaxTable;
        private Label labelNetIncome;
        private Button btnReset;
    }
}
