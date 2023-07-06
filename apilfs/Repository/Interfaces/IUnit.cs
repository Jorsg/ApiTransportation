using System.Linq;

namespace apilfs.Repository.Interfaces
{
    public interface IUnit
    {
        IQueryable<Models.Unit> GetUnits();

        Models.Unit GetUnitbyId(string unit);

        void InsertUnit(Models.Unit unit);

        void Save();
    }
}
