using Xamarin.Forms;
using MyApp.ViewModel;

namespace MyApp.Views
{
    public partial class AboutView : ContentPage
    {
        public AboutView()
        {
            BindingContext = new PersonalViewModel();
            InitializeComponent();

            //_ScrollView.SetBinding(View.)

            _ScrollView.SetBinding(View.MarginProperty, new Binding("Height", source: _nameStack, converter: new ThicknessConverter(),
                converterParameter: 1, mode: BindingMode.OneWay));
        }
    }
}
