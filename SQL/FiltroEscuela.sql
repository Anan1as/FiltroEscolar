-- Active: 1717615517417@@bztwgoao2fz3nlxaier5-mysql.services.clever-cloud.com@3306
/*-----Teacher table----*/
CREATE TABLE Teachers (
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    Names VARCHAR(125) NOT NULL,
    Specialty VARCHAR(125) NOT NULL,
    Phone VARCHAR(25) NOT NULL,
    Email VARCHAR(125) NOT NULL,
    YearsExperience INTEGER NOT NULL
);

INSERT INTO Teachers (Names, Specialty, Phone, Email, YearsExperience) 
VALUES ('Robinson Cortez', 'Software Development', '1234567890', 'robinson@example.com', 5),
       ('Viviana Mendoza', 'English', '1234567890', 'viviana@example.com', 3)



/*-----Student table----*/
CREATE TABLE Students (
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    Names VARCHAR(125) NOT NULL,
    Birthdate DATE NOT NULL,
    Address VARCHAR(125) NOT NULL,
    Email VARCHAR(125) NOT NULL
);

INSERT INTO Students (Names, Birthdate, Address, Email)
VALUES ('Laura Restrepo', '2004-09-19', 'Calle 123', 'laura@example.com'),
       ('Jeremy Soto', '2002-08-22', 'Calle 456', 'jeremy@example.com')



/*-----Course table----*/
CREATE TABLE Courses (
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(125) NOT NULL,
    Description TEXT NOT NULL,
    TeacherId INTEGER NOT NULL,
    FOREIGN KEY (TeacherId) REFERENCES Teachers(Id),
    Schedule VARCHAR(125) NOT NULL,
    Duration VARCHAR(20) NOT NULL,
    Capacity INTEGER NOT NULL
);

INSERT INTO Courses (Name, Description, TeacherId, Schedule, Duration, Capacity)
VALUES ('Software Development', 'Learn how to develop software', 1, 'Monday and Wednesday 6:00 PM - 8:00 PM', '3 months', 20),
       ('English', 'Learn English', 2, 'Tuesday and Thursday 6:00 PM - 8:00 PM', '3 months', 20)



/*-----Enrollment table----*/
CREATE TABLE Enrollments (
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    Date DATE NOT NULL,
    StudentId INTEGER NOT NULL,
    FOREIGN KEY (StudentId) REFERENCES Students(Id),
    CourseId INTEGER NOT NULL,
    FOREIGN KEY (CourseId) REFERENCES Courses(Id),
    Status ENUM('Pagado', 'Pendiente de pago', 'Cancelada') NOT NULL
);

INSERT INTO Enrollments (Date, StudentId, CourseId, Status)
VALUES ('2022-01-01', '1', '2', 'Pagado'),
       ('2022-01-01', '2', '1', 'Pagado')