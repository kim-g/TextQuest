using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PhoneQuest
{
	public class StartPage : ContentPage
	{


        public StartPage() => Content = new StackLayout
        {
            Children = {
                    new StackLayout
                    {
                        Children =
                        {
                            new Label
                            {
                                Text = "Панель вопросов",
                                HorizontalTextAlignment = TextAlignment.Center,
                                VerticalTextAlignment = TextAlignment.Center
                                
                            }
                        },
                        VerticalOptions = LayoutOptions.FillAndExpand
                    },

                    new StackLayout
                    {
                        Children =
                        {
                            new Label { Text = "Панель ответов" }
                        },
                        VerticalOptions = LayoutOptions.End

                    }

                }
        };
    }
}