namespace GitTags.Package
{
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;

    using static PackageGuids;
    using static Vsix;


    [InstalledProductRegistration("110", "112", Version, IconResourceID = 400)]
    [Guid(PackageString)]

    public sealed class Package
    {
    }
}