using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraCuuDieuLuat.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TraCuuDieuLuat.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class tracuu : ContentPage
    {
        public tracuu()
        {
            InitializeComponent();
            
        }
        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                    myCollectionView.ItemsSource =  App.mydatabase.Docdieuluat();  
            }catch (Exception )
            {

            }
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new themdieuluat());
        }

        private async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var emp = item.CommandParameter as dieuluat;
            await Navigation.PushAsync(new themdieuluat(emp));
        }

        private async void SwipeItem_Invoked_1(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var emp = item.CommandParameter as dieuluat;
            var resutl = await DisplayAlert("Thông báo", $"Bạn có chắc chắn xóa {emp.Dieu} - {emp.Khoan} không ? ", "yes", "no");
            if(resutl)
            {
                await App.mydatabase.Xoadieuluat(emp);
                myCollectionView.ItemsSource =  App.mydatabase.Docdieuluat();
            }    
        }

        async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            myCollectionView.ItemsSource = await App.mydatabase.Timkiem(e.NewTextValue);
        }

        async void SwipeItem_Invoked_2(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var emp = item.CommandParameter as dieuluat;
            await Navigation.PushAsync(new chitietdieuluat(emp));
        }
    }
}