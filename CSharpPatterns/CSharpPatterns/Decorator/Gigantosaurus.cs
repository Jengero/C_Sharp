using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPatterns.Decorator
{
    // The base implementation of the interface that will wrap the decorator (Concrete Component)
    public class Gigantosaurus : IGigantosaurus
    {
        private string _roar;

        public Gigantosaurus() { }
        public Gigantosaurus(string roar)
        {
            _roar = roar;
        }

        public string Roar()
        {
            return _roar;
        }
    }
}
