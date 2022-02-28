using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPToDoApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;

            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;

            Tasks tasks = new Tasks();
            tasks.TaskList.Add("AAAA", new ToDo("Task1", "Description1", Priority.Low, DateTime.Now));
            tasks.TaskList.Add("BBBB", new ToDo("Task2", "Description2", Priority.High, DateTime.Now));
            BaseExample.ItemsSource = tasks.ToList();
        }


        private void BaseExample_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListView listView = (ListView)sender;
            FlyoutShowOptions options = new FlyoutShowOptions();
            //options.Position = item.P
            options.ShowMode = FlyoutShowMode.Transient;
            ListViewCommandBarFlyout1.ShowAt(listView, options);
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog();
            dialog.Title = "Add a new Task";
            dialog.PrimaryButtonText = "Add";
            dialog.CloseButtonText = "Cancel";
            dialog.DefaultButton = ContentDialogButton.Primary;
            dialog.Content = new ToDoPage();

            var result = dialog.ShowAsync();
        }
    }
}
