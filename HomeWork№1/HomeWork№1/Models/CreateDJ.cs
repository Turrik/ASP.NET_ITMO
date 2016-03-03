using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork_1.Models
{
    public class CreateDJ
    {
        public static IEnumerable<DJ> CreateDjs()
        {
            List<DJ> DJs = new List<DJ>();
            DJs.Add(new DJ()
            {
                Name = "Axwell",
                Genre = "House",
                Favourite_track="I am"
            });

            DJs.Add(new DJ()
            {
                Name = "Shapov",
                Genre = "Progressive house",
                Favourite_track = "Vavilon"
            });
            return DJs;
        }
    }
}