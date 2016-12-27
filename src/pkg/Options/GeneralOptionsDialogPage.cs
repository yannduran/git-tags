using Microsoft.VisualStudio.Shell;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace GitTags.Package.Options
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]

    public class GeneralOptionsDialogPage : DialogPage
    {
        [Category("Git Tags")]
        [DisplayName("Enabled")]
        [Description("Determines whether the Git Tags functionality is enabled or disabled")]

        public bool Enabled { get; set; }

        public override void LoadSettingsFromStorage()
        {
            Enabled = true;

            base.LoadSettingsFromStorage();
        }
    }
}