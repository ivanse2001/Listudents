using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace pasarLista
{
    public partial class PaginaListaProfesor : ContentPage
    {
        Asignatura a = new Asignatura();
        public PaginaListaProfesor(Asignatura asignatura)
        {
            InitializeComponent();
            a = asignatura;
            
            //

            ListView listView = new ListView
            {
                RowHeight = 90,
                // Source of data items.
                ItemsSource = a.misAlumnosEnAsignatura,
                
                // Define template for displaying each item.
                // (Argument of DataTemplate constructor is called for 
                //      each item; it must return a Cell derivative.)
                ItemTemplate = new DataTemplate(() =>
                {
                    // Create views with bindings for displaying each property.
                    Label nameLabel = new Label();
                    nameLabel.SetBinding(Label.TextProperty, "Nombre");
                    nameLabel.FontSize = 18;
                    nameLabel.TextColor = Color.Black;
                    nameLabel.Margin = new Thickness(10, 0, 4, 0);
                    Label apellidosLabel = new Label();
                    apellidosLabel.FontSize = 16;
                    apellidosLabel.Margin = new Thickness(10, 0, 4, 0);
                    apellidosLabel.SetBinding(Label.TextProperty, "Apellidos");
                    apellidosLabel.TextColor = Color.Black;

                    
                    BoxView boxView = new BoxView();
                    boxView.SetBinding(BoxView.ColorProperty, "Color");
                    boxView.Margin = new Thickness(5, 0, 0, 0);
                    boxView.CornerRadius = 20;
                    boxView.Scale = 0.54;

                    // Return an assembled ViewCell.
                    return new ViewCell
                    {
                        
                        Height = 1.5,
                        View = new StackLayout
                        {
                            Padding = new Thickness(1, 2),
                            Orientation = StackOrientation.Horizontal,
                            
                            Children =
                                {
                                    boxView,
                                    new StackLayout
                                    {
                                        
                                        VerticalOptions = LayoutOptions.Center,
                                        Spacing = 0,
                                        Children =
                                        {
                                            nameLabel,
                                            apellidosLabel
                                        }
                                        }
                                }
                        }
                    };
                })
            };

            this.Content = new StackLayout
            {

                 Children =
                {
                    listView
                }

            };
            

        }

       

        
    }

    
}

