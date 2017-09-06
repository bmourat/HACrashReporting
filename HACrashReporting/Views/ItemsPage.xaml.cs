using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HACrashReporting
{
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
        }
		void CrashMeClicked(object sender, EventArgs e)
		{
			int x = 0;
			x = 4 / x;
		}
    }
}
