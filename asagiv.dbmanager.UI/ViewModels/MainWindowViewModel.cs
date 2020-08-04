using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;
using asagiv.dbmanager.babythankyounotes;
using Avalonia.Threading;
using DynamicData;
using DynamicData.Binding;
using Microsoft.EntityFrameworkCore;
using ReactiveUI;

namespace asagiv.dbmanager.UI.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        #region Fields
        private MainDbContext _dbContext;
        private ObservableCollection<People> _people;
        private IDisposable _peopleChangedDisposable;
        private Subject<Unit> _peopleChangedSubject;
        #endregion

        #region Properties
        public ObservableCollection<People> people
        {
            get => _people;
            set => this.RaiseAndSetIfChanged(ref _people, value);
        }
        #endregion

        #region Constructor
        public MainWindowViewModel()
        {
            _dbContext = new MainDbContext();

            _peopleChangedDisposable = this.WhenPropertyChanged(x => x.people).Subscribe(async x => await propChangedAsync(x));
            _peopleChangedSubject = new Subject<Unit>();
            _peopleChangedSubject.Subscribe(propChangedCompleted);

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            people = new ObservableCollection<People>();
        }
        #endregion

        #region Methods
        private async Task propChangedAsync(PropertyValue<MainWindowViewModel, ObservableCollection<People>> obj)
        {
            if(people == null) return;

            var peopleToAdd = await _dbContext.People.ToListAsync();

            foreach (var person in peopleToAdd)
                people.Add(person);

            _peopleChangedSubject.OnNext(Unit.Default);
        }

        private void propChangedCompleted(Unit _)
        {
            Console.WriteLine("Done!");
        }
        #endregion
    }
}
