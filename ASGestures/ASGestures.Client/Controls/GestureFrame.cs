using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ASGestures.Client.Controls
{
    public class GestureFrame : Frame
    {
        public GestureFrame()
        {

        }

        #region Events

        public event EventHandler SwipeDown;
        public event EventHandler SwipeUp;
        public event EventHandler SwipeLeft;
        public event EventHandler SwipeRight;
        public event EventHandler Tapped;
        public event EventHandler LongPressed;

        #endregion

        #region Commands

        public ICommand SwipeDownCommand
        {
            get { return (ICommand)GetValue(SwipeDownCommandProperty); }
            set { SetValue(SwipeDownCommandProperty, value); }
        }

        public static readonly BindableProperty SwipeDownCommandProperty = BindableProperty.Create(
            "SwipeDownCommand", typeof(ICommand), typeof(GestureFrame));

        public ICommand SwipeUpCommand
        {
            get { return (ICommand)GetValue(SwipeUpCommandProperty); }
            set { SetValue(SwipeUpCommandProperty, value); }
        }

        public static readonly BindableProperty SwipeUpCommandProperty = BindableProperty.Create(
            "SwipeUpCommand", typeof(ICommand), typeof(GestureFrame));

        public ICommand SwipeLeftCommand
        {
            get { return (ICommand)GetValue(SwipeLeftCommandProperty); }
            set { SetValue(SwipeLeftCommandProperty, value); }
        }

        public static readonly BindableProperty SwipeLeftCommandProperty = BindableProperty.Create(
            "SwipeLeftCommand", typeof(ICommand), typeof(GestureFrame));

        public ICommand SwipeRightCommand
        {
            get { return (ICommand)GetValue(SwipeRightCommandProperty); }
            set { SetValue(SwipeRightCommandProperty, value); }
        }

        public static readonly BindableProperty SwipeRightCommandProperty = BindableProperty.Create(
            "SwipeRightCommand", typeof(ICommand), typeof(GestureFrame));

        public ICommand TappedCommand
        {
            get { return (ICommand)GetValue(TappedCommandProperty); }
            set { SetValue(TappedCommandProperty, value); }
        }

        public static readonly BindableProperty TappedCommandProperty = BindableProperty.Create(
            "TappedCommand", typeof(ICommand), typeof(GestureFrame));

        public ICommand LongPressedCommand
        {
            get { return (ICommand)GetValue(LongPressedCommandProperty); }
            set { SetValue(LongPressedCommandProperty, value); }
        }

        public static readonly BindableProperty LongPressedCommandProperty = BindableProperty.Create(
            "LongPressedCommand", typeof(ICommand), typeof(GestureFrame));

        #endregion

        #region Event Handlers

        public void OnSwipeDown()
        {
            if (SwipeDown != null)
                SwipeDown(this, null);
            else
                SwipeDownCommand?.Execute(null);
        }

        public void OnSwipeUp()
        {
            if (SwipeUp != null)
                SwipeUp(this, null);
            else
                SwipeUpCommand?.Execute(null);
        }

        public void OnSwipeLeft()
        {
            if (SwipeLeft != null)
                SwipeLeft(this, null);
            else
                SwipeLeftCommand?.Execute(null);
        }

        public void OnSwipeRight()
        {
            if (SwipeRight != null)
                SwipeRight(this, null);
            else
                SwipeRightCommand?.Execute(null);
        }

        public void OnTapped()
        {
            if (Tapped != null)
                Tapped(this, null);
            else
                TappedCommand?.Execute(null);
        }

        public void OnLongPressed()
        {
            if (LongPressed != null)
                LongPressed(this, null);
            else
                LongPressedCommand?.Execute(null);
        }

        #endregion
    }
}

