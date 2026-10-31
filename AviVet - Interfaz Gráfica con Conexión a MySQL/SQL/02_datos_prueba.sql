-- DATOS DE DEMOSTRACIÓN: ejecutar una sola vez y después del DDL.
-- Son opcionales: también puedes registrar todos los datos desde la interfaz.
USE veterinaria_aves;

INSERT INTO propietarios (nombre, telefono) VALUES
('Ana Torres', '3312345678'),
('Carlos Ruiz', '3398765432');

INSERT INTO aves (nombre, especie, id_propietario) VALUES
('Kiwi', 'Periquito', 1),
('Luna', 'Cacatua', 1),
('Pico', 'Canario', 2);

INSERT INTO consultas (id_ave, motivo, diagnostico) VALUES
(1, 'Revision general', 'Ave saludable'),
(3, 'Perdida de apetito', 'Observacion y seguimiento');
