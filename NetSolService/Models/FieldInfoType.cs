namespace NetSolService.Models
{
    public class FieldInfoType
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Field { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Information { get; set; }
    }
}