using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuVerify.Infra
{

    public class BaseContext : DbContext
    {
        /// <summary>Initializes a new instance of the <see cref="BaseContext" /> class.</summary>
        /// <param name="options">The options.</param>
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }        
    }   
}
