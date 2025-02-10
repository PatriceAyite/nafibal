﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nafibel.DATA.Repositories
{
    internal class UildConverter
    {
        public class UlidToBytesConverter : ValueConverter<Ulid, byte[]>
        {
            private static readonly ConverterMappingHints defaultHints = new ConverterMappingHints(size: 16);

            public UlidToBytesConverter() : this(null)
            {
            }

            public UlidToBytesConverter(ConverterMappingHints mappingHints = null)
                : base(
                        convertToProviderExpression: x => x.ToByteArray(),
                        convertFromProviderExpression: x => new Ulid(x),
                        mappingHints: defaultHints.With(mappingHints))
            {
            }
        }

        public class UlidToStringConverter : ValueConverter<Ulid, string>
        {
            private static readonly ConverterMappingHints defaultHints = new ConverterMappingHints(size: 26);

            public UlidToStringConverter() : this(null)
            {
            }

            public UlidToStringConverter(ConverterMappingHints mappingHints = null)
                : base(
                        convertToProviderExpression: x => x.ToString(),
                        convertFromProviderExpression: x => Ulid.Parse(x),
                        mappingHints: defaultHints.With(mappingHints))
            {
            }
        }
    }
}
