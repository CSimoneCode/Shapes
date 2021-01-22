using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    interface IShape
    {
        /// <summary>
        /// i don't fucking know
        /// </summary>
        /// <returns>area</returns>
        double Area();

        double Perimeter();

        /// <summary>
        /// Asks the user for input and intializes values appropriate to the type
        /// </summary>
        void Initialize();

    }
}
