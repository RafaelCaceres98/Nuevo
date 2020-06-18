CREATE TABLESPACE ProyectoCredySoft DATAFILE 'C:\app\norma\product\18.0.0\oradata\XE\XEPDB1\CredySoft.ora' SIZE 30m;
alter session set "_ORACLE_SCRIPT"=true;
CREATE ROLE CredySoftAdmi;
GRANT ALL PRIVILEGES to CredySoftAdmi;
CREATE USER AdmiCredy IDENTIFIED BY 1234 DEFAULT TABLESPACE ProyectoCredySoft;
GRANT CREATE TRIGGER to AdmiCredy;
GRANT CREATE PROCEDURE TO AdmiCredy;
GRANT CREATE SEQUENCE TO AdmiCRedy;
GRANT UNLIMITED TABLESPACE To ADmiCREdy;
GRANT CredySoftAdmi TO AdmiCredy;