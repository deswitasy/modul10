using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using modul10_103022300004.Models;
using Microsoft.AspNetCore.Http;

namespace modul10_103022300004.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private static List<Movie> movieList = new List<Movie>
        {
            new Movie ("The Shawshank Redemption", "Frank Darabont", new List<string> { "Tim Robbins" , "Morgan Freeman", "Bob Gunton"}, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie ("The GodFather", "Francis Ford Coppola",  new List<string> {"Marlon Brando", "Al Pacino", "James Caan" }, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movie ("The Dark Knight", "Christopher Nolan", new List<string>{"Christian Bale", "Heath Ledger", "Aaron Eckhart"}, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        };
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            return Ok(movieList);
        }
        [HttpGet("{index}")]
        public ActionResult<Movie> Get(int index)
        {
            if (index < 0 || index >= movieList.Count)
            {
                return NotFound();
            }
            return Ok(movieList[index]);
        }
        [HttpPost]
        public void Post([FromBody] Movie movieBaru)
        {
            movieList.Add(movieBaru);

        }
        [HttpDelete]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= movieList.Count)
            {
                return NotFound();
            }
            movieList.RemoveAt(index);
            return Ok();
        }
    }
}
