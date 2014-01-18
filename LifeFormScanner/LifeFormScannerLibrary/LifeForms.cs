using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LifeFormScannerLibrary
{
    [DataContract]
    class LifeFormsResult
    {
        [DataMember]
        public LifeForm[] LifeForms;

    }

    [DataContract]
    class LifeForm
    {
        [DataMember]
        public string IP;
        [DataMember]
        public string MACAddress;
        [DataMember]
        public string DeviceName;
        [DataMember]
        public string OwnerName;

    }
    
}
