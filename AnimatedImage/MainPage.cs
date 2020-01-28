using System;
using Xamarin.Forms;


namespace AnimatedImage

{
    public class MainPage : ContentPage
    {
        private Label Counter;
        private Label InitialCounter;

        public MainPage()
        {
            StackLayout contentView = new StackLayout();

            Button showNormalList = new Button()
            {
                Text = "List"
            };
            InitialCounter = new Label()
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "---"
            };
            Counter = new Label()
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "---"
            };
            showNormalList.Clicked += ShowNormalList_Clicked;

            contentView.Children.Add(showNormalList);

            contentView.Children.Add(InitialCounter);
            contentView.Children.Add(Counter);
            Content = contentView;
        }


        private void ShowNormalList_Clicked(object sender, EventArgs e)
        {
            ScrollView page = new ScrollView();
            Navigation.PushAsync(page.GetMainPage());
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Counter.Text = "Total Memory:" + GC.GetTotalMemory(false);
            if (InitialCounter.Text.Length < 5)
            {
                InitialCounter.Text = "inital Memory:" + GC.GetTotalMemory(false);
            }

        }

    }
}
