using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul9_1302210095
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> MahasiswaData = new List<Mahasiswa>
        {
            new Mahasiswa("Rahma Sakti Rahardian","1302210095", new List<string>{"CRI2C4","CRI2E4","CRJ2G3","CII3B4","CRJ2H3","CRJ2H3","CRJ2A3","CRI2F2"},2),
            new Mahasiswa("Alif Taufiqurrahman" ,"1302213011", new List<string>{"CRI2C4","CRI2E4","CRJ2G3","CII3B4","CRJ2H3","CRJ2H3","CRJ2A3","CRI2F2"},2),
            new Mahasiswa("Deva Angela Felisitas Toding", "1302213111", new List<string>{"CRI2C4","CRI2E4","CRJ2G3","CII3B4","CRJ2H3","CRJ2H3","CRJ2A3","CRI2F2"}, 2)
        };
        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return MahasiswaData;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return MahasiswaData[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            MahasiswaData.Add(value);
        }

        // PUT api/<MahasiswaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            MahasiswaData[id] = value;
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            MahasiswaData.Remove(MahasiswaData[id]);
        }
    }
}
