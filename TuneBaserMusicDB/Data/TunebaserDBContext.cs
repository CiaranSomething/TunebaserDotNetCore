using TuneBaserMusicDB.Models;
using Microsoft.EntityFrameworkCore;

namespace TuneBaserMusicDB.Data
{
    public class TunebaserDBContext : DbContext
    {
        public TunebaserDBContext(DbContextOptions<TunebaserDBContext> options) : base(options)
        {
        }



    }
}
