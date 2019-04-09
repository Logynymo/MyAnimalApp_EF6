﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using REPO;

namespace IO
{
    public class InitializerSpecies : DropCreateDatabaseIfModelChanges<AnimalContext>
    {
        protected override void Seed(AnimalContext context)
        {
            IList<Species> defaultSpecies = new List<Species>
            {
            new Species() { SpeciesName = "Skildpadde" },
            new Species() { SpeciesName = "Hun" },
            new Species() { SpeciesName = "Kat" },
            new Species() { SpeciesName = "Hest" },
            new Species() { SpeciesName = "Slange" },
            new Species() { SpeciesName = "Gris" },
            new Species() { SpeciesName = "Fugl" }
            };

            foreach (Species species in defaultSpecies)
            {
                context.Species.Add(species);
            }

            context.SaveChanges();
        }
    }
}
