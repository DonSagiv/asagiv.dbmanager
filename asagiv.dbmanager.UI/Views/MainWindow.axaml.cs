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
        }
        #endregion

        #region Methods
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        protected override void OnDataContextChanged(EventArgs e)
        {
            base.OnDataContextChanged(e);

            viewModel = DataContext as MainWindowViewModel;
        }
        #endregion


    }
}
