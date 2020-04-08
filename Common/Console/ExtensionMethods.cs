using System;

namespace Common
{
    public static class ExtensionMethods
    {
        public static char CharAt(this string @string, int pos) => @string[pos];
    }
}
