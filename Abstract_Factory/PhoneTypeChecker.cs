/* Name: Colin Weatherly
 * Date: 2/4/2022
 * File: PhoneTypeChecker.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class PhoneTypeChecker
    {
        public IPhoneFactory factory;
        public Manufacturers manu;

        public PhoneTypeChecker(Manufacturers m)
        {
            switch (m)
            {
                case Manufacturers.SAMSUNG:
                    {
                        manu = m;
                        factory = new SamsungFactory();
                        break;
                    }
                case Manufacturers.HTC:
                    {
                        manu = m;
                        factory = new HTCFactory();
                        break;
                    }
                case Manufacturers.NOKIA:
                    {
                        manu = m;
                        factory = new NokiaFactory();
                        break;
                    }
                default:
                    {
                        manu = m;
                        factory = null;
                        break;
                    }
            }
        }

        public void CheckProducts()
        {
            if (factory != null)
            {
                ISmart smart = factory.GetSmart();
                IDumb dumb = factory.GetDumb();

                Console.WriteLine("Manufacturer: " + manu);
                Console.WriteLine("Smart Phone: " + smart.getName());
                Console.WriteLine("Dumb Phone: " + dumb.getName() + "\n");
            }
            else
            {
                Console.WriteLine("This manufacturer type is not listed.\n");
            }
        }
    }

    enum Manufacturers
    {
        SAMSUNG,
        HTC,
        NOKIA
    }
}
