/*
	Classe gerada automaticamente pelo MSTech Code Creator
*/

namespace MSTech.GestaoEscolar.DAL.Abstracts
{
	using System;
	using System.Data;
	using MSTech.Data.Common;
	using MSTech.Data.Common.Abstracts;
	using MSTech.GestaoEscolar.Entities;
	
	/// <summary>
	/// Classe abstrata de CLS_AlunoAvaliacaoTurmaDisciplinaObservacao.
	/// </summary>
	public abstract class Abstract_CLS_AlunoAvaliacaoTurmaDisciplinaObservacaoDAO : Abstract_DAL<CLS_AlunoAvaliacaoTurmaDisciplinaObservacao>
	{
        /// <summary>
		/// ConnectionString.
		/// </summary>
        protected override string ConnectionStringName
        {
            get
            {
                return "GestaoEscolar";
            }
        }
        	
		/// <summary>
		/// Configura os parametros do metodo de carregar.
		/// </summary>
		/// <param name="qs">Objeto da Store Procedure.</param>
        /// <param name="entity">Entidade com os dados para preenchimento dos parametros.</param>
		protected override void ParamCarregar(QuerySelectStoredProcedure qs, CLS_AlunoAvaliacaoTurmaDisciplinaObservacao entity)
		{
			if (entity != null & qs != null)
            {
			Param = qs.NewParameter();
			Param.DbType = DbType.Int64;
			Param.ParameterName = "@tud_id";
			Param.Size = 8;
			Param.Value = entity.tud_id;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Int64;
			Param.ParameterName = "@alu_id";
			Param.Size = 8;
			Param.Value = entity.alu_id;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Int32;
			Param.ParameterName = "@mtu_id";
			Param.Size = 4;
			Param.Value = entity.mtu_id;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Int32;
			Param.ParameterName = "@mtd_id";
			Param.Size = 4;
			Param.Value = entity.mtd_id;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Int32;
			Param.ParameterName = "@fav_id";
			Param.Size = 4;
			Param.Value = entity.fav_id;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Int32;
			Param.ParameterName = "@ava_id";
			Param.Size = 4;
			Param.Value = entity.ava_id;
			qs.Parameters.Add(Param);


			}
		}
		
		/// <summary>
		/// Configura os parametros do metodo de Inserir.
		/// </summary>
		/// <param name="qs">Objeto da Store Procedure.</param>
        /// <param name="entity">Entidade com os dados para preenchimento dos parametros.</param>
		protected override void ParamInserir(QuerySelectStoredProcedure qs, CLS_AlunoAvaliacaoTurmaDisciplinaObservacao entity)
		{
            if (entity != null & qs != null)
            {
                Param = qs.NewParameter();
                Param.DbType = DbType.Int64;
                Param.ParameterName = "@tud_id";
                Param.Size = 8;
                Param.Value = entity.tud_id;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int64;
                Param.ParameterName = "@alu_id";
                Param.Size = 8;
                Param.Value = entity.alu_id;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@mtu_id";
                Param.Size = 4;
                Param.Value = entity.mtu_id;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@mtd_id";
                Param.Size = 4;
                Param.Value = entity.mtd_id;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@fav_id";
                Param.Size = 4;
                Param.Value = entity.fav_id;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@ava_id";
                Param.Size = 4;
                Param.Value = entity.ava_id;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.AnsiString;
                Param.ParameterName = "@ado_qualidade";
                Param.Size = 2147483647;
                if (!string.IsNullOrEmpty(entity.ado_qualidade))
                {
                    Param.Value = entity.ado_qualidade;
                }
                else
                {
                    Param.Value = DBNull.Value;
                }
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.AnsiString;
                Param.ParameterName = "@ado_desempenhoAprendizado";
                Param.Size = 2147483647;
                if (!string.IsNullOrEmpty(entity.ado_desempenhoAprendizado))
                {
                    Param.Value = entity.ado_desempenhoAprendizado;
                }
                else
                {
                    Param.Value = DBNull.Value;
                }
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.AnsiString;
                Param.ParameterName = "@ado_recomendacaoAluno";
                Param.Size = 2147483647;
                if (!string.IsNullOrEmpty(entity.ado_recomendacaoAluno))
                {
                    Param.Value = entity.ado_recomendacaoAluno;
                }
                else
                {
                    Param.Value = DBNull.Value;
                }
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.AnsiString;
                Param.ParameterName = "@ado_recomendacaoResponsavel";
                Param.Size = 2147483647;
                if (!string.IsNullOrEmpty(entity.ado_recomendacaoResponsavel))
                {
                    Param.Value = entity.ado_recomendacaoResponsavel;
                }
                else
                {
                    Param.Value = DBNull.Value;
                }
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Byte;
                Param.ParameterName = "@ado_situacao";
                Param.Size = 1;
                Param.Value = entity.ado_situacao;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.DateTime;
                Param.ParameterName = "@ado_dataCriacao";
                Param.Size = 16;
                Param.Value = entity.ado_dataCriacao;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.DateTime;
                Param.ParameterName = "@ado_dataAlteracao";
                Param.Size = 16;
                Param.Value = entity.ado_dataAlteracao;
                qs.Parameters.Add(Param);
            }
		}
		
