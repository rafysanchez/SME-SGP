/*
	Classe gerada automaticamente pelo MSTech Code Creator
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MSTech.Data.Common;
using MSTech.Data.Common.Abstracts;
using MSTech.GestaoEscolar.Entities;

namespace MSTech.GestaoEscolar.DAL.Abstracts
{
	
	/// <summary>
	/// Classe abstrata de ACA_ParametroBuscaAluno
	/// </summary>
	public abstract class Abstract_ACA_ParametroBuscaAlunoDAO : Abstract_DAL<ACA_ParametroBuscaAluno>
	{
	
        protected override string ConnectionStringName
        {
            get
            {
                return "GestaoEscolar";
            }
        }
        	
		/// <summary>
		/// Configura os parametros do metodo de carregar
		/// </ssummary>
		/// <param name="qs">Objeto da Store Procedure</param>
		protected override void ParamCarregar(QuerySelectStoredProcedure qs, ACA_ParametroBuscaAluno entity)
		{
			Param = qs.NewParameter();
			Param.DbType = DbType.Int32;
			Param.ParameterName = "@pba_id";
			Param.Size = 4;
			Param.Value = entity.pba_id;
			qs.Parameters.Add(Param);


		}
		
		/// <summary>
		/// Configura os parametros do metodo de Inserir
		/// </summary>
		/// <param name="qs">Objeto da Store Procedure</param>
		protected override void ParamInserir(QuerySelectStoredProcedure qs, ACA_ParametroBuscaAluno entity)
		{
			Param = qs.NewParameter();
			Param.DbType = DbType.Byte;
			Param.ParameterName = "@pba_tipo";
			Param.Size = 1;
			Param.Value = entity.pba_tipo;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Guid;
			Param.ParameterName = "@tdo_id";
			Param.Size = 16;
			if( entity.tdo_id != Guid.Empty  )
				Param.Value = entity.tdo_id;
			else
				Param.Value = DBNull.Value;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Boolean;
			Param.ParameterName = "@pba_integridade";
			Param.Size = 1;
			Param.Value = entity.pba_integridade;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Byte;
			Param.ParameterName = "@pba_situacao";
			Param.Size = 1;
			Param.Value = entity.pba_situacao;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.DateTime;
			Param.ParameterName = "@pba_dataCriacao";
			Param.Size = 16;
			Param.Value = entity.pba_dataCriacao;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.DateTime;
			Param.ParameterName = "@pba_dataAlteracao";
			Param.Size = 16;
			Param.Value = entity.pba_dataAlteracao;
			qs.Parameters.Add(Param);


		}
		
		/// <summary>
		/// Configura os parametros do metodo de Alterar
		/// </summary>
		/// <param name="qs">Objeto da Store Procedure</param>
		protected override void ParamAlterar(QueryStoredProcedure qs, ACA_ParametroBuscaAluno entity)
		{
			Param = qs.NewParameter();
			Param.DbType = DbType.Int32;
			Param.ParameterName = "@pba_id";
			Param.Size = 4;
			Param.Value = entity.pba_id;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Byte;
			Param.ParameterName = "@pba_tipo";
			Param.Size = 1;
			Param.Value = entity.pba_tipo;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Guid;
			Param.ParameterName = "@tdo_id";
			Param.Size = 16;
			if( entity.tdo_id != Guid.Empty  )
				Param.Value = entity.tdo_id;
			else
				Param.Value = DBNull.Value;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Boolean;
			Param.ParameterName = "@pba_integridade";
			Param.Size = 1;
			Param.Value = entity.pba_integridade;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.Byte;
			Param.ParameterName = "@pba_situacao";
			Param.Size = 1;
			Param.Value = entity.pba_situacao;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.DateTime;
			Param.ParameterName = "@pba_dataCriacao";
			Param.Size = 16;
			Param.Value = entity.pba_dataCriacao;
			qs.Parameters.Add(Param);

			Param = qs.NewParameter();
			Param.DbType = DbType.DateTime;
			Param.ParameterName = "@pba_dataAlteracao";
			Param.Size = 16;
			Param.Value = entity.pba_dataAlteracao;
			qs.Parameters.Add(Param);


		}

		/// <summary>
		/// Configura os parametros do metodo de Deletar
		/// </summary>
		/// <param name="qs">Objeto da Store Procedure</param>
		protected override void ParamDeletar(QueryStoredProcedure qs, ACA_ParametroBuscaAluno entity)
		{
			Param = qs.NewParameter();
			Param.DbType = DbType.Int32;
			Param.ParameterName = "@pba_id";
			Param.Size = 4;
			Param.Value = entity.pba_id;
			qs.Parameters.Add(Param);


		}
		
		/// <summary>
		/// Recebe o valor do auto incremento e coloca na propriedade 
		/// </summary>
		/// <param name="qs">Objeto da Store Procedure</param>
		protected override bool ReceberAutoIncremento(QuerySelectStoredProcedure qs, ACA_ParametroBuscaAluno entity)
		{
			entity.pba_id = Convert.ToInt32(qs.Return.Rows[0][0]);
			return (entity.pba_id > 0);
		}		
	}
}

