using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfUserMessageDal : GenericRepository<UserMessage>, IUserMessageDal
    {
        private readonly Context _context;

        public EfUserMessageDal(Context context) : base(context)
        {
           _context = context;
        }

        public List<UserMessage> GetUserMessagesWithUser()
        {
            return _context.UserMessages.Include(x => x.User).ToList();
        }
    }
}
