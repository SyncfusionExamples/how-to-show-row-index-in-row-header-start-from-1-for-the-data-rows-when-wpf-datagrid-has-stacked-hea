using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTestingSample.Model;

namespace WpfTestingSample
{
    class ViewModel:INotifyPropertyChanged
    {
        EmployeeDetails emp = new EmployeeDetails();

        private string rowHeaderText = "RowHeader";

        public string RowHeaderText
        {
            get
            {
                return rowHeaderText;
            }
            set
            {
                rowHeaderText = value;
                OnPropertyChanged("RowHeaderText");
            }
        }

        #region Constructor

        public ViewModel()
        {
            this.GDCSource = emp;
        }

        #endregion

        private ObservableCollection<BusinessObjects> gdcsource;
        public ObservableCollection<BusinessObjects> GDCSource
        {
            get
            {
                return gdcsource;
            }
            set
            {
                gdcsource = value;
                OnPropertyChanged("GDCSource");
            }
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


    }

    #region GDCSource DataSource
    class EmployeeDetails : ObservableCollection<BusinessObjects>
    {
        Random rand = new Random();
        public EmployeeDetails()
        {
            PopulateCollection();
        }

        private void PopulateCollection()
        {
            this.Clear();

            for (int i = 0; i < 10; i++)
            {
                BusinessObjects b = new BusinessObjects() { EmployeeName = "Mart", EmployeeAge = 45, EmployeeArea = "U;SA", EmployeeSalary = 33000, ExperienceInMonth = 10, EmployeeGender = "Male",EmployeeDate=DateTime.Now };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "Peter", EmployeeAge = 35, EmployeeArea = "UK", EmployeeSalary = 5678, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "James", EmployeeAge = 42, EmployeeArea = "UAE", EmployeeSalary = 18700, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "Oliver", EmployeeAge = 36, EmployeeArea = "USA", EmployeeSalary = 67000, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "Robert", EmployeeAge = 54, EmployeeArea = "India", EmployeeSalary = 34567, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "Suji", EmployeeAge = 45, EmployeeArea = "UK", EmployeeSalary = 90000, ExperienceInMonth = 10, EmployeeGender = "Female", EmployeeDate = DateTime.Now };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "Mahesh", EmployeeAge = 48, EmployeeArea = "UK", EmployeeSalary = 34567, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
                this.Add(b);
                //b = new BusinessObjects() { EmployeeName = "Ruby", EmployeeAge = 49, EmployeeArea = "UK", EmployeeSalary = 12345, ExperienceInMonth = 10, EmployeeGender = "Female" };
                //this.Add(b);
                //b = new BusinessObjects() { EmployeeName = "Christain", EmployeeAge = 54, EmployeeArea = "India", EmployeeSalary = 80000, ExperienceInMonth = 10, EmployeeGender = "Male" };
                //this.Add(b);
                //b = new BusinessObjects() { EmployeeName = "Aravind", EmployeeAge = 65, EmployeeArea = "India", EmployeeSalary = 12000, ExperienceInMonth = 10, EmployeeGender = "Male" };
                //this.Add(b);
                //b = new BusinessObjects() { EmployeeName = "Daniel", EmployeeAge = 56, EmployeeArea = "USA", EmployeeSalary = 16000, ExperienceInMonth = 10, EmployeeGender = "Male" };
                //this.Add(b);
                //b = new BusinessObjects() { EmployeeName = "Suhitha Azar", EmployeeAge = 78, EmployeeArea = "UK", EmployeeSalary = 98789, ExperienceInMonth = 10, EmployeeGender = "Female" };
                //this.Add(b);
                //b = new BusinessObjects() { EmployeeName = "Praveen", EmployeeAge = 54, EmployeeArea = "UAE", EmployeeSalary = 45678, ExperienceInMonth = 10, EmployeeGender = "Male" };
                //this.Add(b);
                //b = new BusinessObjects() { EmployeeName = "Stephen", EmployeeAge = 45, EmployeeArea = "USA", EmployeeSalary = 21000, ExperienceInMonth = 10, EmployeeGender = "Male" };
                //this.Add(b);
                //b = new BusinessObjects() { EmployeeName = "Asha Joseph", EmployeeAge = 56, EmployeeArea = "India", EmployeeSalary = 56787, ExperienceInMonth = 10, EmployeeGender = "Female" };
                //this.Add(b);
                //b = new BusinessObjects() { EmployeeName = "Clarke", EmployeeAge = 67, EmployeeArea = "UK", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeGender = "Male" };
                //this.Add(b);
                //b = new BusinessObjects() { EmployeeName = "Dhileep Venkatesh", EmployeeAge = 45, EmployeeArea = "UK", EmployeeSalary = 45656, ExperienceInMonth = 10, EmployeeGender = "Male" };
            }

        }
    }

    #endregion
}
