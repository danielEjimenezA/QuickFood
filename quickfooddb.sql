/*
 Navicat Premium Data Transfer

 Source Server         : 127.0.0.1
 Source Server Type    : MySQL
 Source Server Version : 80025
 Source Host           : localhost:3306
 Source Schema         : quickfooddb

 Target Server Type    : MySQL
 Target Server Version : 80025
 File Encoding         : 65001

 Date: 15/07/2021 19:31:47
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for cliente
-- ----------------------------
DROP TABLE IF EXISTS `cliente`;
CREATE TABLE `cliente`  (
  `cltId` int(0) NOT NULL,
  `cltNombre` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `cltTelefono` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `cltDireccion` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `cltIdentificacion` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`cltId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mesero
-- ----------------------------
DROP TABLE IF EXISTS `mesero`;
CREATE TABLE `mesero`  (
  `msrId` int(0) NOT NULL,
  `msrNombre` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `msrIdentificacion` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`msrId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for pedido
-- ----------------------------
DROP TABLE IF EXISTS `pedido`;
CREATE TABLE `pedido`  (
  `pddId` int(0) NOT NULL,
  `pddFecha` datetime(0) NULL DEFAULT NULL,
  `pddEstado` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `cltId` int(0) NULL DEFAULT NULL,
  `msrId` int(0) NULL DEFAULT NULL,
  PRIMARY KEY (`pddId`) USING BTREE,
  INDEX `FK_pedido_mesero`(`msrId`) USING BTREE,
  INDEX `FK_pedido_cliente`(`cltId`) USING BTREE,
  CONSTRAINT `FK_pedido_cliente` FOREIGN KEY (`cltId`) REFERENCES `cliente` (`cltId`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_pedido_mesero` FOREIGN KEY (`msrId`) REFERENCES `mesero` (`msrId`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for pedidodetalle
-- ----------------------------
DROP TABLE IF EXISTS `pedidodetalle`;
CREATE TABLE `pedidodetalle`  (
  `pdeId` int(0) NOT NULL,
  `pdeDescripcion` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `pddId` int(0) NULL DEFAULT NULL,
  `pltId` int(0) NULL DEFAULT NULL,
  PRIMARY KEY (`pdeId`) USING BTREE,
  INDEX `FK_pedidodetalle_pedido`(`pddId`) USING BTREE,
  INDEX `FK_pedidodetalle_plato`(`pltId`) USING BTREE,
  CONSTRAINT `FK_pedidodetalle_pedido` FOREIGN KEY (`pddId`) REFERENCES `pedido` (`pddId`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_pedidodetalle_plato` FOREIGN KEY (`pltId`) REFERENCES `plato` (`pltId`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for plato
-- ----------------------------
DROP TABLE IF EXISTS `plato`;
CREATE TABLE `plato`  (
  `pltId` int(0) NOT NULL,
  `pltDescripcion` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `pltEstado` char(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`pltId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
