using System;

namespace Tabuleiro
{
    class TabuleiroXadrezException : Exception
    {
        public TabuleiroXadrezException(string msg) : base(msg)
        {
        }
    }
}
