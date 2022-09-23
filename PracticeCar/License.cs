using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCar
{
    internal class License
    {
        public int KeyCode { get; set; }
        public string? Type { get; set; }
        public DateOnly InitialDate { get; set; }
        public DateOnly ExpirationDate { get; set; }

        public bool status = false;

        //
        public DateOnly today = new DateOnly(2022, 09, 22);

        public License createLicense(string TypeParameter, DateOnly InitialDateParameter, DateOnly ExpirationDateParameter)
        {
            License licenseCustom = new License();
            licenseCustom.Type = TypeParameter;
            licenseCustom.InitialDate = InitialDateParameter;
            licenseCustom.ExpirationDate = ExpirationDateParameter;
            if (licenseCustom.ExpirationDate >= today)
            {
                licenseCustom.status = true;
            }

            return licenseCustom;
        }
        public bool Validate(License lic)
        {
        if (lic.ExpirationDate > today)
            {
                return true;   
            }
            else
            {
                return false;   
            }
        

        }

    }
}
