using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zh_MF9RFV.JokeModels;

namespace zh_MF9RFV.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class FunnyController : ControllerBase
    {
        [HttpGet]
         [Route("jokes/all")]
         public IActionResult M1()
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var viccek = from x in context.Jokes
                         select x;
            return Ok(viccek);
        }

        [HttpGet]
        [Route("jokes/{id}")]
        public IActionResult M2(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var vicc = (from x in context.Jokes
                        where x.JokeSk == id
                        select x).FirstOrDefault();
            if (vicc == null) return BadRequest("Nincs ilyen sorszámú vicc");
            return Ok(vicc);   
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public void Delete(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var törlendő = (from x in context.Jokes
                            where x.JokeSk == id
                            select x).FirstOrDefault();
            context.Remove(törlendő);
            context.SaveChanges();
        }

        [HttpPost]
        [Route("add")]
        public void Add(string vicc)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            Joke ujVicc = new Joke();
            ujVicc.JokeText = vicc;
            context.Jokes.Add(ujVicc);
            context.SaveChanges();
        }

        [HttpPost]
        [Route("like/{id}")]
        public void Like(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var jóVicc = (from x in context.Jokes
                          where x.JokeSk == id
                          select x).FirstOrDefault();
            jóVicc.UpVotes++;
            context.Update(jóVicc);
            context.SaveChanges();
        }

        [HttpPost]
        [Route("dislike/{id}")]
        public void Disike(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var rosszVicc = (from x in context.Jokes
                          where x.JokeSk == id
                          select x).FirstOrDefault();
            rosszVicc.DownVotes++;
            context.Update(rosszVicc);
            context.SaveChanges();
        }
    }
}
