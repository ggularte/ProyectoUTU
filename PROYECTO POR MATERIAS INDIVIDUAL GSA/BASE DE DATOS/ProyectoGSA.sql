/*Creación BD*/
CREATE DATABASE ProyectoGSA;
USE ProyectoGSA;
/*Entidades y relaciones*/
CREATE TABLE Persona(CI integer, Fecha_Nac date NOT NULL, Calle varchar(25) NOT NULL, Esquina varchar(25) NOT NULL, Numero varchar(10) NOT NULL, Primer_Apellido varchar(20) NOT NULL, Segundo_Apellido varchar(20) NOT NULL, Primer_Nombre varchar(20) NOT NULL, Segundo_Nombre varchar(20), Correo varchar(40),
PRIMARY KEY (CI));

CREATE TABLE Personal_Medico(CI integer, EstadoBorradoM boolean NOT NULL DEFAULT FALSE,
PRIMARY KEY (CI),
FOREIGN KEY (CI) REFERENCES Persona(CI));

CREATE TABLE Paciente(CI_Paciente integer, Estado_Civil VARCHAR(12) NOT NULL, Sexo CHAR(1) NOT NULL, EstadoBorradoP boolean NOT NULL DEFAULT FALSE,
PRIMARY KEY (CI_Paciente),
FOREIGN KEY (CI_Paciente) REFERENCES Persona(CI),
CONSTRAINT CHK_Paciente CHECK (Estado_Civil IN ('Soltero/a','Viudo/a','Casado/a','Divorciado/a') AND Sexo IN ('F','M' )));

CREATE TABLE Medico (CI_Medico integer, Especialidad varchar(25) NOT NULL,
PRIMARY KEY(CI_Medico),
FOREIGN KEY (CI_Medico) REFERENCES Personal_Medico(CI));

CREATE TABLE Persona_Telefono(CI integer, Telefono varchar(9),
PRIMARY KEY(CI, Telefono),                                                                                   
FOREIGN KEY (CI) REFERENCES Persona(CI),
UNIQUE(CI, Telefono));

CREATE TABLE Respuesta(ID_Resp integer AUTO_INCREMENT, TextoResp varchar(160) NOT NULL,
PRIMARY KEY(ID_Resp));

CREATE TABLE Pregunta (ID_Preg integer AUTO_INCREMENT, TextoPreg varchar(160) NOT NULL,
PRIMARY KEY(ID_Preg));

CREATE TABLE Atiende(Fecha_Atiende datetime, CI_Medico integer, CI_Paciente integer, Estado_De_Conciencia varchar(20) NOT NULL, Movilidad varchar(20) NOT NULL, Otro varchar(20), Fiebre boolean, Dolor boolean, Malestar boolean, Pulso VARCHAR(10) NOT NULL , Frecuencia_Cardiaca varchar(20), Temperatura double NOT NULL, Grado_De_Hidratacion varchar(20) NOT NULL, Estado_De_Nutricion VARCHAR(8) NOT NULL, Actitud VARCHAR(10) NOT NULL, Grado_De_Colaboracion varchar(20) NOT NULL, Frecuencia_Respiratoria varchar(20) NOT NULL, Motivo varchar(240) NOT NULL, Enfermedad_Actual varchar(55), Nombre_Acompaniante varchar(20), Tipo_EnfermedadActual varchar(20), Tipo_EnfermedadAnterior varchar(20), Enfermedad_Familiar varchar(55), Antecedentes_Personales varchar(55),
PRIMARY KEY(Fecha_Atiende, CI_Medico, CI_Paciente),
FOREIGN KEY(CI_Medico) REFERENCES Medico(CI_Medico),
FOREIGN KEY(CI_Paciente) REFERENCES Paciente(CI_Paciente),
CONSTRAINT CHK_Atiende CHECK (Pulso IN ('Fuerte','Débil','Normal','Filiforme') AND Actitud IN ('Coma','Apatía','Normal','Excitación') AND Estado_De_Nutricion IN ('Obesidad','Común','Anorexia','Caquexia')));

CREATE TABLE Analisis_Clinico(ID_Analisis integer AUTO_INCREMENT, TipoAnalisis varchar(50) NOT NULL, Resultado varchar(240) NOT NULL, Fecha_Analisis DATETIME NOT NULL, Fecha_Atiende DATETIME NOT NULL, CI_Medico integer NOT NULL, CI_Paciente integer NOT NULL, EstadoBorradoA boolean NOT NULL DEFAULT FALSE,
PRIMARY KEY(ID_Analisis),
FOREIGN KEY (Fecha_Atiende) REFERENCES Atiende(Fecha_Atiende),
FOREIGN KEY (CI_Paciente) REFERENCES Atiende(CI_Paciente),
FOREIGN KEY (CI_Medico) REFERENCES Atiende(CI_Medico));

CREATE TABLE Formulario(ID_Form integer AUTO_INCREMENT, Tipo_Form varchar(50) NOT NULL, EstadoBorradoF boolean NOT NULL DEFAULT FALSE,
PRIMARY KEY(ID_Form));

CREATE TABLE Diagnostico(ID_Diag integer AUTO_INCREMENT, Tipo_Diag varchar(50) NOT NULL, Descripcion_Diag varchar(240) NOT NULL, EstadoBorradoD boolean NOT NULL DEFAULT FALSE,
PRIMARY KEY(ID_Diag));

CREATE TABLE Tratamiento(ID_Trata integer AUTO_INCREMENT, Nombre varchar(50) NOT NULL, Descripcion_Trat varchar(240) NOT NULL, EstadoBorradoT boolean NOT NULL DEFAULT FALSE,
PRIMARY KEY(ID_Trata));

CREATE TABLE Estado(ID_Estado integer AUTO_INCREMENT, Nombre_Estado varchar(40) NOT NULL,
PRIMARY KEY(ID_Estado));

CREATE TABLE Realiza(CI_Paciente integer, ID_Trata integer, FechaInicio datetime NOT NULL, FechaFinal datetime,                                                                          
PRIMARY KEY(CI_Paciente, ID_Trata, FechaInicio),
FOREIGN KEY (CI_Paciente) REFERENCES Paciente(CI_Paciente),                                                                        
FOREIGN KEY (ID_Trata) REFERENCES Tratamiento(ID_Trata));

CREATE TABLE Demanda(ID_Trata integer, ID_Diag integer,
PRIMARY KEY(ID_Trata, ID_Diag),
FOREIGN KEY (ID_Trata) REFERENCES Tratamiento(ID_Trata),
FOREIGN KEY (ID_Diag) REFERENCES Diagnostico(ID_Diag));

CREATE TABLE Contiene (ID_Form integer, ID_Preg integer,
PRIMARY KEY(ID_Form, ID_Preg),
FOREIGN KEY (ID_Form) REFERENCES Formulario(ID_Form),
FOREIGN KEY (ID_Preg) REFERENCES Pregunta(ID_Preg));

CREATE TABLE Sugiere(Fecha_Atiende datetime, CI_Medico integer, CI_Paciente integer, ID_Form integer, ID_Preg integer,
PRIMARY KEY(Fecha_Atiende, CI_Medico, CI_Paciente, ID_Form, ID_Preg),
FOREIGN KEY (Fecha_Atiende) REFERENCES Atiende(Fecha_Atiende),
FOREIGN KEY (CI_Medico) REFERENCES Atiende(CI_Medico),
FOREIGN KEY (CI_Paciente) REFERENCES Atiende(CI_Paciente),
FOREIGN KEY (ID_Preg) REFERENCES Contiene(ID_Preg),
FOREIGN KEY (ID_Form) REFERENCES Contiene(ID_Form));

