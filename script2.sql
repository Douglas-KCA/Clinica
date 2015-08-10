--
-- ER/Studio 8.0 SQL Code Generation
-- Company :      company
-- Project :      ERLaboratorio.DM1
-- Author :       Windows User
--
-- Date Created : Sunday, August 09, 2015 21:11:51
-- Target DBMS : MySQL 5.x
--

-- 
-- TABLE: ANALIISIS 
--

CREATE TABLE ANALIISIS(
    ncodanalisis    INT(10)    NOT NULL AUTO_INCREMENT,
    cdescripcion    CHAR(255)        NOT NULL,
    ncodservicio    DECIMAL(10, 0)    NOT NULL,
    ncodigocita     DECIMAL(10, 0)    NOT NULL,
    nsucursal       DECIMAL(10, 0)    NOT NULL,
    ncodtipo        DECIMAL(10, 0)    NOT NULL,
    ncodpaciente    CHAR(10)          NOT NULL,
    ncodetiqueta    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodanalisis)
)ENGINE=MYISAM
;



-- 
-- TABLE: CITA 
--

CREATE TABLE CITA(
    ncodigocita     INT(10)    NOT NULL AUTO_INCREMENT,
    nsucursal       DECIMAL(10, 0)    NOT NULL,
    ncodpaciente    CHAR(10)          NOT NULL,
    dfechacita      DATE              NOT NULL,
    choracita       CHAR(10)          NOT NULL,
    PRIMARY KEY (ncodigocita, nsucursal, ncodpaciente)
)ENGINE=MYISAM
;



-- 
-- TABLE: DEUDA 
--

CREATE TABLE DEUDA(
    ncoddeuda      INT(10)    NOT NULL AUTO_INCREMENT,
    ntotaldeuda    DECIMAL(10, 2)    NOT NULL,
    nsaldodeuda    DECIMAL(10, 2)    NOT NULL,
    ncodfactura    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncoddeuda)
)ENGINE=MYISAM
;



-- 
-- TABLE: EMPLEADO 
--

CREATE TABLE EMPLEADO(
    ncodempleado    INT(10)          NOT NULL AUTO_INCREMENT,
    ncodpersona     DECIMAL(10, 0),
    ncodpuesto      DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodempleado)
)ENGINE=MYISAM
;



-- 
-- TABLE: ETIQUETA 
--

CREATE TABLE ETIQUETA(
    ncodetiqueta    INT(10)    NOT NULL AUTO_INCREMENT,
    ncodmuestra     DECIMAL(10, 0)    NOT NULL,
    ncodpaciente    CHAR(10)          NOT NULL,
    PRIMARY KEY (ncodetiqueta)
)ENGINE=MYISAM
;



-- 
-- TABLE: FACTURA 
--

CREATE TABLE FACTURA(
    ncodfactura      INT(10)    NOT NULL AUTO_INCREMENT,
    ctipopago        CHAR(10)          NOT NULL,
    dfechafactura    DATE              NOT NULL,
    ncodpaciente     CHAR(10)          NOT NULL,
    PRIMARY KEY (ncodfactura)
)ENGINE=MYISAM
;



-- 
-- TABLE: MEMBRESIA 
--

CREATE TABLE MEMBRESIA(
    ncodmembresia     INT(10)    NOT NULL AUTO_INCREMENT,
    ctipomembresia    CHAR(100)         NOT NULL,
    cporcentaje       CHAR(10)          NOT NULL,
    PRIMARY KEY (ncodmembresia)
)ENGINE=MYISAM
;



-- 
-- TABLE: MrSEGURO 
--

CREATE TABLE MrSEGURO(
    ncodseguro         INT(10)    NOT NULL AUTO_INCREMENT,
    ncodtarifa         DECIMAL(10, 0),
    ncodaseguradora    DECIMAL(10, 0),
    PRIMARY KEY (ncodseguro)
)ENGINE=MYISAM
;



-- 
-- TABLE: MrTIPOEXAMEN 
--

CREATE TABLE MrTIPOEXAMEN(
    ncodtipo             INT(10)    NOT NULL AUTO_INCREMENT,
    cdesctipoexamen      CHAR(100),
    cpreciotipoexamen    CHAR(10)          NOT NULL,
    ncodmuestra          DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodtipo)
)ENGINE=MYISAM
;



-- 
-- TABLE: MUESTRA 
--

