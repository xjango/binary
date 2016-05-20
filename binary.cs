        private static string singleBinary(string x)
        {

         int v = 0, z = 0; //v is for calculation process.
         int[] binary = new int[8] { 128, 64, 32, 16, 8, 4, 2, 1 }; //binary is what we're checking against in each element.
         string str = null; //placeholder ptc.

            //convert.ToInt32  converts a string to an int value
            if (Convert.ToInt32(x) > 255)
            {
                Console.WriteLine("Exceeds 255!");
            }
            else
            {
                /*
                    on for loop, we're iterating through the binary array.
                    We're also checking each element to see if they're less than v.
                    v = calculation number.
                */
                for (int i = 0; i < binary.Length; i++)
                {
                    z = v + binary[i];

                    if (z <= Convert.ToInt32(x))
                    {
                        v = z;
                        str = str + "1";
                    }
                    else
                    {
                        str = str + "0";
                    }
                }
                //Console.WriteLine(str);
            }
            return str; //just returns the binary value of a single number passed into the function(x)
        }