CREATE TABLE Responde(CI_Medico integer, CI_Paciente integer, Fecha_Atiende datetime, ID_Resp integer,
PRIMARY KEY(CI_Medico, CI_Paciente, Fecha_Atiende, ID_Resp),
FOREIGN KEY (CI_Medico) REFERENCES Atiende(CI_Medico),
FOREIGN KEY (CI_Paciente) REFERENCES Atiende(CI_Paciente),
FOREIGN KEY (Fecha_Atiende) REFERENCES Atiende(Fecha_Atiende),
FOREIGN KEY (ID_Resp) REFERENCES Respuesta(ID_Resp));

CREATE TABLE Requiere(ID_Analisis integer, ID_Diag integer,
PRIMARY KEY(ID_Analisis, ID_Diag),
FOREIGN KEY (ID_Analisis) REFERENCES Analisis_Clinico (ID_Analisis),
FOREIGN KEY (ID_Diag) REFERENCES Diagnostico(ID_Diag));

CREATE TABLE Tiene(ID_Form integer, ID_Preg integer, ID_Resp integer, FechaR datetime,
PRIMARY KEY(ID_Form, ID_Preg, ID_Resp, FechaR),                                                                      
FOREIGN KEY(ID_Resp) REFERENCES Respuesta(ID_Resp),
CONSTRAINT `tiene_ibfk_11`
  FOREIGN KEY (`ID_Form`)
  REFERENCES `proyectogsa`.`contiene` (`ID_Form`)
  ON DELETE CASCADE,
CONSTRAINT `tiene_ibfk_22`
  FOREIGN KEY (`ID_Preg`)
  REFERENCES `proyectogsa`.`contiene` (`ID_Preg`)
  ON DELETE CASCADE);

CREATE TABLE Elabora(ID_Diag integer, Fecha_Diag datetime, Fecha_Atiende datetime, CI_Medico integer, CI_Paciente integer,
PRIMARY KEY(ID_Diag, Fecha_Diag),                                                                      
FOREIGN KEY(ID_Diag) REFERENCES Diagnostico(ID_Diag),
FOREIGN KEY(Fecha_Atiende) REFERENCES Atiende(Fecha_Atiende),
FOREIGN KEY(CI_Medico) REFERENCES Atiende(CI_Medico),
FOREIGN KEY(CI_Paciente) REFERENCES Atiende(CI_Paciente));

CREATE TABLE Posee(ID_Estado integer, CI_Paciente integer, FechaInicio_E datetime,
PRIMARY KEY(ID_Estado, CI_Paciente, FechaInicio_E),                                                                      
FOREIGN KEY(ID_Estado) REFERENCES Estado(ID_Estado),
FOREIGN KEY(CI_Paciente) REFERENCES Paciente(CI_Paciente));

CREATE TABLE PartesCuerpo (ID_Partes integer auto_increment, Cabeza boolean, Cuello boolean, Brazo boolean, Mano boolean, Muslo boolean, Pantorrilla boolean, Oreja boolean, Hombro boolean, Espalda boolean, Trasero boolean, Tobillo boolean, Ojo boolean, Nariz boolean, Boca boolean, Munieca boolean, Dedo boolean, Pierna boolean, Frente boolean, Garganta boolean, Pecho boolean, Estomago boolean, Rodilla boolean, Pie boolean,
PRIMARY KEY (ID_Partes));

CREATE TABLE Incluye(ID_Partes integer, CI_Paciente integer, Fecha_Atiende datetime, CI_Medico integer,
PRIMARY KEY(ID_Partes, CI_Paciente, CI_Medico, Fecha_Atiende),
FOREIGN KEY(ID_Partes) REFERENCES PartesCuerpo(ID_Partes),
FOREIGN KEY(Fecha_Atiende) REFERENCES Atiende(Fecha_Atiende),
FOREIGN KEY(CI_Medico) REFERENCES Atiende(CI_Medico),
FOREIGN KEY(CI_Paciente) REFERENCES Atiende(CI_Paciente));

CREATE TABLE Rol(ID_Rol smallint AUTO_INCREMENT, Nombre_Rol varchar(20) NOT NULL,
PRIMARY KEY(ID_Rol));

CREATE TABLE Usuario_Rol(Usuario varchar(20), Rol smallint NOT NULL, CI integer NOT NULL,
PRIMARY KEY(Usuario),
FOREIGN KEY(Rol) REFERENCES Rol(ID_Rol));

CREATE VIEW
vista_SintomasAtiendeCD AS
SELECT p.CI, p.Primer_Nombre, p.Primer_Apellido, a.Enfermedad_Actual, a.Dolor, a.Fiebre, a.Malestar, a.Otro, pc.Cabeza, pc.Cuello, pc.Brazo, pc.Mano, pc.Muslo, pc.Pantorrilla, pc.Oreja, pc.Hombro, pc.Espalda, pc.Trasero, pc.Tobillo, pc.Ojo, pc.Nariz, pc.Boca, pc.Munieca, pc.Dedo, pc.Pierna, pc.Frente, pc.Garganta, pc.Pecho, pc.Estomago, pc.Rodilla, pc.Pie
FROM Persona as p
JOIN Paciente as pa ON p.CI=pa.CI_Paciente
JOIN Atiende as a ON pa.CI_Paciente=a.CI_Paciente
JOIN Incluye as i ON a.Fecha_Atiende=i.Fecha_Atiende
JOIN PartesCuerpo as pc ON i.ID_Partes=pc.ID_Partes;
CREATE VIEW
vista_SintomasAtiendeSD AS
SELECT p.CI, p.Primer_Nombre, p.Primer_Apellido, a.Enfermedad_Actual, a.Dolor, a.Fiebre, a.Malestar, a.Otro
FROM Persona as p
JOIN Paciente as pa ON p.CI=pa.CI_Paciente
JOIN Atiende as a ON pa.CI_Paciente=a.CI_Paciente;
CREATE VIEW
vista_NombreMedico AS
SELECT p.CI, p.Primer_Nombre, p.Primer_Apellido
FROM Persona as p
JOIN Personal_Medico as pm ON p.CI=pm.CI
JOIN Medico as m ON pm.CI=m.CI_Medico;

/*PRIVILEGIOS DE USUARIOS*/
INSERT INTO `Rol` (`Nombre_Rol`) VALUES
('Medico'),
('Auxiliar'),
('Paciente'),
('Administrador');
INSERT INTO `Usuario_Rol` (`Usuario`,`Rol`,`CI`) VALUES
('GSA_Med',1,54200707),
('GSA_Aux',2,55762293),
('GSA_Pac',3,52137108),
('GSA_Adm',4,52582991);

/*Datos principales*/
INSERT INTO `Estado` (`Nombre_Estado`) VALUES
('Recolección de información'),
('Hipótesis diagnóstica'),
('Proceso de verificación y afirmación'),
('Transformación');

INSERT INTO `Diagnostico` (`Tipo_Diag`,`Descripcion_Diag`) VALUES
('Clínico','A'),
('Certeza','B'),
('Diferencia','C'),
('Etiológico','D'),
('Genérico','E'),
('Heroico','F'),
('Lesional','G'),
('Anatómico','H'),
('Topográfico','I'),
('Individual','J'),
('Nosológico','K'),
('Patogenético','A'),
('Presuntivo','A'),
('Sindómico y funcional','A'),
('Sintomático','A');

