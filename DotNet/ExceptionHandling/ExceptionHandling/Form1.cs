namespace ExceptionHandling
{
    public partial class Form1 : Form
    {
        //private TextBox myTextBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //          try
            //{
            //    int[] number = null;
            //   int value = number[1];

            //}

            //catch ( Exception ex )
            //{
            //    MessageBox.Show($"An unexpected error occurred: {ex.Message}");

            //}  


            //string num = "8987879881";
            //try
            //{

            //    char eleventhChar = num[10];
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            //}

            try
            {
                decimal deci = 90.08m;
                string str = (string)(object)deci;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A casting error occurred: {ex.Message}");
            }



        }
    }
}