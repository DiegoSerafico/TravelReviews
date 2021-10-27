using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Models;
using System;
using System.Linq;

namespace TravelReviews.Controllers
{
  public class DestinationsController : Controller
  {
    private readonly TravelReviewsContext _db;

    public DestinationsController(TravelReviewsContext db)
    {
      _db = db;
    }
  }
}