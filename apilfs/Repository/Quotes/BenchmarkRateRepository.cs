using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Quotes
{
    public class BenchmarkRateRepository : IBenchmarkRate
    {
        private readonly BD_LFSContext _context;

        public BenchmarkRateRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public bool insertBenchmarkRate(DTO.BenchmarRateDto benchmarkRate, int idQuotes)
        {
            bool respuesta = false;
            try
            {
                var benchmark = new DTO.MapinBenchmarRate();
                _context.BenchmarkRates.Add(benchmark.MapinBenchmarkRate(benchmarkRate, idQuotes));
                Save();
                respuesta = true;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                throw;
            }
            return respuesta;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool updateBenchmarkRate(BenchmarkRate benchmarkRate)
        {
            throw new NotImplementedException();
        }
    }
}
