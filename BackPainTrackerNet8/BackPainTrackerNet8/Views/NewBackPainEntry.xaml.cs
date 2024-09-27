using BackPainTrackerNet8.Models;

namespace BackPainTrackerNet8.Views;

public partial class NewBackPainEntry : ContentPage
{

    public NewBackPainEntry()
    {
        InitializeComponent();

    }

    private void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var parentTabbedPage = this.Parent as TabbedPage;

        var newEntry = new BackPainEntry
        {
            Date = DatePickerEntry.Date,
            PainLevel = (int)PainSlider.Value,
            Notes = NotesEditor.Text
        };

        PainSlider.Value = 5;
        NotesEditor.Text = string.Empty;

        parentTabbedPage.CurrentPage = parentTabbedPage.Children[0];
    }
}