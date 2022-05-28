using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories
{
    public class FileWriteRepository : WriteRepository<Domain.Entities.File>, IFileWriteRepository
    {
        public FileWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
