using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discolister.Classes
{
    public class Songs
    {
        //contacts class with properties
        [PrimaryKey, AutoIncrement]
        //AutoIncriment adds to ID
        public int Song_ID { get; set; }
        public string sSongName { get; set; }
        public string sAlbumTitle { get; set; }
        public int iAlbumFK_ID { get; set; }
        public string sSongSummary { get; set; }
        public string sSongPath { get; set; }


    }
}
