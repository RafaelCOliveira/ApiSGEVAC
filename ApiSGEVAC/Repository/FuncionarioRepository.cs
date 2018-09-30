using ApiSGEVAC.Models;
using ApiSGEVAC.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace ApiSGEVAC.Repository
{
    public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override Funcionario GetById(int id)
        {
            return _dbContext.Set<Funcionario>()
                .Include(e=> e.Cargo)
                .Include(p => p.Pessoa)
                .Where<Funcionario>(g => g.IdFuncionario == id)
                .First();
        }
 
        public override IEnumerable<Funcionario> List()
        {
            
            return _dbContext.Set<Funcionario>()
                .Include(e=> e.Cargo)
                .Include(p => p.Pessoa)
                .ToList(); 
        }

    }
}