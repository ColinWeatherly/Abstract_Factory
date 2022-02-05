/* Name: Colin Weatherly
 * Date: 2/5/2022
 * File: HTCFactory.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class HTCFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            return new Titan();
        }

        IDumb IPhoneFactory.GetDumb()
        {
            return new Primo();
        }
    }
}
