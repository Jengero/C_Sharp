using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPatterns.Decorator
{
    // Additional functionality that will be added to the main class and "wrap" it,
    // thereby implementing the open-closed principle (Concrete Decorator)
    public class ExtraLoudGigantosaurusDecorator : IGigantosaurus
    {
        private Gigantosaurus _gigantosaurus;
        private string _extraLoudRoar;

        public ExtraLoudGigantosaurusDecorator(Gigantosaurus gigantosaurus, string extaLoudRoar)
        {
            _gigantosaurus = gigantosaurus;
            _extraLoudRoar = extaLoudRoar;
        }

        public string Roar()
        {
            return _gigantosaurus.Roar() + _extraLoudRoar;
        }
    }
}