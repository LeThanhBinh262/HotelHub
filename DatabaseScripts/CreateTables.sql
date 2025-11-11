-- Create Users Table
CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(100) NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Role NVARCHAR(MAX) NOT NULL,
    PhoneNumber NVARCHAR(MAX) NULL,
    IsMfaEnabled BIT NOT NULL
);


-- Create Rooms Table
CREATE TABLE Rooms (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    RoomType NVARCHAR(MAX) NOT NULL,
    Price DECIMAL(18,2) NOT NULL,
    IsAvailable BIT NOT NULL
);

-- Create Bookings Table
CREATE TABLE Bookings (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL FOREIGN KEY REFERENCES Users(Id),
    RoomId INT NOT NULL FOREIGN KEY REFERENCES Rooms(Id),
    CheckInDate DATETIME NOT NULL,
    CheckOutDate DATETIME NOT NULL,
    Status NVARCHAR(MAX) NULL
);

-- Create Payments Table
CREATE TABLE Payments (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    BookingId INT NOT NULL FOREIGN KEY REFERENCES Bookings(Id),
    Amount DECIMAL(18,2) NOT NULL,
    PaymentDate DATETIME NOT NULL,
    PaymentMethod NVARCHAR(MAX) NULL
);