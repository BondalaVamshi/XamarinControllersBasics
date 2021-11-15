using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheSliderXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyView : ContentPage
    {
        public MyView()
        {
            


            Label greeting = new Label();
            greeting.Text = "Greetings,from xamarin!";
            this.Content = greeting;

            Content = new Label
            {
                Text = "this is content label"
            };
            InitializeComponent();
            Label welCome = new Label();
            welCome.Text = "Welcome to xamarin view";
            this.Content = welCome;

#if __ios__
             padding = new thickness(0, 20, 0, 0);
#endif
            Content = new Label
            {
                //Text align is not prefforred because by this this label will occupy total page,using LayoutOptions is best.
                //HorizontalTextAlignment = TextAlignment.Center,
                //VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text =
                     "Mr. Sherlock Holmes, who was usually very late in " +
                     "the mornings, save upon those not infrequent " +
                     "occasions when he was up all night, was seated at " +
                     "the breakfast table. I stood upon the hearth-rug " +
                     "and picked up the stick which our visitor had left " +
                     "behind him the night before. It was a fine, thick " +
                     "piece of wood, bulbous-headed, of the sort which " +
                     "is known as a \u201CPenang lawyer.\u201D Just " +
                     "under the head was a broad silver band, nearly an " +
                     "inch across, \u201CTo James Mortimer, M.R.C.S., " +
                     "from his friends of the C.C.H.,\u201D was engraved " +
                     "upon it, with the date \u201C1884.\u201D It was " +
                     "just such a stick as the old-fashioned family " +
                     "practitioner used to carry\u2014dignified, solid, " +
                     "\n"+
                     "\n" +
                     "and reassuring.",
                     BackgroundColor = Color.Yellow,
                    TextColor = Color.Blue,
                    FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

           

        }
    }
}