		/// <summary>
		/// Configura os parametros do metodo de Alterar.
		/// </summary>
		/// <param name="qs">Objeto da Store Procedure.</param>
        /// <param name="entity">Entidade com os dados para preenchimento dos parametros.</param>
		protected override void ParamAlterar(QueryStoredProcedure qs, CLS_AlunoAvaliacaoTurmaDisciplinaObservacao entity)
		{
            if (entity != null & qs != null)
            {
                Param = qs.NewParameter();
                Param.DbType = DbType.Int64;
                Param.ParameterName = "@tud_id";
                Param.Size = 8;
                Param.Value = entity.tud_id;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int64;
                Param.ParameterName = "@alu_id";
                Param.Size = 8;
                Param.Value = entity.alu_id;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@mtu_id";
                Param.Size = 4;
                Param.Value = entity.mtu_id;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@mtd_id";
                Param.Size = 4;
                Param.Value = entity.mtd_id;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@fav_id";
                Param.Size = 4;
                Param.Value = entity.fav_id;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Int32;
                Param.ParameterName = "@ava_id";
                Param.Size = 4;
                Param.Value = entity.ava_id;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.AnsiString;
                Param.ParameterName = "@ado_qualidade";
                Param.Size = 2147483647;
                if (!string.IsNullOrEmpty(entity.ado_qualidade))
                {
                    Param.Value = entity.ado_qualidade;
                }
                else
                {
                    Param.Value = DBNull.Value;
                }
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.AnsiString;
                Param.ParameterName = "@ado_desempenhoAprendizado";
                Param.Size = 2147483647;
                if (!string.IsNullOrEmpty(entity.ado_desempenhoAprendizado))
                {
                    Param.Value = entity.ado_desempenhoAprendizado;
                }
                else
                {
                    Param.Value = DBNull.Value;
                }
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.AnsiString;
                Param.ParameterName = "@ado_recomendacaoAluno";
                Param.Size = 2147483647;
                if (!string.IsNullOrEmpty(entity.ado_recomendacaoAluno))
                {
                    Param.Value = entity.ado_recomendacaoAluno;
                }
                else
                {
                    Param.Value = DBNull.Value;
                }
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.AnsiString;
                Param.ParameterName = "@ado_recomendacaoResponsavel";
                Param.Size = 2147483647;
                if (!string.IsNullOrEmpty(entity.ado_recomendacaoResponsavel))
                {
                    Param.Value = entity.ado_recomendacaoResponsavel;
                }
                else
                {
                    Param.Value = DBNull.Value;
                }
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.Byte;
                Param.ParameterName = "@ado_situacao";
                Param.Size = 1;
                Param.Value = entity.ado_situacao;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.DateTime;
                Param.ParameterName = "@ado_dataCriacao";
                Param.Size = 16;
                Param.Value = entity.ado_dataCriacao;
                qs.Parameters.Add(Param);

                Param = qs.NewParameter();
                Param.DbType = DbType.DateTime;
                Param.ParameterName = "@ado_dataAlteracao";
                Param.Size = 16;
                Param.Value = entity.ado_dataAlteracao;
                qs.Parameters.Add(Param);
            }
		}

		/// <summary>
		/// Configura os parametros do metodo de Deletar.
		/// </summary>
		/// <param name="qs">Objeto da Store Procedure.</param>
        /// <param name="entity">Entidade com os dados para preenchimento dos parametros.</param>
		protected override void ParamDeletar(QueryStoredProcedure qs, CLS_AlunoAvaliacaoTurmaDisciplinaObservacao entity)
		{
			if (entity != null & qs != null)
            {
			Param = qs.NewParameter();
			Param.DbType = DbType.Int64;
			Param.ParameterName = "@tud_id";
			Param.Size = 8;
			Param.Value = entity.tud_id;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Int64;
			Param.ParameterName = "@alu_id";
			Param.Size = 8;
			Param.Value = entity.alu_id;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Int32;
			Param.ParameterName = "@mtu_id";
			Param.Size = 4;
			Param.Value = entity.mtu_id;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Int32;
			Param.ParameterName = "@mtd_id";
			Param.Size = 4;
			Param.Value = entity.mtd_id;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Int32;
			Param.ParameterName = "@fav_id";
			Param.Size = 4;
			Param.Value = entity.fav_id;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Int32;
			Param.ParameterName = "@ava_id";
			Param.Size = 4;
			Param.Value = entity.ava_id;
			qs.Parameters.Add(Param);


			}
		}
		
		/// <summary>
		/// Recebe o valor do auto incremento e coloca na propriedade.
		/// </summary>
		/// <param name="qs">Objeto da Store Procedure.</param>
		/// <param name="entity">Entidade com os dados para preenchimento dos parametros.</param>
		/// <returns>TRUE - Se entity.ParametroId > 0</returns>
		protected override bool ReceberAutoIncremento(QuerySelectStoredProcedure qs, CLS_AlunoAvaliacaoTurmaDisciplinaObservacao entity)
		{
			if (entity != null & qs != null)
            {

			}

			return false;
		}		
	}
}