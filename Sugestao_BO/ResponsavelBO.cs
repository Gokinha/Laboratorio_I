using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using Sistema.Arquitetura.Library.Core.Interface;
using Sistema.Arquitetura.Library.Core.Util.Security;
using Sugestao_VO;
using Sugestao_DAO;


namespace ResponsavelBO
{

    /// <summary>
    /// Classe de Negocios da Tabela Responsavel
    /// </summary>
    public class ResponsavelBO : IBaseBO<ResponsavelBO, int>
    {

        #region Variaveis Locais
        /// <summary>
        /// Define o objeto de acesso a dados.
        /// </summary>
        protected ResponsavelDAO ResponsavelDAO;
        /// <summary>
        /// Objeto de segurança
        /// </summary>
        protected ObjectSecurity objectSecurity;

        #endregion

        #region Construtores

        /// <summary>
        /// Inicializa uma instância da classe. Cria uma nova conexao com o banco de dados
        /// </summary>
        public ResponsavelBO(ObjectSecurity pObjectSecurity) : base()
        {
            ResponsavelDAO = new ResponsavelDAO(ConnectionFactory.GetDbConnectionDefault(), pObjectSecurity);
            objectSecurity = pObjectSecurity;
        }

        /// <summary>
        /// Inicializa uma instância da classe. Recebendo como parametro a conexao com banco de dados
        /// </summary>
        public ResponsavelBO(System.Data.IDbConnection pIDbConnection, ObjectSecurity pObjectSecurity) : base()
        {
            ResponsavelDAO = new ResponsavelDAO(pIDbConnection, pObjectSecurity);
            objectSecurity = pObjectSecurity;
        }

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the <see cref="ResponsavelBO"/> is reclaimed by garbage collection.
        /// </summary>
        ~ResponsavelBO()
        {
            ResponsavelDAO.Dispose();
        }

        #endregion

        #region WOLI - Métodos Básicos

        /// <summary>
        /// Realiza o insert do objeto por stored Procedure
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser inserido</param>
        /// <returns>Objeto Inserido</returns>
        public Responsavel Insert(Responsavel pObject)
        {
            ResponsavelDAO.BeginTransaction();
            try
            {
                Responsavel ResponsavelAux = ResponsavelDAO.InsertByStoredProcedure(pObject);
                pObject.idResponsavel = ResponsavelAux.idResponsavel;

                ResponsavelDAO.CommitTransaction();
            }
            catch (Exception ex)
            {
                ResponsavelDAO.RollbackTransaction();
                throw ex;
            }
            return pObject;
        }

        /// <summary>
        /// Realiza o update do objeto por stored Procedure
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser atualizado</param>
        /// <returns>Objeto Atualizado</returns>
        public Responsavel Update(Responsavel pObject)
        {
            ResponsavelDAO.BeginTransaction();
            try
            {
                ResponsavelDAO.UpdateByStoredProcedure(pObject);

                ResponsavelDAO.CommitTransaction();
            }
            catch (Exception ex)
            {
                ResponsavelDAO.RollbackTransaction();
                throw ex;
            }
            return pObject;
        }

        /// <summary>
        /// Realiza a deleção do objeto por stored Procedure
        /// </summary>
        /// <param name="pidResponsavel">PK da tabela</param>
        /// <returns>Quantidade de Registros deletados</returns>
        public int Delete(int pidResponsavel)
        {
            int iRetorno = 0;
            ResponsavelDAO.BeginTransaction();
            try
            {
                iRetorno = ResponsavelDAO.DeleteByStoredProcedure(pidResponsavel, false, objectSecurity.UserSystem);
                ResponsavelDAO.CommitTransaction();
            }
            catch (Exception ex)
            {
                ResponsavelDAO.RollbackTransaction();
                throw ex;
            }
            return iRetorno;
        }

        /// <summary>
        /// Retorna registro pela PK
        /// </summary>
        /// <param name="pidResponsavel">PK da tabela</param>
        /// <returns>Registro da PK</returns>
        public Responsavel SelectByPK(int pidResponsavel)
        {
            return ResponsavelDAO.SelectByPK(pidResponsavel);
        }

        /// <summary>
        /// Realiza a busca Lookup
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser atribuidos no filtro</param>
        /// <returns>Lista de Objetos que atendam ao filtro</returns>
        public IList<Responsavel> ListForLookup(Responsavel pObject)
        {
            return ResponsavelDAO.ListForLookup(pObject);
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
        public IList<Responsavel> ListForGrid(Responsavel pObject, int pNumRegPag, int pNumPagina, string pDesOrdem, out int pNumTotReg)
        {
            return ResponsavelDAO.ListForGrid(pObject, pNumRegPag, pNumPagina, pDesOrdem, out pNumTotReg);
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
                ResponsavelDAO = null;

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

        public ResponsavelBO Insert(ResponsavelBO pObject)
        {
            throw new NotImplementedException();
        }

        public ResponsavelBO Update(ResponsavelBO pObject)
        {
            throw new NotImplementedException();
        }

        public IList<ResponsavelBO> ListForGrid(ResponsavelBO pObject, int pNumRegPag, int pNumPagina, string pDesOrdem, out int pNumTotReg)
        {
            throw new NotImplementedException();
        }

        public IList<ResponsavelBO> ListForLookup(ResponsavelBO pObject)
        {
            throw new NotImplementedException();
        }

        ResponsavelBO IBaseBO<ResponsavelBO, int>.SelectByPK(int pChave)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion

        #region Metodos Personalizados

        #endregion
    }

    public class Responsavel
    {
        public object idResponsavel { get; internal set; }
    }
}
