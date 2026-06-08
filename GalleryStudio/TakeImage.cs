using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryStudio
{
    [Serializable]
    public class TakeImage
    {
        int Day = new int();
        int Month = new int();
        int Year = new int();

        int     PhotoNumber    = new int();

        Customers CustomerObject = new Customers();
        
        public TakeImage(int Senderint,Customers SenderCustomer)
        {
            if(Senderint!=0)
                if (SenderCustomer != null)
                {
                    Day = DateTime.Today.Day;
                    Month = DateTime.Today.Month;
                    Year = DateTime.Today.Year;
                    PhotoNumber = Senderint;
                    CustomerObject = SenderCustomer;
                }
        }
        public int DayAccess
        {
            get
            {
                return Day;
            }
            set 
            {
                Day = value;
            }
        }
        public int MonthAccess
        {
            get 
            {
                return Month;
            }
            set
            {
                Month = value;
            }
        }
        public int YearAccess
        {
            get 
            {
                return Year;
            }
            set 
            {
                Year = value;
            }
        }
        public int PhotoNumberAccess
        {
            get 
            {
                return PhotoNumber;
            }
            set 
            {
                PhotoNumber = value;
            }
        }
        public Customers CustomersAcess
        {
            get
            {
                return CustomerObject;
            }
            set 
            {
                CustomerObject = value;
            }
        }
    }
}
