using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IPart
    {
        public ImmutableList<string> Poem { get; set; }

        public void AddPart()
        {
        }
    }
}
