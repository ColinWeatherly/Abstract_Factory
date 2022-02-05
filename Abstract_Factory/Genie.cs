/* Name: Colin Weatherly
 * Date: 2/4/2022
 * File: Genie.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class Genie : IDumb
    {
        string IDumb.getName()
        {
            return "Genie";
        }
    }
}
