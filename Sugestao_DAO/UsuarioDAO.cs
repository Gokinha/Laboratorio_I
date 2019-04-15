using System;
using System.Collections.Generic;
using Sistema.Arquitetura.Library.Core;
using Sistema.Arquitetura.Library.Core.Interface;
using Sistema.Arquitetura.Library.Core.Util.Security;
using Sugestao_VO;

namespace Sugestao_DAO
{
    class UsuarioDAO : NativeDAO<UsuarioVO>, IBaseDAO<UsuarioVO, int>
    {

        /// <summary>
        /// Inicializa uma instância da classe
        /// </summary>
        /// <param name="connection">Recebendo como parametro a conexao com banco de dados</param>
        /// <param name="objectSecurity">Objeto de segurança</param>
        /// <returns>Objeto inserido</returns>
        public UsuarioDAO(System.Data.IDbConnection connection, ObjectSecurity objectSecurity) : base(connection, objectSecurity)
        {
        }

        #region WOLI - Métodos de Persistência Básicos

        /// <summary>
        /// Realiza o insert do objeto por stored Procedure
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser inserido</param>
        /// <returns>Objeto Inserido</returns>
        public UsuarioVO InsertByStoredProcedure(UsuarioVO pObject)
        {
            string sql = "dbo.Usuario";
            StatementDAO statement = new StatementDAO(sql);
            statement.AddParameter("idUsuario", pObject.idUsuario);
            statement.AddParameter("idSetor", pObject.idSetor);
            statement.AddParameter("nome", pObject.nome);
            statement.AddParameter("senha", pObject.senha);
            statement.AddParameter("cpf", pObject.cpf);
            return this.ExecuteReturnT(statement);
        }

        /// <summary>
        /// Realiza o update do objeto por stored Procedure
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser atualizado</param>
        /// <returns>Objeto Atualizado</returns>
        public UsuarioVO UpdateByStoredProcedure(UsuarioVO pObject)
        {
            string sql = "dbo.Usuario";
            StatementDAO statement = new StatementDAO(sql);
            statement.AddParameter("idUsuario", pObject.idUsuario);
            statement.AddParameter("idSetor", pObject.idSetor);
            statement.AddParameter("nome", pObject.nome);
            statement.AddParameter("senha", pObject.senha);
            statement.AddParameter("cpf", pObject.cpf);
            return this.ExecuteReturnT(statement);
        }

        /// <summary>
        /// Realiza a deleção do objeto por stored Procedure
        /// </summary>
        /// <param name="pidCargo">PK da tabela</param>
        /// <returns>Quantidade de Registros deletados</returns>
        public int DeleteByStoredProcedure(int pidUsuario, bool flExclusaoLogica, int userSystem)
        {
            string sql = "Usuario";
            StatementDAO statement = new StatementDAO(sql);
            statement.AddParameter("idUsuario", pidUsuario);
            statement.AddParameter("In_user_system", userSystem);
            return this.ExecuteNonQuery(statement);
        }

        /// <summary>
        /// Retorna registro pela PK
        /// </summary>
        /// <param name="pidCargo">PK da tabela</param>
        /// <returns>Registro da PK</returns>
        public UsuarioVO SelectByPK(int pidUsuario)
        {
            string sql = "dbo.S_sp_Usuario_PK";
            StatementDAO statement = new StatementDAO(sql);
            statement.AddParameter("In_idUsuario", pidUsuario);
            return this.ExecuteReturnT(statement);
        }

        /// <summary>
        /// Realiza a busca Lookup
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser atribuidos no filtro</param>
        /// <returns>Lista de Objetos que atendam ao filtro</returns>
        public IList<UsuarioVO> ListForLookup(UsuarioVO pObject)
        {
            string sql = "Usuario_Lookup";
            StatementDAO statement = new StatementDAO(sql);
            return this.ExecuteReturnListT(statement);
        }

        /// <summary>
        /// Realiza a busca pelos parametros informados no objeto por stored Procedure
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser atribuidos no filtro</param>
        /// <param name="pNumRegPag">Número de registros por página</param>
        /// <param name="pNumPagina">Página corrente</param>
        /// <param name="pDesOrdem">Critério de ordenação</param>
        /// <param name="pNumTotReg">Quantidade de registros que a consulta retorna</param>
        /// <returns>Lista de Objetos que atendam ao filtro</returns>
        public IList<UsuarioVO> ListForGrid(UsuarioVO pObject, int pNumRegPag, int pNumPagina, string pDesOrdem, out int pNumTotReg)
        {
            string sql = "dbo.S_sp_Usuario_Grid";
            StatementDAO statement = new StatementDAO(sql);
            // Parametros para realizar a paginação
            statement.AddParameter("In_Num_Registro_Pagina", pNumRegPag, pNumRegPag.GetType());
            statement.AddParameter("In_Num_Pagina", pNumPagina, pNumPagina.GetType());
            statement.AddParameter("In_Des_Ordem", pDesOrdem, string.Empty.GetType());
            return this.ExecuteReturnListT(statement, out pNumTotReg);
        }

        #endregion

        #region Métodos Personalizados

        #endregion
    }
}