namespace BackPainTrackerNet8.Services
{
    public class NavigationService : INavigationService
    {
        private static NavigationService? _instance;
        public static NavigationService Instance => _instance ??= new NavigationService();

        private NavigationService() { }

        public void NavigateToDatasTab()
        {
            if (Application.Current!.MainPage is TabbedPage tabbedPage)
            {
                tabbedPage.CurrentPage = tabbedPage.Children[0];
            }
        }
    }
}
