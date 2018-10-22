using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.ModelConfiguration;



namespace _2C2P.DAL.ModelMapping
{
    public class MapCardDetails : EntityTypeConfiguration<Models.CardDetails>
    {
        public MapCardDetails()
        {
            this.HasKey(t => t.CardNumber);
            this.Property(t => t.ValidPeriod).IsRequired();
            this.Property(t => t.CardNumber).IsRequired();
            this.ToTable("CardDetails");

        }
    }
}
