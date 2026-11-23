CREATE DATABASE KidsScheduleDB;
USE KidsScheduleDB;
SHOW DATABASES;

USE KidsScheduleDB;

CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Role ENUM('Parent', 'KidHolder') NOT NULL,
    ParentID INT NULL,

    CONSTRAINT fk_user_parent
    FOREIGN KEY (ParentID)
    REFERENCES Users(UserID)
    ON DELETE CASCADE
);

DESCRIBE Users;

USE KidsScheduleDB;

CREATE TABLE Children (
    ChildID INT AUTO_INCREMENT PRIMARY KEY,
    ParentID INT NOT NULL,
    ChildName VARCHAR(100) NOT NULL,
    DateOfBirth DATE,
    Colour VARCHAR(20) DEFAULT 'Blue',

    CONSTRAINT fk_child_parent
    FOREIGN KEY (ParentID)
    REFERENCES Users(UserID)
    ON DELETE CASCADE
);

DESCRIBE Children;

USE KidsScheduleDB;

CREATE TABLE UserChildren (
    UserID INT NOT NULL,
    ChildID INT NOT NULL,

    PRIMARY KEY (UserID, ChildID),

    CONSTRAINT fk_userchildren_user
    FOREIGN KEY (UserID)
    REFERENCES Users(UserID)
    ON DELETE CASCADE,

    CONSTRAINT fk_userchildren_child
    FOREIGN KEY (ChildID)
    REFERENCES Children(ChildID)
    ON DELETE CASCADE
);

DESCRIBE UserChildren;

USE KidsScheduleDB;

CREATE TABLE Days (
    DayID INT AUTO_INCREMENT PRIMARY KEY,
    DayName VARCHAR(15) NOT NULL UNIQUE
);

INSERT INTO Days (DayName) VALUES
('Monday'),
('Tuesday'),
('Wednesday'),
('Thursday'),
('Friday'),
('Saturday'),
('Sunday');

SELECT * FROM Days
ORDER BY DayID ASC;

USE KidsScheduleDB;

CREATE TABLE Schedules (
    ScheduleID INT AUTO_INCREMENT PRIMARY KEY,
    ChildID INT NOT NULL,
    DayID INT NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL,
    Activity VARCHAR(150) NOT NULL,
    Place VARCHAR(100),

    CONSTRAINT fk_schedule_child
    FOREIGN KEY (ChildID)
    REFERENCES Children(ChildID)
    ON DELETE CASCADE,

    CONSTRAINT fk_schedule_day
    FOREIGN KEY (DayID)
    REFERENCES Days(DayID),

    CONSTRAINT chk_schedule_time
    CHECK (StartTime < EndTime)
);

DESCRIBE Schedules;

SHOW tables;