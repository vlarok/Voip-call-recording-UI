using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Domain;

namespace DAL.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private ApplicationDbContext _ctx;

        public CommentRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Comment> All
        {
            get
            {
                return _ctx.Comments.ToList();
            }
        }
        
        public bool Delete(int id)
        {
            try
            {
                Comment comment = (from s in All
                                   where s.CommentId == id
                                   select s).FirstOrDefault();
                _ctx.Comments.Remove(comment);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool AddOrUpdate(Comment comment)
        {
            try
            {

                _ctx.Comments.AddOrUpdate(comment);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {


                return false;
            }
        }


    }
}
