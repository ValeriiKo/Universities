using System.Linq;
using Domain.Abstract;
using Domain.Entities;

namespace Domain.Concrete
{
    public class EFUniversityRepository: IUniversityRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<University> Universities { get { return context.Universities; } }
    }
}
