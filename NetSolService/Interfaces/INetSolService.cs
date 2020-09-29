using System;
using System.Reflection.Metadata;
using System.ServiceModel;
using System.Threading.Tasks;
using NetSolService.Models;

namespace NetSolService
{
    
    [ServiceContract(Namespace="urn:networksolutions:apis", ConfigurationName="NetSolService.NetSolServiceSoap")]
    public interface INetSolService
    {
        [OperationContractAttribute(Action = "http://networksolutions.com/CreateWarehouse", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<CreateWarehouseResponse> CreateWarehouseAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/ReadWarehouse", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<ReadWarehouseResponse> ReadWarehouseAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/UpdateWarehouse", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<UpdateWarehouseResponse> UpdateWarehouseAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/DeleteWarehouse", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<DeleteWarehouseResponse> DeleteWarehouseAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/CreateManufacturer", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<CreateManufacturerResponse> CreateManufacturerAsync(IBaseRequestType request);
            
        [OperationContractAttribute(Action = "http://networksolutions.com/ReadManufacturer", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<ReadManufacturerResponse> ReadManufacturerAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/UpdateManufacturer", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<UpdateManufacturerResponse> UpdateManufacturerAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/DeleteManufacturer", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<DeleteManufacturerResponse> DeleteManufacturerAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/CreateCategory", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<CreateCategoryResponse> CreateCategoryAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/ReadCategory", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<ReadCategoryResponse> ReadCategoryAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/UpdateCategory", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<UpdateCategoryResponse> UpdateCategoryAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/DeleteCategory", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<DeleteCategoryResponse> DeleteCategoryAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/CreateProduct", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<CreateProductResponse> CreateProductAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/ReadProduct", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<ReadProductResponse> ReadProductAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/UpdateProduct", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<UpdateProductResponse> UpdateProductAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/DeleteProduct", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<DeleteProductResponse> DeleteProductAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/CreateCustomer", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<CreateCustomerResponse> CreateCustomerAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/ReadCustomer", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<ReadCustomerResponse> ReadCustomerAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/UpdateCustomer", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<UpdateCustomerResponse> UpdateCustomerAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/DeleteCustomer", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<DeleteCustomerResponse> DeleteCustomerAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/ReadOrder", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<ReadOrderResponse> ReadOrderAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/UpdateOrder", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<UpdateOrderResponse> UpdateOrderAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/CreateOrderStatus", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<CreateOrderStatusResponse> CreateOrderStatusAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/ReadOrderStatus", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<ReadOrderStatusResponse> ReadOrderStatusAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/UpdateOrderStatus", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<UpdateOrderStatusResponse> UpdateOrderStatusAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/DeleteOrderStatus", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<DeleteOrderStatusResponse> DeleteOrderStatusAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/CreatePriceLevel", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<CreatePriceLevelResponse> CreatePriceLevelAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/ReadPriceLevel", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<ReadPriceLevelResponse> ReadPriceLevelAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/UpdatePriceLevel", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<UpdatePriceLevelResponse> UpdatePriceLevelAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/DeletePriceLevel", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<DeletePriceLevelResponse> DeletePriceLevelAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/CreateAttribute", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<CreateAttributeResponse> CreateAttributeAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/ReadAttribute", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<ReadAttributeResponse> ReadAttributeAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/UpdateAttribute", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<UpdateAttributeResponse> UpdateAttributeAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/DeleteAttribute", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<DeleteAttributeResponse> DeleteAttributeAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/UpdateInventory", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<UpdateInventoryResponse> UpdateInventoryAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/PerformMultiple", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<PerformMultipleResponse> PerformMultipleAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/ReadSiteSetting", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<ReadSiteSettingResponse> ReadSiteSettingAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/GetUserToken", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<GetUserTokenResponse> GetUserTokenAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/GetUserKey", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<GetUserKeyResponse> GetUserKeyAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/CreateGiftCertificate", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<CreateGiftCertificateResponse> CreateGiftCertificateAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/ReadGiftCertificate", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<ReadGiftCertificateResponse> ReadGiftCertificateAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/UpdateGiftCertificate", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<UpdateGiftCertificateResponse> UpdateGiftCertificateAsync(IBaseRequestType request);
        
        [OperationContractAttribute(Action = "http://networksolutions.com/DeleteGiftCertificate", ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownType(typeof(IBaseResponseType))]
        [ServiceKnownType(typeof(IBaseRequestType))]
        Task<DeleteGiftCertificateResponse> DeleteGiftCertificateAsync(IBaseRequestType request);
}