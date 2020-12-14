using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;

namespace Capstone_Project
{
    static class Data
    {
        public static Pitcher selectedPitcher;

        public static Dictionary<String, Pitcher> PitcherIdList = new Dictionary<String, Pitcher>()
        {

        };

        public static void InitializePitchers()
        {
            /*using (var stream = File.OpenRead("CustomPitchingData.csv"))
            using (var reader = new StreamReader(stream))
            {
                // Read file content.
                var content = reader.ReadToEnd();

            }*/
            using (var reader = new StreamReader("CustomPitchingData2.csv"))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
            {
                var csvImports = csv.GetRecords<CsvImporter>();
                foreach (CsvImporter csvImport in csvImports)
                {
                    if (Data.PitcherIdList.ContainsKey(csvImport.playerID)){
                        try
                        {
                            YearStat yearStat = new YearStat(csvImport);
                            Data.PitcherIdList[csvImport.playerID].ageStatsDict.Add(csvImport.age, yearStat);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(csvImport.nameFirst + " " + csvImport.nameLast + " caused an error. Error: " +e.StackTrace);
                        }
                    }
                    else if (!Data.PitcherIdList.ContainsKey(csvImport.playerID))
                    {
                        YearStat yearStat = new YearStat(csvImport);
                        Pitcher newPitcher = new Pitcher(csvImport.playerID, csvImport.nameFirst, csvImport.nameLast, csvImport.birthYear);
                        newPitcher.ageStatsDict.Add(csvImport.age, yearStat);
                        PitcherIdList.Add(csvImport.playerID, newPitcher);
                    }
                }
            }
            //Console.WriteLine("Data.PitcherIdList length is " + Data.PitcherIdList.Count);
            foreach (KeyValuePair<String, Pitcher> pitcher in Data.PitcherIdList)
            {
                //Console.WriteLine(pitcher.Key + " " + pitcher.Value);
            }
            InitializeYears();
        }
        public static List<Pitcher> searchPitcher(String searchText)
        {
            List<Pitcher> pitcherList = new List<Pitcher>();
            int x = 1;
            foreach (Pitcher pitcher in Data.PitcherIdList.Values)
            {
                if (pitcher.firstName.ToLower().Contains(searchText.ToLower()))
                {
                    pitcherList.Add(pitcher);
                }
                else if (pitcher.lastName.ToLower().Contains(searchText.ToLower()))
                {
                    pitcherList.Add(pitcher);
                }
                x += 1;
            }
            return pitcherList;
        }
        public static void InitializeYears()
        {
            foreach (Pitcher pitcher in Data.PitcherIdList.Values)
            {
                int[] yearArray = new int[0];
                List<int> yearList = new List<int>();
                foreach (YearStat yearStat in pitcher.ageStatsDict.Values)
                {
                    yearList.Add(yearStat.yearID);
                }
                yearList.Sort();
                foreach (YearStat yearStat in pitcher.ageStatsDict.Values)
                {
                    yearStat.yearInLeague = yearList.IndexOf(yearStat.yearID) + 1;
                }
            }
        }
    }
}
