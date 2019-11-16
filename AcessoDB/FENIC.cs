namespace AcessoDB
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FENIC : DbContext
    {
        public FENIC() : base("name=FENIC")
        {

        }

    }

}