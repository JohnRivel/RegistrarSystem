DROP DATABASE IF EXISTS registrar_db;
CREATE DATABASE registrar_db CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE registrar_db;

CREATE TABLE tblusers (
    UserID      INT AUTO_INCREMENT PRIMARY KEY,
    Username    VARCHAR(30)  NOT NULL,
    Password    CHAR(64)     NOT NULL,
    FullName    VARCHAR(100) NOT NULL,
    Role        ENUM('Administrator','Registrar Staff') NOT NULL,
    Status      ENUM('Active','Inactive') NOT NULL DEFAULT 'Active',
    CONSTRAINT uq_users_username UNIQUE (Username)
) ENGINE=InnoDB;

CREATE TABLE tblstudents (
    StudentID   VARCHAR(20)  NOT NULL PRIMARY KEY,
    LRN         CHAR(12)     NOT NULL,
    LastName    VARCHAR(50)  NOT NULL,
    FirstName   VARCHAR(50)  NOT NULL,
    MiddleName  VARCHAR(50)  NULL,
    Course      VARCHAR(50)  NOT NULL,
    YearLevel   VARCHAR(10)  NOT NULL,
    Section     VARCHAR(20)  NOT NULL,
    ContactNo   VARCHAR(15)  NOT NULL,
    Status      ENUM('Active','Inactive') NOT NULL DEFAULT 'Active',
    CONSTRAINT uq_students_lrn UNIQUE (LRN),
    INDEX ix_students_name (LastName, FirstName)
) ENGINE=InnoDB;

CREATE TABLE tbldocuments (
    DocumentID   INT AUTO_INCREMENT PRIMARY KEY,
    DocumentName VARCHAR(100)  NOT NULL,
    Description  VARCHAR(255)  NULL,
    Fee          DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Status       ENUM('Active','Inactive') NOT NULL DEFAULT 'Active',
    CONSTRAINT uq_documents_name UNIQUE (DocumentName),
    CONSTRAINT ck_documents_fee CHECK (Fee >= 0)
) ENGINE=InnoDB;

CREATE TABLE tblrequest (
    RequestID     INT AUTO_INCREMENT PRIMARY KEY,
    RequestNo     VARCHAR(20)   NOT NULL,
    StudentID     VARCHAR(20)   NOT NULL,
    RequestDate   DATE          NOT NULL,
    TotalAmount   DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    PaymentStatus ENUM('Unpaid','Paid') NOT NULL DEFAULT 'Unpaid',
    ORNo          VARCHAR(30)   NULL,
    ORDate        DATE          NULL,
    AmountPaid    DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Status        ENUM('Pending','Processing','Ready for Release','Released','Cancelled')
                                NOT NULL DEFAULT 'Pending',
    CreatedBy     INT           NOT NULL,
    ReleasedDate  DATETIME      NULL,
    CONSTRAINT uq_request_no UNIQUE (RequestNo),
    CONSTRAINT uq_request_orno UNIQUE (ORNo),
    CONSTRAINT fk_request_student FOREIGN KEY (StudentID)
        REFERENCES tblstudents (StudentID) ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT fk_request_user FOREIGN KEY (CreatedBy)
        REFERENCES tblusers (UserID) ON UPDATE CASCADE ON DELETE RESTRICT,
    INDEX ix_request_date (RequestDate),
    INDEX ix_request_status (Status)
) ENGINE=InnoDB;

