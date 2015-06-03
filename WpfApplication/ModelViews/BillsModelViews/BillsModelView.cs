using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer.Models;
using WpfApplication.UI.BillsUI;

namespace WpfApplication.ModelViews.BillsModelViews
{
    public class BillsModelView : INotifyPropertyChanged
    {

        private List<Bill> _billList;
        private Bill _newBill;
        

        public List<Bill> BillList
        {
            get { return _billList; }
            set { _billList = value; OnPropertyChanged("BillsList"); }
        }

        public BillsModelView()
        {
            _newBill = new Bill();
            BillList = Service.GetAllBills();
        }

        #region PropertyNotification
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion

        public void GetBillList()
        {
            BillList = Service.GetAllBills();
        }

        public Bill NewBill
        {
            get { return _newBill; }
            set { _newBill = value; OnPropertyChanged("NewBill"); }
        }

        public void ShowNewBill()
        {
            EditBill newBill = new EditBill(this);
            newBill.ShowDialog();
        }

        public void ResetEditValue()
        {
            NewBill = new Bill();
        }


        public void AddNewBill()
        {
            NewBill = Service.AddBill(NewBill);
            if (NewBill.BillId != null)
            {
                _billList.Add(NewBill);
            }
        }

        public void DeleteBill(Bill Bill)
        {
            Service.DeleteBill(Bill);
        }
    }
}