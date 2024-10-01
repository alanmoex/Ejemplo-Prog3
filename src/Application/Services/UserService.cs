using Application.Interfaces;
using Application.Models.Requests;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private static int count = 0;
        private readonly IUserRepository _userRepository; 
        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository; 
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id) 
        {
            return _userRepository.GetById(id);
        }

        public void Add(UserCreateRequest request) 
        {
            User user = new User(request.Name, request.Email, request.Password);
            user.Id = count;
            count++;
            _userRepository.Add(user);
        }

        public void Update(int id, UserUpdateRequest request) 
        {
            var obj = _userRepository.GetById(id);

            if (!string.IsNullOrEmpty(request.Name)) { obj.Name = request.Name; }
            if (!string.IsNullOrEmpty(request.Email)) { obj.Email = request.Email; }
            if (!string.IsNullOrEmpty(request.Password)) { obj.Password = request.Password; }

            _userRepository.Update(id, obj);
        }

        public void Delete(int id) 
        {
            var obj = _userRepository.GetById(id);
            _userRepository.Delete(obj);
        }
    }
}
