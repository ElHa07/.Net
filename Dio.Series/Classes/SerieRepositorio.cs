using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace Dio.Series
{

    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaSeries = new List<Serie>();

        public void Atualiza(int id, Serie entdidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Serie entidade)
        {
            throw new NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Serie RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}