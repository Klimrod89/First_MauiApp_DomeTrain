using CommunityToolkit.Maui.Markup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMaui;
public class MainPage : ContentPage
{
    public MainPage()
    {
        Content = new Label()
            .Text("This is a Maui Label!")
            .Center()
            .TextCenter();
    }
}