INSERT INTO `Persona` (`CI`,`Fecha_Nac`,`Calle`,`Esquina`,`Numero`,`Primer_Apellido`,`Segundo_Apellido`,`Primer_Nombre`,`Segundo_Nombre`,`Correo`) VALUES
(55762293,'2002-10-22','a','b','1111','Iriart','Guibernau','Santiago','Miguel','santiagoiriart9@gmail.com'),
(54200707,'2002-12-2','c','d','1112','Gularte','Artola','Gonzalo','Lisandro','gonzalogulartemvd@gmail.com'),
(52137108,'2002-4-18','e','f','1113','Acosta','Bernardo','Agustin','Luciano','agustin14acosta@gmail.com'),
(52582991,'2002-10-14','g','h','1114','Sunes','Pianavilla','Bruno','Daniel','brunosunes@gmai.com'),
(62653134,'2000-11-11','i','j','1115','Rosales','Matos','Zendhel','','mrucl2020@gmail.com'),
(11111111,'2001-12-11','i','j','1116','Rodriguez','Cabrera','Kevin','','krodriguez2020@gmail.com'),
(11111112,'1990-9-10','i','j','1117','Olivera','Trinidad','Nahuel','','nahuoliveraa@gmail.com'),
(11111113,'1998-12-28','i','j','1118','Plada','Rodriguez','Patricia','Betiana', 'patriciaplada@gmail.com'),
(11111114,'2018-11-10','i','j','1119','Maldonado','Correa','Francesca','','francorrea25@gmail.com'),
(11111115,'1991-8-4','i','j','1120','Perez','Disalvo','Martin','','martinpd@hotmail.com'),
(11111116,'1990-3-11','i','j','1120','Santos','Pedrosa','Fabian','','fabiansantospe@hotmail.com'),
(11111117,'1980-4-12','i','j','1120','Olivera','Fernandez','Silvia','','silviolivera18@gmail.com'),
(11111118,'1970-5-13','i','j','1120','Berta','García','Agustina','','agustinagarcia@hotmail.com'),
(11111119,'1967-6-14','i','j','1120','Suarez','Villasante','Carolina','','carosuarez8@gmail.com'),
(11111120,'2012-7-15','i','j','1120','Cordoba','Traverso','Valentin','','ValentinTraverso@gmail.com'),
(11111121,'1999-8-16','i','j','1120','Nievas','Troncoso','Micaela','','MicaelaTroncoso@gmail.com'),
(11111122,'1978-9-17','i','j','1120','Medina','Telechea','Sandra','','SandraTelechea@hotmail.com'),
(11111123,'1945-10-18','i','j','1120','Mayol','Garay','Maria','','MariaGaray@gmail.com'),
(11111124,'2016-11-19','i','j','1120','Silvera','Hernandez','Emma','','EmmaHernandez@hotmail.com'),
(11111125,'2013-12-20','i','j','1120','Rodriguez','Gonzalez','Maxiemiliano','Pedro','MaxiemilianoGonzalez@hotmail.com'),
(11111126,'1950-10-22','a','b','1129','Ferreira','Godoy','Alberto','Pedro','AlbertoGodoy@gmail.com');

INSERT INTO `Persona_Telefono` (`CI`,`Telefono`) VALUES
(55762293,'093982489'),
(54200707,'094742318'),
(52137108,'091027326'),
(52582991,'092111308'),
(62653134,'096242702'),
(11111111,'095762985'),
(11111112,'098876243'),
(11111113,'091876435'),
(11111114,'099339902'),
(11111115,'099199199'),
(11111116,'099122393'),
(11111117,'095567456'),
(11111118,'094444444'),
(11111119,'095554554'),
(11111120,'094223232'),
(11111121,'094556766'),
(11111122,'096666666'),
(11111123,'097777777'),
(11111124,'093345678'),
(11111125,'091023495');

INSERT INTO `Paciente` (`CI_Paciente`,`Estado_Civil`,`Sexo`) VALUES
(55762293,'Soltero/a','M'),
(54200707,'Soltero/a','M'),
(52137108,'Soltero/a','F'),
(52582991,'Soltero/a','F'),
(62653134,'Soltero/a','F'),
(11111111,'Soltero/a','F'),
(11111112,'Casado/a','F'),
(11111113,'Soltero/a','F'),
(11111114,'Soltero/a','F'),
(11111115,'Viudo/a','F'),
(11111116,'Soltero/a','F'),
(11111117,'Casado/a','F'),
(11111126,'Viudo/a','M');

INSERT INTO `Personal_Medico` (`CI`) VALUES
(11111118),
(11111119),
(11111120),
(11111121),
(11111122),
(11111123),
(11111124),
(11111125);

INSERT INTO `Medico` (`CI_Medico`,`Especialidad`) VALUES
(11111118,'Traumatología'),
(11111119,'Dermatología'),
(11111120,'Ginecología '),
(11111121,'Oftalmología'),
(11111122,'Otorrinolaringología'),
(11111124,'Urología'),
(11111125,'Neumología');

