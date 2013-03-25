using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.EF.Infrastructure
{
    public interface IDatabaseFactory
    {
        Context Get();
    }
}
