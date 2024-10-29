using FacturaReminder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FacturaReminder.MVVM.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand TasksViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public TasksViewModel TasksVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        private Visibility _searchVisibility;

        public Visibility SearchVisibility
        {
            get { return _searchVisibility; }
            set 
            { 
                _searchVisibility = value;
                OnPropertyChanged();
            }
        }



        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            TasksVM = new TasksViewModel();
            CurrentView = HomeVM;
            SearchVisibility = Visibility.Collapsed;

            HomeViewCommand = new RelayCommand(o =>
            {
                SearchVisibility = Visibility.Collapsed;
                CurrentView = HomeVM;
            });

            TasksViewCommand = new RelayCommand(o =>
            {
                SearchVisibility = Visibility.Visible;
                CurrentView = TasksVM;
            });
        }
    }
}
