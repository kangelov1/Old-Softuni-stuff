using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InvalidSongSecondsException:InvalidSongException
{
    public InvalidSongSecondsException() : base() { }
    public InvalidSongSecondsException(string message) : base(message) { }
    public InvalidSongSecondsException(int minSongSecondsLength, int maxSongSecondsLength) : base(string.Format("Song seconds should be between {0} and {1}", minSongSecondsLength, maxSongSecondsLength)) { }
}

