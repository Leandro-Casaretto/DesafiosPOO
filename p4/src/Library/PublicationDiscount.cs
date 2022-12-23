using System;

namespace Ucu.Poo.Defense
{
    /// <summary>
    /// Implementamos la interfaz para aplicar el DIP
    /// </summary>
    public class PublicationDiscount : IPublicationItem
    {

        public Material Material { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            
            set
            {
                if (value <= 0)
                {
                    this.amount = value;
                }
                
                /// <summary>
                /// Realizamos la excepción en caso de que el descuento sea positivo.
                /// </summary>
                else
                {
                    throw new ArgumentException("ERROR. El descuento DEBE ser negativo.");
                }
            }
        }
        public PublicationDiscount(int amount)
        {
            
            this.SubTotal = amount;
        }
    }
}
