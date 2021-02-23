using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacija
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Stranica2 : ContentPage
    {
        int i = 0;
        private  Stranica2()
        {
            InitializeComponent();

            slike.Source = ImageSource.FromResource(string.Format($"Aplikacija.Slike.slika{i}"));

        }

        private void Tipka_Clicked(object sender, EventArgs e)
        {
            
            
        }
    }
}