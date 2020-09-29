using System;

namespace NetSolService.Models
{
    public class BaseResponseType : IBaseResponseType
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string RequestId { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public StatusCode Status { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public DateTime TimeStamp { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string StoreUrl { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("ErrorList", Order=4)]
        public ErrorType[] ErrorList { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public decimal Version { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VersionSpecified { get; set; }
    }
}