﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given two Dictionarys, Dictionary<string, int>, merge the two into a new Dictionary, 
         * Dictionary<string, int> where keys in Dictionary2, 
         * and their int values, are added to the int values of matching keys in Dictionary1. 
         * Return the new Dictionary.
         * 
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *  
         * consolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         * 
         */
        public Dictionary<string, int> ConsolidateInventory(
                        Dictionary<string, int> mainWarehouse, 
                            Dictionary<string, int> remoteWarehouse)
        {
            Dictionary<string, int> combinedDictionaries = new Dictionary<string, int>(mainWarehouse);


            foreach (KeyValuePair<string, int> kvp in remoteWarehouse)
            {
                if (!combinedDictionaries.ContainsKey(kvp.Key))
                {
                    // add new key value to the existing somehow
                    combinedDictionaries.Add(kvp.Key, kvp.Value); //does not combine values
                }
                else
                {
                    combinedDictionaries[kvp.Key] += kvp.Value;
                }

            }

            return combinedDictionaries;
        }
    }
}
