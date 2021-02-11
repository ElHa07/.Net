using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace Dio.Series
{

    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>();

        public void Atualiza(int id, Serie objeto)
        {
            ListaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            ListaSerie[id].Excluir();
			// implemento envio de e-mail
        }

        public void Insert(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}