INSERT INTO `Atiende` (`Fecha_Atiende`,`CI_Paciente`,`CI_Medico`,`Estado_De_Conciencia`,`Movilidad`,`Otro`,`Fiebre`,`Dolor`,`Malestar`,`Pulso`,`Frecuencia_Cardiaca`,`Temperatura`,`Grado_De_Hidratacion`,`Estado_De_Nutricion`,`Actitud`,`Grado_De_Colaboracion`,`Frecuencia_Respiratoria`,`Motivo`,`Enfermedad_Actual`,`Nombre_Acompaniante`,`Tipo_EnfermedadActual`,`Tipo_EnfermedadAnterior`,`Enfermedad_Familiar`,`Antecedentes_Personales`) VALUES
('2018-06-01 13:00:20',11111111,11111118,'Normal','Buena','',TRUE,FALSE,FALSE,'Fuerte','125',37.9,'Normal','Caquexia','Normal','Normal','Baja','Fatiga','Anemia','Alberto','Sanginea','Lecion', 'Artrosis', 'Desgarre muscular'),
('2014-04-14 15:00:40',11111126,11111125,'Anormal','Normal','Mareo',TRUE,FALSE,FALSE,'Filiforme','80',36.5,'Sobrehidratado ','Anorexia','Apatía','Normal','Baja','Dolor muscular','Desgarre muscular','Rodolfo','Lecion', '', '', ''),
('2018-06-01 13:00:20',11111116,11111125,'Normal','Normal','',TRUE,FALSE,FALSE,'Débil','114',38.6,'Normal','Obesidad','Normal','Normal','Baja','visión borrosa','Miopia','Ramón','Ocular', '', '', ''),
('2020-06-22 09:30:23',62653134,11111121,'Anormal','Buena','Mareo',TRUE,FALSE,TRUE,'Normal','104',35.2,'Sobrehidratado','Común','Excitación','Normal','Baja','Dificultad al respirar','Asma','Ramón','Respiratorio','Ocular', '', 'Astigmatismo'),
('2020-08-18 16:00:23',11111114,11111125,'Normal','Baja','',TRUE,FALSE,FALSE,'Fuerte','98',38.9,'Normal','Común','Normal','Normal','Baja','Dificultad al respirar','Covid-19','Ramón','Respiratorio','Respiratorio', '', 'Asma'),
('2015-11-02 16:00:34',62653134,11111125,'Normal','Normal','Desorientacion',FALSE,TRUE,FALSE,'Normal','90',39.2,'Normal','Anorexia','Apatía','Normal','Baja','Dolor','Hipercoagubilidad','Agus','Sanginea','Vista', '', 'Miopia'),
('2019-01-01 18:15:12',11111126,11111118,'Anormal','Normal','',FALSE,TRUE,TRUE,'Débil','108',36.8,'Normal','Anorexia','Normal','Normal','Baja','Malestar','Cancer','Rodolfo','Tumor','Lecion', 'Diabetes', 'Fractura'),
('2020-07-28 13:50:23',11111117,11111120,'Normal','Baja','',FALSE,TRUE,FALSE,'Filiforme','100',36.9,'Desidratado','Común','Excitación','Normal','Baja','Dolor de cabeza','Aneurismas de los vasos del cerebro','José','Sanginea','Respiratorio', '', 'Gripe'),
('2010-08-06 19:30:43',11111115,11111125,'Anormal','Buena','',TRUE,TRUE,FALSE,'Normal','112',39.8,'Normal','Anorexia','Normal','Normal','Baja','Dolor Estomscal','Tumor','Lázaro','Tumor','Lecion', '', 'Ematoma'),
('2020-11-01 13:00:20',11111111,11111118,'Normal','Buena','',TRUE,FALSE,FALSE,'Fuerte','125',37.9,'Normal','Caquexia','Normal','Normal','Baja','Fatiga','Anemia','Alberto','Sanginea','Lecion', 'Artrosis', 'Desgarre muscular'),
('2020-11-14 15:00:40',11111126,11111125,'Anormal','Normal','Mareo',TRUE,FALSE,FALSE,'Filiforme','80',36.5,'Sobrehidratado ','Anorexia','Apatía','Normal','Baja','Dolor muscular','Desgarre muscular','Rodolfo','Lecion', '', '', ''),
('2020-11-01 13:00:20',11111116,11111125,'Normal','Normal','',TRUE,FALSE,FALSE,'Débil','114',38.6,'Normal','Obesidad','Normal','Normal','Baja','visión borrosa','Miopia','Ramón','Ocular', '', '', ''),
('2020-11-22 09:30:23',62653134,11111121,'Anormal','Buena','Mareo',TRUE,FALSE,TRUE,'Normal','104',35.2,'Sobrehidratado','Común','Excitación','Normal','Baja','Dificultad al respirar','Asma','Ramón','Respiratorio','Ocular', '', 'Astigmatismo'),
('2020-10-01 13:00:20',11111111,11111118,'Normal','Buena','',TRUE,FALSE,FALSE,'Fuerte','125',37.9,'Normal','Caquexia','Normal','Normal','Baja','Fatiga','Anemia','Alberto','Sanginea','Lecion', 'Artrosis', 'Desgarre muscular'),
('2020-10-02 15:00:40',11111126,11111118,'Anormal','Normal','Mareo',TRUE,FALSE,FALSE,'Filiforme','80',36.5,'Sobrehidratado ','Anorexia','Apatía','Normal','Baja','Dolor muscular','Desgarre muscular','Rodolfo','Lecion', '', '', ''),
('2020-10-03 13:00:20',11111116,11111118,'Normal','Normal','',TRUE,FALSE,FALSE,'Débil','114',38.6,'Normal','Obesidad','Normal','Normal','Baja','Caída','Fractura en el fémul','Ramón','Lecion', '', '', ''),
('2020-10-14 09:30:23',62653134,11111118,'Anormal','Buena','Mareo',TRUE,FALSE,TRUE,'Normal','104',35.2,'Sobrehidratado','Común','Excitación','Normal','Baja','Dificultad al respirar','Asma','Ramón','Respiratorio','Lecion', '', ''),
('2020-10-05 16:00:23',11111114,11111125,'Normal','Baja','',TRUE,FALSE,FALSE,'Fuerte','98',38.9,'Normal','Común','Normal','Normal','Baja','Dificultad al respirar','Covid-19','Ramón','Respiratorio','Respiratorio', '', 'Asma'),
('2020-10-16 16:00:34',62653134,11111125,'Normal','Normal','Desorientacion',FALSE,TRUE,FALSE,'Normal','90',39.2,'Normal','Anorexia','Apatía','Normal','Baja','Dolor','Hipercoagubilidad','Agus','Sanginea','Vista', '', 'Miopia'),
('2020-10-17 18:15:12',11111126,11111120,'Anormal','Normal','',FALSE,TRUE,TRUE,'Débil','108',36.8,'Normal','Anorexia','Normal','Normal','Baja','Malestar','Cancer','Rodolfo','Tumor','Lecion', 'Diabetes', 'Fractura'),
('2020-10-28 13:50:23',11111117,11111120,'Normal','Baja','',FALSE,TRUE,FALSE,'Filiforme','100',36.9,'Desidratado','Común','Excitación','Normal','Baja','Dolor de cabeza','Aneurismas de los vasos del cerebro','José','Sanginea','Respiratorio', '', 'Gripe'),
('2020-10-09 19:30:43',11111115,11111120,'Anormal','Buena','',TRUE,TRUE,FALSE,'Normal','112',39.8,'Normal','Anorexia','Normal','Normal','Baja','Dolor Estomscal','Tumor','Lázaro','Tumor','Lecion', '', 'Ematoma'),
('2020-06-10 13:00:20',11111111,11111118,'Normal','Buena','',TRUE,FALSE,FALSE,'Fuerte','125',37.9,'Normal','Caquexia','Normal','Normal','Baja','Fatiga','Anemia','Alberto','Sanginea','Lecion', 'Artrosis', 'Desgarre muscular'),
('2020-04-11 15:00:40',11111126,11111125,'Anormal','Normal','Mareo',TRUE,FALSE,FALSE,'Filiforme','80',36.5,'Sobrehidratado ','Anorexia','Apatía','Normal','Baja','Dolor muscular','Desgarre muscular','Rodolfo','Lecion', '', '', ''),
('2020-02-12 13:00:20',62653134,11111125,'Normal','Normal','',TRUE,FALSE,FALSE,'Débil','114',38.6,'Normal','Obesidad','Normal','Normal','Baja','visión borrosa','Miopia','Ramón','Ocular', '', '', ''),
('2020-06-13 09:30:23',62653134,11111121,'Anormal','Buena','Mareo',TRUE,FALSE,TRUE,'Normal','104',35.2,'Sobrehidratado','Común','Excitación','Normal','Baja','Dificultad al respirar','Asma','Ramón','Respiratorio','Ocular', '', 'Astigmatismo'),
('2020-06-14 13:00:20',11111111,11111118,'Normal','Buena','',TRUE,FALSE,FALSE,'Fuerte','125',37.9,'Normal','Caquexia','Normal','Normal','Baja','Fatiga','Anemia','Alberto','Sanginea','Lecion', 'Artrosis', 'Desgarre muscular'),
('2020-02-15 15:00:40',62653134,11111118,'Anormal','Normal','Mareo',TRUE,FALSE,FALSE,'Filiforme','80',36.5,'Sobrehidratado ','Anorexia','Apatía','Normal','Baja','Dolor muscular','Desgarre muscular','Rodolfo','Lecion', '', '', ''),
('2020-02-16 13:00:20',62653134,11111125,'Normal','Normal','',TRUE,FALSE,FALSE,'Débil','114',38.6,'Normal','Obesidad','Normal','Normal','Baja','visión borrosa','Miopia','Ramón','Ocular', '', '', ''),
('2020-06-02 09:30:23',62653134,11111121,'Anormal','Buena','Mareo',TRUE,FALSE,TRUE,'Normal','104',35.2,'Sobrehidratado','Común','Excitación','Normal','Baja','Dificultad al respirar','Asma','Ramón','Respiratorio','Ocular', '', 'Astigmatismo'),
('2020-02-19 13:00:20',11111111,11111118,'Normal','Buena','',TRUE,FALSE,FALSE,'Fuerte','125',37.9,'Normal','Caquexia','Normal','Normal','Baja','Fatiga','Anemia','Alberto','Sanginea','Lecion', 'Artrosis', 'Desgarre muscular'),
('2020-04-20 15:00:40',11111111,11111125,'Anormal','Normal','Mareo',TRUE,FALSE,FALSE,'Filiforme','80',36.5,'Sobrehidratado ','Anorexia','Apatía','Normal','Baja','Dolor muscular','Desgarre muscular','Rodolfo','Lecion', '', '', ''),
('2020-02-21 13:00:20',11111116,11111125,'Normal','Normal','',TRUE,FALSE,FALSE,'Débil','114',38.6,'Normal','Obesidad','Normal','Normal','Baja','visión borrosa','Miopia','Ramón','Ocular', '', '', ''),
('2020-02-23 09:30:23',62653134,11111121,'Anormal','Buena','Mareo',TRUE,FALSE,TRUE,'Normal','104',35.2,'Sobrehidratado','Común','Excitación','Normal','Baja','Dificultad al respirar','Asma','Ramón','Respiratorio','Ocular', '', 'Astigmatismo'),
('2020-11-01 15:00:40',11111126,11111125,'Anormal','Normal','Mareo',TRUE,FALSE,FALSE,'Filiforme','80',36.5,'Sobrehidratado ','Anorexia','Apatía','Normal','Baja','Dolor muscular','Desgarre muscular','Rodolfo','Lecion', NULL, NULL, NULL),
('2020-11-01 09:30:23',62653134,11111121,'Anormal','Buena','Mareo',TRUE,FALSE,TRUE,'Normal','104',35.2,'Sobrehidratado','Común','Excitación','Normal','Baja','Dificultad al respirar','Asma','Ramón','Respiratorio','Ocular', NULL, 'Astigmatismo');

