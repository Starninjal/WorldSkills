using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioSenai
{
    public class ServiceBase
    {
        public void validarBase(Conversao conversao)
        {
            if(conversao != null)
            {
                Boolean isDescricaoInvalida = conversao.Moeda.Length > 30;
                if (isDescricaoInvalida)
                {
                    throw new Exception("A descrição da moeda deve ter 30 caracteres ou menos! Tente novamente!");
                }
                Boolean isBaseInvalida = conversao.BaseConversao < 0;
                if (isBaseInvalida)
                {
                    throw new Exception("A base de conversao não pode ser negativa");
                }
                
            } else
            {
                throw new Exception("A conversão não pode ser nula. Tente novamente!");
            }

            
        }
       
    }
}
