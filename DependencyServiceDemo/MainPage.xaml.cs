using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyServiceDemo.DependencyServices;
using Xamarin.Forms;

namespace DependencyServiceDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(System.Object sender, EventArgs e)
        {
            var service = DependencyService.Get<IPlataformMesage>();
            var message = service.GetMessage();
            await DisplayAlert("Service ", message, "OK");
        }

        private async void TexToSpeach_OnClicked(System.Object sender, System.EventArgs e)
        {
            var service = DependencyService.Get<ITextToSpeech>();
            service.speak("Hola desde Xamarin");
        }
    }
}
