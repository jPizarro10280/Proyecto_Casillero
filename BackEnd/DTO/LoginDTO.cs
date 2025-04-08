﻿namespace BackEnd.DTO {
    public class LoginDTO {
        public string Username { get; set; }
        public string Password { get; set; }

        public TokenDTO? Token { get; set; }

        public List<string>? Roles { get; set; }
    }
}
