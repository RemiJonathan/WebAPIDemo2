using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo2.Models
{
    /// <summary>
    /// Memo Entity
    /// </summary>
    public class Memo
    {
        public string Id { set; get; }
        public string Text { get; set; }
        public decimal Priority { get; set; }

        /// <summary>
        /// This returns a summary line for the object.
        /// </summary>
        /// <param name="oneLine">true will print on one line online.</param>
        /// <returns>The formatted string</returns>
        public string PrintMemo(bool oneLine)
        {
            //TODO: use oneLine 
            return String.Format("Id: {0}, Text: {1}, Priority{2}", this.Id, this.Text, this.Priority);
        }
    }
}