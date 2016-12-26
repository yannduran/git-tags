using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;
using System;

namespace GitTags.Package
{
    using YD.Framework.VisualStudio.Packages;

    using static PackageGuids;
    using static Vsix;

    [InstalledProductRegistration("110", "112", Version, IconResourceID = 400)]
    [Guid(PackageGuidString)]

    public sealed class PackageClass : PackageBase
    {
        public PackageClass() : base(PackageCommandSet, Name, Description)
        { }

        protected override void Initialize()
        {
            base.Initialize();
        }
    }
}