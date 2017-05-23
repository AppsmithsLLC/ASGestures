using System;
using System.Collections.Generic;
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

        private void GestureScrollView_ScrollDown(object sender, EventArgs e)
        {
            Label.Text = "Scroll Down";
        }

        private void GestureScrollView_ScrollUp(object sender, EventArgs e)
        {
            Label.Text = "Scroll Up";
        }

        private void GestureScrollView_SwipeRight(object sender, EventArgs e)
        {
            Label.Text = "Swipe Right";
        }

        private void GestureScrollView_SwipeLeft(object sender, EventArgs e)
        {
            Label.Text = "Swipe Left";
        }
    }
    class Person
    {
        public Person(string name, DateTime birthday, Color favoriteColor)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.FavoriteColor = favoriteColor;
        }

        public string Name { private set; get; }

        public DateTime Birthday { private set; get; }

        public Color FavoriteColor { private set; get; }
    };

}
