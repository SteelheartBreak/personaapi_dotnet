
-- Insertar datos en la tabla `persona`
INSERT INTO [persona] ([cc], [nombre], [apellido], [genero], [edad]) VALUES
(1, 'Juan', 'Pérez', 'M', 30),
(2, 'María', 'García', 'F', 25),
(3, 'Carlos', 'Martínez', 'M', 40),
(4, 'Ana', 'Rodríguez', 'F', 35),
(5, 'Pedro', 'López', 'M', 28),
(6, 'Laura', 'Hernández', 'F', 33),
(7, 'José', 'Gómez', 'M', 45),
(8, 'Sandra', 'Díaz', 'F', 27);

-- Insertar datos en la tabla `profesion`
INSERT INTO [profesion] ([nom], [des]) VALUES
('Ingeniero', 'Especializado en ingeniería de software.'),
('Médico', 'Médico pediatra con más de 10 años de experiencia.'),
('Abogado', 'Experto en derecho mercantil.'),
('Profesor', 'Profesor universitario apasionado por la enseñanza.'),
('Contador', 'Contador fiscal con experiencia en auditoría.'),
('Arquitecto', 'Arquitecto comprometido con el diseño sostenible.'),
('Diseñador', 'Diseñador gráfico creativo y versátil.'),
('Programador', 'Desarrollador web con habilidades front-end y back-end.');

-- Insertar datos en la tabla `estudios`
INSERT INTO [estudios] ([id_prof], [cc_per], [fecha], [univer]) VALUES
(1, 1, '2023-01-01', 'Javeriana'),
(2, 2, '2022-12-15', 'Andes'),
(3, 3, '2022-11-30', 'Rosario'),
(4, 4, '2022-10-25', 'UTADEO'),
(5, 5, '2022-09-20', 'UTADEO'),
(6, 6, '2022-08-15', 'UTADEO'),
(7, 7, '2022-07-10', 'Rosario'),
(8, 8, '2022-06-05', 'Javeriana');

-- Insertar datos en la tabla `telefono`
INSERT INTO [telefono] ([num], [oper], [duenio]) VALUES
('123456789', 'Movistar', 1),
('234567890', 'Claro', 2),
('345678901', 'Tigo', 3),
('456789012', 'Orange', 4),
('567890123', 'Vodafone', 5),
('678901234', 'AT&T', 6),
('789012345', 'Verizon', 7),
('890123456', 'Sprint', 8);
