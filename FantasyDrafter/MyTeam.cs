using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyDrafter
{
    class MyTeam
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Team { get; set; }
        public int Bye { get; set; }

        public MyTeam()
        {
            this.Name = "";
            this.Position = "";
            this.Team = "";
            this.Bye = 0;
        }

        public MyTeam(string name, string postion, string team, int bye)
        {
            this.Name = name;
            this.Position = postion;
            this.Team = team;
            this.Bye = bye;
        }

        public override string ToString()
        {
            return (this.Name + "\t\t\t\t" + this.Position + "\t\t\t\t" + this.Team + "\t\t\t\t" + this.Bye);
        }
    }
}
