/* Name: Colin Weatherly
 * Date: 2/5/2022
 * File: IPhoneFactory.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    interface IPhoneFactory
    {
        public ISmart GetSmart();
        public IDumb GetDumb();
    }
}
