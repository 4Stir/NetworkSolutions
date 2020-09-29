namespace NetSolService.Models
{
    public class ErrorType
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Message { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Number { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberSpecified { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public SeverityCode Severity { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SeveritySpecified { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public FieldInfoType FieldInfo { get; set; }
    }
}