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
        //public Dictionary<int, ProjYearStat> projectedAgeStatsDict = new Dictionary<int, ProjYearStat>();
        public List<Pitcher> comparablePitchers = new List<Pitcher>();
        public bool atLeastThreeComparables;
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
        public int getAge()
        {
            int currentAge = -1;
            foreach (int age in ageStatsDict.Keys)
            {
                if (age > currentAge)
                {
                    currentAge = age;
                }
            }
            return currentAge;
        }
        public int getYearOfExperience()
        {
            int currentExperience = -1;
            foreach (YearStat yearStat in ageStatsDict.Values)
            {
                if (yearStat.yearInLeague > currentExperience)
                {
                    currentExperience = yearStat.yearInLeague;
                }
            }
            return currentExperience;
        }
        public void initializeComparablePitchers()
        {
            double averagedERA = Data.selectedPitcher.averagedERA();
            double eraMin = averagedERA * .95;
            double eraMax = averagedERA * 1.05;
            int pitcherAge = Data.selectedPitcher.getAge();
            int yearOfExperience = Data.selectedPitcher.getYearOfExperience();
            foreach (Pitcher pitcher in Data.PitcherIdList.Values)
            {
                if (pitcher.ageStatsDict.ContainsKey(pitcherAge)) {
                double EraAtSameAge = pitcher.ageStatsDict[pitcherAge].ERA;
                if (EraAtSameAge > averagedERA * .95 && EraAtSameAge < averagedERA * 1.05)
                    {
                        int comparablePitchersYearsInLeague = pitcher.ageStatsDict[pitcherAge].yearInLeague;
                        if (comparablePitchersYearsInLeague >= yearOfExperience - 1 && comparablePitchersYearsInLeague <= yearOfExperience + 1)
                        {
                            comparablePitchers.Add(pitcher);
                            Console.WriteLine(pitcher.firstName + " " + pitcher.lastName + " is comparable to " + Data.selectedPitcher.firstName + " " + Data.selectedPitcher.lastName);
                        }
                    }
                }
            }
            if (comparablePitchers.Count() >= 3)
            {
                atLeastThreeComparables = true;
            }
            else if (comparablePitchers.Count() < 3)
            {
                atLeastThreeComparables = false;
            }
        }

        public void initializeProjYearStats()
        {
            if (comparablePitchers.Count >= 3)
            {
                int cut = 0;
                int notCut = 0;
                double cutChance = -1;
                List<double> eras = new List<double>();
                double lowerStandardDevEra;
                double predictedEra;
                double upperStandardDevEra;
                List<double> WHIPs = new List<double>();
                double predictedWHIP;
                List<int> ks = new List<int>();
                double predictedKs;
                List<double> k9s = new List<double>();
                double predictedk9s;
                
                int startingPitcherage = getAge();
                for (int ageCounter = startingPitcherage + 1; ageCounter <= startingPitcherage + 5; ageCounter++)
                {
                    foreach (Pitcher comparablePitcher in comparablePitchers)
                    {
                        bool isThisPlayerPlayingAtAge = comparablePitcher.ageStatsDict.ContainsKey(ageCounter);
                        if (isThisPlayerPlayingAtAge)
                        {
                            notCut += 1;
                            eras.Add(comparablePitcher.ageStatsDict[ageCounter].ERA);
                            WHIPs.Add(comparablePitcher.ageStatsDict[ageCounter].WHIP);
                            ks.Add(comparablePitcher.ageStatsDict[ageCounter].SO);
                            k9s.Add(comparablePitcher.ageStatsDict[ageCounter].k9);
                            //Console.WriteLine(comparablePitcher.firstName + " " + comparablePitcher.lastName + " has an ERA of " + comparablePitcher.ageStatsDict[ageCounter].ERA + " at age " + ageCounter);
                        }
                        else if (!isThisPlayerPlayingAtAge)
                        {
                            cut += 1;
                        }
                        cutChance = Math.Round(cut * 1.0 / notCut * 1.0, 3);
                    }
                    double eraSD = StdDev(eras);
                    predictedEra = eras.Average();
                    predictedWHIP = WHIPs.Average();
                    predictedKs = ks.Average();
                    predictedk9s = k9s.Average();

                    lowerStandardDevEra = predictedEra - eraSD;
                    upperStandardDevEra = predictedEra + eraSD;

                    ProjYearStat newPYS = new ProjYearStat(ageCounter);
                    newPYS.ERA = predictedEra;
                    newPYS.lowerStandardDevERA = lowerStandardDevEra;
                    newPYS.upperStandardDevERA = upperStandardDevEra;
                    newPYS.cutChance = cutChance;
                    newPYS.WHIP = predictedWHIP;
                    newPYS.SO = (int) predictedKs;
                    newPYS.k9 = predictedk9s;
                    try 
                    {
                        ageStatsDict.Add(ageCounter, newPYS);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                        foreach(YearStat yearStat in ageStatsDict.Values)
                        {
                            Console.WriteLine("Age: " + yearStat.age);
                            Console.WriteLine("Age of newPYS: " + newPYS.age);
                        }
                    }
                    foreach (YearStat yearStat in ageStatsDict.Values)
                    {
                        Console.WriteLine("Age: " + yearStat.age + " ERA: " + yearStat.ERA);
                    }
                    //Console.WriteLine("getAge(): " + getAge() + " ageCounter: " + ageCounter);
                    /*Console.WriteLine("= = = = = = =");
                    Console.WriteLine("Age: " + newPYS.age + " Predicted ERA: " + newPYS.ERA);
                    Console.WriteLine("Upper ERA: " + newPYS.upperStandardDevERA + " Lower ERA: " + newPYS.lowerStandardDevERA);
                    Console.WriteLine("Cut Chance: " + newPYS.cutChance);
                    Console.WriteLine("Standard Deviation: " + (newPYS.upperStandardDevERA - newPYS.ERA));*/
                }
            }
        }
        public static double StdDev(IEnumerable<double> values)
        {
            double mean = values.Sum() / values.Count();
            List<double> squares_query = new List<double>();
            foreach (double value in values)
            {
                double square = (value - mean) * (value - mean);
                squares_query.Add(square);
            }
            double sum_of_squares = squares_query.Sum();
            return Math.Sqrt(sum_of_squares / (values.Count()));
        }
        public static double StdDev(IEnumerable<int> values)
        {
            double[] doubleArray = new double[values.Count()];
            int i = 0;
            foreach (int value in values)
            {
                double doubleValue = (double) value;
                doubleArray[i] = doubleValue;
                i++;
            }
            double standardDev = StdDev(doubleArray);
            return standardDev;
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
        public List<YearStat> getLatestYsSince(int numberOfYears, int age)
        {
            List<YearStat> latestYearStats = new List<YearStat>();
            int counter = 0;
            int currentMinYear = 3000;
            List<YearStat> yearStatsBeforeAge = new List<YearStat>();
            foreach (YearStat yearStat in this.ageStatsDict.Values)
            {
                if (yearStat.age <= age)
                {
                    yearStatsBeforeAge.Add(yearStat);
                }
            }
            foreach (YearStat yearStat in yearStatsBeforeAge)
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
        public List<YearStat> getLatestYS(int numberOfYears)
        {
            return getLatestYsSince(numberOfYears, getAge());
        }
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
        public double averagedERA(int currentAge)
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
    }
}
