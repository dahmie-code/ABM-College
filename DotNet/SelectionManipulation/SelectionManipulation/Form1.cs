namespace SelectionManipulation
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Dictionary<string, List<string>>> locationData;

        public Form1()
        {
            InitializeComponent();
            InitializeLocationData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            continent.Text = "Continent";
            countries.Text = "Country";
            state.Text = "Cities";

            comboContinents.Items.AddRange(locationData.Keys.ToArray());
            comboContinents.SelectedIndexChanged += comboContinents_SelectedIndexChanged;
            comboCountries.SelectedIndexChanged += comboCountries_SelectedIndexChanged;
        }


        private void InitializeLocationData()
        {
            locationData = new Dictionary<string, Dictionary<string, List<string>>>()
            {
                {
                    "North America", new Dictionary<string, List<string>>()
                    {
                        { "United States", new List<string> { "New York", "Los Angeles", "Chicago" } },
                        { "Canada", new List<string> { "Toronto", "Vancouver", "Montreal" } },
                        { "Mexico", new List<string> { "Mexico City", "Guadalajara", "Monterrey" } }
                    }
                },
                {
                    "Europe", new Dictionary<string, List<string>>()
                    {
                        { "United Kingdom", new List<string> { "London", "Manchester", "Liverpool" } },
                        { "Germany", new List<string> { "Berlin", "Munich", "Hamburg" } },
                        { "France", new List<string> { "Paris", "Lyon", "Marseille" } }
                    }
                },
                {
                    "Asia", new Dictionary<string, List<string>>()
                    {
                        { "China", new List<string> { "Beijing", "Shanghai", "Shenzhen" } },
                        { "India", new List<string> { "Mumbai", "Delhi", "Bangalore" } },
                        { "Japan", new List<string> { "Tokyo", "Osaka", "Kyoto" } }
                    }
                }
            };
        }
        private void comboContinents_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboCountries.Items.Clear();
            comboStates.Items.Clear();

            string selectedContinent = comboContinents.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedContinent) && locationData.ContainsKey(selectedContinent))
            {
                comboCountries.Items.AddRange(locationData[selectedContinent].Keys.ToArray());
            }
        }
        private void comboCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboStates.Items.Clear();

            
            string selectedContinent = comboContinents.SelectedItem?.ToString();
            string selectedCountry = comboCountries.SelectedItem?.ToString();


            if (!string.IsNullOrEmpty(selectedContinent) && !string.IsNullOrEmpty(selectedCountry) &&
                locationData.ContainsKey(selectedContinent) && locationData[selectedContinent].ContainsKey(selectedCountry))
            {
                comboStates.Items.AddRange(locationData[selectedContinent][selectedCountry].ToArray());

            }
        }
        private void comboStates_SelectedIndexChanged(object sender, EventArgs e)
        {


            string selectedContinent = comboContinents.SelectedItem?.ToString();
            string selectedCountry = comboCountries.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedContinent) && !string.IsNullOrEmpty(selectedCountry) &&
                locationData.ContainsKey(selectedContinent) && locationData[selectedContinent].ContainsKey(selectedCountry))
            {
                comboStates.Items.AddRange(locationData[selectedContinent][selectedCountry].ToArray());
            }
        }


    }
}