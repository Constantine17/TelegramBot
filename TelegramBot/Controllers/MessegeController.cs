using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;
using TelegramBot.Models;
using System.Threading.Tasks;

namespace TelegramBot.Controllers
{
    public class MessegeController : ApiController
    {
        [Route(@"api/messege/update")]
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var commands = Bot.Commands;
            var messege  = update.Message;
            var client   = await Bot.Get();

            foreach (var command in commands)
            {
                if (command.Constrains(messege.Text))
                {
                    command.Execute(messege, client);
                }
            }

            return Ok();
        }


        // GET api/<controller>
        [Route(@"api/rr")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [Route(@"api/rr")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
        
    }
}