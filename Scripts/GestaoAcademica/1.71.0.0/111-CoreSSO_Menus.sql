USE [CoreSSO]
GO

BEGIN TRANSACTION 
SET XACT_ABORT ON   

	DECLARE @sis_id INT = 102
	DECLARE @visaoAdm INT = 1
	DECLARE @visaoGestao INT = 2
	DECLARE @visaoUnidade INT = 3
	DECLARE @nomeSistema VARCHAR(100) = ' SGP'

	UPDATE SYS_Modulo
	SET mod_nome = 'Sistemas'
	WHERE mod_nome = 'Configura��o' AND sis_id = 102 AND mod_situacao <> 3
	
	UPDATE SYS_Modulo
	SET mod_nome = 'Calend�rio'
	WHERE mod_nome = 'Calend�rio escolar' AND sis_id = 102 AND mod_situacao <> 3
	
	UPDATE SYS_Modulo
	SET mod_nome = 'Turmas normais'
	WHERE mod_nome = 'Manuten��o de turmas' AND sis_id = 102 AND mod_situacao <> 3
	
	UPDATE SYS_Modulo
	SET mod_nome = 'Turmas eletivas'
	WHERE mod_nome = 'Manuten��o de turmas eletivas' AND sis_id = 102 AND mod_situacao <> 3
	
	UPDATE SYS_Modulo
	SET mod_nome = 'Turmas multisseriadas'
	WHERE mod_nome = 'Manuten��o de turmas multisseriadas' AND sis_id = 102 AND mod_situacao <> 3
	
	EXEC MS_InserePaginaMenu
		@nomeSistema = @nomeSistema -- Nome do sistema (obrigat�rio)
		,@nomeModuloAvo = NULL -- Nome do m�dulo av� (Opcional, apenas quando houver) 
		,@nomeModuloPai = NULL -- Nome do m�dulo pai (Opcional, apenas quando houver)
		,@nomeModulo = 'Configura��es' -- Nome do m�dulo (Obrigat�rio)
		,@SiteMap1Nome = 'Configura��es'
		,@SiteMap1Url = NULL
		,@SiteMap2Nome = NULL
		,@SiteMap2Url = NULL
		,@SiteMap3Nome = NULL
		,@SiteMap3Url = NULL
		,@possuiVisaoAdm = 1 -- Indicar se possui vis�o de administador
		,@possuiVisaoGestao = 1 -- Indicar se possui vis�o de Gest�o
		,@possuiVisaoUA = 1 -- Indicar se possui vis�o de UA
		,@possuiVisaoIndividual = 0 -- Indicar se possui vis�o de individual

	EXEC MS_InserePaginaMenu
		@nomeSistema = @nomeSistema -- Nome do sistema (obrigat�rio)
		,@nomeModuloAvo = NULL -- Nome do m�dulo av� (Opcional, apenas quando houver) 
		,@nomeModuloPai = 'Administra��o' -- Nome do m�dulo pai (Opcional, apenas quando houver)
		,@nomeModulo = 'Calend�rio escolar' -- Nome do m�dulo (Obrigat�rio)
		,@SiteMap1Nome = 'Calend�rio escolar'
		,@SiteMap1Url = NULL
		,@SiteMap2Nome = NULL
		,@SiteMap2Url = NULL
		,@SiteMap3Nome = NULL
		,@SiteMap3Url = NULL
		,@possuiVisaoAdm = 1 -- Indicar se possui vis�o de administador
		,@possuiVisaoGestao = 1 -- Indicar se possui vis�o de Gest�o
		,@possuiVisaoUA = 1 -- Indicar se possui vis�o de UA
		,@possuiVisaoIndividual = 1 -- Indicar se possui vis�o de individual

	EXEC MS_InserePaginaMenu
		@nomeSistema = @nomeSistema -- Nome do sistema (obrigat�rio)
		,@nomeModuloAvo = NULL -- Nome do m�dulo av� (Opcional, apenas quando houver) 
		,@nomeModuloPai = 'Administra��o' -- Nome do m�dulo pai (Opcional, apenas quando houver)
		,@nomeModulo = 'Manuten��o de turmas' -- Nome do m�dulo (Obrigat�rio)
		,@SiteMap1Nome = 'Manuten��o de turmas'
		,@SiteMap1Url = NULL
		,@SiteMap2Nome = NULL
		,@SiteMap2Url = NULL
		,@SiteMap3Nome = NULL
		,@SiteMap3Url = NULL
		,@possuiVisaoAdm = 1 -- Indicar se possui vis�o de administador
		,@possuiVisaoGestao = 1 -- Indicar se possui vis�o de Gest�o
		,@possuiVisaoUA = 1 -- Indicar se possui vis�o de UA
		,@possuiVisaoIndividual = 1 -- Indicar se possui vis�o de individual

	
	-- Mudando m�dulos de Configura��es para o mod_idPai novo

	DECLARE @mod_idPai INT = (SELECT mod_id FROM SYS_Modulo WHERE mod_nome = 'Configura��es' AND sis_id = @sis_id AND mod_situacao = 1)

	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Formato de avalia��o'

	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Escala de avalia��o'

	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Turnos'
	
	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Cursos'
	
	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Orienta��es curriculares'
	
	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Reuni�es de respons�veis'
	
	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'N�vel de aprendizado'
	
	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Matriz de habilidades'
	
	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Objetos de conhecimento'
	
	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Sondagem'
	
	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Configura��o do servi�o de pend�ncia'
	
	UPDATE SYS_Modulo
	SET mod_situacao = 3
	WHERE sis_id = @sis_id AND mod_nome = 'Cadastros'
	
	-- Mudando m�dulos de Calend�rio para o mod_idPai novo

	SET @mod_idPai = (SELECT mod_id FROM SYS_Modulo WHERE mod_nome = 'Calend�rio escolar' AND sis_id = @sis_id AND mod_situacao = 1)

	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Calend�rio'

	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Eventos do calend�rio escolar'

	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Abertura de anos letivos anteriores'
	
	-- Organizando a ordem dos m�dulos 
	
	UPDATE SYS_VisaoModuloMenu
	SET vmm_ordem = 2
	WHERE sis_id = @sis_id
	AND vis_id = @visaoAdm
	AND mod_id = @mod_idPai

	UPDATE SYS_VisaoModuloMenu
	SET vmm_ordem = 2
	WHERE sis_id = @sis_id
	AND vis_id = @visaoGestao
	AND mod_id = @mod_idPai

	UPDATE SYS_VisaoModuloMenu
	SET vmm_ordem = 4
	WHERE sis_id = @sis_id
	AND vis_id = @visaoUnidade
	AND mod_id = @mod_idPai
	
	-- Mudando m�dulos de Manuten��o de turmas para o mod_idPai novo

	SET @mod_idPai = (SELECT mod_id FROM SYS_Modulo WHERE mod_nome = 'Manuten��o de turmas' AND sis_id = @sis_id AND mod_situacao = 1)

	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Turmas normais'

	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Turmas eletivas'

	UPDATE SYS_Modulo 
	SET mod_idPai = @mod_idPai
	WHERE sis_id = @sis_id AND mod_nome = 'Turmas multisseriadas'
	
	-- Organizando a ordem dos m�dulos 

	DECLARE @vmm_ordem INT
	
	SELECT @vmm_ordem = MAX(vmm_ordem)
	FROM SYS_Modulo mdl WITH(NOLOCK)
	INNER JOIN SYS_Modulo mdf WITH(NOLOCK)
		ON mdl.sis_id = mdf.sis_id
		AND mdl.mod_id = mdf.mod_idPai
		AND mdf.mod_situacao <> 3
	INNER JOIN SYS_VisaoModuloMenu vmm WITH(NOLOCK)
		ON mdf.sis_id = vmm.sis_id
		AND mdf.mod_id = vmm.mod_id
		AND vis_id = @visaoAdm
	WHERE mdl.sis_id = @sis_id AND mdl.mod_nome = 'Administra��o' AND mdl.mod_situacao <> 3
	
	UPDATE SYS_VisaoModuloMenu
	SET vmm_ordem = ISNULL(@vmm_ordem + 1, 1)
	WHERE sis_id = @sis_id
	AND vis_id = @visaoAdm
	AND mod_id = @mod_idPai

	SELECT @vmm_ordem = MAX(vmm_ordem)
	FROM SYS_Modulo mdl WITH(NOLOCK)
	INNER JOIN SYS_Modulo mdf WITH(NOLOCK)
		ON mdl.sis_id = mdf.sis_id
		AND mdl.mod_id = mdf.mod_idPai
		AND mdf.mod_situacao <> 3
	INNER JOIN SYS_VisaoModuloMenu vmm WITH(NOLOCK)
		ON mdf.sis_id = vmm.sis_id
		AND mdf.mod_id = vmm.mod_id
		AND vis_id = @visaoGestao
	WHERE mdl.sis_id = @sis_id AND mdl.mod_nome = 'Administra��o' AND mdl.mod_situacao <> 3
	
	UPDATE SYS_VisaoModuloMenu
	SET vmm_ordem = ISNULL(@vmm_ordem + 1, 1)
	WHERE sis_id = @sis_id
	AND vis_id = @visaoGestao
	AND mod_id = @mod_idPai

	SELECT @vmm_ordem = MAX(vmm_ordem)
	FROM SYS_Modulo mdl WITH(NOLOCK)
	INNER JOIN SYS_Modulo mdf WITH(NOLOCK)
		ON mdl.sis_id = mdf.sis_id
		AND mdl.mod_id = mdf.mod_idPai
		AND mdf.mod_situacao <> 3
	INNER JOIN SYS_VisaoModuloMenu vmm WITH(NOLOCK)
		ON mdf.sis_id = vmm.sis_id
		AND mdf.mod_id = vmm.mod_id
		AND vis_id = @visaoUnidade
	WHERE mdl.sis_id = @sis_id AND mdl.mod_nome = 'Administra��o' AND mdl.mod_situacao <> 3
	
	UPDATE SYS_VisaoModuloMenu
	SET vmm_ordem = ISNULL(@vmm_ordem + 1, 1)
	WHERE sis_id = @sis_id
	AND vis_id = @visaoUnidade
	AND mod_id = @mod_idPai
	
-- Fechar transa��o     
SET XACT_ABORT OFF 
COMMIT TRANSACTION