using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data
{
    public class Order : ICollection, INotifyPropertyChanged, INotifyCollectionChanged
    {
        public ICollection<IOrderItem> Orders { get; set; } = new ObservableCollection<IOrderItem>();

        public List<IOrderItem> ModifiedItems { get; set; }


        public double SalesTaxRate { get; set; } = 0.12;

        private static int nextOrderNumber = 1;


        public int Number { get; }






        public double Subtotal 
        {
            get
            {
                double val = 0;
                foreach (IOrderItem item in Orders)
                {
                    val += item.Price;
                }

                if (val < 0)
                {
                    val = 0;
                }

                return val;
            }
        }

        public uint Calories
        {
            get
            {
                uint val = 0;
                foreach (IOrderItem item in Orders)
                {
                    val += item.Calories;
                }

                if (val < 0)
                {
                    val = 0;
                }

                return val;
            }
        }


        public double Tax => Subtotal * SalesTaxRate;
        public double Total => Subtotal + Tax;

        public int Count => ((ICollection)Orders).Count;

        public bool IsSynchronized => ((ICollection)Orders).IsSynchronized;

        public object SyncRoot => ((ICollection)Orders).SyncRoot;

        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;

        }

        public void Add(IOrderItem item)
        {
            Orders.Add(item);
            if (CollectionChanged != null) CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
            OnPropertyChanged("Subtotal");
            OnPropertyChanged("Tax");
            OnPropertyChanged("Total");
            OnPropertyChanged("Calories");

        }

        public void Remove(IOrderItem item)
        {
            Orders.Remove(item);
            if (CollectionChanged != null) CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove));
            OnPropertyChanged("Subtotal");
            OnPropertyChanged("Tax");
            OnPropertyChanged("Total");
            OnPropertyChanged("Calories");
        }

        void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
                foreach (var item in e.NewItems)
                    ((INotifyPropertyChanged)item).PropertyChanged += OnReplacementChanged;
            if (e.OldItems == null) return;
            {
                foreach (var item in e.OldItems)
                    ((INotifyPropertyChanged)item).PropertyChanged -= OnReplacementChanged;
            }
        }

        private void OnReplacementChanged(object sender, PropertyChangedEventArgs e)
        {
            CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace));
            OnPropertyChanged("Subtotal");
            OnPropertyChanged("Tax");
            OnPropertyChanged("Total");
            OnPropertyChanged("Calories");
        }






        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void CopyTo(Array array, int index)
        {
            ((ICollection)Orders).CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Orders).GetEnumerator();
        }
    }
}
