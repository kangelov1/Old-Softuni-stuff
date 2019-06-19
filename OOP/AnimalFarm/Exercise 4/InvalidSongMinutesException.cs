using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InvalidSongMinutesException:InvalidSongException
{
    public InvalidSongMinutesException() : base() { }
    public InvalidSongMinutesException(string message) : base(message) { }
    public InvalidSongMinutesException(int minSongMinutesLength, int maxSongMinutesLength) : base(string.Format("Song minutes should be between {0} and {1}", minSongMinutesLength, maxSongMinutesLength)) { }
}

