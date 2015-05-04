using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebAp.Controllers;
using WebAp.IRepositories;
using WebAp.Models;
using WebAp.ModelsView;
using WebAp.Repositories;

namespace WebAp.IRepositories
{
    interface IMessageRepository : IRepository<Message>
    {
    }
}
