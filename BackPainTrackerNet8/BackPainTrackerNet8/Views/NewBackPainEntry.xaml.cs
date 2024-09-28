using BackPainTrackerNet8.ViewModels;

namespace BackPainTrackerNet8.Views;

public partial class NewBackPainEntry : ContentPage
{
    public NewBackPainEntry()
    {
        InitializeComponent();
        BindingContext = new NewBackPainEntryViewModel();
    }
}