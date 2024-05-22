using CommunityToolkit.Maui.Core;
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class MainPage : TabbedPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        public ObservableCollection<IDrawingLine> Lines { get; set; }
        


        private void OnCounterClicked(object sender, EventArgs e)
        {
            Signature.Lines.Clear();
        }
    }

}
