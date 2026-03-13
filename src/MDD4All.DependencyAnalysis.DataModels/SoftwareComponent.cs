using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace MDD4All.DependencyAnalysis.DataModels
{
    public class SoftwareComponent
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public ESoftwareComponentType SoftwareComponentType { get; set; }

        public string FileDescription { get; set; }
        
        public string FileVersion { get; set; }
        
        public string ProductName { get; set; }
        
        public string ProductVersion { get; set; }
        
        public string AssemblyName { get; set; }

        public string AssemblyVersion { get; set; }

        public DateTime? LastModified { get; set; } 

        public string OriginalFileName { get; set; }

        public List<SoftwareComponent> Dependencies { get; set; } = new List<SoftwareComponent>();
    }
}
