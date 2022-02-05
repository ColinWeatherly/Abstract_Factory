/* Name: Colin Weatherly
 * Date: 2/5/2022
 * File: SamsungFactory.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class SamsungFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            return new GalaxyS2();
        }

        IDumb IPhoneFactory.GetDumb()
        {
            return new Genie();
        }
    }
}
