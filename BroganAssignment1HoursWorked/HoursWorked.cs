using System.Drawing.Text;

namespace BroganAssignment1HoursWorked
{
    public partial class hoursWorked : Form
    {
        private double payPerHour = 10.50;
        public hoursWorked()
        {
            InitializeComponent();
        }

        private void HoursWorked_Load(object sender, EventArgs e)
        {

        }

        private void summarizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                double hoursWorked = int.Parse(hoursWorkedTextBox.Text);


                if (!string.IsNullOrEmpty(firstNameTextBox.Text) && !string.IsNullOrEmpty(lastNameTextBox.Text) && !string.IsNullOrEmpty(hoursWorkedTextBox.Text))
                {
                    displayLabel.ForeColor = System.Drawing.Color.Black;
                    displayLabel.Text = lastNameTextBox.Text + ", " + firstNameTextBox.Text +
                        "worked " + hoursWorked + " hours at $" + payPerHour +
                        " an hour for a total of $" + (hoursWorked * payPerHour);
                }
                else
                {
                    displayLabel.ForeColor = System.Drawing.Color.Red;
                    displayLabel.Text = "Please fill in every entry to see total pay.";
                }
            }
            catch (Exception ex)
            {
                displayLabel.ForeColor = System.Drawing.Color.Red;
                displayLabel.Text = "Please input a number for the Hours Worked field.";
                Console.WriteLine(ex.ToString());
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
