using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TraCuuDieuLuat.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class themdieuluat : ContentPage
    {
        public themdieuluat()
        {
            InitializeComponent();
        }
        Models.dieuluat _dluat;
        public themdieuluat(Models.dieuluat dluat)
        {
            InitializeComponent();
            Title = " Sửa điều luật";
            _dluat = dluat;
            Chuong.Text = _dluat.Chuong;
            NDChuong.Text = _dluat.NDChuong;
            Dieu.Text = _dluat.Dieu;
            NDDieu.Text= _dluat.NDDieu;
            Khoan.Text = _dluat.Khoan;
            NDKhoan.Text = _dluat.NDKhoan;
            Phatduoi.Text = _dluat.Phatduoi;
            Phattren.Text = _dluat.Phattren;
            Chuong.Focus();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NDKhoan.Text)|| string.IsNullOrEmpty(Khoan.Text) || string.IsNullOrEmpty(Dieu.Text))
            {
                await DisplayAlert("Thông báo", "Nhập thiếu thông tin", "Nhập tiếp");
            }else if (_dluat !=null)
            {
                Suadieuluat();
            }
            else
                Themdieuluat();
        }
        async void Themdieuluat()
        {
            await App.mydatabase.Taodieuluat(new Models.dieuluat
            {
                Chuong = Chuong.Text,
                NDChuong = NDChuong.Text,
                Dieu = Dieu.Text,
                NDDieu = NDDieu.Text,
                Khoan = Khoan.Text,
                NDKhoan = NDKhoan.Text,
                Phatduoi = Phatduoi.Text,
                Phattren = Phattren.Text,
            });
            await Navigation.PopAsync();
        }
        async void Suadieuluat()
        {
            _dluat.Chuong = Chuong.Text;
            _dluat.NDChuong = NDChuong.Text;
            _dluat.Dieu = Dieu.Text;
            _dluat.NDDieu = NDDieu.Text;
            _dluat.Khoan = Khoan.Text;
            _dluat.NDKhoan= NDKhoan.Text;
            _dluat.Phatduoi= Phatduoi.Text;
            _dluat.Phattren= Phattren.Text;
            await App.mydatabase.Suadieuluat(_dluat);
            await Navigation.PopAsync();
        }
    }
}