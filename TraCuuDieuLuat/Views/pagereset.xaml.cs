using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TraCuuDieuLuat.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagereset : ContentPage
    {
        public pagereset()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e) {                    
            var resutl = await DisplayAlert("Cảnh báo", "Bạn có chắc chắn không ? ", "yes", "no");
            if (resutl)
            {
                SqliteConect db = new SqliteConect(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "luatlamnghiep.db3"));
                db.datlai();
                await DisplayAlert("Thông báo", "Ứng dụng của bạn đã được khôi phục cài đặt gốc !", "tiếp tục");
                _ = Navigation.PushAsync(new Homepage());
            }
        }
    }
}