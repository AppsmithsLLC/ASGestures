using Android.Views;
using System;
using System.Drawing;

namespace ASGestures.Droid.Listeners
{
    public class CustomGestureListener : GestureDetector.SimpleOnGestureListener
    {
        private static int SWIPE_THRESHOLD = 100;
        private static int SWIPE_VELOCITY_THRESHOLD = 100;

        public event EventHandler OnSwipeDown;
        public event EventHandler OnSwipeUp;
        public event EventHandler OnSwipeLeft;
        public event EventHandler OnSwipeRight;
        public event EventHandler OnTapped;
        public event EventHandler OnLongPressed;
        public event EventHandler OnScrollUp;
        public event EventHandler OnScrollDown;

        public override bool OnFling(MotionEvent e1, MotionEvent e2, float velocityX, float velocityY)
        {
            Console.WriteLine("OnFling");

            float diffY = e2.GetY() - e1.GetY();
            float diffX = e2.GetX() - e1.GetX();

            if (Math.Abs(diffX) > Math.Abs(diffY))
            {
                if (Math.Abs(diffX) > SWIPE_THRESHOLD && Math.Abs(velocityX) > SWIPE_VELOCITY_THRESHOLD)
                {
                    if (diffX > 0)
                    {
                        OnSwipeRight?.Invoke(this, null);
                    }
                    else
                    {
                        OnSwipeLeft?.Invoke(this, null);
                    }
                }
            }
            else if (Math.Abs(diffY) > SWIPE_THRESHOLD && Math.Abs(velocityY) > SWIPE_VELOCITY_THRESHOLD)
            {
                if (diffY > 0)
                {
                    OnSwipeDown?.Invoke(this, null);
                }
                else
                {
                    OnSwipeUp?.Invoke(this, null);
                }
            }
            return base.OnFling(e1, e2, velocityX, velocityY);
        }

        public override bool OnSingleTapUp(MotionEvent e)
        {
            OnTapped?.Invoke(this, null);
            return base.OnSingleTapUp(e);
        }

        public override void OnLongPress(MotionEvent e)
        {
            OnLongPressed?.Invoke(this, null);
            base.OnLongPress(e);
        }

        public override bool OnScroll(MotionEvent e1, MotionEvent e2, float distanceX, float distanceY)
        {
            var n = 270 - (Math.Atan2(0 - distanceY, 0 - distanceX)) * 180 / Math.PI;
            var angle = n % 360;

            if (angle > 65 && angle < 115)
                OnSwipeLeft?.Invoke(this, null);
            else if (angle > 115 && angle < 245)
                OnScrollDown?.Invoke(this, null);
            else if (angle > 245 && angle < 295)
                OnSwipeRight?.Invoke(this, null);
            else
                OnScrollUp?.Invoke(this, null);
                
            return base.OnScroll(e1, e2, distanceX, distanceY);
        }
    }
}