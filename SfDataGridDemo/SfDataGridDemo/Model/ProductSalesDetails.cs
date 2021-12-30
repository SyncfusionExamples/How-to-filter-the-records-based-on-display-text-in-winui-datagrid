#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;

namespace SfDataGridDemo
{
    /// <summary>
    /// Represents a class that contains the product sales details.
    /// </summary>
    public class ProductSalesDetails : INotifyPropertyChanged
    {
        #region Fields

        private string _product;

        private string _country;

        private string _state;

        private int _quantity;

        private double _discount;

        private double _amount;

        private DateTime _deliveryDate;

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public ProductSalesDetails()
        {

        }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        /// <value>The product.</value>        
        public string Product
        {
            get
            {
                return _product;
            }
            set
            {
                _product = value;
                RaisePropertyChanged("Product");
            }
        }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>The country.</value>       
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
                RaisePropertyChanged("Country");
            }
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>       
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                RaisePropertyChanged("State");
            }
        }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>       
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                RaisePropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// Gets or sets the discount.
        /// </summary>
        /// <value>The discount.</value>       
        public double Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
                RaisePropertyChanged("Discount");
            }
        }       

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>        
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
                RaisePropertyChanged("Amount");
            }
        }

        /// <summary>
        /// Gets or sets the delivery date.
        /// </summary>
        /// <value>The delivery date.</value>        
        public DateTime DeliveryDate
        {
            get
            {
                return _deliveryDate;
            }
            set
            {
                _deliveryDate = value;
                RaisePropertyChanged("DeliveryDate");
            }
        }

        /// <summary>
        /// Occurs when any property value changed.
        /// </summary>
        /// <param name="propertyName">The name of the property which was changed.</param>
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
