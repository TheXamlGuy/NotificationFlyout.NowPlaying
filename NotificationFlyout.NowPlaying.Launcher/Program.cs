using NotificationFlyout.NowPlaying.Views;
using System;
using TheXamlGuy.NotificationFlyout.Wpf.UI.Controls;

namespace NotificationFlyout.NowPlaying.Launcher
{
    public class Program
    {
        [STAThread()]
        public static void Main()
        {
            using (new NowPlaying.App())
            {
                var app = new App();
                new NotificationFlyoutApplication
                {
                    Flyout = new NowPlayingFlyout()
                };
                app.Run();
            }
        }
    }
}
