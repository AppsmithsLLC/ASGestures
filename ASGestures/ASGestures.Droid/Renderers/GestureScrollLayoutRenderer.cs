using System;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using ASGestures.Client.Controls;
using ASGestures.Droid.Listeners;
using ASGestures.Droid.Renderers;

[assembly: ExportRenderer(typeof(GestureScrollView), typeof(GestureScrollLayoutRenderer))]
namespace ASGestures.Droid.Renderers
{
    public class GestureScrollLayoutRenderer : ScrollViewRenderer
    {
        private readonly CustomGestureListener _listener;
        private readonly GestureDetector _detector;

        public GestureScrollLayoutRenderer()
        {
            _listener = new CustomGestureListener();
            _detector = new GestureDetector(_listener);
        }
        
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
            {
                this.GenericMotion -= HandleGenericMotion;
                this.Touch -= HandleTouch;
                _listener.OnScrollUp -= HandleOnScrollUp;
                _listener.OnScrollDown -= HandleOnScrollDown;
                _listener.OnSwipeRight -= HandleOnSwipeRight;
                _listener.OnSwipeLeft -= HandleOnSwipeLeft;
            }

            if (e.OldElement == null)
            {
                this.GenericMotion += HandleGenericMotion;
                this.Touch += HandleTouch;
                _listener.OnScrollUp += HandleOnScrollUp;
                _listener.OnScrollDown += HandleOnScrollDown;
                _listener.OnSwipeRight += HandleOnSwipeRight;
                _listener.OnSwipeLeft += HandleOnSwipeLeft;
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
        
        void HandleOnScrollUp(object sender, EventArgs e)
        {
            GestureScrollView _gi = (GestureScrollView)this.Element;
            _gi.OnScrollUp();
        }

        void HandleOnScrollDown(object sender, EventArgs e)
        {
            GestureScrollView _gi = (GestureScrollView)this.Element;
            _gi.OnScrollDown();
        }

        void HandleOnSwipeLeft(object sender, EventArgs e)
        {
            GestureScrollView _gi = (GestureScrollView)this.Element;
            _gi.OnSwipeLeft();
        }

        void HandleOnSwipeRight(object sender, EventArgs e)
        {
            GestureScrollView _gi = (GestureScrollView)this.Element;
            _gi.OnSwipeRight();
        }
    }
}