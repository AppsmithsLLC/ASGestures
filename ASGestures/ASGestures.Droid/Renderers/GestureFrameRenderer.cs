using System;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using ASGestures.Client.Controls;
using ASGestures.Droid.Renderers;
using ASGestures.Droid.Listeners;

[assembly: ExportRenderer(typeof(GestureFrame), typeof(GestureFrameRenderer))]
namespace ASGestures.Droid.Renderers
{
    public class GestureFrameRenderer : FrameRenderer
    {
        private readonly CustomGestureListener _listener;
        private readonly GestureDetector _detector;

        public GestureFrameRenderer()
        {
            _listener = new CustomGestureListener();
            _detector = new GestureDetector(_listener);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
            {
                this.GenericMotion -= HandleGenericMotion;
                this.Touch -= HandleTouch;
                _listener.OnSwipeLeft -= HandleOnSwipeLeft;
                _listener.OnSwipeRight -= HandleOnSwipeRight;
                _listener.OnSwipeUp -= HandleOnSwipeUp;
                _listener.OnSwipeDown -= HandleOnSwipeDown;
                _listener.OnTapped -= HandleOnTapped;
                _listener.OnLongPressed -= HandleOnLongPressed;
            }

            if (e.OldElement == null)
            {
                this.GenericMotion += HandleGenericMotion;
                this.Touch += HandleTouch;
                _listener.OnSwipeLeft += HandleOnSwipeLeft;
                _listener.OnSwipeRight += HandleOnSwipeRight;
                _listener.OnSwipeUp += HandleOnSwipeUp;
                _listener.OnSwipeDown += HandleOnSwipeDown;
                _listener.OnTapped += HandleOnTapped;
                _listener.OnLongPressed += HandleOnLongPressed;
            }
        }

        void HandleTouch(object sender, TouchEventArgs e)
        {
            _detector.OnTouchEvent(e.Event);
        }

        void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            _detector.OnTouchEvent(e.Event);
        }

        void HandleOnSwipeLeft(object sender, EventArgs e)
        {
            GestureFrame _gi = (GestureFrame)this.Element;
            _gi.OnSwipeLeft();
        }

        void HandleOnSwipeRight(object sender, EventArgs e)
        {
            GestureFrame _gi = (GestureFrame)this.Element;
            _gi.OnSwipeRight();
        }

        void HandleOnSwipeUp(object sender, EventArgs e)
        {
            GestureFrame _gi = (GestureFrame)this.Element;
            _gi.OnSwipeUp();
        }

        void HandleOnSwipeDown(object sender, EventArgs e)
        {
            GestureFrame _gi = (GestureFrame)this.Element;
            _gi.OnSwipeDown();
        }

        void HandleOnTapped(object sender, EventArgs e)
        {
            GestureFrame _gi = (GestureFrame)this.Element;
            _gi.OnTapped();
        }

        void HandleOnLongPressed(object sender, EventArgs e)
        {
            GestureFrame _gi = (GestureFrame)this.Element;
            _gi.OnLongPressed();
        }
    }
}