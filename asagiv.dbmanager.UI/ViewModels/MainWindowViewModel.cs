using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Windows.Input;
using asagiv.dbmanager.babythankyounotes;
using DynamicData;
using Microsoft.EntityFrameworkCore;
using ReactiveUI;

namespace asagiv.dbmanager.UI.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        #region Fields
        private MainDbContext _dbContext;
        private ObservableCollection<People> _people;
        #endregion

        #region Properties
        public ObservableCollection<People> people
        {
            get => _people;
            set => this.RaiseAndSetIfChanged(ref _people, value);
        }
        #endregion

        #region Commands
        public ICommand clickCommand { get; set; }
        #endregion

        #region Constructor
        public MainWindowViewModel()
        {
            _dbContext = new MainDbContext();
            people = new ObservableCollection<People>();
        }
        #endregion

        #region Methods
        public async Task initializeAsync()
        {
            var peopleToAdd = await _dbContext.People.ToListAsync();

            foreach (var person in peopleToAdd)
                people.Add(person);
        }
        #endregion
    }
}
