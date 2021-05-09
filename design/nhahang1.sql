/*==============================================================*/
/* DBMS name:      Sybase SQL Anywhere 12                       */
/* Created on:     2/25/2021 9:26:53 PM                         */
/*==============================================================*/
create database nhahang;
use nhahang;

if exists(select 1 from sys.sysforeignkey where role='FK_ORDERLIS_FOOD_DETA_FOODS') then
    alter table ORDERLIST
       delete foreign key FK_ORDERLIS_FOOD_DETA_FOODS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ORDERLIS_LIST_OF_F_ORDERS') then
    alter table ORDERLIST
       delete foreign key FK_ORDERLIS_LIST_OF_F_ORDERS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ORDERLIS_STAFF_ORD_STAFFS') then
    alter table ORDERLIST
       delete foreign key FK_ORDERLIS_STAFF_ORD_STAFFS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ORDERS_ORDER_DET_TABLES') then
    alter table ORDERS
       delete foreign key FK_ORDERS_ORDER_DET_TABLES
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ORDERS_STAFF_PAY_STAFFS') then
    alter table ORDERS
       delete foreign key FK_ORDERS_STAFF_PAY_STAFFS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ORDERSTA_ORDERS_ST_ORDERS') then
    alter table ORDERSTATUS
       delete foreign key FK_ORDERSTA_ORDERS_ST_ORDERS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_STAFFS_STAFF_PAY_ORDERS') then
    alter table STAFFS
       delete foreign key FK_STAFFS_STAFF_PAY_ORDERS
end if;

drop index if exists FOODS.FOODS_PK;

drop table if exists FOODS;

drop index if exists ORDERLIST.STAFF_ORDER_FK;

drop index if exists ORDERLIST.FOOD_DETAILS_FK;

drop index if exists ORDERLIST.LIST_OF_FOODS_FK;

drop index if exists ORDERLIST.ORDERLIST_PK;

drop table if exists ORDERLIST;

drop index if exists ORDERS.STAFF_PAYMENT2_FK;

drop index if exists ORDERS.ORDER_DETAILS_FK;

drop index if exists ORDERS.ORDERS_PK;

drop table if exists ORDERS;

drop index if exists ORDERSTATUS.ORDERS_STATUS_FK;

drop index if exists ORDERSTATUS.ORDERSTATUS_PK;

drop table if exists ORDERSTATUS;

drop index if exists STAFFS.STAFF_PAYMENT_FK;

drop index if exists STAFFS.STAFFS_PK;

drop table if exists STAFFS;

drop index if exists TABLES.TABLES_PK;

drop table if exists TABLES;


/*==============================================================*/
/* Table: FOODS                                                 */
/*==============================================================*/
create table FOODS 
(
   FOODID               integer                        not null AUTO_INCREMENT,
   FOODNAME             varchar(50)                    null,
   FOODPRICE            numeric                        null,
   FOODKIND             varchar(50)                    null,
   constraint PK_FOODS primary key (FOODID)
);

/*==============================================================*/
/* Index: FOODS_PK                                              */
/*==============================================================*/
create unique index FOODS_PK on FOODS (
FOODID ASC
);

/*==============================================================*/
/* Table: ORDERLIST                                             */
/*==============================================================*/
create table ORDERLIST 
(
   ORDERSID             integer                        not null AUTO_INCREMENT,
   FOODID               integer                        not null,
   STAFFID              integer                        null,
   QUANTITY             numeric                        null,
   constraint PK_ORDERLIST primary key clustered (ORDERSID, FOODID)
);

/*==============================================================*/
/* Index: ORDERLIST_PK                                          */
/*==============================================================*/
DELIMITER //
create unique clustered index ORDERLIST_PK on ORDERLIST (
ORDERSID ASC,
FOODID ASC
);
DELIMITER ;
/*==============================================================*/
/* Index: LIST_OF_FOODS_FK                                      */
/*==============================================================*/
create index LIST_OF_FOODS_FK on ORDERLIST (
ORDERSID ASC
);

/*==============================================================*/
/* Index: FOOD_DETAILS_FK                                       */
/*==============================================================*/
create index FOOD_DETAILS_FK on ORDERLIST (
FOODID ASC
);

/*==============================================================*/
/* Index: STAFF_ORDER_FK                                        */
/*==============================================================*/
create index STAFF_ORDER_FK on ORDERLIST (
STAFFID ASC
);

