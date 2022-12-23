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
        /// Como se usa la directiva System.Text, podemos usar un StringBuilder
        /// /// </summary>
        
        public string AsText()
        {
            StringBuilder text = new StringBuilder();
            
            /// <summary>
            /// Con un foreach vamos agregando las propiedades.
            /// /// </summary>
            foreach(PublicationItem item in items)
            {
                text.Append(item.Material.Name);
                text.Append(item.Quantity.ToString());
                text.Append(item.Price.ToString());
            }
            return text.ToString();
        }
    }
}
