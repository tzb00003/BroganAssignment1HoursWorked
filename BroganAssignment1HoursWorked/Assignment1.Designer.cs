namespace BroganAssignment1HoursWorked
{
    partial class Assignment1
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            hoursWorkedLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            hoursWorkedTextBox = new TextBox();
            summarizeButton = new Button();
            clearButton = new Button();
            displayLabel = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(150, 80);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(97, 25);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "&First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(450, 80);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(95, 25);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "&Last Name";
            // 
            // hoursWorkedLabel
            // 
            hoursWorkedLabel.AutoSize = true;
            hoursWorkedLabel.Location = new Point(750, 80);
            hoursWorkedLabel.Name = "hoursWorkedLabel";
            hoursWorkedLabel.Size = new Size(127, 25);
            hoursWorkedLabel.TabIndex = 2;
            hoursWorkedLabel.Text = "&Hours Worked";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(125, 108);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(150, 31);
            firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(425, 108);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(150, 31);
            lastNameTextBox.TabIndex = 4;
            // 
            // hoursWorkedTextBox
            // 
            hoursWorkedTextBox.Location = new Point(738, 108);
            hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            hoursWorkedTextBox.Size = new Size(150, 31);
            hoursWorkedTextBox.TabIndex = 5;
            // 
            // summarizeButton
            // 
            summarizeButton.Location = new Point(133, 206);
            summarizeButton.Name = "summarizeButton";
            summarizeButton.Size = new Size(142, 37);
            summarizeButton.TabIndex = 6;
            summarizeButton.Text = "&Summarize";
            summarizeButton.UseVisualStyleBackColor = true;
            summarizeButton.Click += summarizeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(299, 206);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(142, 37);
            clearButton.TabIndex = 7;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // displayLabel
            // 
            displayLabel.AutoSize = true;
            displayLabel.BorderStyle = BorderStyle.FixedSingle;
            displayLabel.Location = new Point(88, 304);
            displayLabel.MaximumSize = new Size(850, 200);
            displayLabel.Name = "displayLabel";
            displayLabel.Padding = new Padding(250, 25, 250, 25);
            displayLabel.Size = new Size(838, 102);
            displayLabel.TabIndex = 8;
            displayLabel.Text = "Please insert required information to get total pay.";
            
            // 
            // Assignment1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 464);
            Controls.Add(displayLabel);
            Controls.Add(clearButton);
            Controls.Add(summarizeButton);
            Controls.Add(hoursWorkedTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(hoursWorkedLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "Assignment1";
            Text = "Hours Worked";
            Load += HoursWorked_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label hoursWorkedLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox hoursWorkedTextBox;
        private Button summarizeButton;
        private Button clearButton;
        private Label displayLabel;
    }
}
