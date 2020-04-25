using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public interface IDataReaderDelegate<out T> : IDataDelegate
    {
        T Translate(SqlCommand command, IDataRowReader reader);
    }
}
