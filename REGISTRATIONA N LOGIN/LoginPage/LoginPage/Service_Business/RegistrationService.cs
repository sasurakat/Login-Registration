using LoginPage.DB.Entities;
using LoginPage.Models;
using LoginPage.Repository;
using System;
using System.Collections.Generic;

namespace LoginPage.Service_Business
{
    public class RegistrationService : IRegistration_Services
    {
        private readonly IUserRepo _userRepo;

        public RegistrationService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public AccounUser RegisterUser(AccounUser acountUser)
        {
            UserRegistration userRegistration = new UserRegistration()
            {
                FirstName = acountUser.FirstName,
                LastName = acountUser.LastName,
                Email = acountUser.Email,
                Password = acountUser.Password,
                ConfirmedPassword = acountUser.ConfirmedPassword,
                PhoneNumber = acountUser.PhoneNumber,
                DOB = acountUser.DOB
            };

            _userRepo.RegisterUser(userRegistration);
            return acountUser;
        }
        public bool Login(string email, string password)
        {
          

            throw new NotImplementedException();
        }
        // Uncomment this method if needed
        //public List<UserRegistration> GetAllAccounUsers()
        //{
        //    // Implementation
        //}
    }
}
