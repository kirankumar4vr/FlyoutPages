namespace FlyoutPagesDemo.Views;

public partial class LandingPage : ContentPage
{
    public LandingPage()
    {
        InitializeComponent();
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new MyNavigationPage());
    }
}

