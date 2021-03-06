/*
	Classe gerada automaticamente pelo MSTech Code Creator
*/

namespace MSTech.GestaoEscolar.DAL
{
    using Data.Common;
    using MSTech.GestaoEscolar.DAL.Abstracts;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Description: .
    /// </summary>
    public class ACA_ObjetoAprendizagemTipoCicloDAO : Abstract_ACA_ObjetoAprendizagemTipoCicloDAO
    {
        public DataTable SelectBy_TipoDisciplina
        (
             int tds_id
            , int cal_ano
            , out int totalRecords
        )
        {
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_ObjetoAprendizagemTipoCiclo_ByTipoDisciplina", _Banco);

            #region PARAMETROS

            Param = qs.NewParameter();
            Param.DbType = DbType.Int32;
            Param.ParameterName = "@tds_id";
            Param.Size = 4;
            Param.Value = tds_id;
            qs.Parameters.Add(Param);

            Param = qs.NewParameter();
            Param.DbType = DbType.Int32;
            Param.ParameterName = "@cal_ano";
            Param.Size = 4;
            Param.Value = cal_ano;
            qs.Parameters.Add(Param);

            #endregion

            qs.Execute();

            totalRecords = qs.Return.Rows.Count;

            return qs.Return;
        }

        public Dictionary<int, bool> SelectBy_ObjetoAprendizagem
        (
             int oap_id
        )
        {
            Dictionary<int, bool> listTci_ids = new Dictionary<int, bool>();
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_ObjetoAprendizagemTipoCiclo_By_Oap_Id", _Banco);

            #region PARAMETROS

            Param = qs.NewParameter();
            Param.DbType = DbType.Int32;
            Param.ParameterName = "@oap_id";
            Param.Size = 4;
            Param.Value = oap_id;
            qs.Parameters.Add(Param);

            #endregion

            qs.Execute();

            if (qs.Return.Rows.Count > 0)
                foreach (var item in (from DataRow dr in qs.Return.Rows
                                      select new
                                      {
                                          tci_id = Convert.ToInt32(dr["tci_id"]),
                                          tci_nome = Convert.ToBoolean(dr["CicloEmUso"])
                                      }))
                    listTci_ids.Add(item.tci_id, item.tci_nome);

            return listTci_ids;
        }
        
        /// <summary>
        /// Verifica se os ciclos do objeto de aprendizagem estão em uso
        /// </summary>
        /// <param name="oap_id">ID do objeto de aprendizagem</param>
        public Dictionary<int, string> CiclosEmUso(int oap_id)
        {
            Dictionary<int, string> listTci_ids = new Dictionary<int, string>();
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_ObjetoAprendizagemTipoCiclo_SelectEmUsoBy_Oap_Id", _Banco);

            #region PARAMETROS

            Param = qs.NewParameter();
            Param.DbType = DbType.Int32;
            Param.ParameterName = "@oap_id";
            Param.Size = 4;
            Param.Value = oap_id;
            qs.Parameters.Add(Param);

            #endregion

            qs.Execute();

            if (qs.Return.Rows.Count > 0)
                foreach (var item in (from DataRow dr in qs.Return.Rows
                                      select new
                                      {
                                          tci_id = Convert.ToInt32(dr["tci_id"]),
                                          tci_nome = dr["tci_nome"].ToString()
                                      }))
                    listTci_ids.Add(item.tci_id, item.tci_nome);

            return listTci_ids;
        }

        public void DeleteNew
        (
             int oap_id
        )
        {
            QuerySelectStoredProcedure qs = new QuerySelectStoredProcedure("NEW_ACA_ObjetoAprendizagemTipoCiclo_DELETE", _Banco);

            #region PARAMETROS

            Param = qs.NewParameter();
            Param.DbType = DbType.Int32;
            Param.ParameterName = "@oap_id";
            Param.Size = 4;
            Param.Value = oap_id;
            qs.Parameters.Add(Param);

            #endregion

            qs.Execute();
        }