INSERT INTO `PartesCuerpo` (`Cabeza`, `Cuello`, `Brazo`, `Mano`, `Muslo`, `Pantorrilla`, `Oreja`, `Hombro`, `Espalda`, `Trasero`, `Tobillo`, `Ojo`, `Nariz`, `Boca`, `Munieca`, `Dedo`, `Pierna`, `Frente`, `Garganta`, `Pecho`, `Estomago`, `Rodilla`, `Pie`) VALUES
(FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, FALSE, FALSE),
(FALSE, FALSE, TRUE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE),
(TRUE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE),
(FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, TRUE, FALSE, FALSE, FALSE);

INSERT INTO `Incluye` (`ID_Partes`, `CI_Paciente`, `Fecha_Atiende`, `CI_Medico`) VALUES
(1, 62653134, '2015-11-02 16:00:34', 11111125),
(2, 11111126, '2019-01-01 18:15:12', 11111118),
(3, 11111117, '2020-07-28 13:50:23', 11111120),
(4 ,11111115, '2010-08-06 19:30:43', 11111125);

INSERT INTO `Analisis_Clinico` (`TipoAnalisis`,`Resultado`,`Fecha_Analisis`,`Fecha_Atiende`,`CI_Medico`,`CI_Paciente`) VALUES
('Química sanguíne','Anemia','2018-06-04 13:30:44','2018-06-01 13:00:20',11111118,11111111),
('Radiografia','Sin resultados','2014-04-14 14:30:22','2014-04-14 15:00:40',11111125,11111126),
('Ocular','Miopia','2018-06-04 13:30:44','2018-06-01 13:00:20',11111125,11111116),
('HIS','Covid-19 negativo','2020-06-22 10:15:34','2020-06-22 09:30:23',11111121, 62653134),
('HIS','Covid-19 positivo','2020-08-18 16:40:34','2020-08-18 16:00:23',11111125,11111114),
('Coagulación','hipercoagubilidad','2015-11-12 17:50:32','2015-11-02 16:00:34',11111125,62653134),
('Marcadores tumorales','Cancer','2019-01-30 09:30:43','2019-01-01 18:15:12',11111118,11111126),
('Resonancia magnética de la cabeza','Aneurismas de los vasos del cerebro','2020-08-04 14:30:21','2020-07-28 13:50:23',11111120, 11111117),
('Resonancia magnética del tórax','Tumor','2010-08-23 20:00:00','2010-08-06 19:30:43',11111125, 11111115),
('Química sanguíne','Anemia','2020-11-04 13:00:20','2020-11-01 13:00:20',11111118,11111111),
('Radiografia','Sin resultados','2020-11-01 16:30:40','2020-11-01 15:00:40',11111125,11111126),
('Ocular','Miopia','2020-11-02 13:00:20','2020-11-01 13:00:20',11111125,11111116),
('HIS','Covid-19 negativo','2020-11-06 09:30:23','2020-11-01 09:30:23',11111121, 62653134);

INSERT INTO `Diagnostico` (`Tipo_Diag`,`Descripcion_Diag`) VALUES
('Certeza','Anemia'),
('Lecional','Desgarre muscular'),
('Presuntivo','Miopia'),
('Presuntivo','Asma'),
('Noslógico','Covid-19'),
('Presuntivo','Hipercoagubilidad'),
('Anatomico','Cancer'),
('Presuntivo','Aneurismas de los vasos del cerebro'),
('Presuntivo','Tumor');

INSERT INTO `Tratamiento` (`Nombre`,`Descripcion_Trat`) VALUES
('Medicamento para anemia','Tomar suplementos de hierro.'),
('Tratamiento por desgarre muscular','0 horas: aplicación de frío, 48 horas: reposo, vendaje compresivo de la zona, 72 horas: dejar de aplicar frío, iniciar reabilitacion, 3 semanas finaliza el tratamiento.'),
('Tratamiento para la miopia','Uso de lentes'),
('Tratamiento para el asma','tomar Corticoesteroides inhalados'),
('Tratamiento para el Covid-19','Ingerir ibuprofeno, jarabe para la tos, reposo, ingerir líquidos'),
('Tratamiento para la hipercoagubilidad','Ingerir anticoagulantes durante un periodo de 3 a 6 meses.'),
('Tratamiento para cáncer','Cirujia en la que se extirpa el cáncer'),
('Desbiacion de flujo','Desviar el flujo sanguíneo para que no llegue al saco del aneurisma.'),
('Tratamiento para tumores','Se prosede a extirparse mediante cirugía el tumor');

INSERT INTO `Realiza` (`CI_Paciente`,`ID_Trata`,`FechaInicio`,`FechaFinal`) VALUES
(55762293,1,'2018-06-14 13:30:44','2019-06-15 12:00:30'),
(55762293,2,'2014-05-06 14:00:59','2014-05-27 14:1:50'),
(54200707,3,'2018-06-06 12:30:49','9998-12-31 00:00:00'),
(52137108,4,'2020-06-28 10:15:34','9998-12-31 00:00:00'),
(11111114,5,'2020-08-18 20:20:49','9998-12-31 00:00:00'),
(52137108,6,'2015-11-22 16:30:34','2016-11-24 17:15:39'),
(52582991,7,'2019-02-11 12:30:59','2020-01-25 13:50:54'),
(62653134,8,'2020-08-15 15:00:48','9998-12-31 00:00:00'),
(11111111,9,'2010-08-28 21:15:54','2011-11-08 19:30:58');

INSERT INTO `Elabora` (`ID_Diag`,`Fecha_Diag`,`Fecha_Atiende`,`CI_Medico`,`CI_Paciente`) VALUES
(1,'2018-06-12 13:20:49','2018-06-01 13:00:20',11111118, 11111111),
(2,'2014-04-12 14:51:32','2014-04-14 15:00:40',11111125, 11111126),
(3,'2018-06-04 13:30:44','2018-06-01 13:00:20',11111125, 11111116),
(4,'2020-06-26 10:59:21','2020-06-22 09:30:23',11111121, 62653134),
(5,'2020-08-18 18:40:34','2020-08-18 16:00:23',11111125, 11111114),
(6,'2015-11-20 18:10:30','2015-11-02 16:00:34',11111125, 62653134),
(7,'2019-02-06 10:40:47','2019-01-01 18:15:12',11111118, 11111126),
(8,'2020-08-10 16:13:13','2020-07-28 13:50:23',11111120, 11111117),
(9,'2010-08-26 19:24:53','2010-08-06 19:30:43',11111125, 11111115);

