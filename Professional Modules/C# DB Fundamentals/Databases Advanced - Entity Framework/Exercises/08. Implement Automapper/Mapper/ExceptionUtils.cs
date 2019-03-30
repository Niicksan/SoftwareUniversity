using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AutoMapper
{
    public class ExceptionUtils
    {
        public const string NullableSourceProperty = "The source type provided is null";
        public const string NullableSourceValueGetMethod = "The get method of the source value provided is null";
        public const string NullSourceValueOrReturnType = "The source or the return type is null";
        public const string NullSource = "The source provided is null";
    }
}
