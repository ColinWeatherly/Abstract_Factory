/* Name: Colin Weatherly
 * Date: 2/5/2022
 * File: Titan.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class Titan : ISmart
    {
        string ISmart.getName()
        {
            return "Titan";
        }
    }
}
