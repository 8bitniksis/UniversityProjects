-- Database: defectoscopy

-- DROP DATABASE defectoscopy;

CREATE DATABASE defectoscopy
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Russian_Russia.1251'
    LC_CTYPE = 'Russian_Russia.1251'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;

-- Table: public.typeapparatus

-- DROP TABLE public.typeapparatus;

CREATE TABLE public.typeapparatus
(
    idtypeapparatus integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    nametype text COLLATE pg_catalog."default" NOT NULL,
    destypeapparatus text COLLATE pg_catalog."default",
    CONSTRAINT typeapparatus_pkey PRIMARY KEY (idtypeapparatus)
)

TABLESPACE pg_default;

ALTER TABLE public.typeapparatus
    OWNER to postgres;
-- Table: public.plancontrol

-- DROP TABLE public.plancontrol;

CREATE TABLE public.plancontrol
(
    idplan integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    dateplan date NOT NULL,
    levelcontrol text COLLATE pg_catalog."default" NOT NULL,
    idapparatus integer NOT NULL,
    CONSTRAINT plancontrol_pkey PRIMARY KEY (idplan),
    CONSTRAINT fk_apparatus FOREIGN KEY (idapparatus)
        REFERENCES public.apparatus (idapparatus) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE public.plancontrol
    OWNER to postgres;
-- Table: public.factcontrol

-- DROP TABLE public.factcontrol;

CREATE TABLE public.factcontrol
(
    idfact integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    datefact date NOT NULL,
    idplan integer NOT NULL,
    idemployee integer NOT NULL,
    resultcontorol text COLLATE pg_catalog."default",
    CONSTRAINT factcontrol_pkey PRIMARY KEY (idfact),
    CONSTRAINT fk_plan_fact FOREIGN KEY (idplan)
        REFERENCES public.plancontrol (idplan) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE public.factcontrol
    OWNER to postgres;
-- Table: public.employees

-- DROP TABLE public.employees;

CREATE TABLE public.employees
(
    idemployee integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    nameemployee text COLLATE pg_catalog."default" NOT NULL,
    positionemployee text COLLATE pg_catalog."default" NOT NULL,
    loginemployee text COLLATE pg_catalog."default",
    passwordemployee text COLLATE pg_catalog."default",
    CONSTRAINT employees_pkey PRIMARY KEY (idemployee)
)

TABLESPACE pg_default;

ALTER TABLE public.employees
    OWNER to postgres;
-- Table: public.apparatus

-- DROP TABLE public.apparatus;

CREATE TABLE public.apparatus
(
    nameapparatus text COLLATE pg_catalog."default" NOT NULL,
    inventorynumber text COLLATE pg_catalog."default" NOT NULL,
    idapparatus integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    idtypeapparatus integer NOT NULL,
    characteristicsapparatus text COLLATE pg_catalog."default",
    CONSTRAINT apparatus_pkey PRIMARY KEY (idapparatus),
    CONSTRAINT fk_typy_apparatus FOREIGN KEY (idtypeapparatus)
        REFERENCES public.typeapparatus (idtypeapparatus) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE public.apparatus
    OWNER to postgres;
-- View: public.planapparatus

-- DROP VIEW public.planapparatus;

CREATE OR REPLACE VIEW public.planapparatus
 AS
 SELECT apparatus.nameapparatus,
    plancontrol.levelcontrol,
    plancontrol.dateplan
   FROM plancontrol,
    apparatus
  WHERE apparatus.idapparatus = plancontrol.idapparatus;

ALTER TABLE public.planapparatus
    OWNER TO postgres;
-- View: public.planfact

-- DROP VIEW public.planfact;

CREATE OR REPLACE VIEW public.planfact
 AS
 SELECT apparatus.nameapparatus,
    plancontrol.levelcontrol,
    plancontrol.dateplan,
    factcontrol.datefact,
    factcontrol.resultcontorol,
    employees.nameemployee
   FROM plancontrol,
    factcontrol,
    apparatus,
    employees
  WHERE factcontrol.idplan = plancontrol.idplan AND apparatus.idapparatus = plancontrol.idapparatus AND employees.idemployee = factcontrol.idemployee;

ALTER TABLE public.planfact
    OWNER TO postgres;
INSERT INTO public.factcontrol(
 datefact, idplan, idemployee, resultcontorol)
	VALUES ('2023-03-09', '5', '1', 'норма');
INSERT INTO public.factcontrol(
 datefact, idplan, idemployee, resultcontorol)
	VALUES ('2023-04-09', '6', '2', 'норма');
INSERT INTO public.factcontrol(
 datefact, idplan, idemployee, resultcontorol)
	VALUES ('2023-04-10', '7', '2', 'норма');
INSERT INTO public.factcontrol(
 datefact, idplan, idemployee, resultcontorol)
	VALUES ('2023-04-11', '8', '2', 'норма');
INSERT INTO public.factcontrol(
 datefact, idplan, idemployee, resultcontorol)
	VALUES ('2023-04-12', '9', '1', 'норма');
INSERT INTO public.factcontrol(
 datefact, idplan, idemployee, resultcontorol)
	VALUES ('2023-04-12', '10', '1', 'норма');

-- Examle
/*
CREATE TABLE public.typeapparatus
(
    idtypeapparatus integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    nametype text COLLATE pg_catalog."default" NOT NULL,
    destypeapparatus text COLLATE pg_catalog."default",
    CONSTRAINT typeapparatus_pkey PRIMARY KEY (idtypeapparatus)
)
*/