/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50719
Source Host           : localhost:3306
Source Database       : jldb

Target Server Type    : MYSQL
Target Server Version : 50719
File Encoding         : 65001

Date: 2017-10-27 17:58:36
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `article`
-- ----------------------------
DROP TABLE IF EXISTS `article`;
CREATE TABLE `article` (
  `AutoId` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(256) NOT NULL,
  `Content` text,
  `Picture` varchar(512) DEFAULT NULL,
  `AddTime` datetime DEFAULT NULL,
  `Tags` varchar(256) DEFAULT NULL,
  `PageViews` int(11) DEFAULT NULL,
  `SortIndex` int(11) DEFAULT NULL,
  `Status` char(1) DEFAULT 'N',
  PRIMARY KEY (`AutoId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of article
-- ----------------------------

-- ----------------------------
-- Table structure for `franchisee`
-- ----------------------------
DROP TABLE IF EXISTS `franchisee`;
CREATE TABLE `franchisee` (
  `AutoId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(256) NOT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `Weixin` varchar(128) DEFAULT NULL,
  `Phone` varchar(16) DEFAULT NULL,
  `Address` varchar(256) DEFAULT NULL,
  `Remark` varchar(2048) DEFAULT NULL,
  `ApplyTime` datetime DEFAULT NULL,
  `ProcessTime` datetime DEFAULT NULL,
  `Status` char(1) DEFAULT 'N',
  PRIMARY KEY (`AutoId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of franchisee
-- ----------------------------

-- ----------------------------
-- Table structure for `jl_user`
-- ----------------------------
DROP TABLE IF EXISTS `jl_user`;
CREATE TABLE `jl_user` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(128) DEFAULT NULL,
  `Cellphone` varchar(16) DEFAULT NULL,
  `IsCellphoneConfirmed` bit(1) DEFAULT b'0',
  `Email` varchar(128) DEFAULT NULL,
  `IsEmailConfirmed` bit(1) DEFAULT b'0',
  `RealName` varchar(128) DEFAULT NULL,
  `NickName` varchar(128) DEFAULT NULL,
  `Telephone` varchar(255) DEFAULT NULL,
  `Birthday` date DEFAULT NULL,
  `Gender` char(1) DEFAULT NULL,
  `QQ` varchar(16) DEFAULT NULL,
  `Address` varchar(256) DEFAULT NULL,
  `AddTime` datetime DEFAULT NULL,
  `RegUrl` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of jl_user
-- ----------------------------
INSERT INTO `jl_user` VALUES ('5', 'admin', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('6', 'user001', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('7', 'user100', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('8', 'user101', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('9', 'user102', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('10', 'user103', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('11', 'user104', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('12', 'user105', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('13', 'user106', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('14', 'user107', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('15', 'user108', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('16', 'user109', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('17', 'user110', null, '', null, '', null, null, null, null, null, null, null, null, null);
INSERT INTO `jl_user` VALUES ('18', 'user111', null, '', null, '', null, null, null, null, null, null, null, null, null);

-- ----------------------------
-- Table structure for `material`
-- ----------------------------
DROP TABLE IF EXISTS `material`;
CREATE TABLE `material` (
  `AutoId` int(11) NOT NULL,
  `Title` varchar(64) NOT NULL,
  `Description` varchar(2048) DEFAULT NULL,
  `Picture` varchar(256) DEFAULT NULL,
  `FileName` varchar(256) DEFAULT NULL,
  `MaterialType` char(1) DEFAULT NULL,
  `PageViews` int(11) DEFAULT NULL COMMENT '浏览量/下载量',
  `SortIndex` int(11) DEFAULT '0',
  `Status` char(1) DEFAULT 'N',
  `Url` varchar(512) DEFAULT NULL,
  PRIMARY KEY (`AutoId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of material
-- ----------------------------

-- ----------------------------
-- Table structure for `member`
-- ----------------------------
DROP TABLE IF EXISTS `member`;
CREATE TABLE `member` (
  `AutoId` int(11) NOT NULL,
  `NickName` varchar(64) DEFAULT NULL,
  `RealName` varchar(32) DEFAULT NULL,
  `Description` varchar(1024) DEFAULT NULL,
  `Phone` varchar(16) DEFAULT NULL,
  `Weixin` varchar(16) DEFAULT NULL,
  `QQ` varchar(16) DEFAULT NULL,
  `Email` varchar(64) DEFAULT NULL,
  `Address` varchar(128) DEFAULT NULL,
  `JoinTime` datetime DEFAULT NULL,
  `Picture` varchar(128) DEFAULT NULL,
  `Words` varchar(1024) DEFAULT NULL,
  `SortIndex` int(11) DEFAULT NULL,
  `Status` char(1) DEFAULT 'N',
  PRIMARY KEY (`AutoId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of member
-- ----------------------------

-- ----------------------------
-- Table structure for `product`
-- ----------------------------
DROP TABLE IF EXISTS `product`;
CREATE TABLE `product` (
  `AutoId` int(11) NOT NULL,
  `Name` varchar(128) DEFAULT NULL,
  `Alias` varchar(64) DEFAULT NULL,
  `Description` varchar(2048) DEFAULT NULL,
  `Picture` varchar(1024) DEFAULT NULL,
  `RetailPrice` float DEFAULT NULL,
  `MarketPrice` float DEFAULT NULL,
  `PageViews` int(11) DEFAULT NULL,
  `SortIndex` int(11) DEFAULT NULL,
  `Status` char(1) DEFAULT 'N',
  PRIMARY KEY (`AutoId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of product
-- ----------------------------

-- ----------------------------
-- Table structure for `productcategory`
-- ----------------------------
DROP TABLE IF EXISTS `productcategory`;
CREATE TABLE `productcategory` (
  `AutoId` int(11) NOT NULL,
  `Name` varchar(32) DEFAULT NULL,
  `Alias` varchar(32) DEFAULT NULL,
  `Picture` varchar(128) DEFAULT NULL,
  `Path` varchar(64) DEFAULT NULL,
  `Depth` int(11) DEFAULT NULL,
  `ParentId` int(11) DEFAULT NULL,
  `PageViews` int(11) DEFAULT NULL,
  `SortIndex` int(11) DEFAULT NULL,
  `Status` char(1) DEFAULT 'N',
  PRIMARY KEY (`AutoId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of productcategory
-- ----------------------------

-- ----------------------------
-- Table structure for `webpages_membership`
-- ----------------------------
DROP TABLE IF EXISTS `webpages_membership`;
CREATE TABLE `webpages_membership` (
  `UserId` int(11) NOT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `ConfirmationToken` varchar(128) CHARACTER SET utf8 DEFAULT NULL,
  `IsConfirmed` bit(1) DEFAULT b'0',
  `LastPasswordFailureDate` datetime DEFAULT NULL,
  `PasswordFailuresSinceLastSuccess` int(11) NOT NULL DEFAULT '0',
  `Password` varchar(128) CHARACTER SET utf8 NOT NULL,
  `PasswordChangedDate` datetime DEFAULT NULL,
  `PasswordSalt` varchar(128) CHARACTER SET utf8 NOT NULL,
  `PasswordVerificationToken` varchar(128) CHARACTER SET utf8 DEFAULT NULL,
  `PasswordVerificationTokenExpirationDate` datetime DEFAULT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of webpages_membership
-- ----------------------------
INSERT INTO `webpages_membership` VALUES ('3', '2017-10-16 14:52:27', null, '', '2017-10-16 16:01:21', '1', 'T5C6AQv0yOwQ4/l+WDjgXrWMTLqXYkDF8MREuPP09d7UxavG97d4Qr6v1n92HYpu', '2017-10-16 14:52:27', '', null, null);
INSERT INTO `webpages_membership` VALUES ('4', '2017-10-25 17:12:34', null, '', null, '0', '+tEWIrAJhsvyIJAprLNHn1TehUDzCVmI8QyrCzU32yYwpFXlppnd1qagbhlH/Xc9', '2017-10-25 17:12:34', '', null, null);
INSERT INTO `webpages_membership` VALUES ('5', '2017-10-26 11:33:32', null, '', null, '0', 'AIiMAgS8JIP9xwspsNiMplfsA+kqnVXe03qXTEo0zlMrhLI3NHvlIH3L9YcwLpgjzQ==', '2017-10-26 11:33:32', '', null, null);
INSERT INTO `webpages_membership` VALUES ('6', '2017-10-26 11:33:58', null, '', null, '0', 'AJuMPyC6/rtRfywr4D8yfat6Re9hfOWqfK8YmMkmuoI/wnk/2scMQddj7fXNXxjxxw==', '2017-10-26 11:33:58', '', null, null);
INSERT INTO `webpages_membership` VALUES ('7', '2017-10-26 11:36:39', null, '', null, '0', 'AG7IhymaG3ly63T3igEL9aW0uN4iBtr1joVmZB8NCdeYi3TYk+Lc0r1JjItr0risWg==', '2017-10-26 11:36:39', '', null, null);
INSERT INTO `webpages_membership` VALUES ('8', '2017-10-26 11:41:37', null, '', null, '0', 'AB0se2smcie9H3vC41oxBwvTBdHrD8ENDdy5cbShOrp79J+cg3/wA5OC1kBIvboGfg==', '2017-10-26 11:41:37', '', null, null);
INSERT INTO `webpages_membership` VALUES ('9', '2017-10-26 11:49:03', null, '', null, '0', 'AHo9A+irXpuUGDDLM68jxuVByC2DLCGG2ktb04JJ0rYXBSr2tZ81p9Td8eyvUDyu+Q==', '2017-10-26 11:49:03', '', null, null);
INSERT INTO `webpages_membership` VALUES ('10', '2017-10-26 11:49:57', null, '', null, '0', 'AEJPjH+LyPLXZmMCRHH7t/ZJnSAciuq6clr0t2hjIGj4l86cq68xbAuLQFj9cLNYHw==', '2017-10-26 11:49:57', '', null, null);
INSERT INTO `webpages_membership` VALUES ('11', '2017-10-26 12:03:06', null, '', null, '0', 'AAK9KAQ23n1pCU5aOJSVsYFzcvnvVSD4k6m2kxATgX2MsiK7qA3oO84Gfx2RijrujQ==', '2017-10-26 12:03:06', '', null, null);
INSERT INTO `webpages_membership` VALUES ('12', '2017-10-26 13:56:24', null, '', null, '0', 'ADcvg8xXmD9+B05KZvDBn1Xwl2Z48ghWQeUTRG2fi11LpLHc56RqpywXgXY/R5/NBw==', '2017-10-26 13:56:24', '', null, null);
INSERT INTO `webpages_membership` VALUES ('13', '2017-10-26 13:56:32', null, '', null, '0', 'ADaI+RkuyZa11Wzpbjz5Kf2JZJuya1z45ARb49b/VMVeJxigGjwl6h3JfczBhJLDKQ==', '2017-10-26 13:56:32', '', null, null);
INSERT INTO `webpages_membership` VALUES ('14', '2017-10-26 13:56:34', null, '', null, '0', 'AOMzKFKme/7BYP9kXC9/6ZxGWQo9T2NSvsFZKTIIfB4vkPYFRoxk3dsqowgkGI/gDw==', '2017-10-26 13:56:34', '', null, null);
INSERT INTO `webpages_membership` VALUES ('15', '2017-10-26 13:56:35', null, '', null, '0', 'AHrW+i150+9Yq0CMdzYhYc9d7+cFYwWH3/jQVcbzf43gmTYopQDEUnpnYGPXLr0plA==', '2017-10-26 13:56:35', '', null, null);
INSERT INTO `webpages_membership` VALUES ('16', '2017-10-26 14:03:28', null, '', null, '0', 'AL6iUJ1cOw5aUjZz0gxOiW2rtNFe6Qc7FCxvgCZEjgvUqoz2/n6RvBhxhhQ+sSLoWw==', '2017-10-26 14:03:28', '', null, null);
INSERT INTO `webpages_membership` VALUES ('17', '2017-10-26 14:10:30', null, '', null, '0', 'AGf+3r7Sb+f7WMu20uIlHWkR9RF7AxjiJyjj+AuWGhMh/X7NoVCzTQdOFttvzJFsuQ==', '2017-10-26 14:10:30', '', null, null);
INSERT INTO `webpages_membership` VALUES ('18', '2017-10-26 15:19:52', 'X2Q5UAHw9v_RaefazKe0iA2', '', null, '0', 'ALmJKcdoow6RIqYWjFMh5DsVSb3FgON98rb/5WtXV3sQyuANhXavyAkmPEoT45Exfw==', '2017-10-26 15:19:52', '', null, null);

-- ----------------------------
-- Table structure for `webpages_oauthmembership`
-- ----------------------------
DROP TABLE IF EXISTS `webpages_oauthmembership`;
CREATE TABLE `webpages_oauthmembership` (
  `Provider` varchar(30) CHARACTER SET utf8 NOT NULL,
  `ProviderUserId` varchar(100) CHARACTER SET utf8 NOT NULL,
  `UserId` int(11) NOT NULL,
  PRIMARY KEY (`Provider`,`ProviderUserId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of webpages_oauthmembership
-- ----------------------------

-- ----------------------------
-- Table structure for `webpages_oauthtoken`
-- ----------------------------
DROP TABLE IF EXISTS `webpages_oauthtoken`;
CREATE TABLE `webpages_oauthtoken` (
  `Token` varchar(100) CHARACTER SET utf8 NOT NULL,
  `Secret` varchar(100) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`Token`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of webpages_oauthtoken
-- ----------------------------

-- ----------------------------
-- Table structure for `webpages_roles`
-- ----------------------------
DROP TABLE IF EXISTS `webpages_roles`;
CREATE TABLE `webpages_roles` (
  `RoleId` int(11) NOT NULL AUTO_INCREMENT,
  `RoleName` varchar(256) NOT NULL,
  PRIMARY KEY (`RoleId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of webpages_roles
-- ----------------------------
INSERT INTO `webpages_roles` VALUES ('1', 'admin');
INSERT INTO `webpages_roles` VALUES ('2', 'user');

-- ----------------------------
-- Table structure for `webpages_usersinroles`
-- ----------------------------
DROP TABLE IF EXISTS `webpages_usersinroles`;
CREATE TABLE `webpages_usersinroles` (
  `UserId` int(11) NOT NULL,
  `RoleId` int(11) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `fk_RoleId` (`RoleId`),
  CONSTRAINT `fk_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `webpages_roles` (`RoleId`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of webpages_usersinroles
-- ----------------------------
INSERT INTO `webpages_usersinroles` VALUES ('5', '1');
INSERT INTO `webpages_usersinroles` VALUES ('6', '2');
INSERT INTO `webpages_usersinroles` VALUES ('7', '2');
INSERT INTO `webpages_usersinroles` VALUES ('8', '2');
INSERT INTO `webpages_usersinroles` VALUES ('9', '2');
INSERT INTO `webpages_usersinroles` VALUES ('10', '2');
INSERT INTO `webpages_usersinroles` VALUES ('11', '2');
INSERT INTO `webpages_usersinroles` VALUES ('12', '2');
INSERT INTO `webpages_usersinroles` VALUES ('13', '2');
INSERT INTO `webpages_usersinroles` VALUES ('14', '2');
INSERT INTO `webpages_usersinroles` VALUES ('15', '2');
INSERT INTO `webpages_usersinroles` VALUES ('16', '2');
INSERT INTO `webpages_usersinroles` VALUES ('17', '2');
INSERT INTO `webpages_usersinroles` VALUES ('18', '2');

-- ----------------------------
-- Procedure structure for `procPageQuery`
-- ----------------------------
DROP PROCEDURE IF EXISTS `procPageQuery`;
DELIMITER ;;
CREATE DEFINER=`chenye`@`%` PROCEDURE `procPageQuery`(in page int,
 in pagesize int,
 in fields varchar(1000),
 in tablename varchar(512),
 in filter varchar(512) ,in orderby varchar(128),in primarykey varchar(32))
    COMMENT '分页存储过程'
BEGIN
 if pagesize<=1 then
  set pagesize=20;
 end if;
 if page < 1 then
  set page = 1;
 end if;

 if(length(trim(filter))>0) then
  set filter=concat(' where ',filter);
 end if;

 set @sqlTmp=concat('select @startid:=',primarykey		
		,' from '
		,tablename,' '
		,filter,
		' order by '
		,primarykey
		,' asc limit '
		,(page-1)*pagesize,',1');

 prepare stmsql from @sqlTmp;
 execute stmsql ;
 deallocate prepare stmsql;
 
 if(length(trim(orderby))>0) then
  set orderby=concat(' , ',orderby);
 end if;

 set @strsql = concat('select '
		,`fields`
		,' from '
		,tablename
		,' where '
		,primarykey
		,' >='
		,@startId 
		,' ',filter
		,' order by '
		,primarykey
		,' asc '
		,orderby
		,' limit ',pagesize);
 prepare stmtsql from @strsql;
 execute stmtsql;
 deallocate prepare stmtsql;

 set @strsqlcount=concat('select count(1) as count from ',tablename,' ',filter);
 prepare stmtsqlcount from @strsqlcount;
 execute stmtsqlcount;
 deallocate prepare stmtsqlcount;
END
;;
DELIMITER ;
