using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using Sistema.Arquitetura.Library.Core.Interface;
using Sistema.Arquitetura.Library.Core.Util.Security;
using Sugestao_VO;
using Sugestao_DAO;


namespace UsuarioBO
{

    /// <summary>
    /// Classe de Negocios da Tabela Usuario
    /// </summary>
    public class UsuarioBO : IBaseBO<UsuarioBO, int>
    {

        #region Variaveis Locais
        /// <summary>
        /// Define o objeto de acesso a dados.
        /// </summary>
        protected UsuarioDAO UsuarioDAO;
        /// <summary>
        /// Objeto de segurança
        /// </summary>
        protected ObjectSecurity objectSecurity;

        #endregion

        #region Construtores

        /// <summary>
        /// Inicializa uma instância da classe. Cria uma nova conexao com o banco de dados
        /// </summary>
        public UsuarioBO(ObjectSecurity pObjectSecurity) : base()
        {
            UsuarioDAO = new UsuarioDAO(ConnectionFactory.GetDbConnectionDefault(), pObjectSecurity);
            objectSecurity = pObjectSecurity;
        }

        /// <summary>
        /// Inicializa uma instância da classe. Recebendo como parametro a conexao com banco de dados
        /// </summary>
        public UsuarioBO(System.Data.IDbConnection pIDbConnection, ObjectSecurity pObjectSecurity) : base()
        {
            UsuarioDAO = new UsuarioDAO(pIDbConnection, pObjectSecurity);
            objectSecurity = pObjectSecurity;
        }

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the <see cref="UsuarioBO"/> is reclaimed by garbage collection.
        /// </summary>
        ~UsuarioBO()
        {
            UsuarioDAO.Dispose();
        }

        #endregion

        #region WOLI - Métodos Básicos

        /// <summary>
        /// Realiza o insert do objeto por stored Procedure
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser inserido</param>
        /// <returns>Objeto Inserido</returns>
        public Usuario Insert(Usuario pObject)
        {
            UsuarioDAO.BeginTransaction();
            try
            {
                Usuario UsuarioAux = UsuarioDAO.InsertByStoredProcedure(pObject);
                pObject.idUsuario = UsuarioAux.idUsuario;

                UsuarioDAO.CommitTransaction();
            }
            catch (Exception ex)
            {
                UsuarioDAO.RollbackTransaction();
                throw ex;
            }
            return pObject;
        }

        /// <summary>
        /// Realiza o update do objeto por stored Procedure
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser atualizado</param>
        /// <returns>Objeto Atualizado</returns>
        public Usuario Update(Usuario pObject)
        {
            UsuarioDAO.BeginTransaction();
            try
            {
                UsuarioDAO.UpdateByStoredProcedure(pObject);

                UsuarioDAO.CommitTransaction();
            }
            catch (Exception ex)
            {
                UsuarioDAO.RollbackTransaction();
                throw ex;
            }
            return pObject;
        }

        /// <summary>
        /// Realiza a deleção do objeto por stored Procedure
        /// </summary>
        /// <param name="pidUsuario">PK da tabela</param>
        /// <returns>Quantidade de Registros deletados</returns>
        public int Delete(int pidUsuario)
        {
            int iRetorno = 0;
            UsuarioDAO.BeginTransaction();
            try
            {
                iRetorno = UsuarioDAO.DeleteByStoredProcedure(pidUsuario, false, objectSecurity.UserSystem);
                UsuarioDAO.CommitTransaction();
            }
            catch (Exception ex)
            {
                UsuarioDAO.RollbackTransaction();
                throw ex;
            }
            return iRetorno;
        }

        /// <summary>
        /// Retorna registro pela PK
        /// </summary>
        /// <param name="pidUsuario">PK da tabela</param>
        /// <returns>Registro da PK</returns>
        public Usuario SelectByPK(int pidUsuario)
        {
            return UsuarioDAO.SelectByPK(pidUsuario);
        }

        /// <summary>
        /// Realiza a busca Lookup
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser atribuidos no filtro</param>
        /// <returns>Lista de Objetos que atendam ao filtro</returns>
        public IList<Usuario> ListForLookup(Usuario pObject)
        {
            return UsuarioDAO.ListForLookup(pObject);
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
        public IList<Usuario> ListForGrid(Usuario pObject, int pNumRegPag, int pNumPagina, string pDesOrdem, out int pNumTotReg)
        {
            return UsuarioDAO.ListForGrid(pObject, pNumRegPag, pNumPagina, pDesOrdem, out pNumTotReg);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {

            if (!disposedValue)
            {

                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }
                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                objectSecurity = null;
                UsuarioDAO = null;

                disposedValue = true;
            }
        }

        /// <summary>
        /// This code added to correctly implement the disposable pattern.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        public UsuarioBO Insert(UsuarioBO pObject)
        {
            throw new NotImplementedException();
        }

        public UsuarioBO Update(UsuarioBO pObject)
        {
            throw new NotImplementedException();
        }

        public IList<UsuarioBO> ListForGrid(UsuarioBO pObject, int pNumRegPag, int pNumPagina, string pDesOrdem, out int pNumTotReg)
        {
            throw new NotImplementedException();
        }

        public IList<UsuarioBO> ListForLookup(UsuarioBO pObject)
        {
            throw new NotImplementedException();
        }

        UsuarioBO IBaseBO<UsuarioBO, int>.SelectByPK(int pChave)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion

        #region Metodos Personalizados

        #endregion
    }

    public class Usuario
    {
        public object idUsuario { get; internal set; }
    }
}
