using ProjetRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetRestaurant.ViewModels
{
    public class AccueilViewModel
    {
        private IList<Carte> cartes;

        public IList<Carte> Cartes
        {
            get { return cartes; }
            set { cartes = value; }
        }

    }
}