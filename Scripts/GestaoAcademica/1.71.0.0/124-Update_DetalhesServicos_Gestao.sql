USE [GestaoPedagogica]
GO

BEGIN TRANSACTION 
SET XACT_ABORT ON   

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Fechamento - Pendências', ser_descricao = 'Faz o pré-procesamento do relatório de pendências por disciplinas e alunos.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoRelatorioDisciplinasAlunosPendencias'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Fechamento - Notas e faltas', ser_descricao = 'Faz o pré-procesamento de notas e faltas para o fechamento'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoNotaFrequenciaFechamento'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Fechamento - Processamento abertura', ser_descricao = 'Insere registros da tabela pré-processada para fechamento no dia da abertura do evento.'
	WHERE ser_nomeProcedimento = 'MS_JOB_AtualizaFechamento_AberturaEvento'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Fechamento - Processamento', ser_descricao = 'Faz o pré-procesamento de notas e faltas para o novo fechamento em paralelo.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoNotaFrequenciaFechamentoParalelo'

	UPDATE [SYS_Servicos]
	SET ser_nome = 'Pendências - Aulas sem plano', ser_descricao = 'Faz o pré-procesamento das pendências de aulas sem plano.'
	WHERE ser_nomeProcedimento = 'MS_JOB_ProcessamentoPendenciaAulas'

-- Fechar transação     
SET XACT_ABORT OFF 
COMMIT TRANSACTION