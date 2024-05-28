namespace GestureIssue;

public partial class MainPage : ContentPage
{
	int count = 0;
	int count2 = 0;

	public MainPage()
	{
		InitializeComponent();

		lbl.Text = 
"""
The image below has two TapGestureRecognizer, one that should be trigger with one tap and another with two taps.
The issue is that the 'OneTapGesture' event handler will be called even if I perform a two taps. Shouldn't only the
'TwoTapGesture' be fired?
""";
	}
	void OnetapGesture(object sender, TappedEventArgs e)
	{
		count++;
		OneLog.Text = $"The OneTapGesture was fired: {count} times";
	}

	void TwotapGesture(object sender, TappedEventArgs e)
	{
		count2++;
		TwoLog.Text = $"The TwoTapGesture was fired: {count2} times";
	}
}

