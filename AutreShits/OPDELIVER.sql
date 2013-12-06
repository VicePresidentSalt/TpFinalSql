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

---Insertions
-
-INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Canadiens' , '01-jan-1976','Division Est','Montreal');
-INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Bruins' , '02-feb-1976','Division Est','Boston');
-INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Senators' , '06-jun-1978','Division Est','Ottawa');
-INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Sabres' , '03-jan-1980','Division Est','Buffalo');
-INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Blackhawks' , '12-aug-1982','Division Ouest','Chicago');
-INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Kings' , '12-dec-1985','Division Ouest','Los Angeles');
-INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Canucks' , '08-nov-1986','Division Ouest','Vancouver');
-INSERT INTO Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe) Values ('Stars' , '23-jan-1989','Division Ouest','Dallas');
-
------------------------------------------------------------------------------
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('BRIERE','DANIEL','06-oct-1977','48','Canadiens','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('GALLAGHER','BRENDEN','06-may-1992','11','Canadiens','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('PRICE','CAREY','16-aug-1987','31','Canadiens','Gardien');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('PACIORETTY','MAX','20-nov-1988','67','Canadiens','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('BOURQUE','RENE','06-oct-1977','48','Canadiens','Defenseur');
-
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('IGINLA','JAROME','01-jul-1977','12','Bruins','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('BERGERON','PATRICE','24-jul-1985','37','Bruins','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('CHARA','ZDENO','18-mar-1977','33','Bruins','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('MARCHAND','BRAD','11-may-1988','63','Bruins','Gardien');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('CARON','JORDAN','02-nov-1990','38','Bruins','Defenseur');
-
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('KASSIAN','MATT','28-oct-1986','28','Senators','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('RYAN','BOBBY','17-mar-1987','6','Senators','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('SMITH','ZACK','05-avr-1988','15','Senators','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('TURRIS','KYLE','14-aug-1989','7','Senators','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('GRANT','DEREK','20-avr-1990','57','Senators','Gardien');
-
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('ADAM','LUKE','18-jun-1990','72','Sabres','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('ENNIS','TYLER','06-oct-1989','63','Sabres','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('SCOTT','JOHN','26-sep-1982','32','Sabres','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('MYERS','TYLER','01-feb-1990','57','Sabres','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('MOULSON','MATT','01-nov-1983','26','Sabres','Gardien');
-
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('KANE','PATRICK','19-nov-1988','88','Blackhawks','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('MORIN','JEREMY','16-apr-1991','11','Blackhawks','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('SHARP','PATRICK','27-dec-1981','10','Blackhawks','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('SMITH','BEN','11-jul-1988','28','Blackhawks','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('LEDDY','NICK','20-mar-1991','8','Blackhawks','Gardien');
-
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('BROWN','DUSTIN','04-jul-1984','23','Kings','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('CARTER','JEFF','01-jun-1985','77','Kings','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('NOLAN','JORDAN','23-jun-1989','71','Kings','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('STOLL','JARRET','24-jan-1982','28','Kings','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('KING','DWIGHT','05-nov-1989','74','Kings','Gardien');
-
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('HIGGINS','CHRIS','05-nov-1989','20','Canucks','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('BOOTH','DAVID','05-nov-1989','7','Canucks','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('SEDIN','DANIEL','05-nov-1989','22','Canucks','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('SEDIN','HENRIK','05-nov-1989','33','Canucks','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('WELSH','JEREMY','05-nov-1989','13','Canucks','Gardien');
-
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('COLE','ERIK','05-nov-1989','13','Stars','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('BENN','JAMIE','05-nov-1989','13','Stars','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('BENN','JORIDE','05-nov-1989','13','Stars','Defenseur');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('DALEY','TREVOR','05-nov-1989','13','Stars','Attaquant');
-INSERT INTO Joueurs (NomJoueurs,PrenomJoueur,DateNaissance,NumeroMaillot,EquipeJoueur,PositionJoueur) Values ('SEGUIN','TYLER','05-nov-1989','13','Stars','Gardien');
-
-INSERT INTO Match (EquipeHome,EquipeVisiteur,DateRencontre,Lieu) Values ('Canadiens','Bruins','12-dec-2013','Centre Bell');
-INSERT INTO Match (EquipeHome,EquipeVisiteur,DateRencontre,Lieu) Values ('Bruins','Canadiens','12-dec-2013','TD Garden');

CREATE PUBLIC SYNONYM CoteJoueurs FOR cotefran.joueurs;
grant all on CoteJoueurs to stlauren with grant option;
grant select on cotejoueurs to public;

select nomjoueurs,prenomjoueur,equipejoueur,sum(nbbuts) as Buts , sum(nbPasses) as Passes, sum(nbbuts)+ sum(nbPasses) as points
from joueurs j 
inner join statistiques s on s.numerojoueurs = j.numerojoueurs group by nomjoueurs,prenomjoueur,equipejoueur
order by points desc; 
