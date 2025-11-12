using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PayrollProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioBtn_YesOT.CheckedChanged += RadioBtnOT_CheckedChanged;
            radioBtn_NoOT.CheckedChanged += RadioBtnOT_CheckedChanged;

            radioBtn_YesDeduct.CheckedChanged += RadioBtnDeduct_CheckedChanged;
            radioBtn_NoDeduct.CheckedChanged += RadioBtnDeduct_CheckedChanged;

            // Ensure calculation runs only when Calculate button is clicked
            // Unsubscribe first (safe no-op) then subscribe once to avoid double subscription
            button1.Click -= button1_Click_1;
            button1.Click += button1_Click_1;

            // Make Employee ID accept digits only at typing time
            txtID.KeyPress -= TxtID_KeyPress;
            txtID.KeyPress += TxtID_KeyPress;

            // Defaults: OT and deduction controls disabled
            SetOtControlsEnabled(false);
            radioBtn_NoOT.Checked = true;

            SetDeductionControlsEnabled(false);
            radioBtn_NoDeduct.Checked = true;
        }

        // Prevent non-digit characters in Employee ID textbox
        private void TxtID_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Allow control keys (backspace, etc.) and digits only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ignore the key
            }
        }

        private void RadioBtnOT_CheckedChanged(object? sender, EventArgs e)
        {
            SetOtControlsEnabled(radioBtn_YesOT.Checked);
        }

        private void RadioBtnDeduct_CheckedChanged(object? sender, EventArgs e)
        {
            SetDeductionControlsEnabled(radioBtn_YesDeduct.Checked);
        }

        private void SetOtControlsEnabled(bool enabled)
        {
            txtOTRate.Enabled = enabled;
            txtOTHours.Enabled = enabled;

            if (!enabled)
            {
                // Keep "0" when disabling so code that reads values safely finds a number.
                txtOTRate.Text = "0";
                txtOTHours.Text = "0";
            }
        }

        private void SetDeductionControlsEnabled(bool enabled)
        {
            txtPagIBIG.Enabled = enabled;
            txtPhilHealth.Enabled = enabled;
            txtSSS.Enabled = enabled;

            if (!enabled)
            {
                // Keep "0" when disabling so code that reads values safely finds a number.
                txtPagIBIG.Text = "0";
                txtPhilHealth.Text = "0";
                txtSSS.Text = "0";
            }
        }

        private void RecalculateAndDisplay()
        {
            // Read inputs
            decimal rate = ToDecimal(txtRate.Text);
            decimal hoursWorked = ToDecimal(txtHours.Text);

            // OT inputs (use enabled state to decide whether OT applies)
            decimal otRate = txtOTRate.Enabled ? ToDecimal(txtOTRate.Text) : 0;
            decimal otHours = txtOTHours.Enabled ? ToDecimal(txtOTHours.Text) : 0;

            // Determine normal hours and OT hours
            decimal normalHours;
            decimal actualOtHours;

            if (radioBtn_YesOT.Checked)
            {
                actualOtHours = otHours;
                normalHours = hoursWorked - actualOtHours;
                if (normalHours < 0) normalHours = 0;
            }
            else
            {
                normalHours = hoursWorked;
                actualOtHours = 0;
            }

            // Pay calculations
            decimal normalPay = normalHours * rate;
            decimal otPay = actualOtHours * otRate;
            decimal grossPay = normalPay + otPay;

            // Deductions
            decimal pagibig = txtPagIBIG.Enabled ? ToDecimal(txtPagIBIG.Text) : 0;
            decimal philhealth = txtPhilHealth.Enabled ? ToDecimal(txtPhilHealth.Text) : 0;
            decimal sss = txtSSS.Enabled ? ToDecimal(txtSSS.Text) : 0;
            decimal totalDeductions = pagibig + philhealth + sss;

            // Taxable income and tax
            decimal taxableIncome = grossPay - totalDeductions;
            if (taxableIncome < 0) taxableIncome = 0;

            decimal tax = CalculateTax(taxableIncome);
            decimal netIncome = grossPay - totalDeductions - tax;

            // Display results (labels are not cleared by the "clear inputs" requirement)
            labelGrossPay.Text = "Gross Pay: ₱" + grossPay.ToString("F2");
            labelDeduct.Text = "Deductions: ₱" + totalDeductions.ToString("F2");
            labelTax.Text = "Tax: ₱" + tax.ToString("F2");
            labelNetIncome.Text = "Net Income: ₱" + netIncome.ToString("F2");
        }

        // Converts string input to decimal safely
        private decimal ToDecimal(string text)
        {
            if (decimal.TryParse(text, out decimal value))
                return value;
            return 0;
        }

        private decimal CalculateTax(decimal income)
        {
            if (income <= 20833m)
            {
                return 0m;
            }
            else if (income > 20833m && income <= 33333m)
            {
                return (income - 20833m) * 0.15m;
            }
            else if (income > 33333m && income <= 66666m)
            {
                return 1875m + (income - 33333m) * 0.20m;
            }
            else if (income > 66666m && income <= 166666m)
            {
                return 8541.67m + (income - 66666m) * 0.25m;
            }
            else if (income > 166666m && income <= 666666m)
            {
                return 33541.67m + (income - 166666m) * 0.30m;
            }
            else
            {
                return 183541.67m + (income - 666666m) * 0.35m;
            }
        }

        // Validate all inputs before calculating. Shows MessageBox and focuses the offending control.
        private bool ValidateInputs()
        {
            // ID required and digits only
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter Employee ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return false;
            }

            if (!txtID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Employee ID must contain digits only.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return false;
            }

            // Name required
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter Employee Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // Rate and hours required and numeric
            if (!decimal.TryParse(txtRate.Text, out decimal rate) || rate <= 0)
            {
                MessageBox.Show("Please enter a valid hourly rate (greater than 0).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRate.Focus();
                return false;
            }

            if (!decimal.TryParse(txtHours.Text, out decimal hours) || hours < 0)
            {
                MessageBox.Show("Please enter valid hours worked (0 or greater).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHours.Focus();
                return false;
            }

            // If OT is Yes, OT rate/hours must be valid
            if (radioBtn_YesOT.Checked)
            {
                if (!decimal.TryParse(txtOTRate.Text, out decimal otr) || otr < 0)
                {
                    MessageBox.Show("Please enter a valid OT rate (greater than 0).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOTRate.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtOTHours.Text, out decimal oth) || oth <= 0)
                {
                    MessageBox.Show("Please enter valid OT hours (greater than 0).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOTHours.Focus();
                    return false;
                }

                // OT hours should not exceed total hours worked (optional rule)
                if (oth > hours)
                {
                    MessageBox.Show("OT hours cannot exceed total hours worked.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOTHours.Focus();
                    return false;
                }
            }

            // If deductions enabled, ensure values are numeric and not negative,
            // and require at least one deduction > 0.
            if (radioBtn_YesDeduct.Checked)
            {
                if (!decimal.TryParse(txtPagIBIG.Text, out decimal pagibig) || pagibig < 0)
                {
                    MessageBox.Show("Please enter a valid Pag-IBIG amount (greater than 0).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPagIBIG.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtPhilHealth.Text, out decimal philhealth) || philhealth < 0)
                {
                    MessageBox.Show("Please enter a valid PhilHealth amount (greater than 0).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhilHealth.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtSSS.Text, out decimal sss) || sss < 0)
                {
                    MessageBox.Show("Please enter a valid SSS amount (greater than 0).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSSS.Focus();
                    return false;
                }

                int filledCount = 0;
                if (pagibig > 0) filledCount++;
                if (philhealth > 0) filledCount++;
                if (sss > 0) filledCount++;

                if (filledCount < 1)
                {
                    MessageBox.Show("Enter at least one deduction (Pag-IBIG, PhilHealth or SSS) with an amount greater than 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPagIBIG.Focus();
                    return false;
                }
            }

            return true;
        }

        // Clear all input controls (but keep the result labels intact)
        private void ClearInputs()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtRate.Text = "";
            txtHours.Text = "";

            // Clear OT and deduction textboxes explicitly and reset radios/defaults
            txtOTRate.Text = "";
            txtOTHours.Text = "";
            txtPagIBIG.Text = "";
            txtPhilHealth.Text = "";
            txtSSS.Text = "";

            radioBtn_NoOT.Checked = true;
            SetOtControlsEnabled(false);

            radioBtn_NoDeduct.Checked = true;
            SetDeductionControlsEnabled(false);

            labelGrossPay.Text = "Gross Pay:";
            labelDeduct.Text = "Deductions:";
            labelTax.Text = "Tax:";
            labelNetIncome.Text = "Net Income:";

            // Put cursor back to the first field
            txtID.Focus();
        }

        // Calculate button handler: validate, calculate + display, then clear inputs
        private void button1_Click_1(object? sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            RecalculateAndDisplay();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnTaxTable_Click(object sender, EventArgs e)
        {
            using var f = new Form2();
            f.ShowDialog(this);
        }
    }
}
