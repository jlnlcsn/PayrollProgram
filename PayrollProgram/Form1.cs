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

            // Overtime fields are always editable now; no radio buttons.

            checkBoxPagIBIG.CheckedChanged += DeductionCheckBox_CheckedChanged;
            checkBoxPhilHealth.CheckedChanged += DeductionCheckBox_CheckedChanged;
            checkBoxSSS.CheckedChanged += DeductionCheckBox_CheckedChanged;

            // Ensure calculation runs only when Calculate button is clicked
            // Unsubscribe first (safe no-op) then subscribe once to avoid double subscription
            button1.Click -= button1_Click_1;
            button1.Click += button1_Click_1;

            // Make Employee ID accept digits only at typing time
            txtID.KeyPress -= TxtID_KeyPress;
            txtID.KeyPress += TxtID_KeyPress;

            txtPagIBIG.Text = "0";
            txtPhilHealth.Text = "0";
            txtSSS.Text = "0";

            // Defaults: OT controls enabled for direct entry
            SetOtControlsEnabled(true);
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

        // Radio buttons removed; OT is taken from the OT textboxes directly.

        private void DeductionCheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            UpdateAutoDeductions();
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

            // Use entered OT hours directly; if none entered, treated as 0.
            actualOtHours = otHours;
            normalHours = hoursWorked - actualOtHours;
            if (normalHours < 0) normalHours = 0;

            UpdateAutoDeductions();

            // Pay calculations
            decimal normalPay = normalHours * rate;
            decimal otPay = actualOtHours * otRate;
            decimal grossPay = normalPay + otPay;

            // Deductions
            decimal pagibig = ToDecimal(txtPagIBIG.Text);
            decimal philhealth = ToDecimal(txtPhilHealth.Text);
            decimal sss = ToDecimal(txtSSS.Text);
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

        private void UpdateAutoDeductions()
        {
            decimal basicSalary = ToDecimal(txtRate.Text) * ToDecimal(txtHours.Text);

            txtPagIBIG.Text = checkBoxPagIBIG.Checked ? CalculatePagIBIG(basicSalary).ToString("F2") : "0";
            txtPhilHealth.Text = checkBoxPhilHealth.Checked ? CalculatePhilHealth(basicSalary).ToString("F2") : "0";
            txtSSS.Text = checkBoxSSS.Checked ? CalculateSSS(basicSalary).ToString("F2") : "0";
        }

        private decimal CalculatePagIBIG(decimal salary)
        {
            if (salary <= 1500m)
                return salary * 0.01m;
            if (salary < 10000m)
                return salary * 0.02m;
            return 200m;
        }

        private decimal CalculatePhilHealth(decimal salary)
        {
            if (salary <= 10000m)
                return 250m;
            if (salary < 100000m)
                return salary * 0.025m;
            return 2500m;
        }

        private decimal CalculateSSS(decimal salary)
        {
            if (salary < 5250m)
                return 250m;
            if (salary >= 35000m)
                return 1750m;

            if (salary <= 20000m)
            {
                return 250m + (salary - 5250m) * (750m / 14750m);
            }

            return 1000m + (salary - 20000m) * (750m / 15000m);
        }

        private void FillBreakdownTable(decimal rate, decimal hoursWorked, decimal otRate, decimal otHours, decimal grossPay, decimal tax, decimal pagibig, decimal philhealth, decimal sss, decimal totalDeductions, decimal netIncome)
        {
            dgvBreakdown.Rows.Clear();
            dgvBreakdown.Rows.Add("Salary", "₱" + (rate * hoursWorked).ToString("N2"));
            dgvBreakdown.Rows.Add("Overtime Pay", "₱" + (otRate * otHours).ToString("N2"));
            dgvBreakdown.Rows.Add("Gross Salary", "₱" + grossPay.ToString("N2"));
            dgvBreakdown.Rows.Add("Tax Deduction", "₱" + tax.ToString("N2"));
            dgvBreakdown.Rows.Add("Pag-IBIG", "₱" + pagibig.ToString("N2"));
            dgvBreakdown.Rows.Add("PhilHealth", "₱" + philhealth.ToString("N2"));
            dgvBreakdown.Rows.Add("SSS", "₱" + sss.ToString("N2"));
            dgvBreakdown.Rows.Add("Total Deductions", "₱" + totalDeductions.ToString("N2"));
            dgvBreakdown.Rows.Add("Net Income", "₱" + netIncome.ToString("N2"));
        }

        private void btnBreakdown_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            RecalculateAndDisplay();

            decimal rate = ToDecimal(txtRate.Text);
            decimal hoursWorked = ToDecimal(txtHours.Text);
            decimal otRate = txtOTRate.Enabled ? ToDecimal(txtOTRate.Text) : 0;
            decimal otHours = txtOTHours.Enabled ? ToDecimal(txtOTHours.Text) : 0;
            decimal normalHours = Math.Max(hoursWorked - otHours, 0);
            decimal grossPay = normalHours * rate + otRate * otHours;
            decimal pagibig = ToDecimal(txtPagIBIG.Text);
            decimal philhealth = ToDecimal(txtPhilHealth.Text);
            decimal sss = ToDecimal(txtSSS.Text);
            decimal totalDeductions = pagibig + philhealth + sss;
            decimal taxableIncome = Math.Max(grossPay - totalDeductions, 0);
            decimal tax = CalculateTax(taxableIncome);
            decimal netIncome = grossPay - totalDeductions - tax;

            FillBreakdownTable(rate, hoursWorked, otRate, otHours, grossPay, tax, pagibig, philhealth, sss, totalDeductions, netIncome);
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

            // If OT fields have values, validate them
            if (!string.IsNullOrWhiteSpace(txtOTRate.Text) || !string.IsNullOrWhiteSpace(txtOTHours.Text))
            {
                if (!decimal.TryParse(txtOTRate.Text, out decimal otr) || otr < 0)
                {
                    MessageBox.Show("Please enter a valid OT rate (0 or greater).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOTRate.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtOTHours.Text, out decimal oth) || oth < 0)
                {
                    MessageBox.Show("Please enter valid OT hours (0 or greater).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            return true;
        }

        // Clear all input controls (but keep the result labels intact)
        private void ClearInputs()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtRate.Text = "";
            txtHours.Text = "";

            // Clear OT and deduction controls explicitly and reset radios/defaults
            txtOTRate.Text = "";
            txtOTHours.Text = "";
            checkBoxPagIBIG.Checked = false;
            checkBoxPhilHealth.Checked = false;
            checkBoxSSS.Checked = false;

            UpdateAutoDeductions();

            SetOtControlsEnabled(true);

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
