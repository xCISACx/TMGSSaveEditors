using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using TMGSSaveEditor;

namespace TMGS1SaveEditor
{
    public partial class App : Application
    {
        string projectName = "TMGS1SaveEditor";
        string windowTitle = "TMGS1 Save Editor";
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);

        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var tmgsManager = new UserSaveDataManager();

                desktop.MainWindow = new TMGSSaveEditor.Core.MainWindow(tmgsManager, projectName, windowTitle);
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}