INSERT INTO `Demanda` (`ID_Trata`,`ID_Diag`) VALUES
(1,1),
(2,2),
(3,3),
(4,4),
(5,5),
(6,6),
(7,7),
(8,8),
(9,9);

INSERT INTO `Requiere` (`ID_Analisis`,`ID_Diag`) VALUES
(1,1),
(2,2),
(3,3),
(4,4),
(5,5),
(6,6),
(7,7),
(8,8),
(9,9);

INSERT INTO `Respuesta` (`TextoResp`) VALUES
('Me duele el pié'),
('Hace 5 dias'),
('Es un dolor agudo'),
('Siento que tengo mala digestión'),
('Desde ayer'),
('No'),
('Desde ayer'),
('No'),
('Si'),
('No');

INSERT INTO `Pregunta` (`TextoPreg`) VALUES
('¿Donde le duele?'),
('¿Hace cuanto le empezo el dolor?'),
('¿Qué tipo de dolor?'),
('¿Qué se siente?'),
('¿Hace cuando se siente ese malestar?'),
('¿Tiene toz o fiebre?'),
('¿Hace cuanto le empezó?'),
('¿Se hizo la prueba del covid?'),
('¿Estás resfriado?'),
('¿Se hizo alguna herida o cirugia recientemente?');

INSERT INTO `Formulario` (`Tipo_Form`) VALUES
('Dolor'),
('Dolor'),
('Malestar'),
('Fiebre');

INSERT INTO `Responde` (`CI_Medico`,`CI_Paciente`,`Fecha_Atiende`,`ID_Resp`) VALUES
(11111118, 11111111, '2018-06-01 13:00:20', 1),
(11111118, 11111111, '2018-06-01 13:00:20', 2),
(11111118, 11111111, '2018-06-01 13:00:20', 3),
(11111125, 11111114, '2020-08-18 16:00:23', 1),
(11111125, 11111114, '2020-08-18 16:00:23', 2),
(11111125, 11111114, '2020-08-18 16:00:23', 3),
(11111125, 11111115, '2010-08-06 19:30:43', 4),
(11111125, 11111115, '2010-08-06 19:30:43', 5),
(11111125, 11111115, '2010-08-06 19:30:43', 6),
(11111125, 11111116, '2018-06-01 13:00:20', 4),
(11111125, 11111116, '2018-06-01 13:00:20', 5),
(11111125, 11111116, '2018-06-01 13:00:20', 6),
(11111120, 11111117, '2020-07-28 13:50:23', 4),
(11111120, 11111117, '2020-07-28 13:50:23', 5),
(11111120, 11111117, '2020-07-28 13:50:23', 6),
(11111125, 11111126, '2014-04-14 15:00:40', 4),
(11111125, 11111126, '2014-04-14 15:00:40', 5),
(11111125, 11111126, '2014-04-14 15:00:40', 6),
(11111118, 11111126, '2019-01-01 18:15:12', 7),
(11111118, 11111126, '2019-01-01 18:15:12', 8),
(11111118, 11111126, '2019-01-01 18:15:12', 9),
(11111118, 11111126, '2019-01-01 18:15:12', 10),
(11111125, 62653134, '2015-11-02 16:00:34', 7),
(11111125, 62653134, '2015-11-02 16:00:34', 8),
(11111125, 62653134, '2015-11-02 16:00:34', 9),
(11111125, 62653134, '2015-11-02 16:00:34', 10),
(11111121, 62653134, '2020-06-22 09:30:23', 7),
(11111121, 62653134, '2020-06-22 09:30:23', 8),
(11111121, 62653134, '2020-06-22 09:30:23', 9),
(11111121, 62653134, '2020-06-22 09:30:23', 10);

INSERT INTO `Contiene` (`ID_Form`,`ID_Preg`) VALUES
(1, 1),
(1, 2),
(1, 3),
(2, 1),
(2, 2),
(2, 3),
(3, 4),
(3, 5),
(3, 6),
(4, 7),
(4, 8),
(4, 9),
(4, 10);

INSERT INTO `Tiene` (`ID_Form`,`ID_Preg`,`ID_Resp`, `FechaR`) VALUES
(1, 1, 1, '2018-06-01 13:00:20'),
(1, 2, 2, '2020-08-18 16:00:23'),
(1, 3, 3, '2010-08-06 19:30:43'),
(2, 1, 1, '2018-06-01 13:00:20'),
(2, 2, 2, '2020-08-18 16:00:23'),
(2, 3, 3, '2010-08-06 19:30:43'),
(3, 4, 4, '2018-06-01 13:00:20'),
(3, 5, 5, '2020-08-18 16:00:23'),
(3, 6, 6, '2010-08-06 19:30:43'),
(4, 7, 7, '2018-06-01 13:00:20'),
(4, 8, 8, '2020-08-18 16:00:23'),
(4, 9, 9, '2010-08-06 19:30:43'),
(4, 10 ,10, '2010-08-06 18:15:12');

INSERT INTO `Posee` (`ID_Estado`, `CI_Paciente`, `FechaInicio_E`) VALUES
(1, 55762293, '2020-10-06'),
(2, 54200707, '2020-10-06'),
(3, 52137108, '2020-10-06'),
(4, 52582991, '2020-10-06'),
(1, 62653134, '2020-10-06'),
(2, 11111111, '2020-10-06'),
(3, 11111112, '2020-10-06'),
(4, 11111113, '2020-10-06'),
(1, 11111114, '2020-10-06'),
(2, 11111115, '2020-10-06'),
(3, 11111116, '2020-10-06'),
(4, 11111117, '2020-10-06'),
(1, 11111126, '2020-10-06');
/**/

