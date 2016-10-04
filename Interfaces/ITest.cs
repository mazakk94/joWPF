﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITest
    {
        int Id { get; set; }
        string Name { get; set; }
        TimeSpan Length { get; set; }
        int MaximumPoints { get; set; }
        List<IQuestion> Question { get; set; }        
    }
}
