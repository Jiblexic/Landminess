using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDB.Landmines
{
    interface ILandmineGenerator
    {
        List<int[,]> LandminePlaceholder { get; set; }

        List<int[,]> LandmineLocations();
    }
}
