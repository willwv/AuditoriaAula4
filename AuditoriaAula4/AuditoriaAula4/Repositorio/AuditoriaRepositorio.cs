using AuditoriaAula4.Model;
using AuditoriaAula4.Util;
using System;

namespace AuditoriaAula4.Repositorio
{
    public class AuditoriaRepositorio
    {
        public RetornoAuditoria Auditar(ItemAuditoria item)
        {
            RetornoAuditoria retorno = new RetornoAuditoria() { Sucesso = false };

            if (string.IsNullOrEmpty(item.IdLivro))
                retorno.Mensagem = Strings.FALTA_ID_LIVRO;
            else if (string.IsNullOrEmpty(item.IdUsuario))
                retorno.Mensagem = Strings.FALTA_ID_USUARIO;
            else if (string.IsNullOrEmpty(item.Valor) && Int32.Parse(item.Valor) < 0)
                retorno.Mensagem = Strings.FALTA_VALOR_VENDA;
            else if (item.DataVenda == null)
                retorno.Mensagem = Strings.FALTA_DATA;
            else retorno.Mensagem = Strings.SUCESSO_AUDITORIA;

            return retorno;
        }
    }
}
