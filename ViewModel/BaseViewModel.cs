using CommunityToolkit.Mvvm.ComponentModel;

namespace Frontend.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool _isBusy;
  
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotError))]
    bool _isError;

    [ObservableProperty] private string _title = string.Empty;

    public bool IsNotBusy => !IsBusy;
    public bool IsNotError => !IsError;
}