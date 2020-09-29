using System.Collections.Concurrent;
using System.Xml.Serialization;

namespace NetSolService.Models
{
    public class BaseRequestType : IBaseRequestType
    {
        [XmlElement(Order=0)]
        public string RequestId { get; set; }
        [XmlElement(Order=1)]
        public decimal Version { get; set; }
        [XmlIgnoreAttribute()]
        public bool VersionSpecified { get; set; }
    }
}