using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Part1
    {
        public ImmutableList<string> Poem { get; set; }

        public void AddPart(List<string> _poem)
        {
            _poem.Add("Вот дом,");
            _poem.Add("Который построил Джек.");
            Poem = _poem.ToImmutableList();
        }
    }
}
