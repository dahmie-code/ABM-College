using System.Data;
using System.Data.SqlClient;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=ABMtest; User Id=sa; Password=password123;";
        string currentInput = string.Empty;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setupEventHandlers();
            loadHistory();

        }
        private void setupEventHandlers()
        {

            button0.Click += buttonClick;
            buttonOne.Click += buttonClick;
            buttonTwo.Click += buttonClick;
            buttonThree.Click += buttonClick;
            buttonFour.Click += buttonClick;
            buttonFive.Click += buttonClick;
            buttonSix.Click += buttonClick;
            button7.Click += buttonClick;
            button8.Click += buttonClick;
            button9.Click += buttonClick;
            plus.Click += buttonClick;
            minus.Click += buttonClick;
            multiply.Click += buttonClick;
            divide.Click += buttonClick;
            enter.Click += buttonClick;
            ce.Click += buttonClick;
            dot.Click += buttonClick;
        }
        private void loadHistory()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                WITH NumberedCalculations AS (
                    SELECT 
                        ROW_NUMBER() OVER (ORDER BY CreatedAt DESC) AS RowNumber, 
                        Calculation 
                    FROM 
                        CalculationHistory
                )
                SELECT 
                    RowNumber, 
                    Calculation 
                FROM 
                    NumberedCalculations
                WHERE 
                    RowNumber <= 10
                ORDER BY 
                    RowNumber ASC";

                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    historyListBox.Items.Clear();
                    //int serialNumber = 1;

                    while (reader.Read())
                    {
                        long rowNumber = reader.GetInt64(0);
                        string calculation = reader["Calculation"].ToString();

                        historyListBox.Items.Add($"{rowNumber}. {calculation}");
                        historyListBox.Items.Add("");
                        //serialNumber++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading history: " + ex.Message);
            }
        }

        private void updateHistory(string calculation)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO CalculationHistory (Calculation) VALUES (@Calculation)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Calculation", calculation);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving history: " + ex.Message);
            }
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "ENTER")
            {
                calculateResult();
            }
            else if (button.Text == "CE")
            {
                clearDisplay();
            }
            else if (button.Text == ".")
            {
                char[] operators = { '+', '-', '*', '/' };
                string[] parts = currentInput.Split(operators);
                string currentNumber = parts[parts.Length - 1];

                if (!currentNumber.Contains("."))
                {
                    currentInput += button.Text;
                    displayTextBox.Text = currentInput;
                }
            }
            else
            {
                currentInput += button.Text;
                displayTextBox.Text = currentInput;
            }
        }
        private void calculateResult()
        {
            try
            {
                string expression = currentInput;
                var result = new DataTable().Compute(expression, null);
                decimal resultDecimal = Convert.ToDecimal(result);

                string resultString = resultDecimal % 1 == 0 ? resultDecimal.ToString("0") : resultDecimal.ToString("0.00");

                displayTextBox.Text = resultString;

                string calculation = $"{currentInput} = {resultString}";
                updateHistory(calculation);
                historyListBox.Items.Insert(0, calculation);

                currentInput = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during calculation: " + ex.Message);
                displayTextBox.Text = string.Empty;
                currentInput = string.Empty;
            }
        }

        private void clearDisplay()
        {
            currentInput = string.Empty;
            displayTextBox.Text = string.Empty;
        }
    }
}