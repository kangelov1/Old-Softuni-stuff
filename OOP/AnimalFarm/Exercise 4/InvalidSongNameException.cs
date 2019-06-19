using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class InvalidSongNameException:InvalidSongException
{
    public InvalidSongNameException() : base() { }
    public InvalidSongNameException(string message) : base(message) { }
    public InvalidSongNameException(int minSongNameLength, int maxSongNameLength) : base(string.Format("Song name should be between {0} and {1} symbols", minSongNameLength, maxSongNameLength)) { }
}

