using asagiv.dbmanager.UI.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using System.Threading.Tasks;

namespace asagiv.dbmanager.UI.Views
{
    public class MainWindow : Window
    {
        #region ViewModels
        public MainWindowViewModel viewModel { get; private set; }
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.Opened += async (s,e) => await onOpenedAsync();
        }
        #endregion

        #region Methods
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private async Task onOpenedAsync()
        {
            viewModel = DataContext as MainWindowViewModel;

            await viewModel.initializeAsync();
        }
        #endregion
    }
}
