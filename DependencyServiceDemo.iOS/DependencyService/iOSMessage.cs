using System;
using DependencyServiceDemo.DependencyServices;
using DependencyServiceDemo.iOS.DependencyService;
using Xamarin.Forms;

[assembly: Dependency(typeof(iOSMessage))]
namespace DependencyServiceDemo.iOS.DependencyService
{
    public class iOSMessage : IPlataformMesage
    {
        public iOSMessage()
        {
        }

        public string GetMessage()
        {
            return "Estoy en iOS";
        }
    }
}
