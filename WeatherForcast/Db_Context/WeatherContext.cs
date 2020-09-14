using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForcast.Db_Context
{
    public class WeatherContext : DbContext
    {
        public virtual DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}
