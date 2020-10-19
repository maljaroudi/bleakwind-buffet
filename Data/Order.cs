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



        public ObservableCollection<IOrderItem> Orders { get; set; } = new ObservableCollection<IOrderItem>();









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
            ModifiedItems = new List<IOrderItem>();
            Orders.CollectionChanged += ItemObservableCollection_CollectionChanged;
        }



        public void Add(IOrderItem item)
        {
            Orders.Add(item);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            OnPropertyChanged("Subtotal");
            OnPropertyChanged("Tax");
            OnPropertyChanged("Total");
            OnPropertyChanged("Calories");

        }

        public void Remove(IOrderItem item)
        {
            Orders.Remove(item);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
            OnPropertyChanged("Subtotal");
            OnPropertyChanged("Tax");
            OnPropertyChanged("Total");
            OnPropertyChanged("Calories");
        }




        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            var handler = CollectionChanged;
            if (handler != null)
                handler(this, e);
        }


        void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            IOrderItem item = sender as IOrderItem;
            if (item != null)
                ModifiedItems.Add(item);
        }







        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }



        private void ItemObservableCollection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            
                if (e.NewItems != null)
                {
                    foreach (IOrderItem newItem in e.NewItems)
                    {
                        ModifiedItems.Add(newItem);
                    //Add listener for each item on PropertyChanged event
                    newItem.PropertyChanged += this.OnItemPropertyChanged;
                    }
                }

                if (e.OldItems != null)
                {
                    foreach (IOrderItem oldItem in e.OldItems)
                    {
                        ModifiedItems.Add(oldItem);

                        oldItem.PropertyChanged -= this.OnItemPropertyChanged;
                    }
                }
            
        }

        private void ItemObservableCollection_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyCollectionChangedEventArgs args = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
            OnCollectionChanged(args);

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
