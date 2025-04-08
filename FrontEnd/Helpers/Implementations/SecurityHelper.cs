﻿using FrontEnd.ApiModels;
using FrontEnd.Helpers.Interfaces;
using Newtonsoft.Json;

namespace FrontEnd.Helpers.Implementations {
    public class SecurityHelper : ISecurityHelper {
        IServiceRepository _serviceRepository;
        public SecurityHelper(IServiceRepository service) {
            _serviceRepository = service;
        }


        public LoginAPI Login(string username, string password) {
            try {
                HttpResponseMessage response = _serviceRepository
                                    .PostResponse("api/Auth/login", new { Username = username, Password = password });
                var content = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode) {
                    return JsonConvert.DeserializeObject<LoginAPI>(content);
                } else {
                    return new LoginAPI();
                }

            } catch (Exception) {

                throw;
            }
        }

        public RegisterAPI Register(string username, string password, string email) {
            try {
                HttpResponseMessage response = _serviceRepository
                                    .PostResponse("api/Auth/register", new { Username = username, Password = password, Email = email });
                var content = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode) {
                    return JsonConvert.DeserializeObject<RegisterAPI>(content);
                } else {
                    return new RegisterAPI();
                }

            } catch (Exception) {

                throw;
            }
        }
    }
}
