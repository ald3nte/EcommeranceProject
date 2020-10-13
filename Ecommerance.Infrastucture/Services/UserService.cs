using AutoMapper;
using Ecommerance.Core.Domain;
using Ecommerance.Core.Repositories;
using Ecommerance.Infrastucture.DTO;
using Ecommerance.Infrastucture.Extensions;
using Ecommerance.Infrastucture.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerance.Infrastucture.Services
{
        public class UserService : IUserService
        {
            private readonly IUserRepository _userRepository;
            private readonly IJwtHandler _jwtHandler;
            private readonly IMapper _mapper;
            public UserService(IUserRepository userRepository, IMapper mapper, IJwtHandler jwtHandler)
            {

                _userRepository = userRepository;
                _jwtHandler = jwtHandler;
                _mapper = mapper;
            }

            public async Task<AccountDTO> GetAccountAsync(Guid userId)
            {
            var user = await _userRepository.GetOrFailAsync(userId);
                return _mapper.Map<AccountDTO>(user);
            }

            public async Task<string> LoginAsync(string email, string password)
            {
                var user = await _userRepository.GetAsync(email);
                if (user == null)
                {
                    throw new Exception($"Invalid credentials1.");
                }
                if (user.Password != password)
                {
                    throw new Exception($"Invalid credentials2. {user.Password},{password}");
                }
                var jwt = _jwtHandler.CreateToken(user.Id, user.Role);

                return jwt;
            }

            public async Task RegisterAsync(Guid userId, string email, string firstName, string lastName,  string password, string role = "user")
            {
                var user = await _userRepository.GetAsync(email);
                if (user != null)
                {
                    throw new Exception($"User with email: {email} already exists");
                    throw new Exception($"User with email: {email} already exists");
                }
                user = new User(userId, role, firstName,lastName, email, password);
                await _userRepository.AddAsync(user);


            }
        }
}
