using Xamarin.Forms;

namespace LinqSample001
{
    public partial class LinqSamplePage008 : ContentPage
    {
        /*public SQLiteSamplePage007()
        {
            InitializeComponent();
            var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, Margin = new Thickness { Top = 100 } };
            //Userテーブルに適当なデータを追加する
            UserModel007.insertUser("鈴木");
            UserModel007.insertUser("田中");
            UserModel007.insertUser("斎藤");
            //Userテーブルの行データを取得
            var query = UserModel007.selectUser();
            foreach (var user in query)
            {
                //Userテーブルの名前列をLabelに書き出す
                layout.Children.Add(new Label { Text = user.Name });
            }
            Content = layout;
        }*///おかしくなったら下のソース消してこれのコメントアウトを解呪する!

        public LinqSamplePage008()
        {
            InitializeComponent();

            var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, Margin = new Thickness { Top = 100 } };

            //Userテーブルに適当なデータを追加する
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

            /*
            button.Clicked += delegate
            {
                var query = UserModel008.selectUser();

                foreach (var user in query)
                {

                    //Userテーブルの名前列をLabelに書き出す
                    layout.Children.Add(new Label { Text = user.Name });
                }
            };

            /*var buttonAdd = new Button
            {
                WidthRequest = 60,
                TextColor = Color.White,
                Text = "Add"
            };

            layout.Children.Add(buttonAdd);
            

            //Userテーブルの行データを取得
            var query = UserModel008.selectUser();

            foreach (var user in query)
            {

                //Userテーブルの名前列をLabelに書き出す
                layout.Children.Add(new Label { Text = user.Name });
            }
            */

            Content = layout;
        }



    }
}