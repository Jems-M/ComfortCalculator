namespace ComfortCalculator
{
    public partial class Form1 : Form
    {
        Country UK = new Country();

        Country USA = new Country();

        Country Russia = new Country();

        Country China = new Country();

        Country Chad = new Country();

        Country Brazil = new Country();

        public Form1()
        {
            InitializeComponent();

            UK.SocProgressScore = 86.13;
            UK.FreedomIndex = 91;
            UK.CrimeIndex = 49.6;

            USA.SocProgressScore = 84.65;
            USA.FreedomIndex = 83;
            USA.CrimeIndex = 49.2;

            Russia.SocProgressScore = 71.99;
            Russia.FreedomIndex = 13;
            Russia.CrimeIndex = 39.7;

            China.SocProgressScore = 65.74;
            China.FreedomIndex = 9;
            China.CrimeIndex = 60.8;

            Chad.SocProgressScore = 34.69;
            Chad.FreedomIndex = 15;
            Chad.CrimeIndex = 58.7;

            Brazil.SocProgressScore = 71.26;
            Brazil.FreedomIndex = 72;
            Brazil.CrimeIndex = 66.1;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUK_Click(object sender, EventArgs e)
        {

        }

        private void lblUK_Click(object sender, EventArgs e)
        {
            lblCountryName.Text = "United Kingdom";
            lblSocProgressNum.Text = UK.SocProgressScore.ToString();
            lblFreedomIndexNum.Text = UK.FreedomIndex.ToString();
            lblCrimeIndexNum.Text = UK.CrimeIndex.ToString();
            lblComfortScoreNum.Text = UK.getComfortScore().ToString();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            lblCountryName.Text = "Russia";
            lblSocProgressNum.Text = Russia.SocProgressScore.ToString();
            lblFreedomIndexNum.Text = Russia.FreedomIndex.ToString();
            lblCrimeIndexNum.Text = Russia.CrimeIndex.ToString();
            lblComfortScoreNum.Text = Russia.getComfortScore().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblCountryName.Text = "Brazil";
            lblSocProgressNum.Text = Brazil.SocProgressScore.ToString();
            lblFreedomIndexNum.Text = Brazil.FreedomIndex.ToString();
            lblCrimeIndexNum.Text = Brazil.CrimeIndex.ToString();
            lblComfortScoreNum.Text = Brazil.getComfortScore().ToString();
        }

        private void lblSafetyIndex_Click(object sender, EventArgs e)
        {

        }

        private void lblUSA_Click(object sender, EventArgs e)
        {
            lblCountryName.Text = "United States";
            lblSocProgressNum.Text = USA.SocProgressScore.ToString();
            lblFreedomIndexNum.Text = USA.FreedomIndex.ToString();
            lblCrimeIndexNum.Text = USA.CrimeIndex.ToString();
            lblComfortScoreNum.Text = USA.getComfortScore().ToString();
        }

        private void label1_Click_3(object sender, EventArgs e)
        {
            lblCountryName.Text = "Chad";
            lblSocProgressNum.Text = Chad.SocProgressScore.ToString();
            lblFreedomIndexNum.Text = Chad.FreedomIndex.ToString();
            lblCrimeIndexNum.Text = Chad.CrimeIndex.ToString();
            lblComfortScoreNum.Text = Chad.getComfortScore().ToString();
        }

        private void lblChina_Click(object sender, EventArgs e)
        {
            lblCountryName.Text = "China";
            lblSocProgressNum.Text = China.SocProgressScore.ToString();
            lblFreedomIndexNum.Text = China.FreedomIndex.ToString();
            lblCrimeIndexNum.Text = China.CrimeIndex.ToString();
            lblComfortScoreNum.Text = China.getComfortScore().ToString();
        }
    }
}
