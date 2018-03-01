using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilderEntitesLib
{
 public class FavoritesList
    {

        public int FavListId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
        public Guid ListOwnerId { get; set; }
        public ICollection<Recipe> FavList { get; set; }
    }
}
