using Syncfusion.XForms.DataForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataformXamarin
{
    public class EmployeeInfo : NotificationObject
    {
        private int employeeID;
        private string name;
        private string title;
        private DateTime? joindate;
        private int customerid;
        public EmployeeInfo()
        {

        }
        public int EmployeeID
        {
            get { return this.employeeID; }
            set
            {
                this.employeeID = value;
                this.RaisePropertyChanged("EmployeeID");
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                this.RaisePropertyChanged("Name");
            }
        }
        public string Title
        {
            get { return this.title; }
            set
            {
                this.title = value;
                this.RaisePropertyChanged("Title");
            }
        }

        public int CustomerID
        {
            get { return this.customerid; }
            set
            {
                this.customerid = value;
                this.RaisePropertyChanged("CustomerID");
            }
        }

        [DateRange(MinYear = 2010, MaxYear = 2017, ErrorMessage = "Join date is invalid")]
        public DateTime? JoinDate
        {
            get { return joindate; }
            set
            {
                joindate = value;
                this.RaisePropertyChanged("JoinDate");
            }
        }
    }
}
