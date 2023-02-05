/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     09/01/2023 15:19:03                          */
/*==============================================================*/


if exists (select 1
            from  sysobjects
           where  id = object_id('BENEFICIOS')
            and   type = 'U')
   drop table BENEFICIOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CANDIDATOS')
            and   type = 'U')
   drop table CANDIDATOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('IDEIAS')
            and   type = 'U')
   drop table IDEIAS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INVESTIMENTOS')
            and   type = 'U')
   drop table INVESTIMENTOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NEGOCIOS')
            and   type = 'U')
   drop table NEGOCIOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NOTIFICACOES')
            and   type = 'U')
   drop table NOTIFICACOES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OPORTUNIDADES')
            and   type = 'U')
   drop table OPORTUNIDADES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PARCERIAS')
            and   type = 'U')
   drop table PARCERIAS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REUNIOES')
            and   type = 'U')
   drop table REUNIOES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REUNIOES_DE_USER')
            and   type = 'U')
   drop table REUNIOES_DE_USER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOS_DE_NOTIFICACAO')
            and   type = 'U')
   drop table TIPOS_DE_NOTIFICACAO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOS_DE_USER')
            and   type = 'U')
   drop table TIPOS_DE_USER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOS_OPORTUNIDADE')
            and   type = 'U')
   drop table TIPOS_OPORTUNIDADE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USERS')
            and   type = 'U')
   drop table USERS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VAGAS')
            and   type = 'U')
   drop table VAGAS
go

/*==============================================================*/
/* Table: TIPOS_DE_USER                                         */
/*==============================================================*/
create table TIPOS_DE_USER (
   ID_TIPO_USER         int                  not null,
   NOME_TIPO_USER       text                 not null,
   constraint PK_TIPOS_DE_USER primary key (ID_TIPO_USER)
)
go

/*==============================================================*/
/* Table: USERS                                                 */
/*==============================================================*/
create table USERS (
   ID_USER              int                  not null,
   ID_TIPO_USER         int                  not null,
   NOME_USER            text                 not null,
   EMAIL                text                 not null,
   PASSWORD             text                 not null,
   HAS_CONFIRMED        bit                  not null,
   CV                   text                 null,
   NOVA_PASSWORD_CODE   text                 null,
   NOVA_PASSWORD_DATA   datetime             null,
   CONFIRM_CODE         text                 null,
   CONFIRM_DATE_START   datetime             null,
   constraint PK_USERS primary key (ID_USER),
   constraint FK_USERS_UTILIZADO_TIPOS_DE foreign key (ID_TIPO_USER)
      references TIPOS_DE_USER (ID_TIPO_USER)
)
go

/*==============================================================*/
/* Table: BENEFICIOS                                            */
/*==============================================================*/
create table BENEFICIOS (
   ID_BENEFICIO         int                  not null,
   ID_USER              int                  not null,
   DATA_VALIDADE        datetime             null,
   CONTEUDO_BENEFICIO   text                 not null,
   DESCRICAO_PEQUENA    text                 not null,
   ICONE_BENEFICIO      text                 not null,
   constraint PK_BENEFICIOS primary key (ID_BENEFICIO),
   constraint FK_BENEFICI_BENEFICIO_USERS foreign key (ID_USER)
      references USERS (ID_USER)
)
go

/*==============================================================*/
/* Table: VAGAS                                                 */
/*==============================================================*/
create table VAGAS (
   ID_VAGA              int                  not null,
   QUANTIDADE_VAGAS     int                  not null,
   PUBLICA              bit                  not null,
   ICONE_VAGA           text                 not null,
   TITULO_VAGA          text                 not null,
   DESCRICAO_VAGA       text                 not null,
   ESTADO_VAGA          int                  not null,
   constraint PK_VAGAS primary key (ID_VAGA),
)
go

/*==============================================================*/
/* Table: CANDIDATOS                                            */
/*==============================================================*/
create table CANDIDATOS (
   ID_CANDIDATO         int                  not null,
   ID_VAGA              int                  not null,
   ID_USER              int                  not null,
   DATA_SUBMISSAO       datetime             not null,
   EMAIL_REFERENCIA     text                 null,
   constraint PK_CANDIDATOS primary key (ID_CANDIDATO),
   constraint FK_CANDIDAT_CANDIDATU_VAGAS foreign key (ID_VAGA)
      references VAGAS (ID_VAGA),
   constraint FK_CANDIDAT_CANDIDACO_USERS foreign key (ID_USER)
      references USERS (ID_USER)
)
go

/*==============================================================*/
/* Table: IDEIAS                                                */
/*==============================================================*/
create table IDEIAS (
   ID_IDEIA             int                  not null,
   ID_USER              int                  not null,
   CONTEUDO_IDEIA       text                 not null,
   CATEGORIA            text                 not null,
   DATA_CRIACAO_IDEIA   datetime             not null,
   constraint PK_IDEIAS primary key (ID_IDEIA),
   constraint FK_IDEIAS_IDEIAS_DE_USERS foreign key (ID_USER)
      references USERS (ID_USER)
)
go

/*==============================================================*/
/* Table: TIPOS_OPORTUNIDADE                                    */
/*==============================================================*/
create table TIPOS_OPORTUNIDADE (
   ID_TIPO_OPORTUNIDADE int                  not null,
   TIPO                 text                 not null,
   constraint PK_TIPOS_OPORTUNIDADE primary key (ID_TIPO_OPORTUNIDADE)
)
go

