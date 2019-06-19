﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InvalidArtistNameException:InvalidSongException
{
    public InvalidArtistNameException() : base() { }
    public InvalidArtistNameException(string message) : base(message) { }
    public InvalidArtistNameException(int minNameLength,int maxNameLength):base(string.Format("Artist name should be between{0} and {1} symbols",minNameLength,maxNameLength))
}