CREATE TABLE MUESTRA(
    ncodmuestra        INT(10)    NOT NULL AUTO_INCREMENT,
    crequerimientos    CHAR(255),
    cdescmuestra       CHAR(200)         NOT NULL,
    PRIMARY KEY (ncodmuestra)
)ENGINE=MYISAM
;



-- 
-- TABLE: PACIENTE 
--

CREATE TABLE PACIENTE(
    ncodpaciente     INT(10)          NOT NULL AUTO_INCREMENT,
    crefpaciente     CHAR(100)         NOT NULL,
    ncodpersona      DECIMAL(10, 0),
    ncodseguro       DECIMAL(10, 0)    NOT NULL,
    ncodmembresia    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodpaciente)
)ENGINE=MYISAM
;



-- 
-- TABLE: PERSONA 
--

CREATE TABLE PERSONA(
    ncodpersona          INT(10)    NOT NULL AUTO_INCREMENT,
    cdireccionpersona    CHAR(255)         NOT NULL,
    cemailpersona        CHAR(100)         NOT NULL,
    cnombrepersona       CHAR(200)         NOT NULL,
    capellidopersona     CHAR(255)         NOT NULL,
    cdpipersona          CHAR(10)          NOT NULL,
    dfechanacpersona     CHAR(10)          NOT NULL,
    csexopersona         CHAR(10)          NOT NULL,
    cnitpersona          CHAR(10)          NOT NULL,
    PRIMARY KEY (ncodpersona)
)ENGINE=MYISAM
;



-- 
-- TABLE: PUESTO 
--

CREATE TABLE PUESTO(
    ncodpuesto     INT(10)    NOT NULL AUTO_INCREMENT,
    ndescpuesto    CHAR(255)        NOT NULL,
    PRIMARY KEY (ncodpuesto)
)ENGINE=MYISAM
;



-- 
-- TABLE: SUCURSAL 
--

