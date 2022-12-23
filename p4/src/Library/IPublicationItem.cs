using System;
using System.Collections.Generic;

namespace Ucu.Poo.Defense
{
    public interface IPublicationItem
    {
        Material Material {get; set;}
        int Quantity {get; set;}
        int Price {get; set;}
        int SubTotal { get; set; }
        
    }
}