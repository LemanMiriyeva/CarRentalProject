﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity.Abstract;

namespace Core.Entity.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
