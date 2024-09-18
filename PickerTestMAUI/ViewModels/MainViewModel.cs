using CommunityToolkit.Mvvm.ComponentModel;

namespace PickerTestMAUI.ViewModels
{
    public partial class MainViewModel:ObservableObject
    {
        [ObservableProperty]
        public List<string> names =
        [
           "Alexander",
            "Luis",
            "Miguel",
            "Javier",
            "Carlos",
            "Juan",
            "Pedro",
            "Jose",
            "Ricardo",
            "Fernando",
            "Jorge",
            "Alberto",
        ];
    }
}
