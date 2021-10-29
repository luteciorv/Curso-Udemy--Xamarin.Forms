using System;
using Xamarin.Forms;

namespace AppQuantidade
{
    public partial class MainPage : ContentPage
    {
        private int _amount = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Increase(object sender, EventArgs e)
        {
            _amount++;

            lblAmount.Text = _amount.ToString();
        }

        private void Decrease(object sender, EventArgs e)
        {
            if(_amount <= 0) { return; }

            _amount--;

            lblAmount.Text = _amount.ToString();
        }
    }
}
