using System;

namespace NetSolService.Models
{
    public interface IBaseResponseType
    {
        string RequestId { get; set; }
        StatusCode Status { get; set; }
        DateTime TimeStamp { get; set; }
        string StoreUrl { get; set; }
        ErrorType[] ErrorList { get; set; }
        decimal Version { get; set; }
        bool VersionSpecified { get; set; }
    }
}