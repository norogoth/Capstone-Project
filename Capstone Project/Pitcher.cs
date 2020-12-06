using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project
{
    class Pitcher
    {
        public String  Id;
        public String firstName;
        public String lastName;
        public int birthYear;
        public String fullName { get; set; }
        public Dictionary<int, YearStat> ageStatsDict = new Dictionary<int, YearStat>();
        public Dictionary<int, YearStat> projectedAgeStatsDict = new Dictionary<int, YearStat>();
        public Pitcher()
        {

        }
        public Pitcher(String id, String firstName, String lastName, int birthYear)
        {
            this.Id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.fullName = this.firstName + " " + this.lastName;
        }
        public void initializeProjectedAgeStatsDict()
        {
            
            foreach (Pitcher pitcher in Data.PitcherIdList.Values)
            {
                if ()
                {

                }
            }
        }

        public int getOldestYear(List<YearStat> yearStatList)
        {
            int currentMinYear = 3000;
            foreach (YearStat listYearStat in yearStatList)
            {
                if (listYearStat.yearID < currentMinYear)
                {
                    currentMinYear = listYearStat.yearID;
                }
            }
            return currentMinYear;
        }
        public int getLatestYear(List<YearStat> yearStatList)
        {
            int currentMaxYear = -1;
            foreach (YearStat listYearStat in yearStatList)
            {
                if (listYearStat.yearID > currentMaxYear)
                {
                    currentMaxYear = listYearStat.yearID;
                }
            }
            return currentMaxYear;
        }
        public YearStat getYearStatByYear(int year)
        {
            foreach (YearStat yearStat in ageStatsDict.Values)
            {
                if (yearStat.yearID == year)
                {
                    return yearStat;
                }
            }
            return null;
        }
        public List<YearStat> ysListWithOldestRemoved(List<YearStat> yearStatList)
        {
            int minYear = 3000;
            foreach (YearStat yearStat in yearStatList)
            {
                if (yearStat.yearID < minYear)
                {
                    minYear = yearStat.yearID;
                }
            }
            YearStat yearStatToDelete =  getYearStatByYear(minYear);
            yearStatList.Remove(yearStatToDelete);
            return yearStatList;
        }
        public List<YearStat> getLatestYS(int numberOfYears)
        {
            List<YearStat> latestYearStats = new List<YearStat>();
            int counter = 0;
            int currentMinYear = 3000;
            foreach (YearStat yearStat in this.ageStatsDict.Values)
            {
                if (counter <= numberOfYears - 1)
                {
                    latestYearStats.Add(yearStat);
                    currentMinYear = getOldestYear(latestYearStats);
                    counter += 1;
                }
                else
                {
                    if (yearStat.yearID > getOldestYear(latestYearStats))
                    {
                        latestYearStats = ysListWithOldestRemoved(latestYearStats);
                        latestYearStats.Add(yearStat);
                    }
                }
            }
            return latestYearStats;
        }
        //TODO: To find comparable pitchers, we want the pitchers last three years of WHIP and ERA averaged by IP.
        public double averagedERA()
        {
            int totalIP = 0;
            double EraTimesTIP = 0;
            double ERA = 0;
            foreach (YearStat yearStat in getLatestYS(3))
            {
                totalIP += yearStat.IP;
                EraTimesTIP += yearStat.IP * yearStat.ERA;
            }
            ERA = EraTimesTIP / totalIP;
            return ERA;
        }
        //TODO: We want to be able to find how many pitchers had their last year at the age and year of experience and ERA (+/-) of the selected pitcher. This data will show how many players were cut next year.
/*        public YearStat getLatestYearStats()
        {
            int maximum = -1;
            foreach (YearStat yearStat in this.ageStatsDict.Values)
            {
                if (yearStat.yearID > maximum)
                {
                    maximum = yearStat.yearID;
                }
            }
            foreach (YearStat yearStat in this.ageStatsDict.Values)
            {
                if (yearStat.yearID == maximum)
                {
                    return yearStat;
                }
            }
            return null;
        }*/
    }
}
