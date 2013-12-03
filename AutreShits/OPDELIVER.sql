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

---------------------------------------------------------------------------------------------------------------------------------

--Insertions

INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Canadiens' , '01-jan-1976','Division Est','Montreal');
INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Bruins' , '02-feb-1976','Division Est','Boston');
INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Senators' , '06-jun-1978','Division Est','Ottawa');
INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Sabres' , '03-jan-1980','Division Est','Buffalo');
INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Blackhawks' , '12-aug-1982','Division Ouest','Chicago');
INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Kings' , '12-dec-1985','Division Ouest','Los Angeles');
INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Canucks' , '08-nov-1986','Division Ouest','Vancouver');
INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Canadiens' , '23-jan-1989','Division Ouest','Dallas');




