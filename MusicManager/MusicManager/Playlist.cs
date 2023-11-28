using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicManagerUI
{
    internal class Playlist
    {
        public string playlistName { get; }
        public string ownerName { get; }
        private int ownerUserID { get; }
        private bool isPrivate { get; }
        private bool isDelete { get; }



    }
}
