using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.WindowsAzure.MobileServices.Sync;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Storage_management_System
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrederPage : Page
    {
        public OrederPage()
        {
            this.InitializeComponent();
        }

       


       
        private void Order_List_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Back_click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GoodsManagementPage));
        }
    }

}

