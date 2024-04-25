CREATE DATABASE persona_db;
GO

ALTER AUTHORIZATION ON DATABASE::persona_db TO sa;
GO

USE persona_db;
GO

-- -----------------------------------------------------
-- Table `arq_per_db`.`persona`
-- -----------------------------------------------------
CREATE TABLE [persona] (
  [cc] INT NOT NULL,
  [nombre] VARCHAR(45) NOT NULL,
  [apellido] VARCHAR(45) NOT NULL,
  [genero] CHAR(1) NOT NULL,
  [edad] INT NULL,
  PRIMARY KEY ([cc])
);
GO

-- -----------------------------------------------------
-- Table `arq_per_db`.`profesion`
-- -----------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'profesion')
BEGIN
    CREATE TABLE [profesion] (
      [id] INT PRIMARY KEY IDENTITY(1,1),
      [nom] VARCHAR(90) NOT NULL,
      [des] TEXT NULL
    );
END;


-- -----------------------------------------------------
-- Table `arq_per_db`.`estudios`
-- -----------------------------------------------------
CREATE TABLE [estudios] (
  [id_prof] INT NOT NULL,
  [cc_per] INT NOT NULL,
  [fecha] DATETIME NULL,
  [univer] VARCHAR(50) NULL,
  PRIMARY KEY ([id_prof], [cc_per]),
  CONSTRAINT [estudio_persona_fk] FOREIGN KEY ([cc_per]) REFERENCES [persona] ([cc]),
  CONSTRAINT [estudio_profesion_fk] FOREIGN KEY ([id_prof]) REFERENCES [profesion] ([id])

);
GO



-- -----------------------------------------------------
-- Table `arq_per_db`.`telefono`
-- -----------------------------------------------------
CREATE TABLE [telefono] (
  [num] VARCHAR(15) NOT NULL,
  [oper] VARCHAR(45) NOT NULL,
  [duenio] INT NOT NULL,
  PRIMARY KEY ([num]),
  CONSTRAINT [telefono_persona_fk] FOREIGN KEY ([duenio]) REFERENCES [persona] ([cc])
);
GO
