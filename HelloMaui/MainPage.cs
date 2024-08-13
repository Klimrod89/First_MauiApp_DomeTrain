using CommunityToolkit.Maui.Markup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMaui;
public class MainPage : BaseContentPage
{
    public MainPage()
    {
        Content = new VerticalStackLayout
        {
            Children =
            {
                new Image()
                .Size(500 , 250)
                .Aspect(Aspect.AspectFit)
                .Source("appicon"),
                new Label()
                .Text("Hello MAUI", Colors.Black)
                .Center()
                .TextCenter(),
                new Entry()
                .Placeholder("Notes", Colors.DarkGray)
                .TextColor(Colors.Black)
            }
        };
    }
}
