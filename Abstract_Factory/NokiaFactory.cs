/* Name: Colin Weatherly
 * Date: 2/5/2022
 * File: NokiaFactory.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class NokiaFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            return new Lumia();
        }

        IDumb IPhoneFactory.GetDumb()
        {
            return new Asha();
        }
    }
}
