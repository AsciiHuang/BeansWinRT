using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ApplicationSettings;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 使用者控制項項目範本已記錄在 http://go.microsoft.com/fwlink/?LinkId=234236

namespace Beans
{
    // 自訂設定頁面參考自 http://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh872190.aspx
    public sealed partial class OptionsPage : UserControl
    {
        public delegate void OptionPageEventHandler();
        public event OptionPageEventHandler OnOptionPageModeEvent = null;
        public event OptionPageEventHandler OnOptionPageMusicEvent = null;
        public event OptionPageEventHandler OnOptionPagePathModeEvent = null;

        public OptionsPage()
        {
            this.InitializeComponent();

            int mBeansMaxCount = Utility.GetKeyValue(Constants.BEANS_SETTING_GAME_MODE, Constants.BEANS_COUNT_HARD);
            SwitchEasyMode.IsOn = (mBeansMaxCount == Constants.BEANS_COUNT_EASY);

            int nBGMusicValue = Utility.GetKeyValue(Constants.BEANS_SETTING_PLAY_BACKGROUNDMUSIC, 1);
            Boolean bBGMusicValid = nBGMusicValue == 1;
            SwitchBGMusic.IsOn = bBGMusicValid;
            SwitchStupid.IsOn = Utility.IsStupidMode();

            int nHardModeScore = Utility.GetKeyValue(Constants.BEANS_SETTING_HARDMODE_SCORE, 0);
            int nEasyModeScore = Utility.GetKeyValue(Constants.BEANS_SETTING_EASYMODE_SCORE, 0);
            lblHardModeScore.Text = nHardModeScore.ToString();
            lblEasyModeScore.Text = nEasyModeScore.ToString();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (this.Parent.GetType() == typeof(Popup))
            {
                Popup popup = this.Parent as Popup;
                if (popup != null)
                {
                    popup.IsOpen = false;
                }
            }
            SettingsPane.Show();
        }

        private void OnSwitchEasyModeToggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch ts = (ToggleSwitch)sender;
            Boolean IsOn = ts.IsOn;
            if (IsOn)
            {
                Utility.SetKeyValue(Constants.BEANS_SETTING_GAME_MODE, Constants.BEANS_COUNT_EASY);
            }
            else
            {
                Utility.SetKeyValue(Constants.BEANS_SETTING_GAME_MODE, Constants.BEANS_COUNT_HARD);
            }

            if (OnOptionPageModeEvent != null)
            {
                OnOptionPageModeEvent();
            }
        }

        private void OnSwitchBGMusicToggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch ts = (ToggleSwitch)sender;
            Boolean IsOn = ts.IsOn;
            if (IsOn)
            {
                Utility.SetKeyValue(Constants.BEANS_SETTING_PLAY_BACKGROUNDMUSIC, 1);
            }
            else
            {
                Utility.SetKeyValue(Constants.BEANS_SETTING_PLAY_BACKGROUNDMUSIC, 0);
            }

            if (OnOptionPageMusicEvent != null)
            {
                OnOptionPageMusicEvent();
            }
        }

        private void OnSwitchStupidToggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch ts = (ToggleSwitch)sender;
            Boolean IsOn = ts.IsOn;
            if (IsOn)
            {
                Utility.SetKeyValue(Constants.BEANS_SETTING_STUPID_MODE, 1);
            }
            else
            {
                Utility.SetKeyValue(Constants.BEANS_SETTING_STUPID_MODE, 0);
            }

            if (OnOptionPagePathModeEvent != null)
            {
                OnOptionPagePathModeEvent();
            }
        }
    }
}
