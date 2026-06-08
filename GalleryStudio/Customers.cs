using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryStudio
{
    [Serializable]
    public class Customers
    {
        static Int32 NumberOfObjects = 0;
        const char NULL='\0';
    
        Int32  CustomerID = new Int32();
        String Name = new String(NULL,20);
        String FamilyName = new String(NULL,20);
        String Address = new String(NULL,20);
        Int32  TelephonNumber = new Int32();

        public Customers()
        {
        
        }
        public Int32 CustomenrNumberOfObjectsAccess
        {
            get {
                return NumberOfObjects;
            }
            set
            {
                NumberOfObjects = value;
            }
        }
        public Int32 CustomersCustomerID
        {
            get
            {
                return CustomerID;
            }
            set
            {
                CustomerID = value;
            }
        }
        public String CustomersName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public String CustomersFamilyName
        {
            get
            {
                return FamilyName;
            }
            set
            {
                FamilyName = value;
            }
        }
        public String CustomersAddress
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public Int32 CustomersTellefon
        {
            get
            {
                return TelephonNumber;
            }
            set
            {
                TelephonNumber = value;
            }
        }
        
    }
}
