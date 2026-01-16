# Installation

## Install docker 

choco install docker-cli
choco install docker-compose
choch install docker-machine

## Install docker-compose

## PUll all Imgages by
```
docker pull IMAGE_NAME
```

## Start all Applications
```
cd ops/db && docker-compose up
``` 
- this will start the postgresDB 

- you can sign into the **pgadmin** by
    - user: admin@admin.de
    - pwd:  admin
- you can than create a server by:
    - host: host.docker.internal (mac)
    - host: localhost (windows)
    - user: postgres
    - pwd: EMPTY/NOT SET ALREADY FOR DEV