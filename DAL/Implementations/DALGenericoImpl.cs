﻿using DAL.Interfaces;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class DALGenericoImpl<TEntity> : IDALGenerico<TEntity> where TEntity : class
    {

        private CasilleroProyectoContext _casilleroProyectoContext;

        public DALGenericoImpl(CasilleroProyectoContext casilleroProyectoContext)
        {

            _casilleroProyectoContext = casilleroProyectoContext;
        }

        public bool Add(TEntity entity)
        {
            try
            {
                _casilleroProyectoContext.Add(entity);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public TEntity Get(int id)
        {

            return _casilleroProyectoContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _casilleroProyectoContext.Set<TEntity>().ToList();
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                _casilleroProyectoContext.Set<TEntity>().Attach(entity);
                _casilleroProyectoContext.Set<TEntity>().Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                _casilleroProyectoContext.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
