using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Storage_management_System
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuPage : Page
    {


        private ObservableCollection<MenuItem> menuitems;
        public ObservableCollection<MenuItem> MenuItems
        {
            get {
                return menuitems;
            }
            set
            {
                menuitems = value; 
            }
        }


        public Addr calc = new Addr();
        public MenuPage()
        {
            this.InitializeComponent();
            menuitems = MenuItem.MenuList();
            this.DataContext = MenuItems;
            this.DataContext = calc;
        }
        private void tblAnswer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public class Addr : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            public int putS1;
            public int PutS1
            {
                get { return putS1; }
                set
                {
                    putS1 = value;
                    if (PropertyChanged != null)
                    {
                        //raise the property changed event handler
                        PropertyChanged(this, new PropertyChangedEventArgs("TotalPrice"));
                    }
                }
            }

            public int TotalPrice
            {
             


                get{
                    if (putS1 == 1)
                    {
                        return 8;
                    }
                    else if (putS1 == 2)
                    {
                        return 7;
                    }
                    else if (putS1 == 3)
                    {
                        return 9;
                    }
                    else if (putS1 == 4)
                    {
                        return 10;
                    }
                    else if (putS1 == 5)
                    {
                        return 3;
                    }
                    
                    return 0 ; }
            }
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowMessageDialog();

        }

        private async void ShowMessageDialog()
        {
            var msgDialog = new Windows.UI.Popups.MessageDialog("Send this order?") { Title = "Make sure the Order" };
            msgDialog.Commands.Add(new Windows.UI.Popups.UICommand("OK", uiCommand => { this.tb.Text = $"Your orde has send"; }));
            msgDialog.Commands.Add(new Windows.UI.Popups.UICommand("Cancel", uiCommand => { this.tb.Text = $"pick food again"; }));
            await msgDialog.ShowAsync();
        }
    }

}
