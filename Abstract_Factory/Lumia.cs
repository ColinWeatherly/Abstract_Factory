﻿/* Name: Colin Weatherly
 * Date: 2/4/2022
 * File: Lumia.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class Lumia : ISmart
    {
        string ISmart.getName()
        {
            return "Lumia";
        }
    }
}
