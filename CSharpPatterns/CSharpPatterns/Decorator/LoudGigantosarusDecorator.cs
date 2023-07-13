using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPatterns.Decorator
{
    // Additional functionality that will be added to the main class and "wrap" it,
    // thereby implementing the open-closed principle (Concrete Decorator)
    public class LoudGigantosarusDecorator : IGigantosaurus
    {
        private Gigantosaurus _gigantosaurus;
        private string _loudRoar;

        public LoudGigantosarusDecorator(Gigantosaurus gigantosaurus, string loudRoar)
        {
            _gigantosaurus = gigantosaurus;
            _loudRoar = loudRoar;
        }

        public string Roar()
        {
            return _gigantosaurus.Roar() + _loudRoar;
        }
    }
}
