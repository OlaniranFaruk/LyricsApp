# LyricsApp
A MAUI application created using the MVVM technique. This app allows you to manage the lyrics of songs

# Steps
- Make sure you have your database running
- Correct the DB credentials in <LyricsAPI> folder to match yours
- Compile and run the application in a emulator


creating API image using Dockerfile
```
docker build -t <DockerID>/lyricsapi .
```

running created image mapping port 8000 of host to 80 of container
```
docker run -p 8000:80 --name=lyricsapi <DockerID>/aspapi
```

visit

http://localhost:8000/api/lyrics

# MySQl with Persitent Data

Show available docker volumes
```
docker volume ls
```


Create volume
```
docker volume create mysqldbvolume
```



Running container mounting docker volume to container volume
> -v: mount docker volume to volume in container  
> -e: environment variable in container
```
docker run -it -v mysqldbvolume:/var/lib/mysql -p 8000:3306 -e MYSQL_ROOT_PASSWORD=pw --name mysqlserver -d mysql
```


connecting to mysql server
```
docker exec -it mysqlserver mysql -u root -p
```
OR

use local mysql with localhost and port 8000
```
mysql -h localhost -P 8000 -u root -p
```
