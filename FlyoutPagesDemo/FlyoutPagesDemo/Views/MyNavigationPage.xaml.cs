namespace FlyoutPagesDemo.Views;

public partial class MyNavigationPage : ContentPage
{
    public MyNavigationPage()
    {
        InitializeComponent();
        NavigationPage.SetHasBackButton(this, false);
    }

    void ImageButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }
}

