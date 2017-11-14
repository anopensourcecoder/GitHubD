using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using DateDuration.Models;

namespace DateDuration.ViewModel
{
    class DurationViewModel
    {
        public ObservableCollection<DurationModel> DurationModels
        { 
            get;
            set;
        }

        public void LoadDurationModels()
        {
            ObservableCollection<DurationModel> durationModels = new ObservableCollection<DurationModel>();
            durationModels.Add(new DurationModel {
                StartDate =Convert.ToDateTime("01/01/2008"),
                EndDate =Convert.ToDateTime("02/02/2009")
            } );
            durationModels.Add(new DurationModel
            {
                StartDate = Convert.ToDateTime("01/06/2008"),
                EndDate = Convert.ToDateTime("02/06/2009")
            });
            durationModels.Add(new DurationModel
            {
                StartDate = Convert.ToDateTime("10/10/2015"),
                EndDate = Convert.ToDateTime("11/12/2017")
            });


            DurationModels = durationModels;
        }
    }
}
