using System;
using System.Collections.Generic;
using System.Text;

    class InvalidSongMinuteException : InvalidSongLengthException
    {
        private const string Message = "Song minutes should be between 0 and 14.";

        public InvalidSongMinuteException()
            : base(Message)
        {
        }

        public InvalidSongMinuteException(string message)
            : base(message)
        {
        }
    }

