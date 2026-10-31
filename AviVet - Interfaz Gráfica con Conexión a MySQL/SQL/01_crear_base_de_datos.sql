-- AviVet | Base de datos para veterinaria de aves
-- Ejecutar desde MySQL Workbench (una sola vez).
CREATE DATABASE IF NOT EXISTS veterinaria_aves
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;

USE veterinaria_aves;

CREATE TABLE IF NOT EXISTS propietarios (
    id_propietario INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    telefono VARCHAR(20)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS aves (
    id_ave INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(80) NOT NULL,
    especie VARCHAR(80) NOT NULL,
    id_propietario INT NOT NULL,
    CONSTRAINT fk_ave_propietario
        FOREIGN KEY (id_propietario) REFERENCES propietarios(id_propietario)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS consultas (
    id_consulta INT AUTO_INCREMENT PRIMARY KEY,
    id_ave INT NOT NULL,
    fecha_consulta TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    motivo VARCHAR(200) NOT NULL,
    diagnostico VARCHAR(200),
    CONSTRAINT fk_consulta_ave
        FOREIGN KEY (id_ave) REFERENCES aves(id_ave)
) ENGINE=InnoDB;

-- Comprobacion: deben aparecer las tres tablas.
SHOW TABLES;
