using SudokuVerify.Domain.Entities;
using SudokuVerify.Domain.Interfaces.Repositories;
using SudokuVerify.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuVerify.Infra.Data.Repositories
{
    public class SudokuCheckedRepository : RepositoryBase<SudokuChecked>, ISudokuCheckedRepository
    {
        public SudokuCheckedRepository(BaseContext context): base(context) { }

    }
}
