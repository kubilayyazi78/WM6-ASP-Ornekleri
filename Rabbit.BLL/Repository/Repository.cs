﻿using Rabbit.MODELS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.BLL.Repository
{
 public   class Repository
    {
        public class CustomerRepo : RepositoryBase<Customer, Guid> { }
        public class MailLogRepo : RepositoryBase<MailLog, Guid> { }
    }
}
