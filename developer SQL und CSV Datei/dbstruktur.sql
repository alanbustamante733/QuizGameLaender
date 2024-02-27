create database quizgame;

use quizgame;

Die Tabelle Mappe2, die die Liste von Länder enthält, ist mit dem .CSV Datai gemacht duch einem Import.

CREATE TABLE `quizgame`.`score` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Spielart` VARCHAR(45) NULL,
  `Punkte` INT NULL,
  `spieler` VARCHAR(50) NULL,
  PRIMARY KEY (`id`));

CREATE TABLE `quizgame`.`login` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nutzername` VARCHAR(45) NULL,
  `passwort` VARCHAR(45) NULL,
  PRIMARY KEY (`id`));