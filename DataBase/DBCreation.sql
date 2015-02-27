SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`allergies`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`allergies` (
  `allergyID` INT(11) NOT NULL AUTO_INCREMENT,
  `allergy_name` VARCHAR(200) NOT NULL,
  PRIMARY KEY (`allergyID`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `mydb`.`diagnoses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`diagnoses` (
  `diagnosesID` INT(11) NOT NULL AUTO_INCREMENT,
  `diagnoses_name` VARCHAR(200) NOT NULL,
  `diagnoses_description` TEXT NOT NULL,
  `diagnoses_treatment` TEXT NOT NULL,
  PRIMARY KEY (`diagnosesID`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `mydb`.`positions`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`positions` (
  `postionID` INT(11) NOT NULL AUTO_INCREMENT,
  `position_name` VARCHAR(25) NOT NULL,
  UNIQUE INDEX `postionID` (`postionID` ASC),
  PRIMARY KEY (`postionID`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `mydb`.`employees`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`employees` (
  `employeeID` INT(11) NOT NULL AUTO_INCREMENT,
  `ssn` INT(9) NOT NULL,
  `last_name` VARCHAR(50) NOT NULL,
  `middle_initial` VARCHAR(1) NULL DEFAULT NULL,
  `first_name` VARCHAR(50) NOT NULL,
  `dob` DATE NOT NULL,
  `gender` VARCHAR(1) NOT NULL,
  `address` VARCHAR(200) NOT NULL,
  `city` VARCHAR(50) NOT NULL,
  `state` VARCHAR(50) NOT NULL,
  `zip` INT(5) NOT NULL,
  `phone` INT(10) NOT NULL,
  `login` VARCHAR(25) NULL,
  `password` VARCHAR(200) NULL,
  `last_login` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `postionID` INT(11) NOT NULL,
  `enabled` TINYINT NULL DEFAULT 0,
  PRIMARY KEY (`employeeID`),
  INDEX `fk_employees_positions1_idx` (`postionID` ASC),
  CONSTRAINT `fk_employees_positions1`
    FOREIGN KEY (`postionID`)
    REFERENCES `mydb`.`positions` (`postionID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `mydb`.`patients`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`patients` (
  `patientID` INT(11) NOT NULL DEFAULT '0',
  `ssn` INT(9) NOT NULL,
  `last_name` VARCHAR(50) NOT NULL,
  `middle_initial` VARCHAR(1) NULL DEFAULT NULL,
  `first_name` VARCHAR(50) NOT NULL,
  `dob` DATE NOT NULL,
  `gender` VARCHAR(1) NOT NULL,
  `address` VARCHAR(200) NOT NULL,
  `city` VARCHAR(50) NOT NULL,
  `state` VARCHAR(50) NOT NULL,
  `zip` INT(5) NOT NULL,
  `home_phone` INT(10) NOT NULL,
  `work_phone` INT(10) NULL,
  `child` VARCHAR(15) NULL DEFAULT NULL COMMENT 'son / daughter',
  `motherID` INT(11) NULL,
  `fatherID` INT(11) NULL,
  PRIMARY KEY (`patientID`),
  INDEX `fk_patients_patients1_idx` (`motherID` ASC),
  INDEX `fk_patients_patients2_idx` (`fatherID` ASC),
  CONSTRAINT `fk_patients_patients1`
    FOREIGN KEY (`motherID`)
    REFERENCES `mydb`.`patients` (`patientID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_patients_patients2`
    FOREIGN KEY (`fatherID`)
    REFERENCES `mydb`.`patients` (`patientID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `mydb`.`patient_allergies`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`patient_allergies` (
  `patientallergyID` INT(11) NOT NULL AUTO_INCREMENT,
  `allergy_name` VARCHAR(200) NULL DEFAULT NULL,
  `patientID` INT(11) NOT NULL,
  `allergyID` INT(11) NOT NULL,
  PRIMARY KEY (`patientallergyID`, `allergyID`),
  INDEX `fk_patient_allergies_patients_idx` (`patientID` ASC),
  INDEX `fk_patient_allergies_allergies1_idx` (`allergyID` ASC),
  CONSTRAINT `fk_patient_allergies_patients`
    FOREIGN KEY (`patientID`)
    REFERENCES `mydb`.`patients` (`patientID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_patient_allergies_allergies1`
    FOREIGN KEY (`allergyID`)
    REFERENCES `mydb`.`allergies` (`allergyID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `mydb`.`patient_visit`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`patient_visit` (
  `visitID` INT(11) NOT NULL AUTO_INCREMENT,
  `patientID` INT(11) NOT NULL,
  `visit_date` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `appt_date` TIMESTAMP NULL DEFAULT NULL,
  `doctorID` INT(11) NOT NULL,
  `nurseID` INT(11) NOT NULL,
  PRIMARY KEY (`visitID`),
  INDEX `fk_patient_visit_patients1_idx` (`patientID` ASC),
  INDEX `fk_patient_visit_employees1_idx` (`doctorID` ASC),
  INDEX `fk_patient_visit_employees2_idx` (`nurseID` ASC),
  CONSTRAINT `fk_patient_visit_patients1`
    FOREIGN KEY (`patientID`)
    REFERENCES `mydb`.`patients` (`patientID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_patient_visit_employees1`
    FOREIGN KEY (`doctorID`)
    REFERENCES `mydb`.`employees` (`employeeID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_patient_visit_employees2`
    FOREIGN KEY (`nurseID`)
    REFERENCES `mydb`.`employees` (`employeeID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `mydb`.`tests`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tests` (
  `testID` INT(11) NOT NULL AUTO_INCREMENT,
  `test_name` VARCHAR(200) NOT NULL,
  PRIMARY KEY (`testID`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `mydb`.`patient_tests`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`patient_tests` (
  `patient_testID` INT(11) NOT NULL AUTO_INCREMENT,
  `visitID` INT(11) NOT NULL,
  `testID` INT(11) NOT NULL,
  `test_ordered` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `test_taken` TIMESTAMP NULL DEFAULT '0000-00-00 00:00:00',
  `test_completed` TIMESTAMP NULL DEFAULT NULL,
  `results` INT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`patient_testID`),
  INDEX `fk_patient_tests_patient_visit1_idx` (`visitID` ASC),
  INDEX `fk_patient_tests_tests1_idx` (`testID` ASC),
  CONSTRAINT `fk_patient_tests_patient_visit1`
    FOREIGN KEY (`visitID`)
    REFERENCES `mydb`.`patient_visit` (`visitID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_patient_tests_tests1`
    FOREIGN KEY (`testID`)
    REFERENCES `mydb`.`tests` (`testID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `mydb`.`patient_visit_vitals`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`patient_visit_vitals` (
  `vitalsID` INT(11) NOT NULL AUTO_INCREMENT,
  `visitID` INT(11) NOT NULL,
  `blood_pressure` VARCHAR(20) NOT NULL,
  `temp` VARCHAR(20) NOT NULL,
  `pulse` VARCHAR(20) NOT NULL,
  `height` INT(4) NOT NULL,
  `weight` INT(4) NOT NULL,
  PRIMARY KEY (`vitalsID`, `visitID`),
  INDEX `fk_patient_visit_vitals_patient_visit1_idx` (`visitID` ASC),
  CONSTRAINT `fk_patient_visit_vitals_patient_visit1`
    FOREIGN KEY (`visitID`)
    REFERENCES `mydb`.`patient_visit` (`visitID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `mydb`.`patient_vist_notes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`patient_vist_notes` (
  `notesID` INT(11) NOT NULL AUTO_INCREMENT,
  `employeeID` INT(11) NOT NULL,
  `visitID` INT(11) NOT NULL,
  `note` TEXT NOT NULL,
  `date` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`notesID`),
  INDEX `fk_patient_vist_notes_patient_visit1_idx` (`visitID` ASC),
  CONSTRAINT `fk_patient_vist_notes_patient_visit1`
    FOREIGN KEY (`visitID`)
    REFERENCES `mydb`.`patient_visit` (`visitID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `mydb`.`patient_vist_symptoms`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`patient_vist_symptoms` (
  `symptomID` INT(11) NOT NULL AUTO_INCREMENT,
  `visitID` INT(11) NOT NULL,
  `symptom_name` VARCHAR(300) NOT NULL,
  `diagnoses_diagnosesID` INT(11) NOT NULL,
  PRIMARY KEY (`symptomID`, `diagnoses_diagnosesID`),
  INDEX `fk_patient_vist_symptoms_diagnoses1_idx` (`diagnoses_diagnosesID` ASC),
  INDEX `fk_patient_vist_symptoms_patient_visit1_idx` (`visitID` ASC),
  CONSTRAINT `fk_patient_vist_symptoms_diagnoses1`
    FOREIGN KEY (`diagnoses_diagnosesID`)
    REFERENCES `mydb`.`diagnoses` (`diagnosesID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_patient_vist_symptoms_patient_visit1`
    FOREIGN KEY (`visitID`)
    REFERENCES `mydb`.`patient_visit` (`visitID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = latin1;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
