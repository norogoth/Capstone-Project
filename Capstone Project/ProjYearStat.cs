using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project
{
    class ProjYearStat : YearStat
    {
        public double cutChance;
        public double lowerStandardDevERA;
        //public double predictedERA;
        public double upperStandardDevERA;
        public ProjYearStat(int age)
        {
            this.age = age;
        }
        public ProjYearStat(YearStat yearStat)
        {
            this.birthYear = yearStat.birthYear;
            this.nameFirst = yearStat.nameFirst;
            this.nameLast = yearStat.nameLast;
            this.age = yearStat.age;
            this.ID = yearStat.ID;
            this.playerID = yearStat.playerID;
            this.yearID = yearStat.yearID;
            this.stint = yearStat.stint;
            this.teamID = yearStat.teamID;
            this.team_ID = yearStat.team_ID;
            this.LgID = yearStat.LgID;
            this.W = yearStat.W;
            this.L = yearStat.L;
            this.G = yearStat.G;
            this.GS = yearStat.GS;
            this.CG = yearStat.CG;
            this.SHO = yearStat.SHO;
            this.SV = yearStat.SV;
            this.IPouts = yearStat.IPouts;
            this.H = yearStat.H;
            this.ER = yearStat.ER;
            this.HR = yearStat.HR;
            this.BB = yearStat.BB;
            this.SO = yearStat.SO;
            this.IBB = yearStat.IBB;
            this.WP = yearStat.WP;
            this.HBP = yearStat.HBP;
            this.BK = yearStat.BK;
            this.BFP = yearStat.BFP;
            this.GF = yearStat.GF;
            this.R = yearStat.R;
            this.SH = yearStat.SH;
            this.SF = yearStat.SF;
            this.GIDP = yearStat.GIDP;
            this.IP = yearStat.IPouts / 3;
            if (this.IP != 0)
            {
                this.ERA = 9.0 * yearStat.ER / this.IP;
                this.WHIP = ((double)yearStat.BB + (double)yearStat.H) / ((double) this.IP);
                this.k9 = (this.SO * 9) / this.IP;
            }
            //cutChance = -1;
            lowerStandardDevERA = -1;
            //predictedERA = -1;
            upperStandardDevERA = -1;
    }
    }
}
