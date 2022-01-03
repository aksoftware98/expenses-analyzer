using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKSoftware.ExpensesAnalyzer.Models
{
    /// <summary>
    /// Represents the expense object that simulates the real expense in life
    /// </summary>
    public class Expense : TableEntity
    {
        /// <summary>
        /// Operation number divided by each user 
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// User id that the expense operation is related to
        /// </summary>
        public string? UserId { get; set; }

        /// <summary>
        /// Is deleted indicator for soft deletion 
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Description of the expense operation 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Quantity of the purchased item 
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Single item price 
        /// </summary>
        public decimal ItemPrice { get; set; }

        /// <summary>
        /// Total price of the item from the single item price multiple quantity 
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Location where the operation has been made (City)
        /// </summary>
        public string? Location { get; set; }

        /// <summary>
        /// Category of the operation 
        /// </summary>
        public string? Category { get; set; }

        /// <summary>
        /// Array of tags that the operation is associated with
        /// </summary>
        public string? Tags { get; set; }

        /// <summary>
        /// Real-world date of the operation 
        /// </summary>
        public DateTime OperationDate { get; set; }

        /// <summary>
        /// Currency of the operation (3 chars ISO Code)
        /// </summary>
        public string? Currency { get; set; }

        /// <summary>
        /// Client platform that has been used to register the operation 
        /// </summary>
        public string? Platform { get; set; }

        /// <summary>
        /// Detailed description why the operation has been done 
        /// </summary>
        public string? Reason { get; set; }

        /// <summary>
        /// Barcode used to identity the item for easy insert next time
        /// </summary>
        public string? Barcode { get; set; }

        /// <summary>
        /// Represents the severity of the operation that goes from 1 to 7 as following 
        /// 1 - Required (Metro, Bread, Communications)
        /// 2 - Some how required (Tea, Papers)
        /// 3 - Entertinment (Going with friend)
        /// 4 - // TODO: Other values to be defined
        /// </summary>
        public int SeverityLevel { get; set; }

        /// <summary>
        /// Method of the payment (Card, Transfer, Cash, PayPal ..etc)
        /// </summary>
        public string? PaymentMethod { get; set; }

        /// <summary>
        /// Reference of the payment method used to commit the operation (Last 4 digits for card, paypal email ..etc)
        /// </summary>
        public string? PaymentMethodReference { get; set; }

    }
}
