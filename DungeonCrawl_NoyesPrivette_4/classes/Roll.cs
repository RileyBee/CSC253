using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DungeonCrawl_NoyesPrivette_3
{
    public class Roll
    {
        public static int GenerateRandomNumber()
        {
            // Create buffer of 6 bytes
            byte[] buff = new byte[6];  

            //Create new instance of RNGCryptoServiceProvider class.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            //Fill buffer with bytes
            rng.GetBytes(buff);

            //Convert to 32 bit absolute value integer.
            int rando = Math.Abs(BitConverter.ToInt32(buff, 0));

            //Convert to single digit and find digit between 1 & 3
            int mod = rando % 10;

            //Return value if modulus is between 1-3           

            if (mod > 0 && mod < 4)
            {
                return mod;
            }
            else
            {
                return GenerateRandomNumber();
            }

        }

        }
    }


