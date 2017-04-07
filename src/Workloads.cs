using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.Setup.Samples.OfflineLayout
{
    public class Workload
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Workload(string id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }

    public class Workloads : ObservableCollection<Workload>
    {
        public Workloads() : base()
        {
            // TODO: Read these from the manifest so they are always updated
            Add(new Workload("Microsoft.VisualStudio.Workload.CoreEditor", "Visual Studio core editor"));
            Add(new Workload("Microsoft.VisualStudio.Workload.Azure", "Azure development"));
            Add(new Workload("Microsoft.VisualStudio.Workload.Data", "Data storage and processing"));
            Add(new Workload("Microsoft.VisualStudio.Workload.ManagedDesktop", ".NET desktop development"));
            Add(new Workload("Microsoft.VisualStudio.Workload.ManagedGame", "Game development with Unity"));
            Add(new Workload("Microsoft.VisualStudio.Workload.NativeCrossPlat", "Linux development with C++"));
            Add(new Workload("Microsoft.VisualStudio.Workload.NativeDesktop", "Desktop development with C++"));
            Add(new Workload("Microsoft.VisualStudio.Workload.NativeGame", "Game development with C++"));
            Add(new Workload("Microsoft.VisualStudio.Workload.NativeMobile", "Mobile development with C++"));
            Add(new Workload("Microsoft.VisualStudio.Workload.NetCoreTools", ".NET Core cross-platform development"));
            Add(new Workload("Microsoft.VisualStudio.Workload.NetCrossPlat", "Mobile development with .NET"));
            Add(new Workload("Microsoft.VisualStudio.Workload.NetWeb", "ASP.NET and web development"));
            Add(new Workload("Microsoft.VisualStudio.Workload.Node", "Node.js development"));
            Add(new Workload("Microsoft.VisualStudio.Workload.Office", "Office/SharePoint development"));
            Add(new Workload("Microsoft.VisualStudio.Workload.Universal", "Universal Windows Platform development"));
            Add(new Workload("Microsoft.VisualStudio.Workload.VisualStudioExtension", "Visual Studio extension development"));
            Add(new Workload("Microsoft.VisualStudio.Workload.WebCrossPlat", "Mobile development with JavaScript"));
        }

    }
}
