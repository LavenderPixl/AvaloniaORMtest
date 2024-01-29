using System.Text.RegularExpressions;
using AvaloniaORMtest.Views;

using ReactiveUI;

namespace AvaloniaORMtest.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    // private ViewModelBase currentView = new CreateGroupViewModel();
    private GroupContext db = new GroupContext();     
    public CreateGroupViewModel GroupVm { get; set; } = new();
    public CreateUserViewModel UserVm { get; set; } = new();
    // public ViewModelBase CurrentView
    // {
    //     get => currentView;
    //     set => this.RaiseAndSetIfChanged(ref currentView, value, nameof(CurrentView));
    // }

    public string Greeting => db.DbPath;

    // public void OpenCreateGroupWindow()
    // {
    //     CurrentView = new CreateGroupViewModel();
    // }
    //
    // public void OpenCreateUserWindow()
    // {
    //     CurrentView = new CreateUserViewModel();
    // }

    // public void ViewAllGroups()
    // {
    //     
    // }
}