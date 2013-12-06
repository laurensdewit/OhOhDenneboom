using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.OData.Builder;

namespace OhOhDenneboom.Models.DAL.Mapper
{
    public class BoomMap : EntityTypeConfiguration<Boom>
    {
        public BoomMap()
        {
            Property(b => b.Naam).IsRequired();
        }
    }
}