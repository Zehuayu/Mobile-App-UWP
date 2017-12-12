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
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Storage_management_System
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GoodsManagementPage : Page
    {



        public GoodsManagementPage()
        {
            this.InitializeComponent();
        }



        private MobileServiceCollection<GoodsInfo, GoodsInfo> items;
        


        private async void Add_Button(object sender, RoutedEventArgs e)
        {

            GoodsInfo item = new GoodsInfo
            {
                name = NameInput.Text,
                quantity = QuantityInput.Text,
                cost = CostInput.Text,
                price = PriceInput.Text,
                supplier = SupplierInput.Text
            };

            await App.MobileService.GetTable<GoodsInfo>().InsertAsync(item);


        }

        private async void Show_Table(object sender, RoutedEventArgs e)
        {
            MobileServiceInvalidOperationException exep = null;


            try
            {

                items = await App.MobileService.GetTable<GoodsInfo>().ToCollectionAsync();


            }
            catch (MobileServiceInvalidOperationException ex)
            {
                exep = ex;
            }



            if (exep == null) MylistView.DataContext = items;
        }


       // public MobileServiceClient MobileService { get; set; }
        

       // IMobileServiceSyncTable Goodstable;


        
        private async void Update_Click(object sender, RoutedEventArgs e)
        {
            GoodsInfo goods = new GoodsInfo
            {
                name = NameInput.Text,
                quantity = QuantityInput.Text,
                cost = CostInput.Text,
                price = PriceInput.Text,
                supplier = SupplierInput.Text
            };

           // IMobileServiceTable<GoodsInfo> Item = App.MobileService.GetTable<GoodsInfo>().UpdateAsync(goods);




        }

        private void Delete_click(object sender, RoutedEventArgs e)
        {
            //IMobileServiceTable<GoodsInfo> Item = App.MobileService.GetTable<GoodsInfo>().DeleteAsync();

        }

        private void to_orderList_Page(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OrederPage));
        }

        private void to_Home(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
