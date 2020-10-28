using RoomBooking.Wpf.Common;
using RoomBooking.Wpf.ViewModels;
using System.Windows;

namespace RoomBooking.Wpf
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    public App()
    {
      WindowController controller = new WindowController();
      var mainViewModel = new MainViewModel(controller);
      controller.ShowWindow(mainViewModel, false);
      Dispatcher.Invoke(async () => await mainViewModel.InitAsync());
    }
  }
}
