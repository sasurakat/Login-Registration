using LoginPage.DB.Entities;
using LoginPage.DB.WriteAndReadFromJson;
using System;
using System.Collections.Generic;

namespace LoginPage.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly string Registerfile = "Data.Json";
        private readonly WriteToJson _writeToJson;
        private readonly ReadFromJson _readFromJson;

        public UserRepo(WriteToJson writeToJson, ReadFromJson readFromJson)
        {
            _writeToJson = writeToJson;
            _readFromJson = readFromJson;
        }

        public void RegisterUser(UserRegistration registration)
        {
            try
            {
                List<UserRegistration> listOfRegistered = _readFromJson.ReadFromJsons<UserRegistration>(Registerfile);
                listOfRegistered.Add(registration);
                _writeToJson.WriteToJsons(listOfRegistered, Registerfile);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool Login(string email, string password)
        {
            try
            {
                List<UserRegistration> listOfRegistered = _readFromJson.ReadFromJsons<UserRegistration>(Registerfile);

                foreach (UserRegistration registration in listOfRegistered)
                {
                    if (registration.Email == email && registration.Password == password)
                    {
                        return true; // User found
                    }
                }

                return false; // User not found
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
