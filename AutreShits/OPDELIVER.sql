CREATE TABLE Divisions
  (
    NomDivision  VARCHAR2 (40) NOT NULL ,
    DateCreation DATE
  ) ;
ALTER TABLE Divisions ADD CONSTRAINT Divisions_PK PRIMARY KEY
(
  NomDivision
)
;

CREATE TABLE Equipes
  (
    NomEquipe      VARCHAR2 (40) NOT NULL ,
    DateIntroLigue DATE ,
    LogoEquipe BLOB ,
    DivisionEquipe VARCHAR2 (40) NOT NULL ,
    VilleEquipe    VARCHAR2 (40)
  ) ;
ALTER TABLE Equipes ADD CONSTRAINT Equipes_PK PRIMARY KEY
(
  NomEquipe
)
;

CREATE TABLE Joueurs
  (
    NumeroJoueurs NUMBER NOT NULL ,
    NomJoueurs    VARCHAR2 (40) ,
    PrenomJoueur  VARCHAR2 (40) ,
    DateNaissance DATE ,
    PhotoJoueurs BLOB ,
    NumeroMaillot  NUMBER ,
    EquipeJoueur   VARCHAR2 (40) NOT NULL ,
    PositionJoueur VARCHAR2 (40)
  ) ;
ALTER TABLE Joueurs ADD CONSTRAINT Joueurs_PK PRIMARY KEY
(
  NumeroJoueurs
)
;

CREATE TABLE MATCH
  (
    NumeroMatch    NUMBER NOT NULL ,
    EquipeHome     VARCHAR2 (40) NOT NULL ,
    EquipeVisiteur VARCHAR2 (40) NOT NULL ,
    DateRencontre  DATE ,
    Lieu           VARCHAR2 (40)
  ) ;
ALTER TABLE MATCH ADD CONSTRAINT Match_PK PRIMARY KEY
(
  NumeroMatch
)
;

ALTER TABLE Equipes ADD CONSTRAINT Equipes_Divisions_FK FOREIGN KEY ( DivisionEquipe ) REFERENCES Divisions ( NomDivision ) ;

ALTER TABLE Joueurs ADD CONSTRAINT Joueurs_Equipes_FK FOREIGN KEY ( EquipeJoueur ) REFERENCES Equipes ( NomEquipe ) ;

ALTER TABLE MATCH ADD CONSTRAINT Match_Equipes_FKHOME FOREIGN KEY ( EquipeHome ) REFERENCES Equipes ( NomEquipe ) ;

ALTER TABLE MATCH ADD CONSTRAINT Match_Equipes_FKVISITEUR FOREIGN KEY ( EquipeVisiteur ) REFERENCES Equipes ( NomEquipe ) ;

create table Statistiques
(
  NumeroJoueurs Number,
  NumeroMatch Number,
  NbButs Number,
  NbPasses Number,
  TempsPunition Number,
  constraint PKSTATS primary key(NumeroJoueurs,NumeroMatch),
  constraint FKNUMJOUEURS Foreign Key(NumeroJoueurs) References Joueurs(NumeroJoueurs),
  constraint FKNUMMATCH Foreign Key(NumeroMatch) References Match(NumeroMatch)  
);