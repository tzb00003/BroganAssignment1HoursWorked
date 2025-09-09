using System.Drawing.Text;

namespace BroganAssignment1HoursWorked
{
    public partial class Assignment1 : Form
    {
        private double PAY_PER_HOUR = 10.50;
        public Assignment1()
        {
            InitializeComponent();
        }

        private void HoursWorked_Load(object sender, EventArgs e)
        {

            firstNameLabel.UseMnemonic = true;
            firstNameTextBox.TabIndex = 1;

            lastNameLabel.UseMnemonic = true;
            lastNameTextBox.TabIndex = 2;

            hoursWorkedLabel.UseMnemonic = true;
            hoursWorkedTextBox.TabIndex = 3;

          
        }

        private void summarizeButton_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(firstNameTextBox.Text) && !string.IsNullOrEmpty(lastNameTextBox.Text) && !string.IsNullOrEmpty(hoursWorkedTextBox.Text))
                {
                    try
                    {
                        double hoursWorked = int.Parse(hoursWorkedTextBox.Text);

                        displayLabel.ForeColor = System.Drawing.Color.Black;
                        displayLabel.Text = $"{lastNameTextBox.Text}, {firstNameTextBox.Text} worked {hoursWorked} hours at ${PAY_PER_HOUR} an hour for a total of ${hoursWorked * PAY_PER_HOUR}.";
                    }
                    catch (Exception ex)
                    {
                        displayLabel.ForeColor = System.Drawing.Color.Red;
                        displayLabel.Text = "Please input a number for the Hours Worked field.";
                        Console.WriteLine(ex.ToString());
                    }
                }
                else
                {
                    displayLabel.ForeColor = System.Drawing.Color.Red;
                    displayLabel.Text = "Please fill in every entry to see total pay.";
                }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayLabel.ForeColor = System.Drawing.Color.Black;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            hoursWorkedTextBox.Text = string.Empty;
            displayLabel.Text = "Please insert required information to get total pay.";
        }
    }
}
