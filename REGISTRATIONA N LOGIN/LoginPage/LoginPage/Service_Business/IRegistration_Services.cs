using LoginPage.Models;
using System;
using System.Collections.Generic;


namespace LoginPage.Service_Business
{
    public interface IRegistration_Services
    {
        bool Login(string email, string password);
        public AccounUser RegisterUser(AccounUser accounUser);
        //List<AccounUser> GetAllAccounUsers();

     
    }
}
 