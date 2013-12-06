using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OhOhDenneboom.Models.DAL
{
    public class OhOhDenneboomInitializer : DropCreateDatabaseAlways<OhOhDenneboomContext>
    {
        protected override void Seed(OhOhDenneboomContext context)
        {
            //SeedMembership();

        }
    }
}