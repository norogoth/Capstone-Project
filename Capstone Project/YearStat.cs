using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project
{
    class YearStat : CsvImporter
    {
        public double BAOpp { get; set; }
        public double WHIP { get; set; }
        public double ERA { get; set; }
        public double k9 { get; set; }
        public int IP { get; set; }
        public int yearInLeague { get; set; }

        public YearStat() { }
        public YearStat(CsvImporter csvImporter)
        {
            this.birthYear = csvImporter.birthYear;
            this.nameFirst = csvImporter.nameFirst;
            this.nameLast = csvImporter.nameLast;
            this.age = csvImporter.age;
            this.ID = csvImporter.ID;
            this.playerID = csvImporter.playerID;
            this.yearID = csvImporter.yearID;
            this.stint = csvImporter.stint;
            this.teamID = csvImporter.teamID;
            this.team_ID = csvImporter.team_ID;
            this.LgID = csvImporter.LgID;
            this.W = csvImporter.W;
            this.L = csvImporter.L;
            this.G = csvImporter.G;
            this.GS = csvImporter.GS;
            this.CG = csvImporter.CG;
            this.SHO = csvImporter.SHO;
            this.SV = csvImporter.SV;
            this.IPouts = csvImporter.IPouts;
            this.H = csvImporter.H;
            this.ER = csvImporter.ER;
            this.HR = csvImporter.HR;
            this.BB = csvImporter.BB;
            this.SO = csvImporter.SO;
            this.IBB = csvImporter.IBB;
            this.WP = csvImporter.WP;
            this.HBP = csvImporter.HBP;
            this.BK = csvImporter.BK;
            this.BFP = csvImporter.BFP;
            this.GF = csvImporter.GF;
            this.R = csvImporter.R;
            this.SH = csvImporter.SH;
            this.SF = csvImporter.SF;
            this.GIDP = csvImporter.GIDP;
            this.IP = csvImporter.IPouts / 3;
            if (this.IP != 0)
            {
                this.ERA = (9.0 * csvImporter.ER) / (1.0 * this.IP);
                this.WHIP = ((double)csvImporter.BB + (double)csvImporter.H) / (double)this.IP;
                this.k9 = (this.SO * 9) / this.IP;
            }
        }
    }
}
