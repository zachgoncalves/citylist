/* Author: Zach Goncalves
 * Temple University / October 10 2018 / CIS 3309 / Mid Term Exam
 * Class: City
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityGen.Classes
{
    class City
    {
        // City stores information about the city and some functions to perform on it
        string cityName;
        string cityState;
        string keywords;

        // Default constructor used to instantiate city objects
        public City(string city, string state, string desc)
        {
            cityName = city;
            cityState = state;
            keywords = desc; 
        }

        // Outputs formatted string with city information 
        public string displayCity()
        {
            string cityInfo = "Name: " + cityName + " State: " + cityState + " Keywords: " + keywords + "\n";
            return cityInfo;
        }

        // Returns keywords 
        public string getKeywords()
        {
            return keywords;
        }

        // Searches through the keywords in the city and returns if there is a match or not
        public void searchKeywords(string keyword, ref bool isMatch, ref bool isEndOfSearch)
        {
            string[] cityKeywords = getKeywords().Split();
            // There exists a bug that, if multiple keywords are entered, the first keyword does
            // not return as found sucessfully. Ran out of time! :( 
            for (int i = 0; i < cityKeywords.Length; i++)
            {
                if (cityKeywords[i].ToString().Equals(keyword))
                {
                    isMatch = true;
                    isEndOfSearch = true;
                }
                else if (isMatch = false && i == cityKeywords.Length)
                {
                    isMatch = false;
                    isEndOfSearch = true;
                }
            }
        }
    }
}
