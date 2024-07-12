using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Latih12_MdiForm
{
    public class DbDal
    {
        private const string _connstring= @"Data Source=DESKTOP-B10RQSP;Initial Catalog = LatihanDatabase; Integrated Security = True; Encrypt=True;Trust Server Certificate=True";
    }
    public IEnumerable<MahasiswaModel> Listdata()
    {
        const string sql = @"SELECT * FROM Mahasiswa";
        using var conn = new SqlConnection(_connstring);
        var listMahasiswa = conn.Query<MahasiswaModel>(sql);
        return listMahasiswa;
    }
}
