using System.Data;

namespace DateManipulation
{
    public partial class Form2 : Form
    {
        List<Dictionary<string, string>> _flights = new List<Dictionary<string, string>>();
        public Form2()
        {
            InitializeComponent();
            InitializeFlights();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;


            button1.Text = "Search flights";

        }

        private void InitializeFlights()
        {

            _flights.Add(new Dictionary<string, string>
            {
                { "FlightName", "Flight A" },

                { "Departure", "YTO-Canada" },
                { "Arrival", "AMS-Netherlands" },

                { "DateFrom", DateTime.Now.ToShortDateString() },
                { "DateTo", DateTime.Now.AddDays(7).ToShortDateString() }
            });

            _flights.Add(new Dictionary<string, string>
            {
                { "FlightName", "Flight B" },


                { "Departure", "YYC-Canada" },
                { "Arrival", "PAR-France" },


                { "DateFrom", DateTime.Now.AddDays(10).ToShortDateString() },
                { "DateTo", DateTime.Now.AddDays(15).ToShortDateString() }
            });

            _flights.Add(new Dictionary<string, string>
            {
                { "FlightName", "Flight C" },

                { "Departure", "YVR-Canada" },
                { "Arrival", "JNB-South Africa" },


                { "DateFrom", DateTime.Now.AddDays(20).ToShortDateString() },
                { "DateTo", DateTime.Now.AddDays(30).ToShortDateString() }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDateFrom = dateTimePicker1.Value.Date;
                DateTime selectedDateTo = dateTimePicker2.Value.Date;

                var matchingFlights = _flights.Where(flight =>
                {
                    DateTime flightDateFrom = DateTime.Parse(flight["DateFrom"]).Date;
                    DateTime flightDateTo = DateTime.Parse(flight["DateTo"]).Date;
                    return flightDateFrom >= selectedDateFrom && flightDateTo <= selectedDateTo;
                }).ToList();

                DisplayFlights(matchingFlights);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDateFrom = dateTimePicker1.Value.Date;
                var flightsFrom = _flights.Where(flight =>
                {
                    DateTime flightDateFrom = DateTime.Parse(flight["DateFrom"]).Date;
                    return flightDateFrom >= selectedDateFrom;
                }).ToList();

                DisplayFlights(flightsFrom);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDateTo = dateTimePicker2.Value.Date;
                var flightsTo = _flights.Where(flight =>
                {
                    DateTime flightDateTo = DateTime.Parse(flight["DateTo"]).Date;
                    return flightDateTo <= selectedDateTo;
                }).ToList();

                DisplayFlights(flightsTo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayFlights(List<Dictionary<string, string>> flights)
        {
            try
            {
                listBox1.Items.Clear();

                if (flights.Any())
                {
                    foreach (var flight in flights)
                    {
                        string flightDetails = $"Flight Name: {flight["FlightName"]},\n " +
                                               $"Departure: {flight["Departure"]},\n " +
                                               $"Arrival: {flight["Arrival"]},\n " +
                                               $"Date From: {flight["DateFrom"]},\n " +
                                               $"Date To: {flight["DateTo"]}";

                        listBox1.Items.Add(flightDetails);
                    }
                }
                else
                {
                    listBox1.Items.Add("No flights found within the selected date range.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
