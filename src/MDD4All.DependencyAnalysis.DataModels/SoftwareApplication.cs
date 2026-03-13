using System.Collections.Generic;

namespace MDD4All.DependencyAnalysis.DataModels
{
    public class SoftwareApplication
    {
        public List<SoftwareComponent> SoftwareComponents { get; set; } = new List<SoftwareComponent>();
    }
}
