using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories
{
    public class FileReadRepository : ReadRepository<ETicaretAPI.Domain.Entities.File>, IFileReadRepository
    {
        public FileReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
