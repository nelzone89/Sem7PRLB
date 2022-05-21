using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Sem7B
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection(); //Metodo de conexion
    }
}
