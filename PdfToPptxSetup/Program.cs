using System;
using System.IO;
using System.Windows.Forms;
using WixSharp;
using WixSharp.Forms;

namespace PdfToPptxSetup
{
    internal class Program
    {
        static void Main()
        {

            var projectName = "PDF to PPTX";
            //AutoElements.DisableAutoKeyPath = true;
            var fullSetup = new Feature("Complete");
            var projectVersion = "1.0.0";

            var project = new ManagedProject(projectName,
                new Dir(@"%ProgramFiles%\Teknikteamet\PDF to PPTX",
                    new Files(@"MSI Files\*.*")),
                new Dir("%Desktop%", new ExeFileShortcut(projectName, Path.Combine("[INSTALLDIR]", "PdfToPptx.exe"), arguments: "") { WorkingDirectory = "[INSTALLDIR]", Location = @"%ProgramMenu%" }));
            

            project.ControlPanelInfo.Manufacturer = "Teknikteamet";
            project.Version = new Version(projectVersion);

            //Set GUID and UpgradeCode to the same for a smooth upgrade process
            project.GUID = new Guid("66a5d043-9552-4e26-908b-2e3452d03206");
            project.UpgradeCode = new Guid("66a5d043-9552-4e26-908b-2e3452d03206");

            //New GUID for each new version
            project.ProductId = new Guid("c0f9086a-87c1-4667-8118-f95a8129f977");

            project.MajorUpgrade = new MajorUpgrade
            {
                AllowSameVersionUpgrades = true,
                Schedule = UpgradeSchedule.afterInstallValidate,
                DowngradeErrorMessage = "A later version of [ProductName] is already installed. Setup will now exit."
            };

            //project.InstallScope = InstallScope.perUser;

            project.ManagedUI = new ManagedUI();
            project.ManagedUI.InstallDialogs.Add(Dialogs.Welcome).Add(Dialogs.Progress).Add(Dialogs.Exit);

            //project.SourceBaseDir = "<input dir path>";
            //project.OutDir = "<output dir path>";
            project.OutFileName = $"PDFToPPTXSetup v{project.Version.ToString()}";
            
            project.BuildMsi();
        }


    }
}