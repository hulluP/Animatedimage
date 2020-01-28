using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AnimatedImage
{
    public class ScrollView : ContentPage
    {

        private Color COLOR_SCHEME_COLOR_2 = Color.White;
        private CollectionXModel PageModel;
        private StackLayout _VerticallViewStack;
        private ListView ListView;

        public ScrollView()

        {

            PageModel = new CollectionXModel();
            PageModel.LoadMoreResults();
        }

        public Page GetMainPage()
        {

            ListView = new ListView()
            {

            };
            ListView.SeparatorVisibility = SeparatorVisibility.None;
            ListView.ItemsSource = PageModel.ViewImages;
            ListView.ItemSelected += listSelection;
            ListView.ItemTemplate = new DataTemplate(typeof(CustomCell));

            Content = ListView;
            return this;
        }

        private void listSelection(object sender, SelectedItemChangedEventArgs e)
        {
            ListView.ItemSelected -= listSelection;
            Navigation.PopAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (PageModel != null)
            {
                PageModel.Dispose();
            }
            //BindingContext = null; 
            //ImageCollectionView.RemoveBinding(ItemsView.ItemsSourceProperty);
            //ImageCollectionView.SelectionChanged -= OnCollectionViewSelectionChanged;
        }

        public class CustomCell : ViewCell
        {
            public CustomCell()
            {


                var listImage = new Image
                {
                    BackgroundColor = Color.Gray,
                    HorizontalOptions = LayoutOptions.EndAndExpand,
                    IsAnimationPlaying = true
                };
                listImage.SetBinding(Image.SourceProperty, new Binding("ImageSource"));


                View = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    Padding = new Thickness(15, 5, 5, 15),
                    Children = {
                          listImage
                }
                };
            }
        }
    }
}