/*==============================================================*/
/* Table: ORDERS                                                */
/*==============================================================*/
create table ORDERS 
(
   ORDERSID             integer                        not null AUTO_INCREMENT,
   STAFFID              integer                        null,
   TABLEID              integer                        null,
   ORDERNOTE            long varchar                   null,
   CUSTOMERNAME         varchar(20)                    null,
   constraint PK_ORDERS primary key (ORDERSID)
);

/*==============================================================*/
/* Index: ORDERS_PK                                             */
/*==============================================================*/
create unique index ORDERS_PK on ORDERS (
ORDERSID ASC
);

/*==============================================================*/
/* Index: ORDER_DETAILS_FK                                      */
/*==============================================================*/
create index ORDER_DETAILS_FK on ORDERS (
TABLEID ASC
);

/*==============================================================*/
/* Index: STAFF_PAYMENT2_FK                                     */
/*==============================================================*/
create index STAFF_PAYMENT2_FK on ORDERS (
STAFFID ASC
);

/*==============================================================*/
/* Table: ORDERSTATUS                                           */
/*==============================================================*/
create table ORDERSTATUS 
(
   ORDERSTATUSID        integer                        not null AUTO_INCREMENT,
   ORDERSID             integer                        null,
   STATUS               varchar(20)                    null,
   constraint PK_ORDERSTATUS primary key (ORDERSTATUSID)
);

/*==============================================================*/
/* Index: ORDERSTATUS_PK                                        */
/*==============================================================*/
create unique index ORDERSTATUS_PK on ORDERSTATUS (
ORDERSTATUSID ASC
);

/*==============================================================*/
/* Index: ORDERS_STATUS_FK                                      */
/*==============================================================*/
create index ORDERS_STATUS_FK on ORDERSTATUS (
ORDERSID ASC
);

/*==============================================================*/
/* Table: STAFFS                                                */
/*==============================================================*/
create table STAFFS 
(
   STAFFID              integer                        not null AUTO_INCREMENT,
   ORDERSID             integer                        null,
   USERNAME             varchar(10)                    null,
   PASSWORD             varchar(10)                    null,
   STAFFNAME            varchar(20)                    null,
   constraint PK_STAFFS primary key (STAFFID)
);

/*==============================================================*/
/* Index: STAFFS_PK                                             */
/*==============================================================*/
create unique index STAFFS_PK on STAFFS (
STAFFID ASC
);

/*==============================================================*/
/* Index: STAFF_PAYMENT_FK                                      */
/*==============================================================*/
create index STAFF_PAYMENT_FK on STAFFS (
ORDERSID ASC
);

/*==============================================================*/
/* Table: TABLES                                                */
/*==============================================================*/
create table TABLES 
(
   TABLEID              integer                        not null AUTO_INCREMENT,
   TABLENAME            varchar(5)                     null,
   TABLESTATUS          smallint                       null,
   OPENTIME             timestamp                      null,
   CLOSETIME            timestamp                      null,
   constraint PK_TABLES primary key (TABLEID)
);

/*==============================================================*/
/* Index: TABLES_PK                                             */
/*==============================================================*/
create unique index TABLES_PK on TABLES (
TABLEID ASC
);

alter table ORDERLIST
   add constraint FK_ORDERLIS_FOOD_DETA_FOODS foreign key (FOODID)
      references FOODS (FOODID)
      on update restrict
      on delete restrict;

alter table ORDERLIST
   add constraint FK_ORDERLIS_LIST_OF_F_ORDERS foreign key (ORDERSID)
      references ORDERS (ORDERSID)
      on update restrict
      on delete restrict;

alter table ORDERLIST
   add constraint FK_ORDERLIS_STAFF_ORD_STAFFS foreign key (STAFFID)
      references STAFFS (STAFFID)
      on update restrict
      on delete restrict;

alter table ORDERS
   add constraint FK_ORDERS_ORDER_DET_TABLES foreign key (TABLEID)
      references TABLES (TABLEID)
      on update restrict
      on delete restrict;

alter table ORDERS
   add constraint FK_ORDERS_STAFF_PAY_STAFFS foreign key (STAFFID)
      references STAFFS (STAFFID)
      on update restrict
      on delete restrict;

alter table ORDERSTATUS
   add constraint FK_ORDERSTA_ORDERS_ST_ORDERS foreign key (ORDERSID)
      references ORDERS (ORDERSID)
      on update restrict
      on delete restrict;

alter table STAFFS
   add constraint FK_STAFFS_STAFF_PAY_ORDERS foreign key (ORDERSID)
      references ORDERS (ORDERSID)
      on update restrict
      on delete restrict;

