using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;
namespace HelloMaui;
public class MainPage : BaseContentPage
{
    const int imageWidthRequest = 500;
    const int imageHeightRequest = 250;
    const int labelHeightRequest = 32;
    const int absoluteLayoutChildrenSpacing = 12;
    public MainPage()
    {
        BackgroundColor = Colors.DarkViolet;
        Content = new ScrollView
        {
            Content = new Grid
            {
                RowDefinitions = Rows.Define(
                    (Row.Image, Star),
                    (Row.Label, 32),
                    (Row.Entry, 40),
                    (Row.LargeTextEntry, 500)),

                ColumnDefinitions = Columns.Define(
                    (Column.Entry1, Star),
                    (Column.Entry2, Star),
                    (Column.Entry3, Star)),

                RowSpacing = 12,
                ColumnSpacing = 12,

                BackgroundColor = Colors.LightSteelBlue,
                Children =
                {
                    new Image()
                    .Size(imageWidthRequest , imageHeightRequest)
                    .Aspect(Aspect.AspectFit)
                    .Source("appicon")
                    .Row(Row.Image)
                    .ColumnSpan(All<Column>()),

                    new Label()
                    .Text("Hello MAUI", Colors.Black)
                    .Height(labelHeightRequest)
                    .Center()
                    .TextCenter()
                    .Row(Row.Label)
                    .ColumnSpan(All<Column>()),

                     new Entry()
                            .Placeholder("First Entry", Colors.DarkGray)
                            .TextColor(Colors.Black)
                            .Row(Row.Entry)
                            .Column(Column.Entry1),

                     new Entry()
                            .Placeholder("First Entry", Colors.DarkGray)
                            .TextColor(Colors.Black)
                            .Row(Row.Entry)
                            .Column(Column.Entry2),

                     new Entry()
                            .Placeholder("First Entry", Colors.DarkGray)
                            .TextColor(Colors.Black)
                            .Row(Row.Entry)
                            .Column(Column.Entry3),

                     new Label{LineBreakMode = LineBreakMode.WordWrap}
                            .Text("LARGE Text", Colors.Black)
                            .TextCenter()
                            .FontSize(100)
                            .Row(Row.LargeTextEntry).ColumnSpan(All<Column>())
                } 
            }.Top().CenterHorizontal()
        };
    }
        
    enum Row { Image, Label, Entry , LargeTextEntry}
    enum Column { Entry1, Entry2, Entry3 }
}
