using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;
using OleInterop = Microsoft.VisualStudio.OLE.Interop;
using EnvDTE;
using EnvDTE80;

namespace GitTags.Package
{
    using Options;
    using YD.Framework.VisualStudio.Packages;

    using static PackageGuids;
    using static Vsix;

    [InstalledProductRegistration("#110", "#112", Version, IconResourceID = 400)]
    [Guid(PackageGuidString)]

    [ProvideOptionPage(typeof(GeneralOptionsDialogPage), "Git Tags", "General", 0, 0, true, new[] { "Git", "Tags" })]
    public sealed class PackageClass : PackageBase
    {
        private readonly Lazy<DTE2> _dte;
        private readonly Lazy<GeneralOptionsDialogPage> _generalOptions;
        private readonly Lazy<OleInterop.IServiceProvider> _serviceProvider;

        public PackageClass() : base(PackageCommandSet, Name, Description)
        {
            _generalOptions = new Lazy<GeneralOptionsDialogPage>(() => GetDialogPage<GeneralOptionsDialogPage>(), true);
            _dte = new Lazy<DTE2>(() => GetGlobalService<DTE, DTE2>());
            _serviceProvider = new Lazy<OleInterop.IServiceProvider>(() => GetGlobalService<OleInterop.IServiceProvider, OleInterop.IServiceProvider>());
        }

        protected override void Initialize()
        {

            base.Initialize();
        }
    }
}