using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;
using Frontend.Model;

namespace Frontend.ViewModel;

public partial class MainPageViewModel : BaseViewModel
{
    public MainPageViewModel()
    {
        Title = "Hello World";
    }

    public ObservableCollection<Friend> Friends { get; set; } = new();

    [RelayCommand]
    public async Task GetFriendsAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;

            if (Friends.Count > 0)
            {
                Friends.Clear();
            }

            Friends.Add(new Friend()
            {
                Username = "Johnny",
                IconUrl = "https://picsum.photos/500",
                Status = "Online"
            });
            Friends.Add(new Friend()
            {
                Username = "Zedrick",
                IconUrl = "https://picsum.photos/501",
                Status = "Offline"
            });
            Friends.Add(new Friend()
            {
                Username = "Tyler",
                IconUrl = "https://picsum.photos/502",
                Status = "Online"
            });
            Friends.Add(new Friend()
            {
                Username = "Manuel",
                IconUrl = "https://picsum.photos/504",
                Status = "Online"
            });
            Friends.Add(new Friend()
            {
                Username = "Oscar",
                IconUrl = "https://picsum.photos/505",
                Status = "Online"
            });
            Friends.Add(new Friend()
            {
                Username = "Jotan",
                IconUrl = "https://picsum.photos/506",
                Status = "Online"
            });
        }
        catch (Exception ex)
        {
            Debug.WriteLine("An Exception has occurred: " + ex);
        }
        finally
        {
            IsBusy = false;
        }
    }

    [RelayCommand]
    public async Task GoToMessageAsync()
    {
        await Shell.Current.GoToAsync("//message");
    }
        
}