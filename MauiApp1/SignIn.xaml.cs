namespace MauiApp1;

public partial class SignIn : ContentPage
{
    //int count = 0;
    public SignIn()
	{
		InitializeComponent();
	}
    private void OnCounterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignUp());
    }

}