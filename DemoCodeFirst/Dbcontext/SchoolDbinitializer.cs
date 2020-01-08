using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DemoCodeFirst.Dbcontext
{
    public class SchoolDbinitializer:CreateDatabaseIfNotExists<SchoolDbcontext>
    {
        protected override void Seed(SchoolDbcontext context)
        {
            base.Seed(context);
        }
    }
}