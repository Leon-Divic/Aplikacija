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
    public partial class Stranica1 : ContentPage
    {
        public Stranica1()
        {
            InitializeComponent();
            Lista.ItemsSource = new List<klasa>
            {
                new klasa {ime = "FC Bayern München", status="Allianz Arena", image="bayern.png"},
                new klasa{ime = "Borussia Dortmund", status="SIGNAL IDUNA PARK", image="borusia.png"},
                new klasa {ime = "RB Leipzig", status="Red Bull Arena",image="Leipzig.png"},
                new klasa {ime = "Borussia Mönchengladbach", status="Borrusia Park", image="monchengl.png"},
                new klasa {ime = "Bayer 04 Leverkusen", status="Bay Arena", image="keverkusen.png"},
                new klasa {ime = "TSG Hoffenheim", status="PreZero Arena", image="hoffenheim.png"},
                new klasa {ime = "VfL Wolfsburg", status="Volkswagen Arena", image="wolfsburg.png"},
                new klasa {ime = "Sport-Club Freiburg", status="Schwarzwald-Stadion", image="freiburg.png"},
                new klasa {ime = "Eintracht Frankfurt", status="Deutsche Bank Park", image="frankfurt.png"},
                new klasa {ime = "Hertha Berlin", status="Olympiastadion", image="hertha.png"},
                new klasa {ime = "1. FC Union Berlin", status="An der Alten Försterei", image="union.png"},
                new klasa {ime = "FC Schalke 04", status="VELTINS-Arena", image="schalke.png"},
                new klasa {ime = "1. FSV Mainz 05", status="OPEL ARENA", image="mainz.png"},
                new klasa {ime = "1. FC Köln", status="RheinEnergieSTADION", image="koln.png"},
                new klasa {ime = "FC Augsburg", status="WWK ARENA", image="augsburg.png"},
                new klasa {ime = "SV Werder Bremen", status="wohninvest WESERSTADION", image="bremen.png"},
                new klasa {ime = "DSC Arminia Bielefeld", status="SchücoArena", image="bielfield.png"},
                new klasa {ime = "VfB Stuttgart", status="Mercedes-Benz Arena", image="stuttgart.png"}
            };








        }
        public class klasa

        {

            public string ime { get; set; }
            public string status { get; set; }

            public string image { get; set; }

            

        }

   

        

        private void Slajder_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var ImageSource = new UriImageSource
            {
                Uri = new Uri("https://upload.wikimedia.org/wikipedia/hr/thumb/9/92/Njema%C4%8Dka-Bundesliga-logo.png/300px-Njema%C4%8Dka-Bundesliga-logo.png")
            };
            ImageSource.CachingEnabled = false;
            slika.Source = ImageSource;
        }
    }
}