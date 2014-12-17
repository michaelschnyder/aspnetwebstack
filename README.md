aspnetwebstack (Extended)
=========================

Extended the OData Library because some improvements are only available in v4 of the Library. 
Unfortunately the v4-Version is incompatible with the very popular "PowerQuery"-Extension for MS-Excel. 
This Repository fill aims to fill this gap.
**Note**: This is not an official build/repo for ASP.NET

**What's in included**
* Support Null in Navigation Properties as discussed here: http://stackoverflow.com/questions/21361470/odata-null-navigation-property-while-using-typeless-entity-object-support-in-web

###Installation###

From time to time, never versions are published via Nuget. To install use
    
    PM> Install-Package EmTwo.Microsoft.AspNet.WebApi.OData -Pre
