namespace NetSolService.Models
{
    public interface IBaseRequestType
    {
        string RequestId { get; set; }
        decimal Version { get; set; }
        bool VersionSpecified { get; set; }
    }
}