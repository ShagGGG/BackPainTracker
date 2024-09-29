using BackPainTrackerNet8.Models;
using BackPainTrackerNet8.Services;
using System.ComponentModel;
using System.Windows.Input;

namespace BackPainTrackerNet8.ViewModels
{
    /// <summary>
    /// Viewmodel for new back pain entry
    /// </summary>
    internal class NewBackPainEntryViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Date properties
        /// </summary>
        private DateTime _date = DateTime.Now;
        public DateTime Date
        {
            get => _date;
            set
            {
                if (_date != value)
                {
                    _date = value;
                    OnPropertyChanged(nameof(Date));
                }
            }
        }

        /// <summary>
        /// Pain Level properties
        /// </summary>
        private int _painLevel = 5;
        public int PainLevel
        {
            get => _painLevel;
            set
            {
                if (_painLevel != value)
                {
                    _painLevel = value;
                    OnPropertyChanged(nameof(PainLevel));
                }
            }
        }

        /// <summary>
        /// Notes properties
        /// </summary>
        private string _notes = string.Empty;
        public string Notes
        {
            get => _notes;
            set
            {
                if (_notes != value)
                {
                    _notes = value;
                    OnPropertyChanged(nameof(Notes));
                }
            }
        }

        /// <summary>
        /// Define save command for a new Back pain entry
        /// </summary>
        public ICommand SaveCommand { get; }

        public NewBackPainEntryViewModel()
        {
            SaveCommand = new Command(ExecuteSaveCommand);
        }

        private void ExecuteSaveCommand()
        {
            var newEntry = new BackPainEntry
            {
                Date = this.Date,
                PainLevel = this.PainLevel,
                Notes = this.Notes
            };

            //TODO: Utilisation de l'API pour stocker les datas en BDD


            PainLevel = 5;
            Notes = string.Empty;

            NavigationService.Instance.NavigateToDatasTab();
        }


        /// <summary>
        /// If property changed, notify user interface
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
