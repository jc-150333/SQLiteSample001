using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LinqSample001
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, Margin = new Thickness { Top = 100 } };

            //Userテーブルに適当なデータを追加する!
            UserModel008.insertUser("鈴木");
            UserModel008.insertUser("田中");
            UserModel008.insertUser("斎藤");

            var button = new Button { Text = "Load" };

            var content = new ContentPage
            {
                Title = "SQLite",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        button
                    }
                },
            };
        }
    }
}
