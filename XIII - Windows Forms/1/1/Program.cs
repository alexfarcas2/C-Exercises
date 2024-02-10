using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

public class BasicCalculator : Form
{
    private TextBox expressionBox;
    private Button[] digitButtons;
    private Button addButton, subtractButton, multiplyButton, divideButton;
    private Button equalsButton, clearButton;

    public BasicCalculator()
    {
        InitializeCalculator();
    }

    private void InitializeCalculator()
    {
        // Set up the text box for input
        expressionBox = new TextBox();
        expressionBox.Location = new Point(10, 10);
        expressionBox.Size = new Size(230, 20);
        expressionBox.ReadOnly = true;

        // Set up digit buttons
        digitButtons = new Button[10];
        for (int i = 0; i < digitButtons.Length; i++)
        {
            digitButtons[i] = new Button();
            digitButtons[i].Text = i.ToString();
            digitButtons[i].Size = new Size(40, 40);
            if (i == 0)
            {
                digitButtons[i].Location = new Point(55, 175); // Position for button 0
            }
            else
            {
                // Position other buttons in a grid
                int x = 10 + ((i - 1) % 3) * 45;
                int y = 40 + ((i - 1) / 3) * 45;
                digitButtons[i].Location = new Point(x, y);
            }
            digitButtons[i].Click += DigitButtonClick;
            Controls.Add(digitButtons[i]);
        }

        // Set up operation buttons
        addButton = new Button();
        addButton.Text = "+";
        addButton.Size = new Size(40, 40);
        addButton.Location = new Point(145, 40);
        addButton.Click += OperationButtonClick;
        Controls.Add(addButton);

        subtractButton = new Button();
        subtractButton.Text = "-";
        subtractButton.Size = new Size(40, 40);
        subtractButton.Location = new Point(145, 85);
        subtractButton.Click += OperationButtonClick;
        Controls.Add(subtractButton);

        multiplyButton = new Button();
        multiplyButton.Text = "*";
        multiplyButton.Size = new Size(40, 40);
        multiplyButton.Location = new Point(145, 130);
        multiplyButton.Click += OperationButtonClick;
        Controls.Add(multiplyButton);

        divideButton = new Button();
        divideButton.Text = "/";
        divideButton.Size = new Size(40, 40);
        divideButton.Location = new Point(200, 130);
        divideButton.Click += OperationButtonClick;
        Controls.Add(divideButton);

        // Set up equals button
        equalsButton = new Button();
        equalsButton.Text = "=";
        equalsButton.Size = new Size(40, 40);
        equalsButton.Location = new Point(200, 85);
        equalsButton.Click += CalculateButtonClick;
        Controls.Add(equalsButton);

        // Set up clear button
        clearButton = new Button();
        clearButton.Text = "C";
        clearButton.Size = new Size(40, 40);
        clearButton.Location = new Point(200, 40);
        clearButton.Click += ClearButtonClick;
        Controls.Add(clearButton);

        // Add controls to the form
        Controls.Add(expressionBox);

        // Set up the form
        Size = new Size(260, 230);
        Text = "Basic Calculator";
    }

    private void DigitButtonClick(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        expressionBox.Text += button.Text;
    }

    private void OperationButtonClick(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        expressionBox.Text += " " + button.Text + " ";
    }

    private void CalculateButtonClick(object sender, EventArgs e)
    {
        try
        {
            var result = new DataTable().Compute(expressionBox.Text, null);
            expressionBox.Text = result.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error in expression: " + ex.Message);
        }
    }

    private void ClearButtonClick(object sender, EventArgs e)
    {
        expressionBox.Text = "";
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new BasicCalculator());
    }
}
