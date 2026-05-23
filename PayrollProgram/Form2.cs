using System;
using System.Drawing;
using System.Windows.Forms;

namespace PayrollProgram
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            PopulateTaxTable();
        }

        private void PopulateTaxTable()
        {
            // Clear any existing controls
            taxTable.Controls.Clear();

            // Header + 6 bracket rows (designer has RowCount = 7)
            string[,] data = new string[,]
            {
                { "Range", "Rate", "Notes" },
                { "₱20,833 and below", "0%", "None" },
                { "₱20,833.01 – ₱33,333", "15%", "15% of the excess over ₱20,833" },
                { "₱33,333.01 – ₱66,666", "20%", "₱1,875.00 + 20% of the excess over ₱33,333" },
                { "₱66,666.01 – ₱166,666", "25%", "₱8,541.67 + 25% of the excess over ₱66,666" },
                { "₱166,666.01 – ₱666,666", "30%", "₱33,541.67 + 30% of the excess over ₱166,666" },
                { "Over ₱666,666", "35%", "₱183,541.67 + 35% of the excess over ₱666,666" }
            };

            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            // Ensure the TableLayoutPanel layout matches data dimensions (optional)
            taxTable.RowCount = rows;
            taxTable.ColumnCount = cols;

            taxTable.SuspendLayout();

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    var lbl = new Label
                    {
                        Text = data[r, c],
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Margin = new Padding(4)
                    };

                    // Make header bold
                    if (r == 0)
                        lbl.Font = new Font(lbl.Font, FontStyle.Bold);

                    // Add to specific column/row
                    taxTable.Controls.Add(lbl, c, r);
                }
            }

            taxTable.ResumeLayout();
        }
    }
}
