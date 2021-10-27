using Microsoft.EntityFrameworkCore;

namespace TravelReviews.Models
{
  public class TravelReviewsContext : DbContext
  {
    public TravelReviewsContext(DbContextOptions<TravelReviewsContext> options)
        : base(options)
    {
    }

    public DbSet<Destination> Destinations { get; set; }
  }
}