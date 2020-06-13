using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPICore.Models
{
    public class SmartContext:DbContext
    {
        public SmartContext(DbContextOptions<SmartContext> options)
    : base(options)
        {
        }
    }
}
