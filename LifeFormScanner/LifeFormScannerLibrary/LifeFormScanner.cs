using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Web;
using System.Net;
using System.Net.NetworkInformation;
using System.Collections;

namespace LifeFormScannerLibrary
{
    partial class LifeFormScanner : ILifeFormScanner
    {
        private LifeFormsResult GetLifeFormsWork()
        {
            LifeFormsResult result = new LifeFormsResult();
            string rtn = "";
            List<LifeForm> lifeforms = new List<LifeForm>();

            //Dictionary<IPAddress, PhysicalAddress> all = Network.GetAllDevicesOnLAN();
            List<LifeFormScannerLibrary.Network.DeviceInfo> all = Network.GetAllDevicesOnLAN();
            //foreach (KeyValuePair<IPAddress, PhysicalAddress> kvp in all)

            List<IPInfo> ips = IPInfo.GetIPInfo();

            //foreach (LifeFormScannerLibrary.Network.DeviceInfo device in all)
            foreach (IPInfo i in ips)
            {
                LifeForm temp = new LifeForm();

                temp.IP = i.IPAddress;
                temp.MACAddress = i.MacAddress;
                temp.DeviceName = i.HostName;

                lifeforms.Add(temp);
            }

            result.LifeForms = lifeforms.ToArray();

            return result;

            /*
            // Get my PC IP address
            rtn += "My IP : " + Network.GetIPAddress();
            // Get My PC MAC address
            rtn += "My MAC: " + Network.GetMacAddress();
            // Get all devices on network*/

        }


        public LifeFormsResult GetLifeForms_GETXML()
        {
            return GetLifeFormsWork();
        }

        public LifeFormsResult GetLifeForms_GETJSON()
        {
            return GetLifeFormsWork();
        }

        public LifeFormsResult GetLifeForms_POST(string Data, string LicenseKey)
        {
            return GetLifeFormsWork();
        }

        public LifeFormsResult GetLifeForms_PUT(string Data, string LicenseKey)
        {
            throw new WebFaultException(HttpStatusCode.NotImplemented);
        }

        public LifeFormsResult GetLifeForms_DELETE(string Data, string LicenseKey)
        {
            throw new WebFaultException(HttpStatusCode.NotImplemented);
        }


        public LifeFormsResult GetLifeForms(string Data, string LicenseKey)
        {
            LifeFormsResult result = new LifeFormsResult();
            try
            {
                result = GetLifeFormsWork();
            }
            catch (WebFaultException wf)
            {
                if (wf.StatusCode.Equals(HttpStatusCode.BadRequest))
                {
                    //result.OwnerName = "Input length cannot be zero.";
                }
            }
            return result;
        }
    }
}
