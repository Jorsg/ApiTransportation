using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IBenchmarkRate
    {
        bool insertBenchmarkRate(DTO.BenchmarRateDto benchmarkRate, int idQuotes);

        bool updateBenchmarkRate(apilfs.Models.BenchmarkRate benchmarkRate);

        void Save();
    }
}
