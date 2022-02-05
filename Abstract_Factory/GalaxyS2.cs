/* Name: Colin Weatherly
 * Date: 2/5/2022
 * File: GalaxyS2.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class GalaxyS2 : ISmart
    {
        string ISmart.getName()
        {
            return "Galaxy S2";
        }
    }
}
