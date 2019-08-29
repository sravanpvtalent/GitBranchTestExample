using EmptyRepos.Irepository;
using EmptyRepos.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmptyRepos.BussinessAccessLayer
{
    public class bal
    {
       public  Irepos iobj;
        public bal(repos robj)
        {
            iobj = robj;
        }
    }
}