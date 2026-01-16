# case-study-45b95c0d-a76a-463a-98c9-ecbc0defd018

Table of Contents

- [1. Aufgabenstellung](#1-aufgabenstellung)
- [2. Setup Steps](#2-setup-steps)
  - [2.1 Create Empty Solution](#21-create-empty-solution)
  - [2.2 Create Domain Layer](#22-create-domain-module)
  - [2.3 Create Presentation Layer](#23-create-presentation-layer-rest-api)
  - [2.4 Create Infrastructure Layer](#24-create-infrastructure)
  - [2.5 Create Application Layer](#25-create-application-layer)
  - [2.6 Activate Open API](#26-activate-openai)
- [3. Run Project](#3-run-project)
- [4. Dependencies](#4-deps)

## 1. Aufgabenstellung

**Aufgabe**:
Entwickle ein Backend für ein Raumbuchungssystem mit REST-Endpunkten.

**Usecase**:
Raumbuchungssystem

**Datenobjekte**:
Raum
Buchung
Nutzer

**Architektur**:
Domain-Driven-Design
Onion-Architecture

**Technik**:
- .Net Core Minimal API als Backend
- Nur REST-Endpunkte
- Keine Authentifizierung
- Swagger-ui zur Anzeige der Endpunkte
- EF Core als Persistence Layer
- Postgresql als Datenbank
- Data Migration Tool nicht notwendig

**Optional**:
- Frontend

---


## 2. Setup Steps

### 2.1 Create Empty Solution

```
dotnet new sln
```

- add default gitignore

```
dotnet new gitignore
```



```

```

### 2.2 Create Domain Module

```
dotnet new classlib -o caseStudy.RoomBooking.Domain

```

- add project to solution

```
dotnet sln add ./caseStudy.RoomBooking.Domain/caseStudy.RoomBooking.Domain.csproj 
```




### 2.3 Create Presentation Layer (REST API)

```
 dotnet new web -o caseStudy.RoomBooking.Presentation.API
```

- add project to solution

```
donet sln add caseStudy.RoomBooking.Presentation.API/caseStudy.RoomBooking.Presentation.API.csproj 
```



### 2.4 Create Infrastructure
```

```

- delete auto generated files from main and src folder


### 2.5 Create Application Layer
```
```

### 2.6 Activate OpenAI




## 3. Run Project


