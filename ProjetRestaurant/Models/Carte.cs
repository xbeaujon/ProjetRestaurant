using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetRestaurant.Models
{
    public class Carte
    {
        public List<Section> Sections { get; set; }

        public Carte()
        {
            Sections = new List<Section>
            {
                new Entrees(),
                new Plats(),
                new Desserts(),
                new Boissons()
            };
        }
    }
}