/*PERMISOS USUARIOS*/
CREATE ROLE 'GSAAdministradores';
CREATE ROLE 'GSAMedicos';
CREATE ROLE 'GSAAuxiliares';
CREATE ROLE 'GSAPacientes';
/*Todas las tablas*/
GRANT ALL PRIVILEGES ON ProyectoGSA.* TO 'GSAAdministradores';
GRANT CREATE USER ON *.* TO 'GSAAdministradores';
/*Persona*/
GRANT SELECT ON ProyectoGSA.Persona TO 'GSAMedicos','GSAAuxiliares','GSAPacientes';
/*Persona_Telefono*/
GRANT SELECT ON ProyectoGSA.Persona_Telefono TO 'GSAMedicos','GSAAuxiliares';
/*Paciente*/
GRANT SELECT ON ProyectoGSA.Paciente TO 'GSAMedicos','GSAAuxiliares','GSAPacientes';
/*Respuesta*/
GRANT INSERT, SELECT ON ProyectoGSA.Respuesta TO 'GSAMedicos';
GRANT INSERT ON ProyectoGSA.Respuesta TO 'GSAAuxiliares';
/*Analisis_clinico*/
GRANT INSERT, SELECT, UPDATE ON ProyectoGSA.Analisis_clinico TO 'GSAMedicos';
GRANT INSERT, SELECT ON ProyectoGSA.Analisis_clinico TO 'GSAAuxiliares';
GRANT SELECT ON ProyectoGSA.Analisis_clinico TO 'GSAPacientes';
/*Realiza*/
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Realiza TO 'GSAMedicos';
GRANT SELECT, INSERT ON ProyectoGSA.Realiza TO 'GSAAuxiliares';
GRANT SELECT ON ProyectoGSA.Realiza TO 'GSAPacientes';
/*Demanda*/
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Demanda TO 'GSAMedicos';
/*Atiende*/
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Atiende TO 'GSAMedicos';
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Atiende TO 'GSAAuxiliares';
GRANT SELECT ON ProyectoGSA.Atiende TO 'GSAPacientes';
/*Formulario*/
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Formulario TO 'GSAMedicos','GSAAuxiliares';
/*Tiene*/
GRANT SELECT, INSERT, UPDATE, DELETE ON ProyectoGSA.Tiene TO 'GSAMedicos','GSAAuxiliares';
/*Diagnostico*/
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Diagnostico TO 'GSAMedicos';
GRANT INSERT, UPDATE ON ProyectoGSA.Diagnostico TO 'GSAAuxiliares';
GRANT SELECT ON ProyectoGSA.Diagnostico TO 'GSAPacientes';
/*Tratamiento*/
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Tratamiento TO 'GSAMedicos';
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Tratamiento TO 'GSAAuxiliares';
GRANT SELECT ON ProyectoGSA.Tratamiento TO 'GSAPacientes';
/*Pregunta*/
GRANT ALL PRIVILEGES ON ProyectoGSA.Pregunta TO 'GSAMedicos','GSAAuxiliares';
/*Sugiere */
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Sugiere TO 'GSAMedicos','GSAAuxiliares';
/*Responde*/
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Responde TO 'GSAMedicos';
/*Requiere*/
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Requiere TO 'GSAMedicos';
/*Contiene*/
GRANT ALL PRIVILEGES ON ProyectoGSA.Contiene TO 'GSAMedicos','GSAAuxiliares';
/*Estado*/
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Estado TO 'GSAMedicos';
/*Elabora*/
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Elabora TO 'GSAMedicos';
GRANT SELECT ON ProyectoGSA.Elabora TO 'GSAPacientes';
/*Posee*/
GRANT SELECT, INSERT, UPDATE ON ProyectoGSA.Posee TO 'GSAMedicos','GSAAuxiliares';
/*Partes Cuerpo*/
GRANT SELECT, INSERT ON ProyectoGSA.PartesCuerpo TO 'GSAMedicos';
/*Incluye*/
GRANT SELECT, INSERT ON ProyectoGSA.Posee TO 'GSAMedicos';
/*Rol*/
GRANT SELECT ON ProyectoGSA.Rol TO 'GSAMedicos','GSAAuxiliares','GSAPacientes';
/*Usuario_Rol*/
GRANT SELECT ON ProyectoGSA.Usuario_Rol TO 'GSAMedicos','GSAAuxiliares','GSAPacientes';
FLUSH PRIVILEGES;
/*USUARIOS*/
CREATE USER 'GSA_Med'@'192.168.1.209'
IDENTIFIED BY 'GSAMedico';
GRANT GSAMedicos TO 'GSA_Med'@'192.168.1.209';
CREATE USER 'GSA_Aux'@'192.168.1.209'
IDENTIFIED BY 'GSAAuxiliar';
GRANT GSAAuxiliares TO 'GSA_Aux'@'192.168.1.209';
CREATE USER 'GSA_Pac'@'192.168.1.209'
IDENTIFIED BY 'GSAPaciente';
GRANT GSAPacientes TO 'GSA_Pac'@'192.168.1.209';
CREATE USER 'GSA_Adm'@'192.168.1.209'
IDENTIFIED BY 'GSAAdministrador';
GRANT GSAAdministradores TO 'GSA_Adm'@'192.168.1.209';
GRANT SUPER ON *.* TO GSAAdministradores;
/**/
/*CONSULTAS OBLIGATORIAS*/
/*1.Mostrar nombre de los médicos y cantidad de pacientes que atendieron en un determinado mes.*/
SELECT p.Primer_Nombre as 'Nombre', p.Primer_Apellido as 'Apellido', COUNT(a.CI_Paciente) as 'Cantidad de pacientes atendidos'
FROM Persona as p
JOIN Personal_Medico as pm ON p.CI=pm.CI
JOIN Medico as m ON pm.CI=m.CI_Medico
JOIN Atiende as a ON m.CI_Medico=a.CI_Medico
WHERE Month(a.Fecha_Atiende)= 8 AND Year(a.Fecha_Atiende)=2020
GROUP BY p.Primer_Nombre, p.Primer_Apellido;
/*2.Mostrar Historial clínico de un paciente determinado (todos los diagnósticos que tuvo un paciente con sus correspondientes fechas).*/
SELECT e.CI_Paciente as 'CI Paciente', d.ID_Diag as 'ID Diagnóstico', d.Descripcion_Diag as 'Descripción diagnóstico', e.Fecha_Diag as 'Fecha de elaboración'
FROM Diagnostico as d
JOIN Elabora as e ON d.ID_Diag=e.ID_Diag
WHERE CI_Paciente=62653134;
/*3.Nombre y apellido de los auxiliares de todos los médicos.*/
SELECT p.Primer_Nombre as 'Nombre', p.Primer_Apellido as 'Apellido'
FROM Persona as p
JOIN Personal_Medico as pm ON p.CI=pm.CI
ORDER BY p.Primer_Apellido;
/*4.Nombre de los pacientes y tipo de tratamiento que se encuentran realizando al día de hoy.*/
SELECT p.Primer_Nombre as 'Nombre', p.Primer_Apellido as 'Apellido', t.Nombre as 'Nombre de tratamiento'
FROM Persona as p
JOIN Paciente as pa ON p.CI=pa.CI_Paciente
JOIN Realiza as r ON pa.CI_Paciente=r.CI_Paciente
JOIN Tratamiento as t ON r.ID_Trata=t.ID_Trata
WHERE r.FechaFinal = '9998-12-31 00:00:00' /*EN NUESTRO SISTEMA LA FECHA FINAL SE REPRESENTA COMO 9998-12-31 00:00:00*/
ORDER BY p.Primer_Apellido;
/*5.De todas las consultas realizadas este mes, mostrar nombre del paciente, síntoma que presenta y nombre del médico que lo atendió.*/
SELECT p.Primer_Nombre as 'Nombre paciente', p.Primer_Apellido as 'Apellido paciente', vsa.Dolor as 'Síntoma dolor', vsa.Fiebre as 'Síntoma fiebre', vsa.Malestar as 'Síntoma malestar', vsa.Otro as 'Otro síntoma', vnm.Primer_Nombre as 'Nombre médico', vnm.Primer_Apellido as 'Apellido médico'
FROM Persona as p
JOIN Paciente as pa ON p.CI=pa.CI_Paciente
JOIN Atiende as a ON pa.CI_Paciente=a.CI_Paciente
JOIN vista_SintomasAtiendeSD as vsa ON vsa.CI=a.CI_Paciente
JOIN vista_NombreMedico as vnm ON vnm.CI=a.CI_Medico
JOIN Elabora as e ON a.Fecha_Atiende=e.Fecha_Atiende
JOIN Diagnostico as d ON e.ID_Diag=d.ID_Diag
WHERE Month(e.Fecha_Atiende)= Month(now());
/*6.Listado de médicos por tipo de especialidad.*/
SELECT m.CI_Medico as 'CI Medico', p.Primer_Nombre as 'Nombre', p.Primer_Apellido as 'Apellido', m.Especialidad
FROM Medico as m
JOIN Personal_Medico as pm ON pm.CI= m.CI_Medico
JOIN Persona as p ON p.CI=pm.CI
ORDER BY Especialidad;
/*7.Nombre de los pacientes que nunca consultaron en un mes determinado.*/
SELECT DISTINCT p.Primer_Nombre as 'Nombre', p.Primer_Apellido as 'Apellido'
FROM Persona as p
JOIN Paciente as pa ON p.CI=pa.CI_Paciente
JOIN Atiende as a ON pa.CI_Paciente=a.CI_Paciente
WHERE Month(a.Fecha_Atiende) NOT IN ("3")
ORDER BY p.Primer_Apellido;
/*8.Días transcurridos entre la consulta y la realización de análisis para los pacientes atendidos este mes.*/
SELECT ac.CI_Paciente as 'CI Paciente', a.Fecha_Atiende as 'Fecha de la consulta', ac.Fecha_Analisis 'Fecha análisis' , datediff(ac.Fecha_Analisis, a.Fecha_Atiende) as 'Días transcurridos entre la consulta y la realización de análisis para los pacientes atendidos este mes'
FROM Atiende as a
JOIN Analisis_Clinico as ac ON a.Fecha_Atiende=ac.Fecha_Atiende
WHERE MONTH(a.Fecha_Atiende)=Month(now()) AND YEAR(a.Fecha_Atiende)=Year(now());
/*CONSULTAS OPCIONALES*/
/*9.Mostrar el estado en el que se encuentran los pacientes al día de hoy, es decir, nombre del paciente y nombre del estado.*/
SELECT p.Primer_Nombre as 'Nombre', p.Primer_Apellido as 'Apellido', e.Nombre_Estado as 'Nombre estado'
FROM Persona as p
JOIN Paciente as pa ON pa.CI_Paciente=p.CI
JOIN Posee as po ON pa.CI_Paciente=po.CI_Paciente
JOIN Estado as e ON e.ID_Estado=po.ID_Estado;
/*10.Análisis y/o estudios realizados a un paciente determinado en este año.*/
SELECT CI_Paciente as 'CI Paciente',TipoAnalisis as 'Tipo análisis', Resultado as 'Resultado análisis', Fecha_Analisis as 'Fecha de elaboración del análisis'
FROM Analisis_Clinico
WHERE CI_Paciente=11111117 AND YEAR(Fecha_Analisis)=YEAR(now());
/*11.Listar todas las enfermedades con su correspondiente tipo ordenadas alfabéticamente por tipo.*/
SELECT DISTINCT Tipo_EnfermedadActual as 'Tipo enfermedad', Enfermedad_Actual as 'Enfermedad'
FROM Atiende
ORDER BY Tipo_EnfermedadActual ASC;
/*12.Promedio de consultas diarias en el mes.*/
SELECT count(a.Fecha_Atiende) AS 'Numero de consultas en el mes', COUNT(a.Fecha_Atiende)/30 AS 'Promedio'
From Atiende as a
WHERE MONTH(a.Fecha_Atiende)=Month(now()) AND YEAR(a.Fecha_Atiende)=Year(now());
/*13.Mostrar la enfermedad por la que han consultado la mayor cantidad de pacientes.*/
SELECT Motivo, COUNT(Motivo) AS 'Veces consultado/a'
FROM Atiende
GROUP BY Motivo
ORDER BY COUNT(Motivo) DESC
LIMIT 1;
/*14.Mostrar nombre de los pacientes que presentan la enfermedad covid 19 y son mayores de 60 o presentan una enfermedad anterior de tipo respiratorio. Poner como encabezado en la salida “Persona de riesgo COVID”.*/
SELECT p.CI, p.Primer_Nombre, p.Primer_Apellido as 'Persona de riesgo COVID'
FROM Persona as p
JOIN Paciente as pa ON p.CI=pa.CI_Paciente
JOIN Atiende as a ON pa.CI_Paciente=a.CI_Paciente
WHERE a.Enfermedad_Actual='COVID 19' AND TIMESTAMPDIFF(YEAR, p.Fecha_Nac, curdate())>60 OR Tipo_EnfermedadAnterior='Respiratorio';
/*15.Mostrar nombre, apellido del paciente y las preguntas y respuestas del formulario aplicado en la consulta de una fecha determinada.*/
SELECT DISTINCT p.Primer_Nombre as 'Nombre', p.Primer_Apellido as 'Apellido', pr.TextoPreg as 'Pregunta', re.TextoResp 'Respuesta'
FROM Persona as p
JOIN Paciente as pa ON p.CI=pa.CI_Paciente
JOIN Atiende as a ON a.CI_Paciente=pa.CI_Paciente
JOIN Responde as r ON r.Fecha_Atiende=a.Fecha_Atiende
JOIN Respuesta as re ON re.ID_Resp=r.ID_Resp
JOIN Tiene as t ON t.ID_Resp=re.ID_Resp
JOIN Pregunta as pr ON pr.ID_Preg=t.ID_Preg
JOIN Contiene as c ON c.ID_Preg=pr.ID_Preg
WHERE YEAR(r.Fecha_Atiende)=2018 AND MONTH(r.Fecha_Atiende)=06 AND DAY(r.Fecha_Atiende) =1;
/*16.Médico que atendió más consultas en un mes determinado.*/
SELECT m.CI_Medico as 'CI Medico', p.Primer_Nombre as 'Nombre', p.Primer_Apellido as 'Apellido', COUNT(a.Fecha_Atiende) as 'Cantidad de consultas atendidas'
FROM Persona as p
JOIN Personal_Medico as pm ON p.CI=pm.CI
JOIN Medico as m ON pm.CI=m.CI_Medico
JOIN Atiende as a ON m.CI_Medico=a.CI_Medico
WHERE Month(a.Fecha_Atiende)= 11 AND Year(a.Fecha_Atiende)=2020
GROUP BY a.Fecha_Atiende
ORDER BY COUNT(a.Fecha_Atiende) DESC
LIMIT 1;
/*17.Mostrar nombre de los pacientes que no están realizando ningún tratamiento.*/
SELECT DISTINCT pa.CI_Paciente as 'CI Paciente', p.Primer_Nombre as 'Nombre', p.Primer_Apellido as 'Apellido'
FROM Persona as p
JOIN Paciente as pa ON pa.CI_Paciente=p.CI
LEFT JOIN Realiza as re ON pa.CI_Paciente=re.CI_Paciente
LEFT JOIN Tratamiento as tr ON tr.ID_Trata=re.ID_Trata
WHERE pa.CI_Paciente NOT IN (SELECT DISTINCT CI_Paciente FROM Realiza) OR re.FechaFinal < now();
/*18.Mostrar nombre de los pacientes que consultaron más de 5 veces en el año.*/
SELECT p.CI as 'CI Paciente', p.Primer_Nombre as 'Nombre', p.Primer_Apellido as 'Apellido', COUNT(a.Fecha_Atiende) as 'Veces que consultaron'
FROM Persona as p
JOIN Paciente as pa ON p.CI=pa.CI_Paciente
JOIN Atiende as a ON pa.CI_Paciente=a.CI_Paciente
WHERE YEAR(a.Fecha_Atiende)=Year(now())
GROUP BY p.CI
HAVING COUNT(a.Fecha_Atiende) > 5;
/*19.Mostrar el nombre de los 3 pacientes que consultaron más veces en los últimos  40 días.*/
SELECT a.CI_Paciente as 'CI', Primer_Nombre AS 'Nombre', Primer_Apellido as 'Apellido', count(a.Fecha_Atiende) as 'Veces que consultó'
FROM Persona as p
JOIN Atiende as a ON a.CI_Paciente=p.CI
WHERE datediff(NOW(),a.Fecha_Atiende)<=40
GROUP BY a.CI_Paciente
ORDER BY count(a.Fecha_Atiende) DESC
LIMIT 3;
/*20.Patología o enfermedad que padecen más pacientes.*/
SELECT Enfermedad_Actual as 'Patología o enfermedad que padecen más pacientes'
FROM Atiende
GROUP BY Enfermedad_Actual
ORDER BY COUNT(Enfermedad_Actual) DESC
LIMIT 1;