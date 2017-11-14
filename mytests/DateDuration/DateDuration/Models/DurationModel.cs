using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace DateDuration.Models
{

    class DurationModel : INotifyPropertyChanged
    {
        private DateTime startDate;
        private DateTime endDate;
        private int durationDays;

        public DateTime StartDate
        {

            get
            {
                return startDate;
            }
            set
            {
                if(startDate!= value)
                {
                    startDate = value;
                    durationDays = (endDate - startDate).Days;
                    RaisePropertyChanged("StartDate");
                    RaisePropertyChanged("EndDate");
                    RaisePropertyChanged("DurationDays");
                }
            }
        }

        public DateTime EndDate
        {

            get
            {
                return endDate;
            }
            set
            {
                if (endDate != value)
                {
                    endDate = value;
                    durationDays = (endDate - startDate).Days;
                    RaisePropertyChanged("StartDate");
                    RaisePropertyChanged("EndDate");
                    RaisePropertyChanged("DurationDays");
                }
            }
        }

        public int DurationDays
        {

            get
            {
                return durationDays;
            }
            set
            {
                if (durationDays != value)
                {
                    durationDays = value;
                    RaisePropertyChanged("StartDate");
                    RaisePropertyChanged("EndDate");
                    RaisePropertyChanged("DurationDays");
                }
            }
        }



        // Following are fixed!
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
