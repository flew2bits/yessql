using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesSql
{
    public interface IReadOnlySession: IDisposable
    {
        /// <summary>
        /// Loads objects by id
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAsync<T>(int[] ids) where T : class;
    }
}
