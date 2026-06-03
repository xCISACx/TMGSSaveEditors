using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using TMGSSaveEditor;

namespace TMGS4SaveEditor
{
    public partial class App : Application
    {
        string projectName = "TMGS4SaveEditor";
        string windowTitle = "TMGS4 Save Editor";
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