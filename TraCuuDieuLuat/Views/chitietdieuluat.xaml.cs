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
    public partial class chitietdieuluat : ContentPage
    {
        Models.dieuluat _dluat;
        public chitietdieuluat(Models.dieuluat dluat)
        {
            InitializeComponent();
            
            _dluat = dluat;
            Chuong.Text = _dluat.Chuong;
            NDChuong.Text = _dluat.NDChuong;
            Dieu.Text = _dluat.Dieu;
            NDDieu.Text = _dluat.NDDieu;
            Khoan.Text = _dluat.Khoan;
            NDKhoan.Text = _dluat.NDKhoan;
            phatduoi.Text = _dluat.Phatduoi;
            phattren.Text = _dluat.Phattren;
        }
    }
}