using System;
using Xamarin.Forms;

namespace ASGestures.Client.Controls
{
    public class GestureFrame : Frame
    {
        public GestureFrame()
        {

        }

        public event EventHandler SwipeDown;
        public event EventHandler SwipeUp;
        public event EventHandler SwipeLeft;
        public event EventHandler SwipeRight;
        public event EventHandler Tapped;
        public event EventHandler LongPressed;

        public void OnSwipeDown()
        {
            if (SwipeDown != null)
                SwipeDown(this, null);
        }

        public void OnSwipeUp()
        {
            if (SwipeUp != null)
                SwipeUp(this, null);
        }

        public void OnSwipeLeft()
        {
            if (SwipeLeft != null)
                SwipeLeft(this, null);
        }

        public void OnSwipeRight()
        {
            if (SwipeRight != null)
                SwipeRight(this, null);
        }

        public void OnTapped()
        {
            if (Tapped != null)
                Tapped(this, null);
        }

        public void OnLongPressed()
        {
            if (LongPressed != null)
                LongPressed(this, null);
        }
    }
}

