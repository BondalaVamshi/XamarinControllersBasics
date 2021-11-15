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
    public partial class VariableFormattedTextPage : ContentPage
    {
        public VariableFormattedTextPage()
        {
            FormattedString formattedString = new FormattedString();
            formattedString.Spans.Add(new Span
            {
                Text = "I "
            });
            formattedString.Spans.Add(new Span
            {
                Text = "love",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            });
            formattedString.Spans.Add(new Span
            {
                Text = " Xamarin.Forms!"
            });
            Content = new Label
            {
                FormattedText = formattedString,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            var colors = new[]
             {
             new { value = Color.White, name = "White" },
             new { value = Color.Silver, name = "Silver" },
             new { value = Color.Gray, name = "Gray" },
             new { value = Color.Black, name = "Black" },
             new { value = Color.Red, name = "Red" }
             };
            StackLayout stackLayout = new StackLayout();
            foreach (var color in colors)
            {
                stackLayout.Children.Add(
                new Label
                {
                    Text = color.name,
                    TextColor = color.value,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                });
            }

            Content = stackLayout;

        }
    }
}