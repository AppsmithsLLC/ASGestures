using Xamarin.Forms;

namespace ASGestures
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GestureFrame_SwipeDown(object sender, System.EventArgs e)
        {
            Label.Text = "Swipe Down";
        }

        private void GestureFrame_SwipeUp(object sender, System.EventArgs e)
        {
            Label.Text = "Swipe Up";
        }

        private void GestureFrame_SwipeLeft(object sender, System.EventArgs e)
        {
            Label.Text = "Swipe Left";
        }

        private void GestureFrame_SwipeRight(object sender, System.EventArgs e)
        {
            Label.Text = "Swipe Right";
        }

        private void GestureFrame_Tapped(object sender, System.EventArgs e)
        {
            Label.Text = "Tapped";
        }

        private void GestureFrame_LongPressed(object sender, System.EventArgs e)
        {
            Label.Text = "Long Press";
        }
    }
}