CREATE TABLE tblrequestdetails (
    RequestDetailID INT AUTO_INCREMENT PRIMARY KEY,
    RequestID       INT           NOT NULL,
    DocumentID      INT           NOT NULL,
    Quantity        INT           NOT NULL DEFAULT 1,
    Amount          DECIMAL(10,2) NOT NULL,
    SubTotal        DECIMAL(10,2) NOT NULL,
    CONSTRAINT uq_details_doc UNIQUE (RequestID, DocumentID),
    CONSTRAINT ck_details_qty CHECK (Quantity > 0),
    CONSTRAINT fk_details_request FOREIGN KEY (RequestID)
        REFERENCES tblrequest (RequestID) ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT fk_details_document FOREIGN KEY (DocumentID)
        REFERENCES tbldocuments (DocumentID) ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

INSERT INTO tblusers (Username, Password, FullName, Role, Status) VALUES
('admin',  SHA2('admin123', 256), 'John Cristian Rivel', 'Administrator',   'Active'),
('staff1', SHA2('staff123', 256), 'Patricia Reosa',      'Registrar Staff', 'Active'),
('staff2', SHA2('staff123', 256), 'Allen Dwayne Quimson','Registrar Staff', 'Active'),
('staff3', SHA2('staff123', 256), 'Rhayniel Allen Cantor','Registrar Staff', 'Active');

INSERT INTO tbldocuments (DocumentName, Description, Fee, Status) VALUES
('Transcript of Records',     'Official copy of all grades earned by the student',        150.00, 'Active'),
('Certificate of Enrollment', 'Certifies that the student is currently enrolled',          50.00, 'Active'),
('Certificate of Good Moral', 'Certifies the good moral character of the student',        100.00, 'Active'),
('Certification',             'General certification (grades, units earned, graduation)',  50.00, 'Active'),
('Honorable Dismissal',       'Transfer credential for students moving to another school', 100.00, 'Active'),
('Diploma (Second Copy)',     'Replacement copy of the diploma',                          300.00, 'Inactive');

INSERT INTO tblstudents (StudentID, LRN, LastName, FirstName, MiddleName, Course, YearLevel, Section, ContactNo, Status) VALUES
('20260001', '123456789001', 'Galang', 'Josh Matthew', NULL, 'BSIT', '1st Year', 'A', '09171000001', 'Active'),
('20260002', '123456789002', 'Quimson', 'Allen Dwayne', NULL, 'BSCS', '2nd Year', 'B', '09171000002', 'Active'),
('20260003', '123456789003', 'Cantor', 'Rhayniel Allen', NULL, 'BSBA', '3rd Year', 'C', '09171000003', 'Active'),
('20260004', '123456789004', 'Reosa', 'Patricia', NULL, 'BSED', '4th Year', 'A', '09171000004', 'Active'),
('20260005', '123456789005', 'Borromeo', 'Ronalyn', NULL, 'BSN', '1st Year', 'B', '09171000005', 'Active'),
('20260006', '123456789006', 'Bernaldez', 'Bernadette', NULL, 'BSCrim', '2nd Year', 'C', '09171000006', 'Active'),
('20260007', '123456789007', 'Lopez', 'Gabriel', NULL, 'BSHM', '3rd Year', 'A', '09171000007', 'Active'),
('20260008', '123456789008', 'Pebida', 'Jasry', NULL, 'BSIT', '4th Year', 'B', '09171000008', 'Active'),
('20260009', '123456789009', 'Metharam', 'Joshua', NULL, 'BSCS', '1st Year', 'C', '09171000009', 'Active'),
('20260010', '123456789010', 'Ayap', 'Daimery Gold', NULL, 'BSBA', '2nd Year', 'A', '09171000010', 'Active'),
('20260011', '123456789011', 'Villarino', 'Justine', NULL, 'BSED', '3rd Year', 'B', '09171000011', 'Active'),
('20260012', '123456789012', 'Sumalinog', 'Ace', NULL, 'BSN', '4th Year', 'C', '09171000012', 'Active'),
('20260013', '123456789013', 'Marcos', 'Danielle', NULL, 'BSCrim', '1st Year', 'A', '09171000013', 'Active'),
('20260014', '123456789014', 'Abadilla', 'Cj', NULL, 'BSHM', '2nd Year', 'B', '09171000014', 'Active'),
('20260015', '123456789015', 'Atienza', 'Ulrich Allister', NULL, 'BSIT', '3rd Year', 'C', '09171000015', 'Active'),
('20260016', '123456789016', 'Casilan', 'Earl Cedric', NULL, 'BSCS', '4th Year', 'A', '09171000016', 'Active'),
('20260017', '123456789017', 'Corolla', 'Maria', NULL, 'BSBA', '1st Year', 'B', '09171000017', 'Active'),
('20260018', '123456789018', 'Lorenzo', 'Hannah', NULL, 'BSED', '2nd Year', 'C', '09171000018', 'Active'),
('20260019', '123456789019', 'Campita', 'Dylan', NULL, 'BSN', '3rd Year', 'A', '09171000019', 'Active'),
('20260020', '123456789020', 'Finn', 'Danish', NULL, 'BSCrim', '4th Year', 'B', '09171000020', 'Active'),
('20260021', '123456789021', 'Geavican', 'Adrian', NULL, 'BSHM', '1st Year', 'C', '09171000021', 'Active'),
('20260022', '123456789022', 'Bunyi', 'Carl', NULL, 'BSIT', '2nd Year', 'A', '09171000022', 'Active'),
('20260023', '123456789023', 'Moan', 'Chris', NULL, 'BSCS', '3rd Year', 'B', '09171000023', 'Active'),
('20260024', '123456789024', 'Khi', 'Del', NULL, 'BSBA', '4th Year', 'C', '09171000024', 'Active'),
('20260025', '123456789025', 'Asher', 'Godwin', NULL, 'BSED', '1st Year', 'A', '09171000025', 'Active'),
('20260026', '123456789026', 'Diocampo', 'Ivan Winzle', NULL, 'BSN', '2nd Year', 'B', '09171000026', 'Active'),
('20260027', '123456789027', 'Resuena', 'Jan Aron', NULL, 'BSCrim', '3rd Year', 'C', '09171000027', 'Active'),
('20260028', '123456789028', 'Ang', 'Jerimiah', NULL, 'BSHM', '4th Year', 'A', '09171000028', 'Active'),
('20260029', '123456789029', 'Labutap', 'Johann Carlo', NULL, 'BSIT', '1st Year', 'B', '09171000029', 'Active'),
('20260030', '123456789030', 'Magsino', 'Kyle', NULL, 'BSCS', '2nd Year', 'C', '09171000030', 'Active'),
('20260031', '123456789031', 'Hombria', 'RJ', NULL, 'BSBA', '3rd Year', 'A', '09171000031', 'Active'),
('20260032', '123456789032', 'Landrito', 'Wesleybrian', NULL, 'BSED', '4th Year', 'B', '09171000032', 'Active'),
('20260033', '123456789033', 'Landrito', 'Nicole', NULL, 'BSN', '1st Year', 'C', '09171000033', 'Active'),
('20260034', '123456789034', 'Etang', 'Dan', NULL, 'BSCrim', '2nd Year', 'A', '09171000034', 'Active'),
('20260035', '123456789035', 'Gregorio', 'Yuwan Andrei', NULL, 'BSHM', '3rd Year', 'B', '09171000035', 'Active'),
('20260036', '123456789036', 'Bobadilla', 'Raven', NULL, 'BSIT', '4th Year', 'C', '09171000036', 'Active'),
('20260037', '123456789037', 'Zamora', 'Neil', NULL, 'BSCS', '1st Year', 'A', '09171000037', 'Active'),
('20260038', '123456789038', 'Rollon', 'Dylan Paolo', NULL, 'BSBA', '2nd Year', 'B', '09171000038', 'Active'),
('20260039', '123456789039', 'Tiposo', 'Justine', NULL, 'BSED', '3rd Year', 'C', '09171000039', 'Active'),
('20260040', '123456789040', 'Gwyneth', 'Shania', NULL, 'BSN', '4th Year', 'A', '09171000040', 'Active'),
('20260041', '123456789041', 'Cristines', 'Manice', NULL, 'BSCrim', '1st Year', 'B', '09171000041', 'Active'),
('20260042', '123456789042', 'Contantino', 'Hanna', NULL, 'BSHM', '2nd Year', 'C', '09171000042', 'Active'),
('20260043', '123456789043', 'Reyes', 'John Matthew', NULL, 'BSIT', '3rd Year', 'A', '09171000043', 'Active'),
('20260044', '123456789044', 'Howard', 'Paul', NULL, 'BSCS', '4th Year', 'B', '09171000044', 'Active'),
('20260045', '123456789045', 'Nava', 'Grace', NULL, 'BSBA', '1st Year', 'C', '09171000045', 'Active'),
('20260046', '123456789046', 'Pillar', 'Ivan', NULL, 'BSED', '2nd Year', 'A', '09171000046', 'Active'),
('20260047', '123456789047', 'Resurreccion', 'James Murfhy', NULL, 'BSN', '3rd Year', 'B', '09171000047', 'Active'),
('20260048', '123456789048', 'Prado', 'Phoebe', NULL, 'BSCrim', '4th Year', 'C', '09171000048', 'Active'),
('20260049', '123456789049', 'Luna', 'John Carl', NULL, 'BSHM', '1st Year', 'A', '09171000049', 'Active'),
('20260050', '123456789050', 'Gwn', 'Sophia', NULL, 'BSIT', '2nd Year', 'B', '09171000050', 'Active'),
('20260051', '123456789051', 'Bautista', 'Elizabeth', NULL, 'BSCS', '3rd Year', 'C', '09171000051', 'Active'),
('20260052', '123456789052', 'Hilapo', 'Klarizze', NULL, 'BSBA', '4th Year', 'A', '09171000052', 'Active'),
('20260053', '123456789053', 'Miranda', 'Benedict', NULL, 'BSED', '1st Year', 'B', '09171000053', 'Active'),
('20260054', '123456789054', 'Clear', 'Rona', NULL, 'BSN', '2nd Year', 'C', '09171000054', 'Active'),
('20260055', '123456789055', 'Deguzman', 'James', NULL, 'BSCrim', '3rd Year', 'A', '09171000055', 'Active'),
('20260056', '123456789056', 'Osorio', 'Mark Daniel', NULL, 'BSHM', '4th Year', 'B', '09171000056', 'Active'),
('20260057', '123456789057', 'James', 'Justine', NULL, 'BSIT', '1st Year', 'C', '09171000057', 'Active'),
('20260058', '123456789058', 'Mendoza', 'Fiona Katheleen', NULL, 'BSCS', '2nd Year', 'A', '09171000058', 'Active'),
('20260059', '123456789059', 'Ergina', 'Justine', NULL, 'BSBA', '3rd Year', 'B', '09171000059', 'Active'),
('20260060', '123456789060', 'San Juan', 'Chyra', NULL, 'BSED', '4th Year', 'C', '09171000060', 'Active'),
('20260061', '123456789061', 'Cabarrubia', 'Nicole Baustista', NULL, 'BSN', '1st Year', 'A', '09171000061', 'Active'),
('20260062', '123456789062', 'Claire', 'Angelia', NULL, 'BSCrim', '2nd Year', 'B', '09171000062', 'Active'),
('20260063', '123456789063', 'Gonzales', 'Marry Anne', NULL, 'BSHM', '3rd Year', 'C', '09171000063', 'Active'),
('20260064', '123456789064', 'Arabella', 'Bianca', NULL, 'BSIT', '4th Year', 'A', '09171000064', 'Active'),
('20260065', '123456789065', 'Dela Cruz', 'Sandy', NULL, 'BSCS', '1st Year', 'B', '09171000065', 'Active'),
('20260066', '123456789066', 'Villasencio', 'Reiner', NULL, 'BSBA', '2nd Year', 'C', '09171000066', 'Active'),
('20260067', '123456789067', 'Nolasco', 'Krizzy', NULL, 'BSED', '3rd Year', 'A', '09171000067', 'Active'),
('20260068', '123456789068', 'Magsombol', 'Faythe', NULL, 'BSN', '4th Year', 'B', '09171000068', 'Active'),
('20260069', '123456789069', 'Aira', 'Sophia', NULL, 'BSCrim', '1st Year', 'C', '09171000069', 'Active'),
('20260070', '123456789070', 'Argana', 'Laurent Dwayane', NULL, 'BSHM', '2nd Year', 'A', '09171000070', 'Active'),
('20260071', '123456789071', 'Laureaga', 'Alyssa', NULL, 'BSIT', '3rd Year', 'B', '09171000071', 'Active'),
('20260072', '123456789072', 'Saavedra', 'Jeanyxia Bea', NULL, 'BSCS', '4th Year', 'C', '09171000072', 'Active'),
('20260073', '123456789073', 'Advincula', 'Benz', NULL, 'BSBA', '1st Year', 'A', '09171000073', 'Active'),
('20260074', '123456789074', 'Pecho', 'Juliana', NULL, 'BSED', '2nd Year', 'B', '09171000074', 'Active'),
('20260075', '123456789075', 'Galvez', 'Julienne Gail', NULL, 'BSN', '3rd Year', 'C', '09171000075', 'Active'),
('20260076', '123456789076', 'Dimanlig', 'Zamantha', NULL, 'BSCrim', '4th Year', 'A', '09171000076', 'Active');

INSERT INTO tblrequest (RequestID, RequestNo, StudentID, RequestDate, PaymentStatus, ORNo, ORDate, Status, CreatedBy, ReleasedDate) VALUES
( 1, 'REQ-2026-00001', '20260001', '2026-08-18', 'Paid',   'OR-100001', '2026-08-18', 'Released',          2, '2026-08-21 10:15:00'),
( 2, 'REQ-2026-00002', '20260002', '2026-08-18', 'Paid',   'OR-100002', '2026-08-18', 'Released',          2, '2026-08-22 14:30:00'),
( 3, 'REQ-2026-00003', '20260003', '2026-08-20', 'Unpaid', NULL,        NULL,         'Cancelled',         3, NULL),
( 4, 'REQ-2026-00004', '20260004', '2026-08-25', 'Paid',   'OR-100003', '2026-08-25', 'Released',          1, '2026-08-28 09:00:00'),
( 5, 'REQ-2026-00005', '20260005', '2026-08-27', 'Unpaid', NULL,        NULL,         'Cancelled',         2, NULL),
( 6, 'REQ-2026-00006', '20260006', '2026-09-01', 'Paid',   'OR-100004', '2026-09-01', 'Ready for Release', 3, NULL),
( 7, 'REQ-2026-00007', '20260007', '2026-09-03', 'Paid',   'OR-100005', '2026-09-03', 'Ready for Release', 2, NULL),
( 8, 'REQ-2026-00008', '20260008', '2026-09-07', 'Unpaid', NULL,        NULL,         'Cancelled',         3, NULL),
( 9, 'REQ-2026-00009', '20260009', '2026-09-10', 'Paid',   'OR-100006', '2026-09-10', 'Ready for Release', 2, NULL),
(10, 'REQ-2026-00010', '20260010', '2026-09-14', 'Paid',   'OR-100007', '2026-09-14', 'Processing',        3, NULL),
(11, 'REQ-2026-00011', '20260011', '2026-09-16', 'Paid',   'OR-100008', '2026-09-16', 'Processing',        2, NULL),
(12, 'REQ-2026-00012', '20260012', '2026-09-18', 'Paid',   'OR-100009', '2026-09-18', 'Processing',        1, NULL),
(13, 'REQ-2026-00013', '20260013', '2026-09-21', 'Unpaid', NULL,        NULL,         'Pending',           2, NULL),
(14, 'REQ-2026-00014', '20260014', '2026-09-22', 'Unpaid', NULL,        NULL,         'Pending',           3, NULL),
(15, 'REQ-2026-00015', '20260015', '2026-09-23', 'Unpaid', NULL,        NULL,         'Pending',           2, NULL);

INSERT INTO tblrequestdetails (RequestID, DocumentID, Quantity, Amount, SubTotal) VALUES
( 1, 1, 1, 0, 0), ( 1, 3, 1, 0, 0),
( 2, 3, 1, 0, 0),
( 3, 2, 2, 0, 0),
( 4, 1, 2, 0, 0), ( 4, 5, 1, 0, 0),
( 5, 4, 1, 0, 0),
( 6, 2, 1, 0, 0), ( 6, 3, 1, 0, 0),
( 7, 1, 1, 0, 0),
( 8, 5, 1, 0, 0),
( 9, 1, 1, 0, 0), ( 9, 4, 2, 0, 0),
(10, 2, 3, 0, 0),
(11, 3, 1, 0, 0), (11, 4, 1, 0, 0),
(12, 1, 1, 0, 0),
(13, 1, 1, 0, 0), (13, 2, 1, 0, 0),
(14, 3, 2, 0, 0),
(15, 5, 1, 0, 0), (15, 1, 1, 0, 0);

UPDATE tblrequestdetails rd
JOIN tbldocuments d ON d.DocumentID = rd.DocumentID
SET rd.Amount = d.Fee,
    rd.SubTotal = d.Fee * rd.Quantity;

UPDATE tblrequest r
SET r.TotalAmount = (SELECT SUM(rd.SubTotal) FROM tblrequestdetails rd WHERE rd.RequestID = r.RequestID);

UPDATE tblrequest SET AmountPaid = TotalAmount WHERE PaymentStatus = 'Paid';