        ///// <summary>
        ///// Inseri os valores da classe em um registro ja existente.
        ///// </summary>
        ///// <param name="entity">Entidade com os dados a serem modificados.</param>
        ///// <returns>True - Operacao bem sucedida.</returns>
        // protected override bool Alterar(ACA_ObjetoAprendizagemTipoCiclo entity)
        // {
        //    return base.Alterar(entity);
        // }
        ///// <summary>
        ///// Inseri os valores da classe em um novo registro.
        ///// </summary>
        ///// <param name="entity">Entidade com os dados a serem inseridos.</param>
        ///// <returns>True - Operacao bem sucedida.</returns>
        // protected override bool Inserir(ACA_ObjetoAprendizagemTipoCiclo entity)
        // {
        //    return base.Inserir(entity);
        // }
        ///// <summary>
        ///// Carrega um registro da tabela usando os valores nas chaves.
        ///// </summary>
        ///// <param name="entity">Entidade com os dados a serem carregados.</param>
        ///// <returns>True - Operacao bem sucedida.</returns>
        // public override bool Carregar(ACA_ObjetoAprendizagemTipoCiclo entity)
        // {
        //    return base.Carregar(entity);
        // }
        ///// <summary>
        ///// Exclui um registro do banco.
        ///// </summary>
        ///// <param name="entity">Entidade com os dados a serem apagados.</param>
        ///// <returns>True - Operacao bem sucedida.</returns>
        // public override bool Delete(ACA_ObjetoAprendizagemTipoCiclo entity)
        // {
        //    return base.Delete(entity);
        // }
        ///// <summary>
        ///// Configura os parametros do metodo de Alterar.
        ///// </summary>
        ///// <param name="qs">Objeto da Store Procedure.</param>
        ///// <param name="entity">Entidade com os dados para preenchimento dos parametros.</param>
        // protected override void ParamAlterar(QueryStoredProcedure qs, ACA_ObjetoAprendizagemTipoCiclo entity)
        // {
        //    base.ParamAlterar(qs, entity);
        // }
        ///// <summary>
        ///// Configura os parametros do metodo de Carregar.
        ///// </summary>
        ///// <param name="qs">Objeto da Store Procedure.</param>
        ///// <param name="entity">Entidade com os dados para preenchimento dos parametros.</param>
        // protected override void ParamCarregar(QuerySelectStoredProcedure qs, ACA_ObjetoAprendizagemTipoCiclo entity)
        // {
        //    base.ParamCarregar(qs, entity);
        // }
        ///// <summary>
        ///// Configura os parametros do metodo de Deletar.
        ///// </summary>
        ///// <param name="qs">Objeto da Store Procedure.</param>
        ///// <param name="entity">Entidade com os dados para preenchimento dos parametros.</param>
        // protected override void ParamDeletar(QueryStoredProcedure qs, ACA_ObjetoAprendizagemTipoCiclo entity)
        // {
        //    base.ParamDeletar(qs, entity);
        // }
        ///// <summary>
        ///// Configura os parametros do metodo de Inserir.
        ///// </summary>
        ///// <param name="qs">Objeto da Store Procedure.</param>
        ///// <param name="entity">Entidade com os dados para preenchimento dos parametros.</param>
        // protected override void ParamInserir(QuerySelectStoredProcedure qs, ACA_ObjetoAprendizagemTipoCiclo entity)
        // {
        //    base.ParamInserir(qs, entity);
        // }
        ///// <summary>
        ///// Salva o registro no banco de dados.
        ///// </summary>
        ///// <param name="entity">Entidade com os dados para preenchimento para inserir ou alterar.</param>
        ///// <returns>True - Operacao bem sucedida.</returns>
        // public override bool Salvar(ACA_ObjetoAprendizagemTipoCiclo entity)
        // {
        //    return base.Salvar(entity);
        // }
        ///// <summary>
        ///// Realiza o select da tabela.
        ///// </summary>
        ///// <returns>Lista com todos os registros da tabela.</returns>
        // public override IList<ACA_ObjetoAprendizagemTipoCiclo> Select()
        // {
        //    return base.Select();
        // }
        ///// <summary>
        ///// Realiza o select da tabela com paginacao.
        ///// </summary>
        ///// <param name="currentPage">Pagina atual.</param>
        ///// <param name="pageSize">Tamanho da pagina.</param>
        ///// <param name="totalRecord">Total de registros na tabela original.</param>
        ///// <returns>Lista com todos os registros da p�gina.</returns>
        // public override IList<ACA_ObjetoAprendizagemTipoCiclo> Select_Paginado(int currentPage, int pageSize, out int totalRecord)
        // {
        //    return base.Select_Paginado(currentPage, pageSize, out totalRecord);
        // }
        ///// <summary>
        ///// Recebe o valor do auto incremento e coloca na propriedade. 
        ///// </summary>
        ///// <param name="qs">Objeto da Store Procedure.</param>
        ///// <param name="entity">Entidade com os dados.</param>
        ///// <returns>True - Operacao bem sucedida.</returns>
        // protected override bool ReceberAutoIncremento(QuerySelectStoredProcedure qs, ACA_ObjetoAprendizagemTipoCiclo entity)
        // {
        //    return base.ReceberAutoIncremento(qs, entity);
        // }
        ///// <summary>
        ///// Passa os dados de um datatable para uma entidade.
        ///// </summary>
        ///// <param name="dr">DataRow do datatable preenchido.</param>
        ///// <param name="entity">Entidade onde ser�o transferidos os dados.</param>
        ///// <returns>Entidade preenchida.</returns>
        // public override ACA_ObjetoAprendizagemTipoCiclo DataRowToEntity(DataRow dr, ACA_ObjetoAprendizagemTipoCiclo entity)
        // {
        //    return base.DataRowToEntity(dr, entity);
        // }
        ///// <summary>
        ///// Passa os dados de um datatable para uma entidade.
        ///// </summary>
        ///// <param name="dr">DataRow do datatable preenchido.</param>
        ///// <param name="entity">Entidade onde ser�o transferidos os dados.</param>
        ///// <param name="limparEntity">Indica se a entidade deve ser limpada antes da transferencia.</param>
        ///// <returns>Entidade preenchida.</returns>
        // public override ACA_ObjetoAprendizagemTipoCiclo DataRowToEntity(DataRow dr, ACA_ObjetoAprendizagemTipoCiclo entity, bool limparEntity)
        // {
        //    return base.DataRowToEntity(dr, entity, limparEntity);
        // }
    }
}