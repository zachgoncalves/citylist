/* Author: Zach Goncalves
 * Temple University / October 10 2018 / CIS 3309 / Mid Term Exam
 * Class: CityList
 */
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace CityGen.Classes
{
    class CityList
    {
        // CityList class stores city objects, searches through them, and writes them out 
        ArrayList cityList = new ArrayList();
        int searches = 0;
        int failedSearches = 0;
        int successfulSearches = 0;
        int numCities = 0;
        string fileName = "CityList.txt";

        // Adds a city to array list
        public void addCity(City newCity)
        {
            cityList.Add(newCity);
            numCities++;
        }

        // Traverses through city list and calls city object's search method. 
        // Returns sucessful / failed search info. 
        public string searchList(string keyword, ref bool searchSuccessful)
        {
            searchSuccessful = false;
            string returnCity = "";
            foreach (City city in cityList)
            {
                bool match = false;
                bool endOfList = false;
                city.searchKeywords(keyword, ref match, ref endOfList);
                if (match)
                {
                    returnCity = city.displayCity();
                    searches++;
                    successfulSearches++;
                    searchSuccessful = true;
                    break;
                }
                else
                {
                    if (endOfList)
                    {
                        returnCity = "No city found!";
                        searches++;
                        failedSearches++;
                        searchSuccessful = false;
                    }
                }
            }
            return returnCity;
        }

        // Gets the total number of added cities 
        public string getNumCities()
        {
            return numCities.ToString();
        }

        // Gets the total number of searches and formats them for output
        public string getNumSearches()
        {
            string searchReturn = "Total Searches: " + searches + "\n" +
                "Succesful Searches: " + successfulSearches + "\n" + "Failed Searches: " + failedSearches;
            return searchReturn;
        }

        // Gets all of the cities and formates them for output
        public string getAllCities()
        {
            string allCities = "";
            foreach (City city in cityList)
            {
                allCities += city.displayCity() + "\n";
            }
            return allCities; 
        }
        
        // Writes out all cities in city list to file 
        // File can be found in: CityGen/bin/Debug/
        public void writeOutCities()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (StreamWriter cityWriter = new StreamWriter(fileName))
                {
                    foreach (City city in cityList)
                    {
                        cityWriter.WriteLine(city.displayCity() + ",");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot write file" + "Terminate Program." + ex, "Output File Error.");
            }
        }
    }
}
