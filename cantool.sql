/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50087
Source Host           : localhost:3306
Source Database       : cantool

Target Server Type    : MYSQL
Target Server Version : 50087
File Encoding         : 65001

Date: 2017-10-26 14:29:23
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `can_message`
-- ----------------------------
DROP TABLE IF EXISTS `can_message`;
CREATE TABLE `can_message` (
  `signal_id` int(11) NOT NULL auto_increment,
  `signal_name` varchar(255) NOT NULL,
  `signal_value` varchar(255) NOT NULL,
  `time` date NOT NULL,
  PRIMARY KEY  (`signal_id`)
) ENGINE=InnoDB AUTO_INCREMENT=164 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of can_message
-- ----------------------------
INSERT INTO `can_message` VALUES ('1', 'mx', '100', '2017-10-17');
INSERT INTO `can_message` VALUES ('2', 'mx1', '12', '0000-00-00');
INSERT INTO `can_message` VALUES ('3', 'mx2', '13', '0000-00-00');
INSERT INTO `can_message` VALUES ('4', 'mx4', '12', '0000-00-00');
INSERT INTO `can_message` VALUES ('5', 'mx', '15', '2017-10-25');
INSERT INTO `can_message` VALUES ('6', 'mx', '20', '2017-10-14');
INSERT INTO `can_message` VALUES ('7', 'HVAC', '10', '2017-10-12');
INSERT INTO `can_message` VALUES ('8', 'HVAC', '20', '2017-10-27');
INSERT INTO `can_message` VALUES ('9', 'HVAC', '50', '2017-10-28');
INSERT INTO `can_message` VALUES ('10', 'CDU_HVACOffButtonSt', '1', '2017-10-25');
INSERT INTO `can_message` VALUES ('11', 'CDU_HVACOffButtonStVD', '0', '2017-10-25');
INSERT INTO `can_message` VALUES ('12', 'CDU_HVACAutoModeButtonSt', '0', '2017-10-25');
INSERT INTO `can_message` VALUES ('13', 'CDU_HVACAutoModeButtonStVD', '0', '2017-10-25');
INSERT INTO `can_message` VALUES ('14', 'CDU_HVACFDefrostButtonSt', '0', '2017-10-25');
INSERT INTO `can_message` VALUES ('15', 'CDU_HVACFDefrostButtonStVD', '0', '2017-10-25');
INSERT INTO `can_message` VALUES ('16', 'CDU_HVACDualButtonSt', '0', '2017-10-25');
INSERT INTO `can_message` VALUES ('17', 'CDU_HVACDualButtonStVD', '0', '2017-10-25');
INSERT INTO `can_message` VALUES ('18', 'CDU_HVACIonButtonSt', '0', '2017-10-25');
INSERT INTO `can_message` VALUES ('19', 'CDU_HVACIonButtonStVD', '1', '2017-10-25');
INSERT INTO `can_message` VALUES ('20', 'CDU_HVACCirculationButtonSt', '0', '2017-10-25');
INSERT INTO `can_message` VALUES ('21', 'CDU_HVACCirculationButtonStVD', '0', '2017-10-25');
INSERT INTO `can_message` VALUES ('22', 'CDU_HVACACButtonSt', '1', '2017-10-25');
INSERT INTO `can_message` VALUES ('23', 'CDU_HVACACButtonStVD', '1', '2017-10-25');
INSERT INTO `can_message` VALUES ('24', 'CDU_HVACACMaxButtonSt', '0', '2017-10-25');
INSERT INTO `can_message` VALUES ('25', 'CDU_HVACACMaxButtonStVD', '0', '2017-10-25');
INSERT INTO `can_message` VALUES ('26', 'CDU_HVACModeButtonSt', '4', '2017-10-25');
INSERT INTO `can_message` VALUES ('27', 'HVAC_WindExitSpd', '8', '2017-10-25');
INSERT INTO `can_message` VALUES ('28', 'CDU_HVAC_DriverTempSelect', '28.5', '2017-10-25');
INSERT INTO `can_message` VALUES ('29', 'HVAC_PsnTempSelect', '21', '2017-10-25');
INSERT INTO `can_message` VALUES ('30', 'CDU_HVACCtrlModeSt', '7', '2017-10-25');
INSERT INTO `can_message` VALUES ('31', 'CDU_ControlSt', '0', '2017-10-25');
INSERT INTO `can_message` VALUES ('32', 'CDU_HVACOffButtonSt', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('33', 'CDU_HVACOffButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('34', 'CDU_HVACAutoModeButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('35', 'CDU_HVACAutoModeButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('36', 'CDU_HVACFDefrostButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('37', 'CDU_HVACFDefrostButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('38', 'CDU_HVACDualButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('39', 'CDU_HVACDualButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('40', 'CDU_HVACIonButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('41', 'CDU_HVACIonButtonStVD', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('42', 'CDU_HVACCirculationButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('43', 'CDU_HVACCirculationButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('44', 'CDU_HVACACButtonSt', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('45', 'CDU_HVACACButtonStVD', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('46', 'CDU_HVACACMaxButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('47', 'CDU_HVACACMaxButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('48', 'CDU_HVACModeButtonSt', '4', '2017-10-26');
INSERT INTO `can_message` VALUES ('49', 'HVAC_WindExitSpd', '8', '2017-10-26');
INSERT INTO `can_message` VALUES ('50', 'CDU_HVAC_DriverTempSelect', '28.5', '2017-10-26');
INSERT INTO `can_message` VALUES ('51', 'HVAC_PsnTempSelect', '21', '2017-10-26');
INSERT INTO `can_message` VALUES ('52', 'CDU_HVACCtrlModeSt', '7', '2017-10-26');
INSERT INTO `can_message` VALUES ('53', 'CDU_ControlSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('54', 'CDU_HVACOffButtonSt', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('55', 'CDU_HVACOffButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('56', 'CDU_HVACAutoModeButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('57', 'CDU_HVACAutoModeButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('58', 'CDU_HVACFDefrostButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('59', 'CDU_HVACFDefrostButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('60', 'CDU_HVACDualButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('61', 'CDU_HVACDualButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('62', 'CDU_HVACIonButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('63', 'CDU_HVACIonButtonStVD', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('64', 'CDU_HVACCirculationButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('65', 'CDU_HVACCirculationButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('66', 'CDU_HVACACButtonSt', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('67', 'CDU_HVACACButtonStVD', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('68', 'CDU_HVACACMaxButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('69', 'CDU_HVACACMaxButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('70', 'CDU_HVACModeButtonSt', '4', '2017-10-26');
INSERT INTO `can_message` VALUES ('71', 'HVAC_WindExitSpd', '8', '2017-10-26');
INSERT INTO `can_message` VALUES ('72', 'CDU_HVAC_DriverTempSelect', '28.5', '2017-10-26');
INSERT INTO `can_message` VALUES ('73', 'HVAC_PsnTempSelect', '21', '2017-10-26');
INSERT INTO `can_message` VALUES ('74', 'CDU_HVACCtrlModeSt', '7', '2017-10-26');
INSERT INTO `can_message` VALUES ('75', 'CDU_ControlSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('76', 'CDU_HVACOffButtonSt', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('77', 'CDU_HVACOffButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('78', 'CDU_HVACAutoModeButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('79', 'CDU_HVACAutoModeButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('80', 'CDU_HVACFDefrostButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('81', 'CDU_HVACFDefrostButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('82', 'CDU_HVACDualButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('83', 'CDU_HVACDualButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('84', 'CDU_HVACIonButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('85', 'CDU_HVACIonButtonStVD', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('86', 'CDU_HVACCirculationButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('87', 'CDU_HVACCirculationButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('88', 'CDU_HVACACButtonSt', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('89', 'CDU_HVACACButtonStVD', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('90', 'CDU_HVACACMaxButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('91', 'CDU_HVACACMaxButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('92', 'CDU_HVACModeButtonSt', '4', '2017-10-26');
INSERT INTO `can_message` VALUES ('93', 'HVAC_WindExitSpd', '8', '2017-10-26');
INSERT INTO `can_message` VALUES ('94', 'CDU_HVAC_DriverTempSelect', '28.5', '2017-10-26');
INSERT INTO `can_message` VALUES ('95', 'HVAC_PsnTempSelect', '21', '2017-10-26');
INSERT INTO `can_message` VALUES ('96', 'CDU_HVACCtrlModeSt', '7', '2017-10-26');
INSERT INTO `can_message` VALUES ('97', 'CDU_ControlSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('98', 'CDU_HVACOffButtonSt', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('99', 'CDU_HVACOffButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('100', 'CDU_HVACAutoModeButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('101', 'CDU_HVACAutoModeButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('102', 'CDU_HVACFDefrostButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('103', 'CDU_HVACFDefrostButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('104', 'CDU_HVACDualButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('105', 'CDU_HVACDualButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('106', 'CDU_HVACIonButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('107', 'CDU_HVACIonButtonStVD', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('108', 'CDU_HVACCirculationButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('109', 'CDU_HVACCirculationButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('110', 'CDU_HVACACButtonSt', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('111', 'CDU_HVACACButtonStVD', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('112', 'CDU_HVACACMaxButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('113', 'CDU_HVACACMaxButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('114', 'CDU_HVACModeButtonSt', '4', '2017-10-26');
INSERT INTO `can_message` VALUES ('115', 'HVAC_WindExitSpd', '8', '2017-10-26');
INSERT INTO `can_message` VALUES ('116', 'CDU_HVAC_DriverTempSelect', '28.5', '2017-10-26');
INSERT INTO `can_message` VALUES ('117', 'HVAC_PsnTempSelect', '21', '2017-10-26');
INSERT INTO `can_message` VALUES ('118', 'CDU_HVACCtrlModeSt', '7', '2017-10-26');
INSERT INTO `can_message` VALUES ('119', 'CDU_ControlSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('120', 'CDU_HVACOffButtonSt', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('121', 'CDU_HVACOffButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('122', 'CDU_HVACAutoModeButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('123', 'CDU_HVACAutoModeButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('124', 'CDU_HVACFDefrostButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('125', 'CDU_HVACFDefrostButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('126', 'CDU_HVACDualButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('127', 'CDU_HVACDualButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('128', 'CDU_HVACIonButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('129', 'CDU_HVACIonButtonStVD', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('130', 'CDU_HVACCirculationButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('131', 'CDU_HVACCirculationButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('132', 'CDU_HVACACButtonSt', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('133', 'CDU_HVACACButtonStVD', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('134', 'CDU_HVACACMaxButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('135', 'CDU_HVACACMaxButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('136', 'CDU_HVACModeButtonSt', '4', '2017-10-26');
INSERT INTO `can_message` VALUES ('137', 'HVAC_WindExitSpd', '8', '2017-10-26');
INSERT INTO `can_message` VALUES ('138', 'CDU_HVAC_DriverTempSelect', '28.5', '2017-10-26');
INSERT INTO `can_message` VALUES ('139', 'HVAC_PsnTempSelect', '21', '2017-10-26');
INSERT INTO `can_message` VALUES ('140', 'CDU_HVACCtrlModeSt', '7', '2017-10-26');
INSERT INTO `can_message` VALUES ('141', 'CDU_ControlSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('142', 'CDU_HVACOffButtonSt', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('143', 'CDU_HVACOffButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('144', 'CDU_HVACAutoModeButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('145', 'CDU_HVACAutoModeButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('146', 'CDU_HVACFDefrostButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('147', 'CDU_HVACFDefrostButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('148', 'CDU_HVACDualButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('149', 'CDU_HVACDualButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('150', 'CDU_HVACIonButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('151', 'CDU_HVACIonButtonStVD', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('152', 'CDU_HVACCirculationButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('153', 'CDU_HVACCirculationButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('154', 'CDU_HVACACButtonSt', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('155', 'CDU_HVACACButtonStVD', '1', '2017-10-26');
INSERT INTO `can_message` VALUES ('156', 'CDU_HVACACMaxButtonSt', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('157', 'CDU_HVACACMaxButtonStVD', '0', '2017-10-26');
INSERT INTO `can_message` VALUES ('158', 'CDU_HVACModeButtonSt', '4', '2017-10-26');
INSERT INTO `can_message` VALUES ('159', 'HVAC_WindExitSpd', '8', '2017-10-26');
INSERT INTO `can_message` VALUES ('160', 'CDU_HVAC_DriverTempSelect', '28.5', '2017-10-26');
INSERT INTO `can_message` VALUES ('161', 'HVAC_PsnTempSelect', '21', '2017-10-26');
INSERT INTO `can_message` VALUES ('162', 'CDU_HVACCtrlModeSt', '7', '2017-10-26');
INSERT INTO `can_message` VALUES ('163', 'CDU_ControlSt', '0', '2017-10-26');
