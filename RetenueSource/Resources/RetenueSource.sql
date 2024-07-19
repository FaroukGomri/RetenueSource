CREATE TABLE F_EnteteRetenueSource (
	id INT NOT NULL IDENTITY(1,1),
	TypeIdentifiant INT CHECK (TypeIdentifiant IN (1,2,3,4,5)),
	Identifiant VARCHAR(20),
	CategorieContribuable VARCHAR(2) CHECK (CategorieContribuable IN ('PP','PM')),
	PRIMARY KEY(id)
);

CREATE TABLE F_Beneficiere (
	id INT NOT NULL IDENTITY(1,1),
	TypeIdentifiant INT CHECK (TypeIdentifiant IN (1,2,3,4,5)),
	Identifiant VARCHAR(20),
	CategorieContribuable VARCHAR(2) CHECK (CategorieContribuable IN ('PP','PM')),
	Resident INT,
	NometprenomOuRaisonsociale VARCHAR(200),
	Adresse VARCHAR(200),
	Activite VARCHAR(200),
	AdresseMail VARCHAR(200),
	NumTel VARCHAR(8),
	PRIMARY KEY(id)
);

CREATE TABLE F_LigneRetenueSource (
	id INT NOT NULL IDENTITY(1,1),
	EnteteRetenueSourceId INT,
	TypeIdentifiant INT CHECK (TypeIdentifiant IN (1,2,3,4,5)),
	Identifiant VARCHAR(20),
	CategorieContribuable VARCHAR(2) CHECK (CategorieContribuable IN ('PP','PM')),
	ActeDepot INT CHECK (ActeDepot IN (0,1)),
	AnneeDepot INT CHECK (AnneeDepot BETWEEN 1900 AND 2025),
	MoisDepot INT CHECK (MoisDepot BETWEEN 1 AND 12),
	BeneficiereTypeIdentifiant INT CHECK (BeneficiereTypeIdentifiant IN (1,2,3,4,5)),
	BeneficiereIdentifiant VARCHAR(20),
	BeneficiereCategorieContribuable VARCHAR(2) CHECK (BeneficiereCategorieContribuable IN ('PP','PM')),
	Resident INT,
	NometprenomOuRaisonsociale VARCHAR(200),
	Adresse VARCHAR(200),
	Activite VARCHAR(200),
	AdresseMail VARCHAR(200),
	NumTel VARCHAR(8),
	DatePayement DATE,
	Ref_certif_chez_declarant VARCHAR(20),
	IdTypeOperation VARCHAR(20),
	AnneeFacturation INT CHECK (AnneeFacturation BETWEEN 1900 AND 2025),
	CNPC INT CHECK (CNPC IN (0,1)),
	P_Charge INT CHECK (P_Charge IN (0,1)),
	MontantHT DECIMAL(20,10),
	TauxRS DECIMAL(10,5),
	TauxTVA DECIMAL(10,5),
	MontantRS DECIMAL(10,5),
	MontantTVA DECIMAL(20,10),
	MontantTTC DECIMAL(10,5),
	TaxeAdditionnelleCode VARCHAR(20),
	TaxeAdditionnelleTaux DECIMAL(10,5),
	MontantNetServi DECIMAL(20,10),
	CodeDevise VARCHAR(20),
	TauxChange DECIMAL(10,5),
	MontantRSDevise DECIMAL(10,5),
	MontantTTCDevise DECIMAL(10,5),
	MontantNetServiDevise DECIMAL(10,5),
	TotalMontantHT DECIMAL(20,10),
	TotalMontantTVA DECIMAL(10,5),
	TotalMontantTTC DECIMAL(20,10),
	TotalMontantRS DECIMAL(20,10),
	TotalTaxeAdditionnelleCode VARCHAR(20),
	TotalTaxeAdditionnelleMontant DECIMAL(10,5),
	TotalMontantNetServi DECIMAL(20,10),
	TotalMontantDeviseCode VARCHAR(20),
	TotalMontantDeviseTotalMontantRS DECIMAL(10,5),
	TotalMontantDeviseTotalMontantTTC DECIMAL(10,5),
	TotalMontantDeviseTotalMontantNetServi DECIMAL(10,5),
);

SELECT * FROM F_EnteteRetenueSource;
SELECT * FROM F_Beneficiere;
SELECT * FROM F_LigneRetenueSource;

/*DROP TABLE F_EnteteRetenueSource;
DROP TABLE F_Beneficiere;
DROP TABLE F_LigneRetenueSource;*/