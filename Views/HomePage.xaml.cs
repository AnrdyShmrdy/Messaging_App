namespace Messaging_App.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        BindingContext = new Models.Home();
        navButton.Clicked += async (sender, args) =>
        {
            await Navigation.PushAsync(new ClientPage());
        };
    }
}