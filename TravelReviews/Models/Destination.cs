using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelReviews.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]
        public int Rating { get; set; }

        public static List<Destination> GetDestinations()
        {
          var apiCallTask = ApiHelper.GetAll();
          var result = apiCallTask.Result;

          JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
          List<Destination> destinationList = JsonConvert.DeserializeObject<List<Destination>>(jsonResponse.ToString());

          return destinationList;
        }
    }
}