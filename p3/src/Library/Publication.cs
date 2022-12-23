using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Publication
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<PublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<PublicationItem>(this.items);
            }
        }

        private IList<PublicationItem> items = new List<PublicationItem>();

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(PublicationItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(PublicationItem item)
        {
            this.items.Remove(item);
        }

        /// <summary>
        /// ¿Por qué agregamos el método en esta clase? Porque es la experta en información.
        /// </summary>
        
        int totalCost = 0;
        public int Total()
        {
            foreach (PublicationItem item in items)
            {
                totalCost += (item.Price) * (item.Quantity);
            }
            return totalCost;
        }
    }
}