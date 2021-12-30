#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SfDataGridDemo
{
    /// <summary>
    /// Represents a class that contains the product sales details collection.
    /// </summary>
    public class ProductSalesDetailsCollection
    {
        /// <summary>
        /// It contains the ObservableCollection of product sales details.
        /// </summary>
        private ObservableCollection<ProductSalesDetails> _productInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSalesDetailsCollection"/> class.
        /// </summary>
        public ProductSalesDetailsCollection()
        {
            ProductInfo = this.GetSalesInfo();
        }

        /// <summary>
        /// Gets or sets the sales info.
        /// </summary>
        /// <value>The sales info.</value>
        public ObservableCollection<ProductSalesDetails> ProductInfo
        {
            get
            {
                return _productInfo;
            }
            set
            {
                _productInfo = value;
            }
        }

        /// <summary>
        /// Gets the sales info.
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<ProductSalesDetails> GetSalesInfo()
        {
            ObservableCollection<ProductSalesDetails> items = new ObservableCollection<ProductSalesDetails>();
            if (items != null)
            {
                items.Add(new ProductSalesDetails() { Product = "Bike", Country = "Australia", Discount = 11, State = "Queensland", Amount = 270000, Quantity = 4, DeliveryDate = new DateTime(2010, 12, 2, 10, 50, 23) });
                items.Add(new ProductSalesDetails() { Product = "Car", Country = "Canada", Discount = 4, State = "Alberta", Amount = 330000, Quantity = 5, DeliveryDate = new DateTime(2010, 12, 2, 7, 30, 22) });
                items.Add(new ProductSalesDetails() { Product = "Truck", Country = "France", Discount = 13, State = "Essonne", Amount = 30000, Quantity = 6, DeliveryDate = new DateTime(2010, 5, 2, 4, 5, 19) });
                items.Add(new ProductSalesDetails() { Product = "Van", Country = "Germany", Discount = 1, State = "Bayern", Amount = 330000, Quantity = 12, DeliveryDate = new DateTime(2012, 10, 2, 2, 20, 23) });
                items.Add(new ProductSalesDetails() { Product = "BiCycle", Country = "United States", Discount = 3, State = "New Yorke", Amount = 30000, Quantity = 3, DeliveryDate = new DateTime(2009, 6, 2, 7, 40, 21) });
                items.Add(new ProductSalesDetails() { Product = "Bike", Country = "Germany", Discount = 6, State = "Hamburg", Amount = 30000, Quantity = 20, DeliveryDate = new DateTime(2011, 7, 2, 4, 10, 23) });
                items.Add(new ProductSalesDetails() { Product = "Car", Country = "Australia", Discount = 13, State = "Tasmania", Amount = 30000, Quantity = 15, DeliveryDate = new DateTime(2008, 2, 2, 6, 12, 23) });
                items.Add(new ProductSalesDetails() { Product = "Truck", Country = "United States", Discount = 11, State = "California", Amount = 120000, Quantity = 13, DeliveryDate = new DateTime(2010, 4, 2, 11, 15, 23) });
                items.Add(new ProductSalesDetails() { Product = "Van", Country = "Canada", Discount = 13, State = "Manitoba", Amount = 150000, Quantity = 54, DeliveryDate = new DateTime(2012, 11, 16, 9, 34, 23) });
                items.Add(new ProductSalesDetails() { Product = "BiCycle", Country = "France", Discount = 12, State = "Gers", Amount = 270000, Quantity = 09, DeliveryDate = new DateTime(2012, 11, 16, 6, 30, 20) });
            }
            return items;
        }
    }
}
