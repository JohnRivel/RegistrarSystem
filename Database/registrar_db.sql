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
    LastName    VARCHAR(50)  NOT NULL,
    FirstName   VARCHAR(50)  NOT NULL,
    MiddleName  VARCHAR(50)  NULL,
    Course      VARCHAR(50)  NOT NULL,
    YearLevel   VARCHAR(10)  NOT NULL,
    Section     VARCHAR(20)  NOT NULL,
    ContactNo   VARCHAR(15)  NOT NULL,
    Status      ENUM('Active','Inactive') NOT NULL DEFAULT 'Active',
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

INSERT INTO tblstudents (StudentID, LastName, FirstName, MiddleName, Course, YearLevel, Section, ContactNo, Status) VALUES
('20260001', 'Galang', 'Josh Matthew', NULL, 'BSIT', '1st Year', 'BSIT11M1', '09171000001', 'Active'),
('20260002', 'Quimson', 'Allen Dwayne', NULL, 'BSCS', '2nd Year', 'BSCS21A2', '09171000002', 'Active'),
('20260003', 'Cantor', 'Rhayniel Allen', NULL, 'BSBA', '3rd Year', 'BSBA31E3', '09171000003', 'Active'),
('20260004', 'Reosa', 'Patricia', NULL, 'BSED', '4th Year', 'BSED41M1', '09171000004', 'Active'),
('20260005', 'Borromeo', 'Ronalyn', NULL, 'BSTM', '1st Year', 'BSTM11A2', '09171000005', 'Active'),
('20260006', 'Bernaldez', 'Bernadette', NULL, 'BSCRIM', '2nd Year', 'BSCRIM21E3', '09171000006', 'Active'),
('20260007', 'Lopez', 'Gabriel', NULL, 'BSHM', '3rd Year', 'BSHM31M1', '09171000007', 'Active'),
('20260008', 'Pebida', 'Jasry', NULL, 'BSIT', '4th Year', 'BSIT41A2', '09171000008', 'Active'),
('20260009', 'Metharam', 'Joshua', NULL, 'BSCS', '1st Year', 'BSCS11E3', '09171000009', 'Active'),
('20260010', 'Ayap', 'Daimery Gold', NULL, 'BSBA', '2nd Year', 'BSBA21M1', '09171000010', 'Active'),
('20260011', 'Villarino', 'Justine', NULL, 'BSED', '3rd Year', 'BSED31A2', '09171000011', 'Active'),
('20260012', 'Sumalinog', 'Ace', NULL, 'BSTM', '4th Year', 'BSTM41E3', '09171000012', 'Active'),
('20260013', 'Marcos', 'Danielle', NULL, 'BSCRIM', '1st Year', 'BSCRIM11M1', '09171000013', 'Active'),
('20260014', 'Abadilla', 'Cj', NULL, 'BSHM', '2nd Year', 'BSHM21A2', '09171000014', 'Active'),
('20260015', 'Atienza', 'Ulrich Allister', NULL, 'BSIT', '3rd Year', 'BSIT31E3', '09171000015', 'Active'),
('20260016', 'Casilan', 'Earl Cedric', NULL, 'BSCS', '4th Year', 'BSCS41M1', '09171000016', 'Active'),
('20260017', 'Corolla', 'Maria', NULL, 'BSBA', '1st Year', 'BSBA11A2', '09171000017', 'Active'),
('20260018', 'Lorenzo', 'Hannah', NULL, 'BSED', '2nd Year', 'BSED21E3', '09171000018', 'Active'),
('20260019', 'Campita', 'Dylan', NULL, 'BSTM', '3rd Year', 'BSTM31M1', '09171000019', 'Active'),
('20260020', 'Finn', 'Danish', NULL, 'BSCRIM', '4th Year', 'BSCRIM41A2', '09171000020', 'Active'),
('20260021', 'Geavican', 'Adrian', NULL, 'BSHM', '1st Year', 'BSHM11E3', '09171000021', 'Active'),
('20260022', 'Bunyi', 'Carl', NULL, 'BSIT', '2nd Year', 'BSIT21M1', '09171000022', 'Active'),
('20260023', 'Moan', 'Chris', NULL, 'BSCS', '3rd Year', 'BSCS31A2', '09171000023', 'Active'),
('20260024', 'Khi', 'Del', NULL, 'BSBA', '4th Year', 'BSBA41E3', '09171000024', 'Active'),
('20260025', 'Asher', 'Godwin', NULL, 'BSED', '1st Year', 'BSED11M1', '09171000025', 'Active'),
('20260026', 'Diocampo', 'Ivan Winzle', NULL, 'BSTM', '2nd Year', 'BSTM21A2', '09171000026', 'Active'),
('20260027', 'Resuena', 'Jan Aron', NULL, 'BSCRIM', '3rd Year', 'BSCRIM31E3', '09171000027', 'Active'),
('20260028', 'Ang', 'Jerimiah', NULL, 'BSHM', '4th Year', 'BSHM41M1', '09171000028', 'Active'),
('20260029', 'Labutap', 'Johann Carlo', NULL, 'BSIT', '1st Year', 'BSIT11A2', '09171000029', 'Active'),
('20260030', 'Magsino', 'Kyle', NULL, 'BSCS', '2nd Year', 'BSCS21E3', '09171000030', 'Active'),
('20260031', 'Hombria', 'RJ', NULL, 'BSBA', '3rd Year', 'BSBA31M1', '09171000031', 'Active'),
('20260032', 'Landrito', 'Wesleybrian', NULL, 'BSED', '4th Year', 'BSED41A2', '09171000032', 'Active'),
('20260033', 'Landrito', 'Nicole', NULL, 'BSTM', '1st Year', 'BSTM11E3', '09171000033', 'Active'),
('20260034', 'Etang', 'Dan', NULL, 'BSCRIM', '2nd Year', 'BSCRIM21M1', '09171000034', 'Active'),
('20260035', 'Gregorio', 'Yuwan Andrei', NULL, 'BSHM', '3rd Year', 'BSHM31A2', '09171000035', 'Active'),
('20260036', 'Bobadilla', 'Raven', NULL, 'BSIT', '4th Year', 'BSIT41E3', '09171000036', 'Active'),
('20260037', 'Zamora', 'Neil', NULL, 'BSCS', '1st Year', 'BSCS11M1', '09171000037', 'Active'),
('20260038', 'Rollon', 'Dylan Paolo', NULL, 'BSBA', '2nd Year', 'BSBA21A2', '09171000038', 'Active'),
('20260039', 'Tiposo', 'Justine', NULL, 'BSED', '3rd Year', 'BSED31E3', '09171000039', 'Active'),
('20260040', 'Gwyneth', 'Shania', NULL, 'BSTM', '4th Year', 'BSTM41M1', '09171000040', 'Active'),
('20260041', 'Cristines', 'Manice', NULL, 'BSCRIM', '1st Year', 'BSCRIM11A2', '09171000041', 'Active'),
('20260042', 'Contantino', 'Hanna', NULL, 'BSHM', '2nd Year', 'BSHM21E3', '09171000042', 'Active'),
('20260043', 'Reyes', 'John Matthew', NULL, 'BSIT', '3rd Year', 'BSIT31M1', '09171000043', 'Active'),
('20260044', 'Howard', 'Paul', NULL, 'BSCS', '4th Year', 'BSCS41A2', '09171000044', 'Active'),
('20260045', 'Nava', 'Grace', NULL, 'BSBA', '1st Year', 'BSBA11E3', '09171000045', 'Active'),
('20260046', 'Pillar', 'Ivan', NULL, 'BSED', '2nd Year', 'BSED21M1', '09171000046', 'Active'),
('20260047', 'Resurreccion', 'James Murfhy', NULL, 'BSTM', '3rd Year', 'BSTM31A2', '09171000047', 'Active'),
('20260048', 'Prado', 'Phoebe', NULL, 'BSCRIM', '4th Year', 'BSCRIM41E3', '09171000048', 'Active'),
('20260049', 'Luna', 'John Carl', NULL, 'BSHM', '1st Year', 'BSHM11M1', '09171000049', 'Active'),
('20260050', 'Gwn', 'Sophia', NULL, 'BSIT', '2nd Year', 'BSIT21A2', '09171000050', 'Active'),
('20260051', 'Bautista', 'Elizabeth', NULL, 'BSCS', '3rd Year', 'BSCS31E3', '09171000051', 'Active'),
('20260052', 'Hilapo', 'Klarizze', NULL, 'BSBA', '4th Year', 'BSBA41M1', '09171000052', 'Active'),
('20260053', 'Miranda', 'Benedict', NULL, 'BSED', '1st Year', 'BSED11A2', '09171000053', 'Active'),
('20260054', 'Clear', 'Rona', NULL, 'BSTM', '2nd Year', 'BSTM21E3', '09171000054', 'Active'),
('20260055', 'Deguzman', 'James', NULL, 'BSCRIM', '3rd Year', 'BSCRIM31M1', '09171000055', 'Active'),
('20260056', 'Osorio', 'Mark Daniel', NULL, 'BSHM', '4th Year', 'BSHM41A2', '09171000056', 'Active'),
('20260057', 'James', 'Justine', NULL, 'BSIT', '1st Year', 'BSIT11E3', '09171000057', 'Active'),
('20260058', 'Mendoza', 'Fiona Katheleen', NULL, 'BSCS', '2nd Year', 'BSCS21M1', '09171000058', 'Active'),
('20260059', 'Ergina', 'Justine', NULL, 'BSBA', '3rd Year', 'BSBA31A2', '09171000059', 'Active'),
('20260060', 'San Juan', 'Chyra', NULL, 'BSED', '4th Year', 'BSED41E3', '09171000060', 'Active'),
('20260061', 'Cabarrubia', 'Nicole Baustista', NULL, 'BSTM', '1st Year', 'BSTM11M1', '09171000061', 'Active'),
('20260062', 'Claire', 'Angelia', NULL, 'BSCRIM', '2nd Year', 'BSCRIM21A2', '09171000062', 'Active'),
('20260063', 'Gonzales', 'Marry Anne', NULL, 'BSHM', '3rd Year', 'BSHM31E3', '09171000063', 'Active'),
('20260064', 'Arabella', 'Bianca', NULL, 'BSIT', '4th Year', 'BSIT41M1', '09171000064', 'Active'),
('20260065', 'Dela Cruz', 'Sandy', NULL, 'BSCS', '1st Year', 'BSCS11A2', '09171000065', 'Active'),
('20260066', 'Villasencio', 'Reiner', NULL, 'BSBA', '2nd Year', 'BSBA21E3', '09171000066', 'Active'),
('20260067', 'Nolasco', 'Krizzy', NULL, 'BSED', '3rd Year', 'BSED31M1', '09171000067', 'Active'),
('20260068', 'Magsombol', 'Faythe', NULL, 'BSTM', '4th Year', 'BSTM41A2', '09171000068', 'Active'),
('20260069', 'Aira', 'Sophia', NULL, 'BSCRIM', '1st Year', 'BSCRIM11E3', '09171000069', 'Active'),
('20260070', 'Argana', 'Laurent Dwayane', NULL, 'BSHM', '2nd Year', 'BSHM21M1', '09171000070', 'Active'),
('20260071', 'Laureaga', 'Alyssa', NULL, 'BSIT', '3rd Year', 'BSIT31A2', '09171000071', 'Active'),
('20260072', 'Saavedra', 'Jeanyxia Bea', NULL, 'BSCS', '4th Year', 'BSCS41E3', '09171000072', 'Active'),
('20260073', 'Advincula', 'Benz', NULL, 'BSBA', '1st Year', 'BSBA11M1', '09171000073', 'Active'),
('20260074', 'Pecho', 'Juliana', NULL, 'BSED', '2nd Year', 'BSED21A2', '09171000074', 'Active'),
('20260075', 'Galvez', 'Julienne Gail', NULL, 'BSTM', '3rd Year', 'BSTM31E3', '09171000075', 'Active'),
('20260076', 'Dimanlig', 'Zamantha', NULL, 'BSCRIM', '4th Year', 'BSCRIM41M1', '09171000076', 'Active');

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