/*==============================================================*/
/* Table: OPORTUNIDADES                                         */
/*==============================================================*/
create table OPORTUNIDADES (
   ID_OPORTUNIDADE      int                  not null,
   ID_TIPO_OPORTUNIDADE int                  not null,
   ID_USER              int                  not null,
   ESTADO               int                  not null,
   TITULO_OPORTUNIDADE  text                 not null,
   DESCRICAO_OPORTUNIDADE text                 not null,
   ICONE_OPORTUNIDADE   text                 not null,
   constraint PK_OPORTUNIDADES primary key (ID_OPORTUNIDADE),
   constraint FK_OPORTUNI_OPORTUNID_TIPOS_OP foreign key (ID_TIPO_OPORTUNIDADE)
      references TIPOS_OPORTUNIDADE (ID_TIPO_OPORTUNIDADE),
   constraint FK_OPORTUNI_OPORTUNID_USERS foreign key (ID_USER)
      references USERS (ID_USER)
)
go

/*==============================================================*/
/* Table: INVESTIMENTOS                                         */
/*==============================================================*/
create table INVESTIMENTOS (
   ID_OPORTUNIDADE      int                  not null,
   CAPITAL_INVESTIDO    float                not null,
   ALVO_INVESTIMENTO    text                 not null,
   constraint PK_INVESTIMENTOS primary key (ID_OPORTUNIDADE),
   constraint FK_INVESTIM_TIPO3_OPORTUNI foreign key (ID_OPORTUNIDADE)
      references OPORTUNIDADES (ID_OPORTUNIDADE)
)
go

/*==============================================================*/
/* Table: NEGOCIOS                                              */
/*==============================================================*/
create table NEGOCIOS (
   ID_OPORTUNIDADE      int                  not null,
   NECESSIDADES         text                 not null,
   TIPO_PROJETO         text                 not null,
   AREA_NEGOCIO         text                 not null,
   CONTACTOS            text                 not null,
   NOME_CLIENTE         text                 not null,
   constraint PK_NEGOCIOS primary key (ID_OPORTUNIDADE),
   constraint FK_NEGOCIOS_TIPO_OPORTUNI foreign key (ID_OPORTUNIDADE)
      references OPORTUNIDADES (ID_OPORTUNIDADE)
)
go

/*==============================================================*/
/* Table: TIPOS_DE_NOTIFICACAO                                  */
/*==============================================================*/
create table TIPOS_DE_NOTIFICACAO (
   ID_TIPO_NOTIFICACAO  int                  not null,
   NOME_TIPO_NOTIFICACAO text                 not null,
   constraint PK_TIPOS_DE_NOTIFICACAO primary key (ID_TIPO_NOTIFICACAO)
)
go

/*==============================================================*/
/* Table: NOTIFICACOES                                          */
/*==============================================================*/
create table NOTIFICACOES (
   ID_NOTIFICACAO       int                  not null,
   ID_TIPO_NOTIFICACAO  int                  not null,
   ID_USER              int                  not null,
   CONTEUDO_NOTIFICACAO text                 not null,
   VISTA                bit                  not null,
   DATA_CRIACAO_NOTIFICACAO datetime             not null,
   constraint PK_NOTIFICACOES primary key (ID_NOTIFICACAO),
   constraint FK_NOTIFICA_TIPO_DE_N_TIPOS_DE foreign key (ID_TIPO_NOTIFICACAO)
      references TIPOS_DE_NOTIFICACAO (ID_TIPO_NOTIFICACAO),
   constraint FK_NOTIFICA_NOTIFICAC_USERS foreign key (ID_USER)
      references USERS (ID_USER)
)
go

/*==============================================================*/
/* Table: PARCERIAS                                             */
/*==============================================================*/
create table PARCERIAS (
   ID_OPORTUNIDADE      int                  not null,
   NOME_PARCEIRO        text                 not null,
   constraint PK_PARCERIAS primary key (ID_OPORTUNIDADE),
   constraint FK_PARCERIA_TIPO2_OPORTUNI foreign key (ID_OPORTUNIDADE)
      references OPORTUNIDADES (ID_OPORTUNIDADE)
)
go

/*==============================================================*/
/* Table: REUNIOES                                              */
/*==============================================================*/
create table REUNIOES (
   ID_REUNIAO           int                  not null,
   DATA_INICIO          datetime             not null,
   DURACAO_REUNIAO      int                  not null,
   TITULO_REUNIAO       text                 not null,
   DESCRICAO_REUNIAO    text                 not null,
   constraint PK_REUNIOES primary key (ID_REUNIAO)
)
go

/*==============================================================*/
/* Table: REUNIOES_DE_USER                                      */
/*==============================================================*/
create table REUNIOES_DE_USER (
   ID_REUNIAO           int                  not null,
   ID_USER              int                  not null,
   constraint PK_REUNIOES_DE_USER primary key (ID_REUNIAO, ID_USER),
   constraint FK_REUNIOES_REUNIOES__REUNIOES foreign key (ID_REUNIAO)
      references REUNIOES (ID_REUNIAO),
   constraint FK_REUNIOES_REUNIOES__USERS foreign key (ID_USER)
      references USERS (ID_USER)
)
go

