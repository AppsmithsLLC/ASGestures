using Android.Views;
using System;

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
                        if (OnSwipeRight != null)
                            OnSwipeRight(this, null);
                    }
                    else
                    {
                        if (OnSwipeLeft != null)
                            OnSwipeLeft(this, null);
                    }
                }
            }
            else if (Math.Abs(diffY) > SWIPE_THRESHOLD && Math.Abs(velocityY) > SWIPE_VELOCITY_THRESHOLD)
            {
                if (diffY > 0)
                {
                    if (OnSwipeDown != null)
                        OnSwipeDown(this, null);
                }
                else
                {
                    if (OnSwipeUp != null)
                        OnSwipeUp(this, null);
                }
            }
            return base.OnFling(e1, e2, velocityX, velocityY);
        }

        public override bool OnSingleTapUp(MotionEvent e)
        {
            OnTapped(this, null);
            return base.OnSingleTapUp(e);
        }

        public override void OnLongPress(MotionEvent e)
        {
            OnLongPressed(this, null);
            base.OnLongPress(e);
        }
    }
}