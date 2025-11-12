using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetProductCatalogItemsResponse")]
public class GetGetProductCatalogItemsResponse : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/billing/product-catalog-items?";

        GetProductCatalogItemsResponse response = ImmyBotApiService.Get<GetProductCatalogItemsResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
