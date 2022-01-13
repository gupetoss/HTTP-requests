using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JediController : ControllerBase
    {
        /*public static List<string> RankJedi = new List<string>
        {
            "Yunling", "Padawan", "Jedi", "Master", "Sith"
        };

        public static List<string> Abilities = new List<string>
        {
            "Flamusfract", "Impact on the mind", "Tutaminis", "Curator Salva", "Altus Sopor", "Prima Vista", "Tactus Society",
            "Aggravation of Feelings", "Ty wordrax", "Mental telepathy", "Telekinesis", "Changing the environment", "Sato Consigliere",
            "Combat Meditation", "Decrease", "Similfuturus", "Capturing Power"
        };*/

        public static List<Jedi> Jedis = new List<Jedi>
        {
            new Jedi(1, "Kan Dro", "Droft", "Jedi", "Froggy Luss", "Rebel", "Flamusfract, Impact on the mind"),
            new Jedi(2, "Shupo Draw", "Unknown", "Sith", "No", "Krath", "Ty wordrax, Similfuturus, Mental telepathy")
        };

        // GET: api/<JediController>
        [HttpGet]
        public List<Jedi> Get()
        {
            return Jedis;
        }

        // GET api/<JediController>/string
        [HttpGet("{findString}")]
        public List<Jedi> Get(string findString)
        {
            List<Jedi> jedis = new List<Jedi>();
            foreach (Jedi j in Jedis)
            {
                if (Int32.TryParse(findString, out int id))
                {
                    if (j.Id == id)
                    {
                        jedis.Add(j);
                        continue;
                    }
                }
                else if (j.Name == findString || j.Rank == findString || j.Padawan == findString || j.Locations == findString)
                {
                    jedis.Add(j);
                }
            }
            return jedis;
        }

        // POST api/<JediController>
        [HttpPost]
        public void Post([FromBody] Jedi jedi)
        {
            Jedis.Add(jedi);
        }

        // PUT api/<JediController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Jedi updateJedi)
        {
            Jedi jedi = Jedis.Find(f => f.Id == id);
            int index = Jedis.IndexOf(jedi);

            Jedis[index].Id = updateJedi.Id;
            Jedis[index].Name = updateJedi.Name;
            Jedis[index].Locations = updateJedi.Locations;
            Jedis[index].Way = updateJedi.Way;
            Jedis[index].Padawan = updateJedi.Padawan;
            Jedis[index].Abilities = updateJedi.Abilities;
            Jedis[index].Rank = updateJedi.Rank;
        }

        // DELETE api/<JediController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Jedi jedi = Jedis.Find(f => f.Id == id);
            Jedis.Remove(jedi);
        }
    }
}
