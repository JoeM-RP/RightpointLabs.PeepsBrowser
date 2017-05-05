using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Rightpoint.Peeps.Browser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        WebView content = new WebView();
        Uri site = new Uri("http://rightpoint.com/tenyears");
        public MainPage()
        {
            this.InitializeComponent();

            var refreshTimer = new DispatcherTimer();
            refreshTimer.Tick += RefreshTimerOnTick;
            refreshTimer.Interval = new TimeSpan(0, 0, 30, 0);
            refreshTimer.Start();

            content.Source = site;

            this.Content = content;
        }

        private void RefreshTimerOnTick(object sender, object o)
        {
            content.Navigate(site);
        }
    }
}
