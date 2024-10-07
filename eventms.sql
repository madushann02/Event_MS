-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 05, 2024 at 09:11 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eventms`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `tp` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `name`, `password`, `email`, `tp`) VALUES
('654565', 'admin', '1234', 'admin@gmail.com', '1658497');

-- --------------------------------------------------------

--
-- Table structure for table `bookedevents`
--

CREATE TABLE `bookedevents` (
  `bookingid` int(50) NOT NULL,
  `eventid` varchar(100) NOT NULL,
  `memberid` varchar(100) NOT NULL,
  `eventname` varchar(100) NOT NULL,
  `eventtype` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bookedevents`
--

INSERT INTO `bookedevents` (`bookingid`, `eventid`, `memberid`, `eventname`, `eventtype`) VALUES
(1, '1', '222222165644', 'vdbsdgds', 'gggerhrh');

-- --------------------------------------------------------

--
-- Table structure for table `manageevents`
--

CREATE TABLE `manageevents` (
  `eventid` int(50) NOT NULL,
  `eventname` varchar(100) NOT NULL,
  `eventtype` varchar(100) NOT NULL,
  `eventvenue` varchar(100) NOT NULL,
  `ticketprice` varchar(100) NOT NULL,
  `ticketsavailable` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `manageevents`
--

INSERT INTO `manageevents` (`eventid`, `eventname`, `eventtype`, `eventvenue`, `ticketprice`, `ticketsavailable`) VALUES
(1, 'vdbsdgds', 'hrhrhrhrh', 'gggerhrh', 'hrhrhrwe', '5645466');

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `ID` varchar(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `tp` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`ID`, `Name`, `password`, `email`, `tp`) VALUES
('021', 'dinu', '1235', 'drm@gmail.com', '765849851'),
('2222221555', 'maleesha', '1234', 'dm@gmail.com', '765849851'),
('222222165644', 'dinidu', '123', 'dm@gmail.com', '765849851');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `NAME` varchar(100) NOT NULL,
  `PASSWORD` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `bookedevents`
--
ALTER TABLE `bookedevents`
  ADD PRIMARY KEY (`bookingid`);

--
-- Indexes for table `manageevents`
--
ALTER TABLE `manageevents`
  ADD PRIMARY KEY (`eventid`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bookedevents`
--
ALTER TABLE `bookedevents`
  MODIFY `bookingid` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `manageevents`
--
ALTER TABLE `manageevents`
  MODIFY `eventid` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
