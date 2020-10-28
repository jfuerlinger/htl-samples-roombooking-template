using RoomBooking.Wpf.Common;
using RoomBooking.Wpf.Common.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace RoomBooking.Wpf.ViewModels
{
  public class MainViewModel : BaseViewModel
  {
    public MainViewModel(IWindowController windowController) : base(windowController)
    {
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      throw new NotImplementedException();
    }

    public override async Task InitAsync()
    {
      await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
      throw new NotImplementedException();
    }
  }
}
