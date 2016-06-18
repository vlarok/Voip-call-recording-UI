using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using Domain;

namespace BLL.Services
{
    public class CommentService
    {
        private ICommentRepository _repo;
        private Factories.CommentFactory _factory;
        public CommentService()
        {
            this._repo = new CommentRepository(new ApplicationDbContext());
            this._factory = new Factories.CommentFactory();
        }
      

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }
      
        public bool AddOrUpdate(Comment comment)
        {
            return _repo.AddOrUpdate(comment);
        }
    }
}
