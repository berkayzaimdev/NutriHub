using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Favourites.Results
{
    public class GetFavouritesQueryResult
    {
        public int FavouriteId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string CardImageUrl { get; set; }
        public decimal Price { get; set; }
        public bool IsInStock { get; set; }
    }
}
