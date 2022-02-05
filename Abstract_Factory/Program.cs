/* Name: Colin Weatherly
 * Date: 2/5/2022
 * File: Program.cs
 * IDE: Visual Studio 2019
 */

using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main()
        {
            for (Manufacturers test = Manufacturers.SAMSUNG; test <= Manufacturers.NOKIA; test++)
            {
                PhoneTypeChecker checker = new PhoneTypeChecker(test);
                checker.CheckProducts();
            }
        }

    }
}
