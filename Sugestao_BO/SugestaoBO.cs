using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using Sistema.Arquitetura.Library.Core.Interface;
using Sistema.Arquitetura.Library.Core.Util.Security;
using Sugestao_VO;
using Sugestao_DAO;


namespace SugestaoBO
{

    /// <summary>
    /// Classe de Negocios da Tabela Sugestao
    /// </summary>
    public class SugestaoBO : IBaseBO<SugestaoBO, int>
    {

        #region Variaveis Locais
        /// <summary>
        /// Define o objeto de acesso a dados.
        /// </summary>
        protected SugestaoDAO SugestaoDAO;
        /// <summary>
        /// Objeto de segurança
        /// </summary>
        protected ObjectSecurity objectSecurity;

        #endregion

        #region Construtores

        /// <summary>
        /// Inicializa uma instância da classe. Cria uma nova conexao com o banco de dados
        /// </summary>
        public SugestaoBO(ObjectSecurity pObjectSecurity) : base()
        {
            SugestaoDAO = new SugestaoDAO(ConnectionFactory.GetDbConnectionDefault(), pObjectSecurity);
            objectSecurity = pObjectSecurity;
        }

        /// <summary>
        /// Inicializa uma instância da classe. Recebendo como parametro a conexao com banco de dados
        /// </summary>
        public SugestaoBO(System.Data.IDbConnection pIDbConnection, ObjectSecurity pObjectSecurity) : base()
        {
            SugestaoDAO = new SugestaoDAO(pIDbConnection, pObjectSecurity);
            objectSecurity = pObjectSecurity;
        }

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the <see cref="SugestaoBO"/> is reclaimed by garbage collection.
        /// </summary>
        ~SugestaoBO()
        {
            SugestaoDAO.Dispose();
        }

        #endregion

        #region WOLI - Métodos Básicos

        /// <summary>
        /// Realiza o insert do objeto por stored Procedure
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser inserido</param>
        /// <returns>Objeto Inserido</returns>
        public Sugestao Insert(Sugestao pObject)
        {
            SugestaoDAO.BeginTransaction();
            try
            {
                Sugestao SugestaoAux = SugestaoDAO.InsertByStoredProcedure(pObject);
                pObject.idSugestao = SugestaoAux.idSugestao;

                SugestaoDAO.CommitTransaction();
            }
            catch (Exception ex)
            {
                SugestaoDAO.RollbackTransaction();
                throw ex;
            }
            return pObject;
        }

        /// <summary>
        /// Realiza o update do objeto por stored Procedure
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser atualizado</param>
        /// <returns>Objeto Atualizado</returns>
        public Sugestao Update(Sugestao pObject)
        {
            SugestaoDAO.BeginTransaction();
            try
            {
                SugestaoDAO.UpdateByStoredProcedure(pObject);

                SugestaoDAO.CommitTransaction();
            }
            catch (Exception ex)
            {
                SugestaoDAO.RollbackTransaction();
                throw ex;
            }
            return pObject;
        }

        /// <summary>
        /// Realiza a deleção do objeto por stored Procedure
        /// </summary>
        /// <param name="pidSugestao">PK da tabela</param>
        /// <returns>Quantidade de Registros deletados</returns>
        public int Delete(int pidSugestao)
        {
            int iRetorno = 0;
            SugestaoDAO.BeginTransaction();
            try
            {
                iRetorno = SugestaoDAO.DeleteByStoredProcedure(pidSugestao, false, objectSecurity.UserSystem);
                SugestaoDAO.CommitTransaction();
            }
            catch (Exception ex)
            {
                SugestaoDAO.RollbackTransaction();
                throw ex;
            }
            return iRetorno;
        }

        /// <summary>
        /// Retorna registro pela PK
        /// </summary>
        /// <param name="pidSugestao">PK da tabela</param>
        /// <returns>Registro da PK</returns>
        public Sugestao SelectByPK(int pidSugestao)
        {
            return SugestaoDAO.SelectByPK(pidSugestao);
        }

        /// <summary>
        /// Realiza a busca Lookup
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser atribuidos no filtro</param>
        /// <returns>Lista de Objetos que atendam ao filtro</returns>
        public IList<Sugestao> ListForLookup(Sugestao pObject)
        {
            return SugestaoDAO.ListForLookup(pObject);
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
        public IList<Sugestao> ListForGrid(Sugestao pObject, int pNumRegPag, int pNumPagina, string pDesOrdem, out int pNumTotReg)
        {
            return SugestaoDAO.ListForGrid(pObject, pNumRegPag, pNumPagina, pDesOrdem, out pNumTotReg);
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
                SugestaoDAO = null;

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

        public SugestaoBO Insert(SugestaoBO pObject)
        {
            throw new NotImplementedException();
        }

        public SugestaoBO Update(SugestaoBO pObject)
        {
            throw new NotImplementedException();
        }

        public IList<SugestaoBO> ListForGrid(SugestaoBO pObject, int pNumRegPag, int pNumPagina, string pDesOrdem, out int pNumTotReg)
        {
            throw new NotImplementedException();
        }

        public IList<SugestaoBO> ListForLookup(SugestaoBO pObject)
        {
            throw new NotImplementedException();
        }

        SugestaoBO IBaseBO<SugestaoBO, int>.SelectByPK(int pChave)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion

        #region Metodos Personalizados

        #endregion
    }

    public class Sugestao
    {
        public object idSugestao { get; internal set; }
    }
}
