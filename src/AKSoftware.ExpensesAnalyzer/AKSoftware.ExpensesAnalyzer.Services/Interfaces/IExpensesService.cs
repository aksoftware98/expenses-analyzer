using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKSoftware.ExpensesAnalyzer.Services.Interfaces
{
    /// <summary>
    /// Interface that wraps all the logic against the expenses object
    /// </summary>
    public interface IExpensesService
    {

        /// <summary>
        /// Add a new expense object
        /// </summary>
        /// <returns></returns>
        Task CreateAsync();

    }
}
