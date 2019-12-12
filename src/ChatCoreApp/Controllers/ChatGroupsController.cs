using System.Collections.Generic;
using ChatAppCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ChatAppCore.Controllers
{
    [Route("api/groups")]
    public class ChatGroupsController : Controller
    {
        [HttpGet("list")]
        public IEnumerable<ChatGroup> ListGroups()
        {
            return new List<ChatGroup>()
            {
                new ChatGroup {
                    Name = "Pokus",
                    Users = new List<ChatUser>{
                        new ChatUser{
                            Name = "Uživatel 1",
                        },
                        new ChatUser{
                            Name = "Uživatel 2",
                        },
                    }
                }
            };
        }
    }
}