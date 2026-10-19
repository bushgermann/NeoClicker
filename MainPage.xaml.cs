namespace NeoClicker
{
    public partial class MainPage : ContentPage
    {
        private const string CounterKey = "CounterValue";
        private int _count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _count = Preferences.Get(CounterKey, 0);
            CounterLabel.Text = _count.ToString();
        }

        private void DisplayTapped(object sender, TappedEventArgs e)
        {
            _count++;
            CounterLabel.Text = _count.ToString();
            Preferences.Set(CounterKey, _count);
        }
    }
}
