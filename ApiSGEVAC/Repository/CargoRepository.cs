using ApiSGEVAC.Models;
using ApiSGEVAC.Data;

namespace ApiSGEVAC.Repository
{
    public class CargoRepository : RepositoryBase<Cargo>, ICargoRepository
    {
        public CargoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}