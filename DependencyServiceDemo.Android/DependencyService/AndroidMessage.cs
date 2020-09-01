using System;
using DependencyServiceDemo.DependencyServices;
using DependencyServiceDemo.Droid.DependencyService;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidMessage))]

namespace DependencyServiceDemo.Droid.DependencyService
{
    public class AndroidMessage : IPlataformMesage
    {
        public AndroidMessage()
        {
        }

        public string GetMessage()
        {
            return "Yo estoy en android";
        }
    }
}
