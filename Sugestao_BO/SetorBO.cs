using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using Sistema.Arquitetura.Library.Core.Interface;
using Sistema.Arquitetura.Library.Core.Util.Security;
using Sugestao_VO;
using Sugestao_DAO;


namespace SetorBO
{

    /// <summary>
    /// Classe de Negocios da Tabela Setor
    /// </summary>
    public class SetorBO : IBaseBO<SetorBO, int>
    {

        #region Variaveis Locais
        /// <summary>
        /// Define o objeto de acesso a dados.
        /// </summary>
        protected SetorDAO SetorDAO;
        /// <summary>
        /// Objeto de segurança
        /// </summary>
        protected ObjectSecurity objectSecurity;

        #endregion

        #region Construtores

        /// <summary>
        /// Inicializa uma instância da classe. Cria uma nova conexao com o banco de dados
        /// </summary>
        public SetorBO(ObjectSecurity pObjectSecurity) : base()
        {
            SetorDAO = new SetorDAO(ConnectionFactory.GetDbConnectionDefault(), pObjectSecurity);
            objectSecurity = pObjectSecurity;
        }

        /// <summary>
        /// Inicializa uma instância da classe. Recebendo como parametro a conexao com banco de dados
        /// </summary>
        public SetorBO(System.Data.IDbConnection pIDbConnection, ObjectSecurity pObjectSecurity) : base()
        {
            SetorDAO = new SetorDAO(pIDbConnection, pObjectSecurity);
            objectSecurity = pObjectSecurity;
        }

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the <see cref="SetorBO"/> is reclaimed by garbage collection.
        /// </summary>
        ~SetorBO()
        {
            SetorDAO.Dispose();
        }

        #endregion

        #region WOLI - Métodos Básicos

        /// <summary>
        /// Realiza o insert do objeto por stored Procedure
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser inserido</param>
        /// <returns>Objeto Inserido</returns>
        public Setor Insert(Setor pObject)
        {
            SetorDAO.BeginTransaction();
            try
            {
                Setor SetorAux = SetorDAO.InsertByStoredProcedure(pObject);
                pObject.idSetor = SetorAux.idSetor;

                SetorDAO.CommitTransaction();
            }
            catch (Exception ex)
            {
                SetorDAO.RollbackTransaction();
                throw ex;
            }
            return pObject;
        }

        /// <summary>
        /// Realiza o update do objeto por stored Procedure
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser atualizado</param>
        /// <returns>Objeto Atualizado</returns>
        public Setor Update(Setor pObject)
        {
            SetorDAO.BeginTransaction();
            try
            {
                SetorDAO.UpdateByStoredProcedure(pObject);

                SetorDAO.CommitTransaction();
            }
            catch (Exception ex)
            {
                SetorDAO.RollbackTransaction();
                throw ex;
            }
            return pObject;
        }

        /// <summary>
        /// Realiza a deleção do objeto por stored Procedure
        /// </summary>
        /// <param name="pidSetor">PK da tabela</param>
        /// <returns>Quantidade de Registros deletados</returns>
        public int Delete(int pidSetor)
        {
            int iRetorno = 0;
            SetorDAO.BeginTransaction();
            try
            {
                iRetorno = SetorDAO.DeleteByStoredProcedure(pidSetor, false, objectSecurity.UserSystem);
                SetorDAO.CommitTransaction();
            }
            catch (Exception ex)
            {
                SetorDAO.RollbackTransaction();
                throw ex;
            }
            return iRetorno;
        }

        /// <summary>
        /// Retorna registro pela PK
        /// </summary>
        /// <param name="pidSetor">PK da tabela</param>
        /// <returns>Registro da PK</returns>
        public Setor SelectByPK(int pidSetor)
        {
            return SetorDAO.SelectByPK(pidSetor);
        }

        /// <summary>
        /// Realiza a busca Lookup
        /// </summary>
        /// <param name="pObject">Objeto com os valores a ser atribuidos no filtro</param>
        /// <returns>Lista de Objetos que atendam ao filtro</returns>
        public IList<Setor> ListForLookup(Setor pObject)
        {
            return SetorDAO.ListForLookup(pObject);
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
        public IList<Setor> ListForGrid(Setor pObject, int pNumRegPag, int pNumPagina, string pDesOrdem, out int pNumTotReg)
        {
            return SetorDAO.ListForGrid(pObject, pNumRegPag, pNumPagina, pDesOrdem, out pNumTotReg);
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
                SetorDAO = null;

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

        public SetorBO Insert(SetorBO pObject)
        {
            throw new NotImplementedException();
        }

        public SetorBO Update(SetorBO pObject)
        {
            throw new NotImplementedException();
        }

        public IList<SetorBO> ListForGrid(SetorBO pObject, int pNumRegPag, int pNumPagina, string pDesOrdem, out int pNumTotReg)
        {
            throw new NotImplementedException();
        }

        public IList<SetorBO> ListForLookup(SetorBO pObject)
        {
            throw new NotImplementedException();
        }

        SetorBO IBaseBO<SetorBO, int>.SelectByPK(int pChave)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion

        #region Metodos Personalizados

        #endregion
    }

    public class Setor
    {
        public object idSetor { get; internal set; }
    }
}
