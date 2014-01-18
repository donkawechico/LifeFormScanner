using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace LifeFormScannerLibrary
{
    [ServiceContract]
    interface ILifeFormScanner
    {
        [OperationContract]
        [WebGet(UriTemplate = "LifeForms/?format=xml", ResponseFormat = WebMessageFormat.Xml)]
        [return: MessageParameter(Name = "LifeForms")]
        LifeFormsResult GetLifeForms_GETXML();

        [OperationContract]
        [WebGet(UriTemplate = "LifeForms/?format=json", ResponseFormat = WebMessageFormat.Json)]
        [return: MessageParameter(Name = "LifeForms")]
        LifeFormsResult GetLifeForms_GETJSON();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [return: MessageParameter(Name = "LifeForms")]
        LifeFormsResult GetLifeForms_POST(string Data, string LicenseKey);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [return: MessageParameter(Name = "LifeForms")]
        LifeFormsResult GetLifeForms_PUT(string Name, string LicenseKey);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{Data}/{LicenseKey}", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        [return: MessageParameter(Name = "LifeForms")]
        LifeFormsResult GetLifeForms_DELETE(string Data, string LicenseKey);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped)]
        LifeFormsResult GetLifeForms(string Data, string LicenseKey);


        [OperationContract]
        LifeFormsResult Operation2(string data);


        /*
        [OperationContract]
        [WebGet(UriTemplate = "{name}/{LicenseKey}?format=xml", ResponseFormat = WebMessageFormat.Xml)]
        [return: MessageParameter(Name = "NameInfoResult")]
        NameInfo GetNameInfoXML(string Name, string LicenseKey);

        [OperationContract]
        [WebGet(UriTemplate = "{name}/{LicenseKey}?format=json", ResponseFormat = WebMessageFormat.Json)]
        [return: MessageParameter(Name = "NameInfoResult")]
        NameInfo GetNameInfoJSON(string Name, string LicenseKey);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [return: MessageParameter(Name = "NameInfoResult")]
        NameInfo GetNameInfoPOST(string Name, string LicenseKey);


        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [return: MessageParameter(Name = "NameInfoResult")]
        NameInfo GetNameInfoPUT(string Name, string LicenseKey);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{name}/{LicenseKey}?format=json", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        [return: MessageParameter(Name = "NameInfoResult")]
        NameInfo GetNameInfoDELETEJSON(string Name, string LicenseKey);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{name}/{LicenseKey}?format=xml", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Xml)]
        [return: MessageParameter(Name = "NameInfoResult")]
        NameInfo GetNameInfoDELETEXML(string Name, string LicenseKey);
        */


    }
}
