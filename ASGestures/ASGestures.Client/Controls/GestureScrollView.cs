using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace ASGestures.Client.Controls
{
    public class GestureScrollView : ScrollView
    {
        public GestureScrollView()
        {
            
        }

        #region Events
        
        public event EventHandler ScrollUp;
        public event EventHandler ScrollDown;
        public event EventHandler SwipeLeft;
        public event EventHandler SwipeRight;

        #endregion

        #region Commands

        public ICommand ScrollUpCommand
        {
            get { return (ICommand)GetValue(ScrollUpCommandProperty); }
            set { SetValue(ScrollUpCommandProperty, value); }
        }

        public static readonly BindableProperty ScrollUpCommandProperty = BindableProperty.Create(
            "ScrollUpCommand", typeof(ICommand), typeof(GestureFrame));

        public ICommand ScrollDownCommand
        {
            get { return (ICommand)GetValue(ScrollDownCommandProperty); }
            set { SetValue(ScrollDownCommandProperty, value); }
        }
        
        public static readonly BindableProperty ScrollDownCommandProperty = BindableProperty.Create(
            "ScrollDownCommand", typeof(ICommand), typeof(GestureFrame));

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

        #endregion

        #region Event Handlers

        public void OnScrollUp()
        {
            if (ScrollUp != null)
                ScrollUp(this, null);
            else
                ScrollUpCommand?.Execute(null);
        }

        public void OnScrollDown()
        {
            if (ScrollDown != null)
                ScrollDown(this, null);
            else
                ScrollDownCommand?.Execute(null);
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
        #endregion
    }
}
