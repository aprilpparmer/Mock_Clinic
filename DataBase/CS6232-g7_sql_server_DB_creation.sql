USE [master]
GO
/****** Object:  Database [CS6232-g7]    Script Date: 03/22/2015 11:00:32 ******/
CREATE DATABASE [CS6232-g7] ON  PRIMARY 
( NAME = N'CS6232-g7', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CS6232-g7.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CS6232-g7_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CS6232-g7_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CS6232-g7] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CS6232-g7].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CS6232-g7] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [CS6232-g7] SET ANSI_NULLS OFF
GO
ALTER DATABASE [CS6232-g7] SET ANSI_PADDING OFF
GO
ALTER DATABASE [CS6232-g7] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [CS6232-g7] SET ARITHABORT OFF
GO
ALTER DATABASE [CS6232-g7] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [CS6232-g7] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [CS6232-g7] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [CS6232-g7] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [CS6232-g7] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [CS6232-g7] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [CS6232-g7] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [CS6232-g7] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [CS6232-g7] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [CS6232-g7] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [CS6232-g7] SET  DISABLE_BROKER
GO
ALTER DATABASE [CS6232-g7] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [CS6232-g7] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [CS6232-g7] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [CS6232-g7] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [CS6232-g7] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [CS6232-g7] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [CS6232-g7] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [CS6232-g7] SET  READ_WRITE
GO
ALTER DATABASE [CS6232-g7] SET RECOVERY FULL
GO
ALTER DATABASE [CS6232-g7] SET  MULTI_USER
GO
ALTER DATABASE [CS6232-g7] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [CS6232-g7] SET DB_CHAINING OFF
GO
USE [CS6232-g7]
GO
/****** Object:  Table [dbo].[tests]    Script Date: 03/22/2015 11:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tests](
	[testID] [int] IDENTITY(1,1) NOT NULL,
	[test_name] [varchar](200) NOT NULL,
 CONSTRAINT [PK_tests] PRIMARY KEY CLUSTERED 
(
	[testID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tests] ON
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (1, N'Amylase                                                                                                                                                                                                 ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (2, N'BMP (Basic Metabolic Panel)                                                                                                                                                                             ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (3, N'CBC (Complete Blood Count)                                                                                                                                                                              ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (4, N'Electrolytes                                                                                                                                                                                            ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (5, N'Flu Test                                                                                                                                                                                                ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (6, N'Glucose                                                                                                                                                                                                 ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (7, N'HIV Antibody                                                                                                                                                                                            ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (8, N'Liver Panel                                                                                                                                                                                             ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (9, N'Lyme Diseas                                                                                                                                                                                             ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (10, N'Stool Culture                                                                                                                                                                                           ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (11, N'TSH (Thyroid Stimulating Hormone)                                                                                                                                                                       ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (12, N'T4 (Thyroxine)                                                                                                                                                                                          ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (13, N'Uric Acid                                                                                                                                                                                               ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (14, N'Urinalysis                                                                                                                                                                                              ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (15, N'Urine culture                                                                                                                                                                                           ')
INSERT [dbo].[tests] ([testID], [test_name]) VALUES (16, N'Strep test (Throat culture)                                                                                                                                                                             ')
SET IDENTITY_INSERT [dbo].[tests] OFF
/****** Object:  Table [dbo].[positions]    Script Date: 03/22/2015 11:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[positions](
	[positionID] [int] IDENTITY(1,1) NOT NULL,
	[position_name] [varchar](25) NULL,
 CONSTRAINT [PK_positions] PRIMARY KEY CLUSTERED 
(
	[positionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[positions] ON
INSERT [dbo].[positions] ([positionID], [position_name]) VALUES (1, N'nurse                    ')
INSERT [dbo].[positions] ([positionID], [position_name]) VALUES (2, N'doctor                   ')
INSERT [dbo].[positions] ([positionID], [position_name]) VALUES (3, N'administrator            ')
INSERT [dbo].[positions] ([positionID], [position_name]) VALUES (4, N'physician                ')
INSERT [dbo].[positions] ([positionID], [position_name]) VALUES (5, N'pharmacist               ')
INSERT [dbo].[positions] ([positionID], [position_name]) VALUES (6, N'general manager          ')
INSERT [dbo].[positions] ([positionID], [position_name]) VALUES (7, N'lab technician           ')
INSERT [dbo].[positions] ([positionID], [position_name]) VALUES (8, N'driver                   ')
SET IDENTITY_INSERT [dbo].[positions] OFF
/****** Object:  Table [dbo].[patients]    Script Date: 03/22/2015 11:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patients](
	[patientID] [int] IDENTITY(1,1) NOT NULL,
	[ssn] [int] NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[middle_initial] [varchar](1) NULL,
	[first_name] [varchar](50) NOT NULL,
	[dob] [date] NOT NULL,
	[gender] [varchar](1) NOT NULL,
	[address] [varchar](200) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[state] [varchar](50) NOT NULL,
	[zip] [int] NOT NULL,
	[home_phone] [varchar](15) NOT NULL,
	[work_phone] [varchar](15) NULL,
	[child] [varchar](15) NULL,
	[motherID] [int] NULL,
	[fatherID] [int] NULL,
 CONSTRAINT [PK_patients] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[patients] ON
INSERT [dbo].[patients] ([patientID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [home_phone], [work_phone], [child], [motherID], [fatherID]) VALUES (1, 111111111, N'Jackson                                           ', N'M', N'Samuel                                            ', CAST(0x3CE60A00 AS Date), N'M', N'875 4TH ST SE                                                                                                                                                                                           ', N'Atlanta                                           ', N'GA                                                ', 30009, N'8034044041     ', NULL, NULL, NULL, NULL)
INSERT [dbo].[patients] ([patientID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [home_phone], [work_phone], [child], [motherID], [fatherID]) VALUES (3, 222222222, N'Clark                                             ', N'B', N'Brandon                                           ', CAST(0xC1160B00 AS Date), N'M', N'765 Holmsbury Rd                                                                                                                                                                                        ', N'Buford                                            ', N'GA                                                ', 31009, N'4041111114     ', NULL, NULL, NULL, 1)
INSERT [dbo].[patients] ([patientID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [home_phone], [work_phone], [child], [motherID], [fatherID]) VALUES (4, 333333333, N'Wilkinson                                         ', NULL, N'Justin                                            ', CAST(0x7A0E0B00 AS Date), N'M', N'7654 Wesley Rd                                                                                                                                                                                          ', N'Atlanta                                           ', N'GA                                                ', 30009, N'7839999993     ', NULL, NULL, NULL, NULL)
INSERT [dbo].[patients] ([patientID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [home_phone], [work_phone], [child], [motherID], [fatherID]) VALUES (5, 444444444, N'Sampras                                           ', N'M', N'Peter                                             ', CAST(0xD4050B00 AS Date), N'M', N'64 Oxford Cir                                                                                                                                                                                           ', N'Chatanooga                                        ', N'TN                                                ', 34009, N'5069966332     ', NULL, NULL, NULL, NULL)
INSERT [dbo].[patients] ([patientID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [home_phone], [work_phone], [child], [motherID], [fatherID]) VALUES (6, 555555555, N'Deschamps                                         ', N'A', N'Olive                                             ', CAST(0x93D50A00 AS Date), N'F', N'567 Lexington Ave                                                                                                                                                                                       ', N'Lawrenceville                                     ', N'GA                                                ', 30056, N'4561239872     ', NULL, NULL, NULL, NULL)
INSERT [dbo].[patients] ([patientID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [home_phone], [work_phone], [child], [motherID], [fatherID]) VALUES (7, 666666666, N'VanHorn                                           ', N'T', N'Doris                                             ', CAST(0x59130B00 AS Date), N'F', N'12 Willow Ln                                                                                                                                                                                            ', N'Carrollton                                        ', N'GA                                                ', 34009, N'4047899871     ', NULL, NULL, NULL, NULL)
INSERT [dbo].[patients] ([patientID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [home_phone], [work_phone], [child], [motherID], [fatherID]) VALUES (8, 777777777, N'Schneider                                         ', NULL, N'Jeremy                                            ', CAST(0x41020B00 AS Date), N'M', N'123 Chastain Rd                                                                                                                                                                                         ', N'Columbia                                          ', N'SC                                                ', 38097, N'8037874989     ', NULL, NULL, NULL, NULL)
INSERT [dbo].[patients] ([patientID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [home_phone], [work_phone], [child], [motherID], [fatherID]) VALUES (9, 888888888, N'McoLoud                                           ', N'H', N'Jessica                                           ', CAST(0x4A180B00 AS Date), N'F', N'125 Summer St                                                                                                                                                                                           ', N'Villa Rica                                        ', N'GA                                                ', 30065, N'4040878787     ', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[patients] OFF
/****** Object:  Table [dbo].[diagnoses]    Script Date: 03/22/2015 11:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diagnoses](
	[diagnosesID] [int] IDENTITY(1,1) NOT NULL,
	[diagnoses_name] [varchar](200) NOT NULL,
	[diagnoses_description] [text] NOT NULL,
	[diagnoses_treatment] [text] NOT NULL,
	[enabled] [tinyint] NULL,
 CONSTRAINT [PK_diagnoses] PRIMARY KEY CLUSTERED 
(
	[diagnosesID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[diagnoses] ON
INSERT [dbo].[diagnoses] ([diagnosesID], [diagnoses_name], [diagnoses_description], [diagnoses_treatment], [enabled]) VALUES (1, N'broken toe                                                                                                                                                                                              ', N'broken toe diagnoses description', N'painkillers', 1)
INSERT [dbo].[diagnoses] ([diagnosesID], [diagnoses_name], [diagnoses_description], [diagnoses_treatment], [enabled]) VALUES (2, N'strep throat                                                                                                                                                                                            ', N'strep throat diagnoses description', N'antibiotics', 1)
INSERT [dbo].[diagnoses] ([diagnosesID], [diagnoses_name], [diagnoses_description], [diagnoses_treatment], [enabled]) VALUES (3, N'flu                                                                                                                                                                                                     ', N'flu diagnois description', N'decongestant and antihistamine', 1)
INSERT [dbo].[diagnoses] ([diagnosesID], [diagnoses_name], [diagnoses_description], [diagnoses_treatment], [enabled]) VALUES (4, N'ulcer                                                                                                                                                                                                   ', N'ulcer diagnoses', N'Famotidine', 1)
SET IDENTITY_INSERT [dbo].[diagnoses] OFF
/****** Object:  Table [dbo].[allergies]    Script Date: 03/22/2015 11:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[allergies](
	[allergyID] [int] IDENTITY(1,1) NOT NULL,
	[allergy_name] [varchar](200) NOT NULL,
	[enabled] [tinyint] NULL,
 CONSTRAINT [PK_allergies] PRIMARY KEY CLUSTERED 
(
	[allergyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[allergies] ON
INSERT [dbo].[allergies] ([allergyID], [allergy_name], [enabled]) VALUES (1, N'penicillin                                                                                                                                                                                              ', 1)
INSERT [dbo].[allergies] ([allergyID], [allergy_name], [enabled]) VALUES (2, N'pollen                                                                                                                                                                                                  ', 1)
INSERT [dbo].[allergies] ([allergyID], [allergy_name], [enabled]) VALUES (3, N'tree nuts                                                                                                                                                                                               ', 1)
INSERT [dbo].[allergies] ([allergyID], [allergy_name], [enabled]) VALUES (4, N'fish                                                                                                                                                                                                    ', 1)
INSERT [dbo].[allergies] ([allergyID], [allergy_name], [enabled]) VALUES (5, N'mold                                                                                                                                                                                                    ', 1)
INSERT [dbo].[allergies] ([allergyID], [allergy_name], [enabled]) VALUES (6, N'dog                                                                                                                                                                                                     ', 1)
INSERT [dbo].[allergies] ([allergyID], [allergy_name], [enabled]) VALUES (7, N'cat                                                                                                                                                                                                     ', 1)
SET IDENTITY_INSERT [dbo].[allergies] OFF
/****** Object:  Table [dbo].[patient_allergies]    Script Date: 03/22/2015 11:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_allergies](
	[patientallergyID] [int] IDENTITY(1,1) NOT NULL,
	[allergy_name] [varchar](200) NULL,
	[patientID] [int] NOT NULL,
	[allergyID] [int] NOT NULL,
 CONSTRAINT [PK_patient_allergies] PRIMARY KEY CLUSTERED 
(
	[patientallergyID] ASC,
	[allergyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[patient_allergies] ON
INSERT [dbo].[patient_allergies] ([patientallergyID], [allergy_name], [patientID], [allergyID]) VALUES (1, N'penicillin                                                                                                                                                                                              ', 1, 1)
INSERT [dbo].[patient_allergies] ([patientallergyID], [allergy_name], [patientID], [allergyID]) VALUES (4, N'pollen                                                                                                                                                                                                  ', 3, 2)
SET IDENTITY_INSERT [dbo].[patient_allergies] OFF
/****** Object:  Table [dbo].[employees]    Script Date: 03/22/2015 11:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employees](
	[employeeID] [int] IDENTITY(1,1) NOT NULL,
	[ssn] [int] NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[middle_initial] [varchar](1) NULL,
	[first_name] [varchar](50) NOT NULL,
	[dob] [date] NOT NULL,
	[gender] [varchar](1) NOT NULL,
	[address] [varchar](200) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[state] [varchar](50) NOT NULL,
	[zip] [int] NOT NULL,
	[phone] [varchar](20) NOT NULL,
	[login] [varchar](25) NULL,
	[password] [varchar](200) NULL,
	[last_login] [smalldatetime] NULL,
	[positionID] [int] NOT NULL,
	[enabled] [tinyint] NULL,
 CONSTRAINT [PK_employees] PRIMARY KEY CLUSTERED 
(
	[employeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[employees] ON
INSERT [dbo].[employees] ([employeeID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [phone], [login], [password], [last_login], [positionID], [enabled]) VALUES (3, 123456789, N'Grier                                             ', N'M', N'Angela                                            ', CAST(0x4BF60A00 AS Date), N'F', N'123 Fly RD                                                                                                                                                                                              ', N'Marrietta                                         ', N'GA                                                ', 30030, N'8037873214          ', NULL, NULL, CAST(0xA462051E AS SmallDateTime), 1, 0)
INSERT [dbo].[employees] ([employeeID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [phone], [login], [password], [last_login], [positionID], [enabled]) VALUES (4, 123412345, N'Merkel                                            ', NULL, N'Diana                                             ', CAST(0x930B0B00 AS Date), N'F', N'3456 Holmes Cir                                                                                                                                                                                         ', N'Atlanta                                           ', N'GA                                                ', 31290, N'4048908900          ', N'dmerkel                  ', N'dmerkel                                                                                                                                                                                                 ', CAST(0xA4620523 AS SmallDateTime), 1, 1)
INSERT [dbo].[employees] ([employeeID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [phone], [login], [password], [last_login], [positionID], [enabled]) VALUES (5, 987654321, N'Trap                                              ', N'J', N'John                                              ', CAST(0x81FA0A00 AS Date), N'M', N'8765 Nate Rd                                                                                                                                                                                            ', N'Atlanta                                           ', N'GA                                                ', 30067, N'7094044040          ', NULL, NULL, CAST(0xA4620526 AS SmallDateTime), 1, 0)
INSERT [dbo].[employees] ([employeeID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [phone], [login], [password], [last_login], [positionID], [enabled]) VALUES (6, 786987888, N'Kirk                                              ', N'B', N'Michael                                           ', CAST(0x4FEE0A00 AS Date), N'M', N'894 Berry Rd                                                                                                                                                                                            ', N'Atlanta                                           ', N'GA                                                ', 30045, N'7879998888          ', NULL, NULL, CAST(0xA4620533 AS SmallDateTime), 2, 0)
INSERT [dbo].[employees] ([employeeID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [phone], [login], [password], [last_login], [positionID], [enabled]) VALUES (8, 945987123, N'Spring                                            ', NULL, N'Daniel                                            ', CAST(0xD5F20A00 AS Date), N'M', N'345 Metro Ave                                                                                                                                                                                           ', N'Smyrna                                            ', N'GA                                                ', 30080, N'4045555555          ', N'dspring                  ', N'dspring                                                                                                                                                                                                 ', CAST(0xA4620536 AS SmallDateTime), 1, 1)
INSERT [dbo].[employees] ([employeeID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [phone], [login], [password], [last_login], [positionID], [enabled]) VALUES (9, 345671299, N'Smith                                             ', N'G', N'Larry                                             ', CAST(0x55DE0A00 AS Date), N'M', N'8678 3rd St                                                                                                                                                                                             ', N'Atlanta                                           ', N'GA                                                ', 30054, N'4048769999          ', N'lsmith                   ', N'lsmith                                                                                                                                                                                                  ', CAST(0xA4620539 AS SmallDateTime), 2, 0)
INSERT [dbo].[employees] ([employeeID], [ssn], [last_name], [middle_initial], [first_name], [dob], [gender], [address], [city], [state], [zip], [phone], [login], [password], [last_login], [positionID], [enabled]) VALUES (10, 124578963, N'AdminLast									       ', NULL, N'AdminFirst										', CAST(0x55DE0A00 AS Date), N'M', N'159 Admin Rd																																															 ', N'Atlanta											', N'GA												   ', 30080, N'4045555545		   ', N'admin					 ', N'admin																																																	  ', CAST(0xA4620539 AS SmallDateTime), 3, 1)				
SET IDENTITY_INSERT [dbo].[employees] OFF
/****** Object:  Table [dbo].[patient_visit]    Script Date: 03/22/2015 11:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_visit](
	[visitID] [int] IDENTITY(1,1) NOT NULL,
	[patientID] [int] NOT NULL,
	[visit_date] [smalldatetime] NOT NULL,
	[appt_date] [smalldatetime] NULL,
	[doctorID] [int] NOT NULL,
	[nurseID] [int] NOT NULL,
 CONSTRAINT [PK_patient_visit] PRIMARY KEY CLUSTERED 
(
	[visitID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[patient_visit] ON
INSERT [dbo].[patient_visit] ([visitID], [patientID], [visit_date], [appt_date], [doctorID], [nurseID]) VALUES (1, 1, CAST(0xA463023E AS SmallDateTime), CAST(0xA4630000 AS SmallDateTime), 6, 8)
INSERT [dbo].[patient_visit] ([visitID], [patientID], [visit_date], [appt_date], [doctorID], [nurseID]) VALUES (2, 3, CAST(0xA4630240 AS SmallDateTime), CAST(0xA4630000 AS SmallDateTime), 6, 8)
INSERT [dbo].[patient_visit] ([visitID], [patientID], [visit_date], [appt_date], [doctorID], [nurseID]) VALUES (3, 4, CAST(0xA4630240 AS SmallDateTime), CAST(0xA4630000 AS SmallDateTime), 9, 3)
INSERT [dbo].[patient_visit] ([visitID], [patientID], [visit_date], [appt_date], [doctorID], [nurseID]) VALUES (4, 5, CAST(0xA4630240 AS SmallDateTime), CAST(0xA4620000 AS SmallDateTime), 6, 3)
INSERT [dbo].[patient_visit] ([visitID], [patientID], [visit_date], [appt_date], [doctorID], [nurseID]) VALUES (5, 6, CAST(0xA4630241 AS SmallDateTime), CAST(0xA4610000 AS SmallDateTime), 9, 4)
INSERT [dbo].[patient_visit] ([visitID], [patientID], [visit_date], [appt_date], [doctorID], [nurseID]) VALUES (6, 7, CAST(0xA4630241 AS SmallDateTime), CAST(0xA4630000 AS SmallDateTime), 9, 5)
INSERT [dbo].[patient_visit] ([visitID], [patientID], [visit_date], [appt_date], [doctorID], [nurseID]) VALUES (7, 8, CAST(0xA4630242 AS SmallDateTime), CAST(0xA4630000 AS SmallDateTime), 6, 5)
SET IDENTITY_INSERT [dbo].[patient_visit] OFF
/****** Object:  Table [dbo].[patient_visit_vitals]    Script Date: 03/22/2015 11:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_visit_vitals](
	[vitalsID] [int] IDENTITY(1,1) NOT NULL,
	[visitID] [int] NOT NULL,
	[blood_pressure] [varchar](20) NOT NULL,
	[temp] [varchar](20) NOT NULL,
	[pulse] [varchar](20) NOT NULL,
	[height] [int] NOT NULL,
	[weight] [float](10) NOT NULL,
 CONSTRAINT [PK_patient_visit_vitals] PRIMARY KEY CLUSTERED 
(
	[vitalsID] ASC,
	[visitID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[patient_visit_vitals] ON
INSERT [dbo].[patient_visit_vitals] ([vitalsID], [visitID], [blood_pressure], [temp], [pulse], [height], [weight]) VALUES (4, 1, N'125/84              ', N'98.6                ', N'88                  ', 59, 190)
INSERT [dbo].[patient_visit_vitals] ([vitalsID], [visitID], [blood_pressure], [temp], [pulse], [height], [weight]) VALUES (5, 2, N'120/88              ', N'98.1                ', N'90                  ', 61, 280)
INSERT [dbo].[patient_visit_vitals] ([vitalsID], [visitID], [blood_pressure], [temp], [pulse], [height], [weight]) VALUES (6, 3, N'130/78              ', N'99.0                ', N'77                  ', 70, 180)
INSERT [dbo].[patient_visit_vitals] ([vitalsID], [visitID], [blood_pressure], [temp], [pulse], [height], [weight]) VALUES (7, 4, N'140/91              ', N'99.2                ', N'89                  ', 58, 203)
INSERT [dbo].[patient_visit_vitals] ([vitalsID], [visitID], [blood_pressure], [temp], [pulse], [height], [weight]) VALUES (8, 5, N'125/68              ', N'99.9                ', N'98                  ', 57, 230)
INSERT [dbo].[patient_visit_vitals] ([vitalsID], [visitID], [blood_pressure], [temp], [pulse], [height], [weight]) VALUES (9, 6, N'109/67              ', N'98.6                ', N'85                  ', 56, 198)
INSERT [dbo].[patient_visit_vitals] ([vitalsID], [visitID], [blood_pressure], [temp], [pulse], [height], [weight]) VALUES (11, 7, N'115/81              ', N'98.4                ', N'79                  ', 59, 205)
SET IDENTITY_INSERT [dbo].[patient_visit_vitals] OFF
/****** Object:  Table [dbo].[patient_visit_symptoms]    Script Date: 03/22/2015 11:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_visit_symptoms](

	[symptomID] [int] IDENTITY(1,1) NOT NULL,
	[visitID] [int] NOT NULL,
	[symptom_name] [varchar](300) NOT NULL,
	[diagnoses_diagnosesID] [int],
 CONSTRAINT [PK_patient_visit_symptoms] PRIMARY KEY 
(
	[symptomID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[patient_visit_symptoms] ON
INSERT [dbo].[patient_visit_symptoms] ([symptomID], [visitID], [symptom_name], [diagnoses_diagnosesID]) VALUES (1, 1, N'abdominal pain                                                                                                                                                                                                                                                                                              ', 4)
INSERT [dbo].[patient_visit_symptoms] ([symptomID], [visitID], [symptom_name], [diagnoses_diagnosesID]) VALUES (2, 2, N'fever, loss of apetite                                                                                                                                                                                                                                                                                      ', 3)
INSERT [dbo].[patient_visit_symptoms] ([symptomID], [visitID], [symptom_name], [diagnoses_diagnosesID]) VALUES (3, 3, N'sore throat, sudden fever,chills                                                                                                                                                                                                                                                                            ', 2)
INSERT [dbo].[patient_visit_symptoms] ([symptomID], [visitID], [symptom_name], [diagnoses_diagnosesID]) VALUES (4, 4, N'toe pain                                                                                                                                                                                                                                                                                                    ', 1)
INSERT [dbo].[patient_visit_symptoms] ([symptomID], [visitID], [symptom_name], [diagnoses_diagnosesID]) VALUES (5, 5, N'severe right abdominal pain                                                                                                                                                                                                                                                                                 ', 4)
INSERT [dbo].[patient_visit_symptoms] ([symptomID], [visitID], [symptom_name], [diagnoses_diagnosesID]) VALUES (6, 6, N'fever                                                                                                                                                                                                                                                                                                       ', 3)
INSERT [dbo].[patient_visit_symptoms] ([symptomID], [visitID], [symptom_name], [diagnoses_diagnosesID]) VALUES (7, 7, N'sore throat, trouble swallowing                                                                                                                                                                                                                                                                             ', 2)
SET IDENTITY_INSERT [dbo].[patient_visit_symptoms] OFF
/****** Object:  Table [dbo].[patient_visit_notes]    Script Date: 03/22/2015 11:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_visit_notes](
	[notesID] [int] IDENTITY(1,1) NOT NULL,
	[employeeID] [int] NOT NULL,
	[visitID] [int] NOT NULL,
	[note] [text] NOT NULL,
	[date] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_patient_visit_notes] PRIMARY KEY CLUSTERED 
(
	[notesID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[patient_visit_notes] ON
INSERT [dbo].[patient_visit_notes] ([notesID], [employeeID], [visitID], [note], [date]) VALUES (2, 8, 1, N'severe abdominal pain', CAST(0xA4630255 AS SmallDateTime))
INSERT [dbo].[patient_visit_notes] ([notesID], [employeeID], [visitID], [note], [date]) VALUES (3, 3, 3, N'severe throat pain', CAST(0xA4630256 AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[patient_visit_notes] OFF
/****** Object:  Table [dbo].[patient_tests]    Script Date: 03/22/2015 11:00:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_tests](
	[patient_testID] [int] IDENTITY(1,1) NOT NULL,
	[visitID] [int] NOT NULL,
	[testID] [int] NOT NULL,
	[test_ordered] [smalldatetime] NOT NULL,
	[test_taken] [smalldatetime] NULL,
	[test_completed] [smalldatetime] NULL,
	[results] [varchar](20) NULL,
 CONSTRAINT [PK_patient_tests] PRIMARY KEY CLUSTERED 
(
	[patient_testID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[patient_tests] ON
INSERT [dbo].[patient_tests] ([patient_testID], [visitID], [testID], [test_ordered], [test_taken], [test_completed], [results]) VALUES (1, 1, 16, CAST(0xA4630000 AS SmallDateTime), CAST(0xA4630000 AS SmallDateTime), CAST(0xA4630000 AS SmallDateTime), N'positive            ')
INSERT [dbo].[patient_tests] ([patient_testID], [visitID], [testID], [test_ordered], [test_taken], [test_completed], [results]) VALUES (2, 3, 1, CAST(0xA4630000 AS SmallDateTime), CAST(0xA4630000 AS SmallDateTime), CAST(0xA4630000 AS SmallDateTime), N'positive            ')
INSERT [dbo].[patient_tests] ([patient_testID], [visitID], [testID], [test_ordered], [test_taken], [test_completed], [results]) VALUES (3, 7, 16, CAST(0xA4630000 AS SmallDateTime), CAST(0xA4630000 AS SmallDateTime), CAST(0xA4630000 AS SmallDateTime), N'negative            ')
SET IDENTITY_INSERT [dbo].[patient_tests] OFF
/****** Object:  Default [DF_patients_middle_initial]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patients] ADD  CONSTRAINT [DF_patients_middle_initial]  DEFAULT (NULL) FOR [middle_initial]
GO
/****** Object:  Default [DF_patients_child]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patients] ADD  CONSTRAINT [DF_patients_child]  DEFAULT (NULL) FOR [child]
GO
/****** Object:  Default [DF_patient_allergies_allergy_name]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_allergies] ADD  CONSTRAINT [DF_patient_allergies_allergy_name]  DEFAULT (NULL) FOR [allergy_name]
GO
/****** Object:  Default [DF_employees_middle_initial]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[employees] ADD  CONSTRAINT [DF_employees_middle_initial]  DEFAULT (NULL) FOR [middle_initial]
GO
/****** Object:  Default [DF_employees_last_login]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[employees] ADD  CONSTRAINT [DF_employees_last_login]  DEFAULT (getdate()) FOR [last_login]
GO
/****** Object:  Default [DF_employees_enabled]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[employees] ADD  CONSTRAINT [DF_employees_enabled]  DEFAULT ((0)) FOR [enabled]
GO
/****** Object:  Default [DF_patient_visit_visit_date]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_visit] ADD  CONSTRAINT [DF_patient_visit_visit_date]  DEFAULT (getdate()) FOR [visit_date]
GO
/****** Object:  Default [DF_patient_visit_appt_date]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_visit] ADD  CONSTRAINT [DF_patient_visit_appt_date]  DEFAULT (NULL) FOR [appt_date]
GO
/****** Object:  Default [DF_patient_visit_notes_date]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_visit_notes] ADD  CONSTRAINT [DF_patient_visit_notes_date]  DEFAULT (getdate()) FOR [date]
GO
/****** Object:  Default [DF_patient_tests_test_ordered]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_tests] ADD  CONSTRAINT [DF_patient_tests_test_ordered]  DEFAULT (getdate()) FOR [test_ordered]
GO
/****** Object:  Default [DF_patient_tests_test_copleted]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_tests] ADD  CONSTRAINT [DF_patient_tests_test_copleted]  DEFAULT (NULL) FOR [test_completed]
GO
/****** Object:  Default [DF_patient_tests_results]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_tests] ADD  CONSTRAINT [DF_patient_tests_results]  DEFAULT (NULL) FOR [results]
GO
/****** Object:  ForeignKey [FK_patients_patients]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patients]  WITH CHECK ADD  CONSTRAINT [FK_patients_patients] FOREIGN KEY([motherID])
REFERENCES [dbo].[patients] ([patientID])
GO
ALTER TABLE [dbo].[patients] CHECK CONSTRAINT [FK_patients_patients]
GO
/****** Object:  ForeignKey [FK_patients_patients1]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patients]  WITH CHECK ADD  CONSTRAINT [FK_patients_patients1] FOREIGN KEY([fatherID])
REFERENCES [dbo].[patients] ([patientID])
GO
ALTER TABLE [dbo].[patients] CHECK CONSTRAINT [FK_patients_patients1]
GO
/****** Object:  ForeignKey [FK_patient_allergies_allergies]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_allergies]  WITH CHECK ADD  CONSTRAINT [FK_patient_allergies_allergies] FOREIGN KEY([allergyID])
REFERENCES [dbo].[allergies] ([allergyID])
GO
ALTER TABLE [dbo].[patient_allergies] CHECK CONSTRAINT [FK_patient_allergies_allergies]
GO
/****** Object:  ForeignKey [FK_patient_allergies_patients]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_allergies]  WITH CHECK ADD  CONSTRAINT [FK_patient_allergies_patients] FOREIGN KEY([patientID])
REFERENCES [dbo].[patients] ([patientID])
GO
ALTER TABLE [dbo].[patient_allergies] CHECK CONSTRAINT [FK_patient_allergies_patients]
GO
/****** Object:  ForeignKey [FK_employees_positions]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[employees]  WITH CHECK ADD  CONSTRAINT [FK_employees_positions] FOREIGN KEY([positionID])
REFERENCES [dbo].[positions] ([positionID])
GO
ALTER TABLE [dbo].[employees] CHECK CONSTRAINT [FK_employees_positions]
GO
/****** Object:  ForeignKey [FK_patient_visit_employees]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_visit]  WITH CHECK ADD  CONSTRAINT [FK_patient_visit_employees] FOREIGN KEY([doctorID])
REFERENCES [dbo].[employees] ([employeeID])
GO
ALTER TABLE [dbo].[patient_visit] CHECK CONSTRAINT [FK_patient_visit_employees]
GO
/****** Object:  ForeignKey [FK_patient_visit_employees1]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_visit]  WITH CHECK ADD  CONSTRAINT [FK_patient_visit_employees1] FOREIGN KEY([nurseID])
REFERENCES [dbo].[employees] ([employeeID])
GO
ALTER TABLE [dbo].[patient_visit] CHECK CONSTRAINT [FK_patient_visit_employees1]
GO
/****** Object:  ForeignKey [FK_patient_visit_patients]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_visit]  WITH CHECK ADD  CONSTRAINT [FK_patient_visit_patients] FOREIGN KEY([patientID])
REFERENCES [dbo].[patients] ([patientID])
GO
ALTER TABLE [dbo].[patient_visit] CHECK CONSTRAINT [FK_patient_visit_patients]
GO
/****** Object:  ForeignKey [FK_patient_visit_vitals_patient_visit]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_visit_vitals]  WITH CHECK ADD  CONSTRAINT [FK_patient_visit_vitals_patient_visit] FOREIGN KEY([visitID])
REFERENCES [dbo].[patient_visit] ([visitID])
GO
ALTER TABLE [dbo].[patient_visit_vitals] CHECK CONSTRAINT [FK_patient_visit_vitals_patient_visit]
GO
/****** Object:  ForeignKey [FK_patient_visit_symptoms_diagnoses]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_visit_symptoms]  WITH CHECK ADD  CONSTRAINT [FK_patient_visit_symptoms_diagnoses] FOREIGN KEY([diagnoses_diagnosesID])
REFERENCES [dbo].[diagnoses] ([diagnosesID])
GO
ALTER TABLE [dbo].[patient_visit_symptoms] CHECK CONSTRAINT [FK_patient_visit_symptoms_diagnoses]
GO
/****** Object:  ForeignKey [FK_patient_visit_symptoms_patient_visit]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_visit_symptoms]  WITH CHECK ADD  CONSTRAINT [FK_patient_visit_symptoms_patient_visit] FOREIGN KEY([visitID])
REFERENCES [dbo].[patient_visit] ([visitID])
GO
ALTER TABLE [dbo].[patient_visit_symptoms] CHECK CONSTRAINT [FK_patient_visit_symptoms_patient_visit]
GO
/****** Object:  ForeignKey [FK_patient_visit_notes_patient_visit]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_visit_notes]  WITH CHECK ADD  CONSTRAINT [FK_patient_visit_notes_patient_visit] FOREIGN KEY([visitID])
REFERENCES [dbo].[patient_visit] ([visitID])
GO
ALTER TABLE [dbo].[patient_visit_notes] CHECK CONSTRAINT [FK_patient_visit_notes_patient_visit]
GO
/****** Object:  ForeignKey [FK_patient_tests_patient_visit]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_tests]  WITH CHECK ADD  CONSTRAINT [FK_patient_tests_patient_visit] FOREIGN KEY([visitID])
REFERENCES [dbo].[patient_visit] ([visitID])
GO
ALTER TABLE [dbo].[patient_tests] CHECK CONSTRAINT [FK_patient_tests_patient_visit]
GO
/****** Object:  ForeignKey [FK_patient_tests_tests]    Script Date: 03/22/2015 11:00:33 ******/
ALTER TABLE [dbo].[patient_tests]  WITH CHECK ADD  CONSTRAINT [FK_patient_tests_tests] FOREIGN KEY([testID])
REFERENCES [dbo].[tests] ([testID])
GO
ALTER TABLE [dbo].[patient_tests] CHECK CONSTRAINT [FK_patient_tests_tests]
GO

/****** Change to encrypted passwords ******/
update employees set password = '029221038231213239247084149013207149222140232099' where employeeID = 4;
update employees set password = '207168175253114192077158076072101068245187231207' where employeeID = 8;
update employees set password = '238173117193055220096111020011087231218085091014', login= 'admin' where employeeID = 10;

ALTER TABLE patient_allergies ADD CONSTRAINT uq_patient_allergies UNIQUE (patientID, allergyID);

Insert into allergies(allergy_name, enabled)values ('penicillian', 1);
Insert into allergies(allergy_name, enabled)values ('pollen', 1);
Insert into allergies(allergy_name, enabled)values ('bees', 1);
Insert into allergies(allergy_name, enabled)values ('sulfa drugs', 1);
Insert into allergies(allergy_name, enabled)values ('peanuts', 1);
Insert into allergies(allergy_name, enabled)values ('shellfish', 1);