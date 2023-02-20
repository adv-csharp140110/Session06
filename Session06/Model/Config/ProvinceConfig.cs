﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06.Model.Config
{
    internal class ProvinceConfig : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired(true)
                .HasComment("نام");
            builder
                .Property(x => x.Id)
                .HasComment("شناسه");
        }
    }
}