CREATE TABLE SUCURSAL(
    nsucursal     INT(10)    NOT NULL AUTO_INCREMENT,
    cubicacion    CHAR(100)         NOT NULL,
    PRIMARY KEY (nsucursal)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrASEGURADORA 
--

CREATE TABLE TrASEGURADORA(
    ncodaseguradora    INT(10)    NOT NULL AUTO_INCREMENT,
    cempresaseguro     CHAR(100)         NOT NULL,
    PRIMARY KEY (ncodaseguradora)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrSERVICIO 
--

CREATE TABLE TrSERVICIO(
    ncodservicio      INT(10)    NOT NULL AUTO_INCREMENT,
    ncodigocita       DECIMAL(10, 0)    NOT NULL,
    nsucursal         DECIMAL(10, 0)    NOT NULL,
    ncodtipo          DECIMAL(10, 0)    NOT NULL,
    ncodpaciente      CHAR(10)          NOT NULL,
    dfechaservicio    DATE,
    ncodempleado      CHAR(10)          NOT NULL,
    ncodfactura       DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodservicio, ncodigocita, nsucursal, ncodtipo, ncodpaciente)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrTARIFASEGURO 
--

CREATE TABLE TrTARIFASEGURO(
    ncodtarifa           INT(10)    NOT NULL AUTO_INCREMENT,
    nporcentajetarifa    DECIMAL(10, 0)    NOT NULL,
    ndeducible           DECIMAL(10, 2)    NOT NULL,
    PRIMARY KEY (ncodtarifa)
)ENGINE=MYISAM
;



-- 
-- TABLE: USUARIO 
--

CREATE TABLE USUARIO(
    ncodusuario         INT(10)    NOT NULL AUTO_INCREMENT,
    cnombreusuario      CHAR(100)         NOT NULL,
    ctipousuario        CHAR(10)          NOT NULL,
    cpasswordusuario    CHAR(100)         NOT NULL,
    ncodempleado        CHAR(10),
    PRIMARY KEY (ncodusuario)
)ENGINE=MYISAM
;



-- 
-- TABLE: ANALIISIS 
--

ALTER TABLE ANALIISIS ADD CONSTRAINT RefTrSERVICIO37 
    FOREIGN KEY (ncodservicio, ncodigocita, nsucursal, ncodtipo, ncodpaciente)
    REFERENCES TrSERVICIO(ncodservicio, ncodigocita, nsucursal, ncodtipo, ncodpaciente)
;

ALTER TABLE ANALIISIS ADD CONSTRAINT RefETIQUETA38 
    FOREIGN KEY (ncodetiqueta)
    REFERENCES ETIQUETA(ncodetiqueta)
;


-- 
-- TABLE: CITA 
--

ALTER TABLE CITA ADD CONSTRAINT RefSUCURSAL16 
    FOREIGN KEY (nsucursal)
    REFERENCES SUCURSAL(nsucursal)
;

ALTER TABLE CITA ADD CONSTRAINT RefPACIENTE27 
    FOREIGN KEY (ncodpaciente)
    REFERENCES PACIENTE(ncodpaciente)
;


-- 
-- TABLE: DEUDA 
--

ALTER TABLE DEUDA ADD CONSTRAINT RefFACTURA41 
    FOREIGN KEY (ncodfactura)
    REFERENCES FACTURA(ncodfactura)
;


-- 
-- TABLE: EMPLEADO 
--

ALTER TABLE EMPLEADO ADD CONSTRAINT RefPERSONA4 
    FOREIGN KEY (ncodpersona)
    REFERENCES PERSONA(ncodpersona)
;

ALTER TABLE EMPLEADO ADD CONSTRAINT RefPUESTO19 
    FOREIGN KEY (ncodpuesto)
    REFERENCES PUESTO(ncodpuesto)
;


-- 
-- TABLE: ETIQUETA 
--

ALTER TABLE ETIQUETA ADD CONSTRAINT RefMUESTRA29 
    FOREIGN KEY (ncodmuestra)
    REFERENCES MUESTRA(ncodmuestra)
;

ALTER TABLE ETIQUETA ADD CONSTRAINT RefPACIENTE30 
    FOREIGN KEY (ncodpaciente)
    REFERENCES PACIENTE(ncodpaciente)
;


-- 
-- TABLE: FACTURA 
--

ALTER TABLE FACTURA ADD CONSTRAINT RefPACIENTE36 
    FOREIGN KEY (ncodpaciente)
    REFERENCES PACIENTE(ncodpaciente)
;


-- 
-- TABLE: MrSEGURO 
--

ALTER TABLE MrSEGURO ADD CONSTRAINT RefTrTARIFASEGURO43 
    FOREIGN KEY (ncodtarifa)
    REFERENCES TrTARIFASEGURO(ncodtarifa)
;

ALTER TABLE MrSEGURO ADD CONSTRAINT RefTrASEGURADORA46 
    FOREIGN KEY (ncodaseguradora)
    REFERENCES TrASEGURADORA(ncodaseguradora)
;


-- 
-- TABLE: MrTIPOEXAMEN 
--

ALTER TABLE MrTIPOEXAMEN ADD CONSTRAINT RefMUESTRA23 
    FOREIGN KEY (ncodmuestra)
    REFERENCES MUESTRA(ncodmuestra)
;


-- 
-- TABLE: PACIENTE 
--

ALTER TABLE PACIENTE ADD CONSTRAINT RefPERSONA3 
    FOREIGN KEY (ncodpersona)
    REFERENCES PERSONA(ncodpersona)
;

ALTER TABLE PACIENTE ADD CONSTRAINT RefMrSEGURO13 
    FOREIGN KEY (ncodseguro)
    REFERENCES MrSEGURO(ncodseguro)
;

ALTER TABLE PACIENTE ADD CONSTRAINT RefMEMBRESIA14 
    FOREIGN KEY (ncodmembresia)
    REFERENCES MEMBRESIA(ncodmembresia)
;


-- 
-- TABLE: TrSERVICIO 
--

ALTER TABLE TrSERVICIO ADD CONSTRAINT RefCITA17 
    FOREIGN KEY (ncodigocita, nsucursal, ncodpaciente)
    REFERENCES CITA(ncodigocita, nsucursal, ncodpaciente)
;

ALTER TABLE TrSERVICIO ADD CONSTRAINT RefEMPLEADO18 
    FOREIGN KEY (ncodempleado)
    REFERENCES EMPLEADO(ncodempleado)
;

ALTER TABLE TrSERVICIO ADD CONSTRAINT RefMrTIPOEXAMEN25 
    FOREIGN KEY (ncodtipo)
    REFERENCES MrTIPOEXAMEN(ncodtipo)
;

ALTER TABLE TrSERVICIO ADD CONSTRAINT RefFACTURA35 
    FOREIGN KEY (ncodfactura)
    REFERENCES FACTURA(ncodfactura)
;


-- 
-- TABLE: USUARIO 
--

ALTER TABLE USUARIO ADD CONSTRAINT RefEMPLEADO39 
    FOREIGN KEY (ncodempleado)
    REFERENCES EMPLEADO(ncodempleado)
;


