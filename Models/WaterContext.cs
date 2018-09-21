using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WisdomWaterServicePlatform.Models;

namespace WisdomWaterServicePlatform
{
    public class WaterContext : DbContext
    {
        public WaterContext(DbContextOptions<WaterContext> options) : base(options)
        {
        }
        public DbSet<Sypump> Sypump { get; set; }
        public DbSet<Wushui> Syep { get; set; }
        public DbSet<Syep_jn> Syep_jn { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sypump>(m =>
            {
                m.Property(n => n.ssll).HasMaxLength(20);//设置最大长度为50个字符
                m.Property(n => n.ljll).HasMaxLength(20).IsRequired();//设置密码不可空且最大20个字符
            });
            base.OnModelCreating(modelBuilder);
        }


    }
}
