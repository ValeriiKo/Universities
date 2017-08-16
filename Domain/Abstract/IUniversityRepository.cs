using Domain.Entities;
using System.Linq;


namespace Domain.Abstract
{
    public interface IUniversityRepository
    {
        IQueryable<University> Universities { get; }
    }
}
