using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Web;
using System.Net;

namespace LifeFormScannerLibrary
{
    partial class LifeFormScanner : ILifeFormScanner
    {
        public LifeFormsResult Operation2(string data)
        {
            return Operation2Work(data);
        }

        private LifeFormsResult Operation2Work(string data)
        {

            LifeFormsResult result = new LifeFormsResult();

            return result;
        }
    }
}
