using Microsoft.JSInterop;

namespace StrangeFilePickerBehavior;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_OnClicked(object sender, EventArgs e)
    {
        Pages.Index.GetJSRuntime().InvokeVoidAsync("openFile",
            new object[] { });
    }
}
