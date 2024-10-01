using Application.Models.Requests;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService
    {
        public List<User> GetAll();
        public User GetById(int id);
        public void Add(UserCreateRequest request);
        public void Update(int id, UserUpdateRequest request);
        public void Delete(int id);
    }
}
