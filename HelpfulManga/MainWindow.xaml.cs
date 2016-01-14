using System;
using System.IO;
using System.Windows;
using iHelpfulEngine;
using iHelpfulEngine.Collection;

namespace HelpfulManga
{
    public partial class MainWindow : Window
    {
        dialogAddURL dialogURL = new dialogAddURL();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AppMain_Loaded(object sender, RoutedEventArgs e)
        {
            Point Desktop = new Point(SystemParameters.WorkArea.Width, SystemParameters.WorkArea.Height);
            this.Left = 10;
            this.Top = Desktop.Y - (this.Height + 10);
            this.Topmost = false;

            RequestBuilder nipp = new RequestBuilder("http://www.nipponanime.net/forum/nisekoi/(one-shot)-nisekoi-ch-0-(lightning)/");
           txtTest.Text = XHR.Connect(nipp).ToString();

            nipp = new RequestBuilder("http://upic.me/i/f1/7bx12.jpg");
            nipp.Referer = "http://www.nipponanime.net/forum/nisekoi";
            XHR c = new XHR(nipp);
            ResponseBuilder a = new ResponseBuilder();
            do
            {
                //File.WriteAllBytes("C:\\Users\\HaKko\\Desktop\\"+Path.GetRandomFileName() +".txt", c.ReceiveByte());
                Console.WriteLine(XHR.BytesPerSecond(c.ReceivedData));
            } while (c.ReceivedData > 0);
        }

        private void AppMain_Closed(object sender, EventArgs e)
        {

        }

        private void AppMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dialogURL.ShowDialog();
        }
    }
}
