﻿namespace FlatFile.Benchmark.Mapping
{
    using CsvHelper.Configuration;
    using FlatFile.Benchmark.Entities;

    public sealed class CsvHelperMappingForCustomObject : CsvClassMap<CustomObject>
    {
        public CsvHelperMappingForCustomObject()
        {
            Map(m => m.GuidColumn).Name("Guid Column").Index(2);
            Map(m => m.IntColumn).Name("Int Column").Index(1);
            Map(m => m.StringColumn).Name("String Column").Index(0);
        }
    }
}