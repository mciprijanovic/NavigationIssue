namespace MAUINavigationIssue
{
    public partial class MainPage : ContentPage
    {        
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
            //await Task.Delay(1); Will work when this is uncommented
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}