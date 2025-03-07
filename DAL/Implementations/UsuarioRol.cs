﻿using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class UsuarioRolDAL : DALGenericoImpl<UsuarioRol>, IUsuarioRolDAL
    {

        private CasilleroProyectoContext _context;

        public UsuarioRolDAL(CasilleroProyectoContext context) : base(context)
        {
            _context = context;
        }

    }
}
